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
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;User ID=sa;Password=1");

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adaptor;
        DataTable dt = new DataTable();

        public FrmRapor()
        {

            InitializeComponent();

        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            //ADO.NET: Activex Data Object - Microsoft un bir DB bağlantı ve işlem teknolojisidir.
            //1.Herhangi bir DB ye uygun bir bağlantı cümlesi ile (Connection String) bağlanabilir.
            //2.Yapılacak olan işlem için bir SQL komutu yazılır. (Command)
            //3.Kurulan bağlantı üzerinden komut çalıştırılır.
            //4.Geriye bir bilgi dönüyorsa bu bilgiyi alıp işleriz.
            //Tekil veri dönüyorsa farklı, bir liste dönüyorsa farklı işleriz.

            //ADO.NET da her farklı DB yapısı için ayrı bir Connection Nesnesi bulunur.  xxxxConnection şeklinde belirtilir.
            //MS-SQL için             : SqlConnection
            //Oracle için             : OracleConnection
            //ODBC veritabanları için : ODBCConnection

            //---- Product Count TextBox

            ReloadProductCount();

            //---- DatagridView

            ReloadGridData();

        }

        private void ReloadProductCount()
        {
            cmd.CommandText = "SELECT Count(UrunID) From Urunler";
            cmd.Connection = conn;

            var gelenDeger = new object();

            OpenConnection();

            try
            {
                gelenDeger = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriyi çekerken sorun çıktı." + ex.Message);
            }

            CloseConnection();

            if (gelenDeger != null && gelenDeger.ToString().Length > 0)
            {
                txtUrunAdet.Text = gelenDeger.ToString() ?? "0";
            }
        }

        private void ReloadGridData()
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT UrunID, UrunAdi, KategoriID, BirimdekiMiktar, BirimFiyati, HedefStokDuzeyi, Sonlandi  FROM Urunler";

                adaptor = new SqlDataAdapter(cmd.CommandText, conn);

                adaptor.Fill(dt);

                dgvUrunListesi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün listesi çekilirken sorun oluştu." + ex.Message);
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantıyı kapatırken sorun çıktı." + ex.Message);
            }
        }

        private void OpenConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantıyı açarken sorun çıktı." + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //---- Product Count TextBox

            ReloadProductCount();

            //---- DatagridView

            ReloadGridData();
        }
    }
}
