using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOveWindowsFormsGiris
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            
            InitializeComponent();

        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            //ADO: Activex Data Object - Microsoft un bir DB bağlantı ve işlem teknolojisidir.
            //1.Herhangi bir DB ye uygun bir bağlantı cümlesi ile (Connection String) bağlanabilir.
            //2.Yapılacak olan işlem için bir SQL komutu yazılır. (Command)
            //3.Kurulan bağlantı üzerinden komut çalıştırılır.
            //4.Geriye bir bilgi dönüyorsa bu bilgiyi alıp işleriz.
            //Tekil veri dönüyorsa farklı, bir liste dönüyorsa farklı işleriz.

            //ADO da her farklı DB yapısı için ayrı bir Connection Nesnesi bulunur.  xxxxConnection şeklinde belirtilir.
            //MS-SQL için             : SqlConnection
            //Oracle için             : OracleConnection
            //ODBC veritabanları için : ODBCConnection

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=.;Initial Catalog=Northwind;User ID=sa;Password=1";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Count(UrunID) From Urunler";
            cmd.Connection = conn;

            conn.Open();

            var gelenDeger = cmd.ExecuteScalar();

            conn.Close();

            txtUrunAdet.Text = gelenDeger.ToString();

        }
    }
}
