﻿using System.Windows.Forms;

namespace cvColorSelectorGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.img2 = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgSelectedColor2 = new System.Windows.Forms.PictureBox();
            this.imgSelectedColor1 = new System.Windows.Forms.PictureBox();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.radTo = new System.Windows.Forms.RadioButton();
            this.radFrom = new System.Windows.Forms.RadioButton();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numBlue2 = new System.Windows.Forms.NumericUpDown();
            this.trackBlue2 = new System.Windows.Forms.TrackBar();
            this.numGreen2 = new System.Windows.Forms.NumericUpDown();
            this.trackGreen2 = new System.Windows.Forms.TrackBar();
            this.numRed2 = new System.Windows.Forms.NumericUpDown();
            this.trackRed2 = new System.Windows.Forms.TrackBar();
            this.numBlue1 = new System.Windows.Forms.NumericUpDown();
            this.trackBlue1 = new System.Windows.Forms.TrackBar();
            this.numGreen1 = new System.Windows.Forms.NumericUpDown();
            this.trackGreen1 = new System.Windows.Forms.TrackBar();
            this.numRed1 = new System.Windows.Forms.NumericUpDown();
            this.trackRed1 = new System.Windows.Forms.TrackBar();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRed1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGreen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRed2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGreen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpen = new System.Windows.Forms.Button();
            this.img1 = new Emgu.CV.UI.ImageBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusColor1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusRgb = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.img2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.img1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 495);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // img2
            // 
            this.img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img2.Location = new System.Drawing.Point(462, 153);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(454, 339);
            this.img2.TabIndex = 3;
            this.img2.TabStop = false;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.imgSelectedColor2);
            this.panel1.Controls.Add(this.imgSelectedColor1);
            this.panel1.Controls.Add(this.chkEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.radTo);
            this.panel1.Controls.Add(this.radFrom);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numBlue2);
            this.panel1.Controls.Add(this.trackBlue2);
            this.panel1.Controls.Add(this.numGreen2);
            this.panel1.Controls.Add(this.trackGreen2);
            this.panel1.Controls.Add(this.numRed2);
            this.panel1.Controls.Add(this.trackRed2);
            this.panel1.Controls.Add(this.numBlue1);
            this.panel1.Controls.Add(this.trackBlue1);
            this.panel1.Controls.Add(this.numGreen1);
            this.panel1.Controls.Add(this.trackGreen1);
            this.panel1.Controls.Add(this.numRed1);
            this.panel1.Controls.Add(this.trackRed1);
            this.panel1.Controls.Add(this.grid);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 144);
            this.panel1.TabIndex = 2;
            // 
            // imgSelectedColor2
            // 
            this.imgSelectedColor2.BackColor = System.Drawing.Color.White;
            this.imgSelectedColor2.Location = new System.Drawing.Point(446, 114);
            this.imgSelectedColor2.Name = "imgSelectedColor2";
            this.imgSelectedColor2.Size = new System.Drawing.Size(20, 16);
            this.imgSelectedColor2.TabIndex = 20;
            this.imgSelectedColor2.TabStop = false;
            // 
            // imgSelectedColor1
            // 
            this.imgSelectedColor1.BackColor = System.Drawing.Color.White;
            this.imgSelectedColor1.Location = new System.Drawing.Point(446, 89);
            this.imgSelectedColor1.Name = "imgSelectedColor1";
            this.imgSelectedColor1.Size = new System.Drawing.Size(20, 16);
            this.imgSelectedColor1.TabIndex = 19;
            this.imgSelectedColor1.TabStop = false;
            // 
            // chkEdit
            // 
            this.chkEdit.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEdit.Location = new System.Drawing.Point(316, 35);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(118, 23);
            this.chkEdit.TabIndex = 3;
            this.chkEdit.Text = "Edit Row";
            this.chkEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEdit.UseVisualStyleBackColor = true;
            this.chkEdit.CheckedChanged += new System.EventHandler(this.chkEdit_CheckedChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(440, 35);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Del Row";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // radTo
            // 
            this.radTo.AutoSize = true;
            this.radTo.Location = new System.Drawing.Point(470, 114);
            this.radTo.Name = "radTo";
            this.radTo.Size = new System.Drawing.Size(38, 17);
            this.radTo.TabIndex = 18;
            this.radTo.Text = "To";
            this.radTo.UseVisualStyleBackColor = true;
            // 
            // radFrom
            // 
            this.radFrom.AutoSize = true;
            this.radFrom.Checked = true;
            this.radFrom.Location = new System.Drawing.Point(470, 88);
            this.radFrom.Name = "radFrom";
            this.radFrom.Size = new System.Drawing.Size(48, 17);
            this.radFrom.TabIndex = 17;
            this.radFrom.TabStop = true;
            this.radFrom.Text = "From";
            this.radFrom.UseVisualStyleBackColor = true;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Union",
            "Subtract"});
            this.cmbType.Location = new System.Drawing.Point(440, 10);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(68, 21);
            this.cmbType.TabIndex = 2;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Range";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "BLUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "RED";
            // 
            // numBlue2
            // 
            this.numBlue2.Location = new System.Drawing.Point(301, 114);
            this.numBlue2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue2.Name = "numBlue2";
            this.numBlue2.Size = new System.Drawing.Size(38, 20);
            this.numBlue2.TabIndex = 15;
            this.numBlue2.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // trackBlue2
            // 
            this.trackBlue2.AutoSize = false;
            this.trackBlue2.LargeChange = 1;
            this.trackBlue2.Location = new System.Drawing.Point(334, 114);
            this.trackBlue2.Maximum = 255;
            this.trackBlue2.Name = "trackBlue2";
            this.trackBlue2.Size = new System.Drawing.Size(113, 20);
            this.trackBlue2.TabIndex = 16;
            this.trackBlue2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBlue2.ValueChanged += new System.EventHandler(this.track_ValueChanged);
            // 
            // numGreen2
            // 
            this.numGreen2.Location = new System.Drawing.Point(155, 114);
            this.numGreen2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen2.Name = "numGreen2";
            this.numGreen2.Size = new System.Drawing.Size(38, 20);
            this.numGreen2.TabIndex = 13;
            this.numGreen2.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // trackGreen2
            // 
            this.trackGreen2.AutoSize = false;
            this.trackGreen2.LargeChange = 1;
            this.trackGreen2.Location = new System.Drawing.Point(189, 114);
            this.trackGreen2.Maximum = 255;
            this.trackGreen2.Name = "trackGreen2";
            this.trackGreen2.Size = new System.Drawing.Size(113, 20);
            this.trackGreen2.TabIndex = 14;
            this.trackGreen2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackGreen2.ValueChanged += new System.EventHandler(this.track_ValueChanged);
            // 
            // numRed2
            // 
            this.numRed2.Location = new System.Drawing.Point(9, 114);
            this.numRed2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed2.Name = "numRed2";
            this.numRed2.Size = new System.Drawing.Size(38, 20);
            this.numRed2.TabIndex = 11;
            this.numRed2.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // trackRed2
            // 
            this.trackRed2.AutoSize = false;
            this.trackRed2.LargeChange = 1;
            this.trackRed2.Location = new System.Drawing.Point(43, 114);
            this.trackRed2.Maximum = 255;
            this.trackRed2.Name = "trackRed2";
            this.trackRed2.Size = new System.Drawing.Size(113, 20);
            this.trackRed2.TabIndex = 12;
            this.trackRed2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRed2.ValueChanged += new System.EventHandler(this.track_ValueChanged);
            // 
            // numBlue1
            // 
            this.numBlue1.Location = new System.Drawing.Point(301, 88);
            this.numBlue1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue1.Name = "numBlue1";
            this.numBlue1.Size = new System.Drawing.Size(38, 20);
            this.numBlue1.TabIndex = 9;
            this.numBlue1.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // trackBlue1
            // 
            this.trackBlue1.AutoSize = false;
            this.trackBlue1.LargeChange = 1;
            this.trackBlue1.Location = new System.Drawing.Point(334, 88);
            this.trackBlue1.Maximum = 255;
            this.trackBlue1.Name = "trackBlue1";
            this.trackBlue1.Size = new System.Drawing.Size(113, 20);
            this.trackBlue1.TabIndex = 10;
            this.trackBlue1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBlue1.ValueChanged += new System.EventHandler(this.track_ValueChanged);
            // 
            // numGreen1
            // 
            this.numGreen1.Location = new System.Drawing.Point(155, 88);
            this.numGreen1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen1.Name = "numGreen1";
            this.numGreen1.Size = new System.Drawing.Size(38, 20);
            this.numGreen1.TabIndex = 7;
            this.numGreen1.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // trackGreen1
            // 
            this.trackGreen1.AutoSize = false;
            this.trackGreen1.LargeChange = 1;
            this.trackGreen1.Location = new System.Drawing.Point(189, 88);
            this.trackGreen1.Maximum = 255;
            this.trackGreen1.Name = "trackGreen1";
            this.trackGreen1.Size = new System.Drawing.Size(113, 20);
            this.trackGreen1.TabIndex = 8;
            this.trackGreen1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackGreen1.ValueChanged += new System.EventHandler(this.track_ValueChanged);
            // 
            // numRed1
            // 
            this.numRed1.Location = new System.Drawing.Point(9, 88);
            this.numRed1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed1.Name = "numRed1";
            this.numRed1.Size = new System.Drawing.Size(38, 20);
            this.numRed1.TabIndex = 5;
            this.numRed1.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // trackRed1
            // 
            this.trackRed1.AutoSize = false;
            this.trackRed1.LargeChange = 1;
            this.trackRed1.Location = new System.Drawing.Point(43, 88);
            this.trackRed1.Maximum = 255;
            this.trackRed1.Name = "trackRed1";
            this.trackRed1.Size = new System.Drawing.Size(113, 20);
            this.trackRed1.TabIndex = 6;
            this.trackRed1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRed1.ValueChanged += new System.EventHandler(this.track_ValueChanged);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colRed1,
            this.colGreen1,
            this.colBlue1,
            this.colRed2,
            this.colGreen2,
            this.colBlue2});
            this.grid.Location = new System.Drawing.Point(524, 3);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(386, 138);
            this.grid.TabIndex = 1;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colType.Width = 56;
            // 
            // colRed1
            // 
            this.colRed1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRed1.HeaderText = "R1";
            this.colRed1.Name = "colRed1";
            this.colRed1.ReadOnly = true;
            this.colRed1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRed1.Width = 46;
            // 
            // colGreen1
            // 
            this.colGreen1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colGreen1.HeaderText = "G1";
            this.colGreen1.Name = "colGreen1";
            this.colGreen1.ReadOnly = true;
            this.colGreen1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGreen1.Width = 46;
            // 
            // colBlue1
            // 
            this.colBlue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colBlue1.HeaderText = "B1";
            this.colBlue1.Name = "colBlue1";
            this.colBlue1.ReadOnly = true;
            this.colBlue1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBlue1.Width = 45;
            // 
            // colRed2
            // 
            this.colRed2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRed2.HeaderText = "R2";
            this.colRed2.Name = "colRed2";
            this.colRed2.ReadOnly = true;
            this.colRed2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRed2.Width = 46;
            // 
            // colGreen2
            // 
            this.colGreen2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colGreen2.HeaderText = "G2";
            this.colGreen2.Name = "colGreen2";
            this.colGreen2.ReadOnly = true;
            this.colGreen2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGreen2.Width = 46;
            // 
            // colBlue2
            // 
            this.colBlue2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colBlue2.HeaderText = "B2";
            this.colBlue2.Name = "colBlue2";
            this.colBlue2.ReadOnly = true;
            this.colBlue2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBlue2.Width = 45;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(9, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 49);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // img1
            // 
            this.img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.img1.Location = new System.Drawing.Point(3, 153);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(453, 339);
            this.img1.TabIndex = 2;
            this.img1.TabStop = false;
            this.img1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img1_MouseClick);
            this.img1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img1_MouseMove);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "JPG files|*.jpg|JPEG files|*.jpeg|PNG files|*.png|All files|*.*";
            this.dlgOpen.Title = "Open Image";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusColor1,
            this.lblStatusRgb,
            this.lblStatusPos,
            this.lblStatusSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusColor1
            // 
            this.lblStatusColor1.BackColor = System.Drawing.Color.Black;
            this.lblStatusColor1.Name = "lblStatusColor1";
            this.lblStatusColor1.Size = new System.Drawing.Size(22, 17);
            this.lblStatusColor1.Text = "     ";
            // 
            // lblStatusRgb
            // 
            this.lblStatusRgb.AutoSize = false;
            this.lblStatusRgb.Name = "lblStatusRgb";
            this.lblStatusRgb.Size = new System.Drawing.Size(100, 17);
            this.lblStatusRgb.Text = "R: 0 G:0 B:0";
            this.lblStatusRgb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusPos
            // 
            this.lblStatusPos.AutoSize = false;
            this.lblStatusPos.Name = "lblStatusPos";
            this.lblStatusPos.Size = new System.Drawing.Size(100, 17);
            this.lblStatusPos.Text = "0,0";
            this.lblStatusPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusSize
            // 
            this.lblStatusSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatusSize.Name = "lblStatusSize";
            this.lblStatusSize.Size = new System.Drawing.Size(83, 17);
            this.lblStatusSize.Text = "Image size: 0x0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 520);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "OpenCV Color Selector GUI - 2019 By M. Shams";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numBlue2;
        private System.Windows.Forms.TrackBar trackBlue2;
        private System.Windows.Forms.NumericUpDown numGreen2;
        private System.Windows.Forms.TrackBar trackGreen2;
        private System.Windows.Forms.NumericUpDown numRed2;
        private System.Windows.Forms.TrackBar trackRed2;
        private System.Windows.Forms.NumericUpDown numBlue1;
        private System.Windows.Forms.TrackBar trackBlue1;
        private System.Windows.Forms.NumericUpDown numGreen1;
        private System.Windows.Forms.TrackBar trackGreen1;
        private System.Windows.Forms.NumericUpDown numRed1;
        private System.Windows.Forms.TrackBar trackRed1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.RadioButton radTo;
        private System.Windows.Forms.RadioButton radFrom;
        private Button btnDel;
        private CheckBox chkEdit;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colRed1;
        private DataGridViewTextBoxColumn colGreen1;
        private DataGridViewTextBoxColumn colBlue1;
        private DataGridViewTextBoxColumn colRed2;
        private DataGridViewTextBoxColumn colGreen2;
        private DataGridViewTextBoxColumn colBlue2;
        private StatusStrip statusStrip1;
        private Emgu.CV.UI.ImageBox img2;
        private Emgu.CV.UI.ImageBox img1;
        private ToolStripStatusLabel lblStatusColor1;
        private ToolStripStatusLabel lblStatusRgb;
        private ToolStripStatusLabel lblStatusSize;
        private ToolStripStatusLabel lblStatusPos;
        private PictureBox imgSelectedColor2;
        private PictureBox imgSelectedColor1;
    }
}