using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        public void MesajVer(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
