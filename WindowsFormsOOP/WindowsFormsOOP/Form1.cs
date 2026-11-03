using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsOOP.Objects;

namespace WindowsFormsOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Document document;

        private void btnPDF_Click(object sender, EventArgs e)
        {
          DialogResult result =  openFileDialog1.ShowDialog(this);

            if (result == DialogResult.OK) {

                if (openFileDialog1.SafeFileName.Substring(openFileDialog1.SafeFileName.ToString().Length - 4,4) == ".pdf")
                {
                    document = new PdfDocument();
                }
                else if (openFileDialog1.SafeFileName.Substring(openFileDialog1.SafeFileName.ToString().Length - 5, 5) == ".docx")
                {
                    document = new WordDocument();
                }
                document.Path = openFileDialog1.FileName;
                document.DocumentName = openFileDialog1.SafeFileName;
           
                lblShowInfo.Text = document.GetFileInfo();
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            document.Print();
        }
    }
}
