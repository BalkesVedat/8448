using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOOP.Objects
{
    internal class ImageDocument : Document
    {
        public ImageDocument()
        {
            
        }

        public string Resolution { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        private int angle;

        public int Angle
        {
            get { return angle; }
           // set { angle = value; }
        }



        public override void Print()
        {
            MessageBox.Show("Image Document Printed");
        }

        public void Rotate(int degree) 
        {
            if (degree > 360) 
            {
                degree = 360;
            }

            if (degree < -360)
            {
                degree = -360;
            }
        
            angle = degree;
        
        }
    }
}
