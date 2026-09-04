namespace KayitFormu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaYatışİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taburcuİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.gboxCinsiyet = new System.Windows.Forms.GroupBox();
            this.gboxCalismaDurumu = new System.Windows.Forms.GroupBox();
            this.rbEmekli = new System.Windows.Forms.RadioButton();
            this.rbMemur = new System.Windows.Forms.RadioButton();
            this.rbUcretli = new System.Windows.Forms.RadioButton();
            this.rbSerbest = new System.Windows.Forms.RadioButton();
            this.rbOgrenci = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.gboxCinsiyet.SuspendLayout();
            this.gboxCalismaDurumu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.hastaİşlemleriToolStripMenuItem,
            this.malzemeİşlemleriToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.rAPORLAMAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.toolStripSeparator1,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.açToolStripMenuItem.Text = "&Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.yazdırToolStripMenuItem.Text = "&Yazdır";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.çıkışToolStripMenuItem.Text = "&Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKaydıToolStripMenuItem,
            this.hastaYatışİşlemiToolStripMenuItem,
            this.taburcuİşlemiToolStripMenuItem});
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.hastaİşlemleriToolStripMenuItem.Text = "&Hasta İşlemleri";
            // 
            // hastaKaydıToolStripMenuItem
            // 
            this.hastaKaydıToolStripMenuItem.Name = "hastaKaydıToolStripMenuItem";
            this.hastaKaydıToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.hastaKaydıToolStripMenuItem.Text = "Has&ta Kayıt ve Güncelleme";
            this.hastaKaydıToolStripMenuItem.Click += new System.EventHandler(this.hastaKaydıToolStripMenuItem_Click);
            // 
            // hastaYatışİşlemiToolStripMenuItem
            // 
            this.hastaYatışİşlemiToolStripMenuItem.Name = "hastaYatışİşlemiToolStripMenuItem";
            this.hastaYatışİşlemiToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.hastaYatışİşlemiToolStripMenuItem.Text = "Hasta Yatış İşlemi";
            // 
            // taburcuİşlemiToolStripMenuItem
            // 
            this.taburcuİşlemiToolStripMenuItem.Name = "taburcuİşlemiToolStripMenuItem";
            this.taburcuİşlemiToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.taburcuİşlemiToolStripMenuItem.Text = "Taburcu İşlemi";
            // 
            // malzemeİşlemleriToolStripMenuItem
            // 
            this.malzemeİşlemleriToolStripMenuItem.Name = "malzemeİşlemleriToolStripMenuItem";
            this.malzemeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.malzemeİşlemleriToolStripMenuItem.Text = "&Malzeme İşlemleri";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.personelİşlemleriToolStripMenuItem.Text = "&Personel İşlemleri";
            // 
            // rAPORLAMAToolStripMenuItem
            // 
            this.rAPORLAMAToolStripMenuItem.Name = "rAPORLAMAToolStripMenuItem";
            this.rAPORLAMAToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.rAPORLAMAToolStripMenuItem.Text = "&RAPORLAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(139, 133);
            this.txtAdSoyad.MaxLength = 50;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(207, 26);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(139, 165);
            this.txtEPosta.MaxLength = 50;
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(207, 26);
            this.txtEPosta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "EPosta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(139, 229);
            this.txtAdres.MaxLength = 150;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(207, 71);
            this.txtAdres.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(139, 198);
            this.txtTelefon.Mask = "(999) 000 00 00";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(207, 26);
            this.txtTelefon.TabIndex = 9;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Checked = true;
            this.rbErkek.Location = new System.Drawing.Point(19, 26);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(75, 24);
            this.rbErkek.TabIndex = 10;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(118, 26);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(74, 24);
            this.rbKadin.TabIndex = 11;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cinsiyet";
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Items.AddRange(new object[] {
            "Dahiliye",
            "KBB",
            "Kardiyoloji",
            "Kadın Doğum",
            "Çocuk",
            "Cildiye",
            "Göz"});
            this.cmbPoliklinik.Location = new System.Drawing.Point(139, 378);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(207, 28);
            this.cmbPoliklinik.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Poliklinik";
            // 
            // dtpIslemTarihi
            // 
            this.dtpIslemTarihi.Location = new System.Drawing.Point(745, 54);
            this.dtpIslemTarihi.Name = "dtpIslemTarihi";
            this.dtpIslemTarihi.Size = new System.Drawing.Size(221, 26);
            this.dtpIslemTarihi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "İşlem Tarihi";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(48, 54);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 17;
            this.picLogo.TabStop = false;
            // 
            // gboxCinsiyet
            // 
            this.gboxCinsiyet.Controls.Add(this.rbErkek);
            this.gboxCinsiyet.Controls.Add(this.rbKadin);
            this.gboxCinsiyet.ForeColor = System.Drawing.Color.Black;
            this.gboxCinsiyet.Location = new System.Drawing.Point(139, 306);
            this.gboxCinsiyet.Name = "gboxCinsiyet";
            this.gboxCinsiyet.Size = new System.Drawing.Size(207, 66);
            this.gboxCinsiyet.TabIndex = 18;
            this.gboxCinsiyet.TabStop = false;
            // 
            // gboxCalismaDurumu
            // 
            this.gboxCalismaDurumu.Controls.Add(this.rbOgrenci);
            this.gboxCalismaDurumu.Controls.Add(this.rbSerbest);
            this.gboxCalismaDurumu.Controls.Add(this.rbUcretli);
            this.gboxCalismaDurumu.Controls.Add(this.rbMemur);
            this.gboxCalismaDurumu.Controls.Add(this.rbEmekli);
            this.gboxCalismaDurumu.Location = new System.Drawing.Point(48, 412);
            this.gboxCalismaDurumu.Name = "gboxCalismaDurumu";
            this.gboxCalismaDurumu.Size = new System.Drawing.Size(518, 69);
            this.gboxCalismaDurumu.TabIndex = 19;
            this.gboxCalismaDurumu.TabStop = false;
            this.gboxCalismaDurumu.Text = "Çalışma Durumu";
            this.gboxCalismaDurumu.Enter += new System.EventHandler(this.gboxCalismaDurumu_Enter);
            // 
            // rbEmekli
            // 
            this.rbEmekli.AutoSize = true;
            this.rbEmekli.Location = new System.Drawing.Point(7, 26);
            this.rbEmekli.Name = "rbEmekli";
            this.rbEmekli.Size = new System.Drawing.Size(81, 24);
            this.rbEmekli.TabIndex = 0;
            this.rbEmekli.TabStop = true;
            this.rbEmekli.Text = "Emekli";
            this.rbEmekli.UseVisualStyleBackColor = true;
            // 
            // rbMemur
            // 
            this.rbMemur.AutoSize = true;
            this.rbMemur.Location = new System.Drawing.Point(94, 26);
            this.rbMemur.Name = "rbMemur";
            this.rbMemur.Size = new System.Drawing.Size(83, 24);
            this.rbMemur.TabIndex = 1;
            this.rbMemur.TabStop = true;
            this.rbMemur.Text = "Memur";
            this.rbMemur.UseVisualStyleBackColor = true;
            // 
            // rbUcretli
            // 
            this.rbUcretli.AutoSize = true;
            this.rbUcretli.Location = new System.Drawing.Point(183, 26);
            this.rbUcretli.Name = "rbUcretli";
            this.rbUcretli.Size = new System.Drawing.Size(79, 24);
            this.rbUcretli.TabIndex = 2;
            this.rbUcretli.TabStop = true;
            this.rbUcretli.Text = "Ücretli";
            this.rbUcretli.UseVisualStyleBackColor = true;
            // 
            // rbSerbest
            // 
            this.rbSerbest.AutoSize = true;
            this.rbSerbest.Location = new System.Drawing.Point(268, 26);
            this.rbSerbest.Name = "rbSerbest";
            this.rbSerbest.Size = new System.Drawing.Size(144, 24);
            this.rbSerbest.TabIndex = 3;
            this.rbSerbest.TabStop = true;
            this.rbSerbest.Text = "Serbest Meslek";
            this.rbSerbest.UseVisualStyleBackColor = true;
            // 
            // rbOgrenci
            // 
            this.rbOgrenci.AutoSize = true;
            this.rbOgrenci.Location = new System.Drawing.Point(419, 25);
            this.rbOgrenci.Name = "rbOgrenci";
            this.rbOgrenci.Size = new System.Drawing.Size(89, 24);
            this.rbOgrenci.TabIndex = 4;
            this.rbOgrenci.TabStop = true;
            this.rbOgrenci.Text = "Öğrenci";
            this.rbOgrenci.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(524, 122);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 75);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(657, 122);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 75);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(790, 122);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 75);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "FORMU TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(987, 589);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gboxCalismaDurumu);
            this.Controls.Add(this.gboxCinsiyet);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpIslemTarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hasta Kayıt Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gboxCinsiyet.ResumeLayout(false);
            this.gboxCinsiyet.PerformLayout();
            this.gboxCalismaDurumu.ResumeLayout(false);
            this.gboxCalismaDurumu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaYatışİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taburcuİşlemiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpIslemTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox gboxCinsiyet;
        private System.Windows.Forms.GroupBox gboxCalismaDurumu;
        private System.Windows.Forms.RadioButton rbOgrenci;
        private System.Windows.Forms.RadioButton rbSerbest;
        private System.Windows.Forms.RadioButton rbUcretli;
        private System.Windows.Forms.RadioButton rbMemur;
        private System.Windows.Forms.RadioButton rbEmekli;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
    }
}

