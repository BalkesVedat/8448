using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Dikkat!..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secim == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gboxCalismaDurumu_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //TODO: Veri Tabanına Kaydet
            //TODO: Ekranı Temizle 

            // throw new NotImplementedException();

            MessageBox.Show("Hasta Kaydı Tamamlandı");
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Text = "";
                }
                else if (item.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)item).Text = "";
                }
                else
                {
                    // diğer
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TextBox tbTest = new TextBox();
            //tbTest.Text = "Test";
            //tbTest.Width = 100;
            //tbTest.Location = new Point(300, 200);
            //tbTest.BackColor = Color.Goldenrod;

            //this.Controls.Add(tbTest);
        }
    }
}
