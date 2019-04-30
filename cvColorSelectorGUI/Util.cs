using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvColorSelectorGUI
{
    class Util
    {

        public static int localToGloabl(int local, int w1, int h1, int w2, int h2)
        {
            //original image: w1, h1
            //boxed image: w2, h2

            float percentage = 0;
            if (w1 > h1)
            {
                percentage = (float)w1 / w2;
            }
            else
            {
                percentage = (float)h1 / h2;
            }

            return (int)(local * (percentage));
        }

        public static int globalToLocal(int global, int w1, int h1, int w2, int h2)
        {
            //original image: w1, h1
            //boxed image: w2, h2

            float percentage = (float)w2 / w1;
            return (int)(global * percentage);
        }


        public static Boolean inBox(int x, int y, int w1, int h1, int w2, int h2)
        {
            return true;
        }
    }
}
