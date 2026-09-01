using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = int.Parse(txtSayi1.Text);
                int s2 = int.Parse(txtSayi2.Text);

                txtSonuc.Text =  (s1+s2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol edip \rtekrar deneyiniz.", "Dikkat!");
               
            }

            
        }
    }
}
