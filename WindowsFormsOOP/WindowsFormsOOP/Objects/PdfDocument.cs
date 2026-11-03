using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOOP.Objects
{
    internal class PdfDocument : Document
    {
        public PdfDocument()
        {
            Extension = ".pdf";
        }

        public string OpenPassword { get; set; }

        public override void Print()
        {
            MessageBox.Show($"PDF Document {DocumentName} Printed");
        }
    }
}
