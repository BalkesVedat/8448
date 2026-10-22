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
            // TODO: This line of code loads data into the 'northwindDataSet_Tedarikciler.Tedarikciler' table. You can move, or remove it, as needed.
            this.tedarikcilerTableAdapter.Fill(this.northwindDataSet_Tedarikciler.Tedarikciler);
            // TODO: This line of code loads data into the 'northwindDataSet_Kategoriler.Kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter.Fill(this.northwindDataSet_Kategoriler.Kategoriler);
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

            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;



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
                cmd.CommandText = "SELECT UrunID, UrunAdi, KategoriID, TedarikciID, BirimFiyati, Sonlandi  FROM Urunler";

                adaptor = new SqlDataAdapter(cmd.CommandText, conn);

                DataTable dtKlon = new DataTable();

                try
                {
                    dtKlon = dt.Clone();
                    dt.Clear();
                    adaptor.Fill(dt);
                }
                catch (Exception)
                {
                    dt = dtKlon;
                    MessageBox.Show("Veri Çekilirken bir sorun oluştu");
                }
                

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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text.Length <= 5 )
            {
                MessageBox.Show("Ürün Adı en az 5 karakter olmalıdır.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          //  MessageBox.Show("Test Başarılı");

            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO Urunler (UrunAdi,TedarikciID,KategoriID,BirimFiyati,Sonlandi) VALUES (@UrunAdi,@TedarikciID,@KategoriID,@BirimFiyati,@Sonlandi)";

            cmd.Parameters.AddWithValue("@UrunAdi",txtUrunAd.Text);
            cmd.Parameters.AddWithValue("@TedarikciID", cmbTedarikci.SelectedValue);
            cmd.Parameters.AddWithValue("@KategoriID", cmbKategori.SelectedValue);
            cmd.Parameters.AddWithValue("@BirimFiyati", nuBirimFiyat.Value);
            cmd.Parameters.AddWithValue("@Sonlandi", chkSonlandi.Checked);

            OpenConnection();

            int adet = cmd.ExecuteNonQuery();

            CloseConnection();

            if (adet > 0)
            {
                MessageBox.Show("Başarıyla kaydedildi");                
            }
            else
            {
                MessageBox.Show("Kaydedilemedi");
            }

            //---- Product Count TextBox

            ReloadProductCount();

            //---- DatagridView

            ReloadGridData();

            FormuTemizle();

        }

        private void FormuTemizle()
        {
            txtUrunID.Text = string.Empty;
            txtUrunAd.Text = string.Empty;
            cmbTedarikci.SelectedIndex = 0;
            cmbKategori.SelectedIndex = 0;
            nuBirimFiyat.Value = 0;
            chkSonlandi.Checked = false;
        }

        private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewCell cell = (DataGridViewCell)sender;

           DataGridViewCell cell = dgvUrunListesi.CurrentCell;

            int satirNo = cell.RowIndex;

            DataGridViewRow satir = dgvUrunListesi.Rows[satirNo];

            txtUrunID.Text = satir.Cells[0].Value.ToString();
            txtUrunAd.Text = satir.Cells[1].Value.ToString();
            cmbKategori.SelectedValue = satir.Cells[2].Value.ToString();
            cmbTedarikci.SelectedValue = satir.Cells[3].Value.ToString();
            nuBirimFiyat.Value = Convert.ToDecimal(satir.Cells[4].Value.ToString());
            chkSonlandi.Checked = Convert.ToBoolean(satir.Cells[5].Value.ToString());

        }
    }
}
