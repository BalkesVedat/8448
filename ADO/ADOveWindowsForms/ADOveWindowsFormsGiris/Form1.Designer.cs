namespace ADOveWindowsFormsGiris
{
    partial class FrmRapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapor));
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.dgvUrunListesi = new System.Windows.Forms.DataGridView();
            this.northwindDataSet = new ADOveWindowsFormsGiris.NorthwindDataSet();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new ADOveWindowsFormsGiris.NorthwindDataSetTableAdapters.UrunlerTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSonlandi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.northwindDataSet_Kategoriler = new ADOveWindowsFormsGiris.NorthwindDataSet_Kategoriler();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter = new ADOveWindowsFormsGiris.NorthwindDataSet_KategorilerTableAdapters.KategorilerTableAdapter();
            this.northwindDataSet_Tedarikciler = new ADOveWindowsFormsGiris.NorthwindDataSet_Tedarikciler();
            this.tedarikcilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tedarikcilerTableAdapter = new ADOveWindowsFormsGiris.NorthwindDataSet_TedarikcilerTableAdapters.TedarikcilerTableAdapter();
            this.nuBirimFiyat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet_Kategoriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet_Tedarikciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikcilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBirimFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Location = new System.Drawing.Point(26, 13);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(74, 16);
            this.lblUrunAdet.TabIndex = 0;
            this.lblUrunAdet.Text = "Ürün Adedi";
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Font = new System.Drawing.Font("Rockwell Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUrunAdet.Location = new System.Drawing.Point(12, 32);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(100, 37);
            this.txtUrunAdet.TabIndex = 1;
            this.txtUrunAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvUrunListesi
            // 
            this.dgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUrunListesi.Location = new System.Drawing.Point(0, 282);
            this.dgvUrunListesi.Name = "dgvUrunListesi";
            this.dgvUrunListesi.RowHeadersWidth = 51;
            this.dgvUrunListesi.RowTemplate.Height = 24;
            this.dgvUrunListesi.Size = new System.Drawing.Size(918, 311);
            this.dgvUrunListesi.TabIndex = 2;
            this.dgvUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunListesi_CellClick);
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.northwindDataSet;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(849, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 56);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtUrunID
            // 
            this.txtUrunID.Enabled = false;
            this.txtUrunID.Location = new System.Drawing.Point(89, 98);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(92, 22);
            this.txtUrunID.TabIndex = 4;
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(13, 101);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(51, 16);
            this.lblUrunID.TabIndex = 5;
            this.lblUrunID.Text = "Ürün ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(89, 126);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(176, 22);
            this.txtUrunAd.TabIndex = 6;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataSource = this.kategorilerBindingSource;
            this.cmbKategori.DisplayMember = "KategoriAdi";
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(89, 155);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(176, 24);
            this.cmbKategori.TabIndex = 8;
            this.cmbKategori.ValueMember = "KategoriID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tedarikçi";
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.DataSource = this.tedarikcilerBindingSource;
            this.cmbTedarikci.DisplayMember = "SirketAdi";
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(89, 185);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(176, 24);
            this.cmbTedarikci.TabIndex = 10;
            this.cmbTedarikci.ValueMember = "TedarikciID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birim Fiyat";
            // 
            // chkSonlandi
            // 
            this.chkSonlandi.AutoSize = true;
            this.chkSonlandi.Location = new System.Drawing.Point(89, 244);
            this.chkSonlandi.Name = "chkSonlandi";
            this.chkSonlandi.Size = new System.Drawing.Size(18, 17);
            this.chkSonlandi.TabIndex = 14;
            this.chkSonlandi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sonlandı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.AccessibleDescription = "*";
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(440, 78);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 141);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AccessibleDescription = "*";
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(548, 78);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(91, 141);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.AccessibleDescription = "*";
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(654, 78);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 141);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // northwindDataSet_Kategoriler
            // 
            this.northwindDataSet_Kategoriler.DataSetName = "NorthwindDataSet_Kategoriler";
            this.northwindDataSet_Kategoriler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.northwindDataSet_Kategoriler;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // northwindDataSet_Tedarikciler
            // 
            this.northwindDataSet_Tedarikciler.DataSetName = "NorthwindDataSet_Tedarikciler";
            this.northwindDataSet_Tedarikciler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tedarikcilerBindingSource
            // 
            this.tedarikcilerBindingSource.DataMember = "Tedarikciler";
            this.tedarikcilerBindingSource.DataSource = this.northwindDataSet_Tedarikciler;
            // 
            // tedarikcilerTableAdapter
            // 
            this.tedarikcilerTableAdapter.ClearBeforeFill = true;
            // 
            // nuBirimFiyat
            // 
            this.nuBirimFiyat.DecimalPlaces = 2;
            this.nuBirimFiyat.Location = new System.Drawing.Point(89, 216);
            this.nuBirimFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuBirimFiyat.Name = "nuBirimFiyat";
            this.nuBirimFiyat.Size = new System.Drawing.Size(176, 22);
            this.nuBirimFiyat.TabIndex = 19;
            this.nuBirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.nuBirimFiyat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkSonlandi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvUrunListesi);
            this.Controls.Add(this.txtUrunAdet);
            this.Controls.Add(this.lblUrunAdet);
            this.Name = "FrmRapor";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet_Kategoriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet_Tedarikciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikcilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBirimFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.TextBox txtUrunAdet;
        private System.Windows.Forms.DataGridView dgvUrunListesi;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private NorthwindDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSonlandi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private NorthwindDataSet_Kategoriler northwindDataSet_Kategoriler;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private NorthwindDataSet_KategorilerTableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private NorthwindDataSet_Tedarikciler northwindDataSet_Tedarikciler;
        private System.Windows.Forms.BindingSource tedarikcilerBindingSource;
        private NorthwindDataSet_TedarikcilerTableAdapters.TedarikcilerTableAdapter tedarikcilerTableAdapter;
        private System.Windows.Forms.NumericUpDown nuBirimFiyat;
    }
}

