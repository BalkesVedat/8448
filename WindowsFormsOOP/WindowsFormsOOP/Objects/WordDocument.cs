using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOOP.Objects
{
    internal class WordDocument:Document
    {
        public WordDocument()
        {
            Extension = ".docx";
        }

        public string OpenPassword { get; set; }

        public override void Print()
        {
            MessageBox.Show($"Word Document {DocumentName} Printed");
        }
    }
}
