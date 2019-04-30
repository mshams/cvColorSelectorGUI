using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace cvColorSelectorGUI
{
    public partial class MainForm : Form
    {
        private string filePath;
        private bool imageSelected;
        private Mat matIn;
        private Mat matOut;
        private int xPos;
        private int yPos;
        private Bgr pixel;
        private bool editMode;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //show imagebox current size
            lblBoxSize.Text = $@"{img1.Width}x{img1.Height}";

            cmbType.SelectedIndex = 0;
            grid.MultiSelect = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //open image file
                    filePath = dlgOpen.FileName;
                    img1.ImageLocation = filePath;

                    //read image file to opencv mat
                    VideoCapture capture = new VideoCapture(filePath);
                    matIn = capture.QueryFrame();
                    matOut = matIn.Clone();
                    lblOrigSize.Text = $@"{matIn.Width}x{matIn.Height}";
                    img2.Image = matOut.ToImage<Bgr, Byte>().ToBitmap();

                    //set image has opened
                    imageSelected = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error");
                }
            }
        }

        private void img1_MouseMove(object sender, MouseEventArgs e)
        {
            if (imageSelected)
            {
                try
                {
                    xPos = e.X;
                    yPos = e.Y;

                    if (Util.inBox(xPos, yPos, matIn.Width, matIn.Height, img1.Width, img1.Height))
                    {
                        pixel = matIn.ToImage<Bgr, Byte>()[yPos, xPos];
                        lblStatus.Text = $@"X={xPos}, Y={yPos}; R:{pixel.Red} G:{pixel.Green} B:{pixel.Blue}";
                    }
                }
                catch (Exception exception)
                {
                    lblStatus.Text = $@"X={xPos}, Y={yPos}; Error";
                }

            }
        }

        private void img1_MouseClick(object sender, MouseEventArgs e)
        {
            if (imageSelected)
            {
                //Update mouse position
                img1_MouseMove(sender, e);

                //select proper radio group
                if (e.Button == MouseButtons.Left)
                {
                    radFrom.Checked = true;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    radTo.Checked = true;
                }

                //update controls
                setRGB(pixel);
            }
        }

        private void setRGB(Bgr bgr)
        {
            //set pixel RGB to controls

            if (radFrom.Checked)
            {
                numBlue1.Value = trackBlue1.Value = (int)bgr.Blue;
                numGreen1.Value = trackGreen1.Value = (int)bgr.Green;
                numRed1.Value = trackRed1.Value = (int)bgr.Red;
            }
            else if (radTo.Checked)
            {
                numBlue2.Value = trackBlue2.Value = (int)bgr.Blue;
                numGreen2.Value = trackGreen2.Value = (int)bgr.Green;
                numRed2.Value = trackRed2.Value = (int)bgr.Red;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grid.Rows.Add(
                cmbType.Text,
                numRed1.Value, numGreen1.Value, numBlue1.Value,
                numRed2.Value, numGreen2.Value, numBlue2.Value
                );
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            //select corresponding trackbar
            NumericUpDown num = (NumericUpDown)sender;
            String trackName = "track" + num.Name.Substring(3);
            TrackBar track = ((TrackBar)Controls.Find(trackName, true)[0]);

            //set he value
            if (track.Value != num.Value)
            {
                track.Value = (int)num.Value;
            }

            if (editMode && grid.SelectedRows.Count > 0)
            {
                String colName = "col" + num.Name.Substring(3);
                int rowIndex = grid.SelectedRows[0].Index;
                grid[colName, rowIndex].Value = num.Value;
            }

            filter();
        }

        private void track_ValueChanged(object sender, EventArgs e)
        {
            //select corresponding trackbar
            TrackBar track = (TrackBar)sender;
            String trackName = "num" + track.Name.Substring(5);
            NumericUpDown num = ((NumericUpDown)Controls.Find(trackName, true)[0]);

            //set he value
            if (num.Value != track.Value)
            {
                num.Value = track.Value;
            }

            filter();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            lblBoxSize.Text = $@"{img1.Width}x{img1.Height}";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (grid.RowCount > 0)
                grid.Rows.RemoveAt(grid.SelectedRows[0].Index);
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            editMode = chkEdit.Checked;
        }

        private void filter()
        {
            if (!imageSelected)
                return;

            int r1, g1, b1, r2, g2, b2;
            getValuesFromControls(out r1, out g1, out b1, out r2, out g2, out b2);

            if (grid.RowCount == 0)
            {
                CvInvoke.InRange(matIn,
                    new ScalarArray(new MCvScalar(b1, g1, r1)),
                    new ScalarArray(new MCvScalar(b2, g2, r2)),
                    matOut);
            }
            else
            {
                //prepare the first range
                Mat temp = new Mat();

                getValuesFromGrid(out r1, out g1, out b1, out r2, out g2, out b2, 0);

                CvInvoke.InRange(matIn,
                    new ScalarArray(new MCvScalar(b1, g1, r1)),
                    new ScalarArray(new MCvScalar(b2, g2, r2)),
                    matOut);

                //apply other ranges
                for (int i = 1; i < grid.RowCount; i++)
                {
                    String type = grid["colType", i].Value.ToString();

                    getValuesFromGrid(out r1, out g1, out b1, out r2, out g2, out b2, i);

                    CvInvoke.InRange(matIn,
                        new ScalarArray(new MCvScalar(b1, g1, r1)),
                        new ScalarArray(new MCvScalar(b2, g2, r2)),
                        temp);

                    //apply operator: Union or Subtract
                    if (type.Equals("Union"))
                    {
                        CvInvoke.BitwiseOr(temp, matOut, matOut);
                    }
                    else
                    {
                        CvInvoke.BitwiseNot(temp, matOut, matOut);
                    }
                }
            }

            img2.Image = matOut.ToImage<Bgr, Byte>().ToBitmap();
        }

        private void getValuesFromControls(out int r1, out int g1, out int b1, out int r2, out int g2, out int b2)
        {
            r1 = (int)numRed1.Value;
            g1 = (int)numGreen1.Value;
            b1 = (int)numBlue1.Value;

            r2 = (int)numRed2.Value;
            g2 = (int)numGreen2.Value;
            b2 = (int)numBlue2.Value;
        }

        private void getValuesFromGrid(out int r1, out int g1, out int b1, out int r2, out int g2, out int b2, int i)
        {
            r1 = Int32.Parse(grid["colRed1", i].Value.ToString());
            g1 = Int32.Parse(grid["colGreen1", i].Value.ToString());
            b1 = Int32.Parse(grid["colBlue1", i].Value.ToString());

            r2 = Int32.Parse(grid["colRed2", i].Value.ToString());
            g2 = Int32.Parse(grid["colGreen2", i].Value.ToString());
            b2 = Int32.Parse(grid["colBlue2", i].Value.ToString());
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editMode && grid.SelectedRows.Count > 0)
            {
                int rowIndex = grid.SelectedRows[0].Index;
                grid["colType", rowIndex].Value = cmbType.Text;
            }
        }
    }
}
