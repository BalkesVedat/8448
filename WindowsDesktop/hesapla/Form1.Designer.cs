namespace hesapla
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.Sonuc = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.nuSayi1 = new System.Windows.Forms.NumericUpDown();
            this.nuSayi2 = new System.Windows.Forms.NumericUpDown();
            this.nuSonuc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(146, 42);
            this.txtSayi1.MaxLength = 5;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSayi1.Size = new System.Drawing.Size(97, 26);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.Text = "0";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(146, 74);
            this.txtSayi2.MaxLength = 5;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSayi2.Size = new System.Drawing.Size(97, 26);
            this.txtSayi2.TabIndex = 2;
            this.txtSayi2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı2";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(146, 184);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSonuc.Size = new System.Drawing.Size(97, 26);
            this.txtSonuc.TabIndex = 5;
            this.txtSonuc.Text = "0";
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(86, 187);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(55, 20);
            this.Sonuc.TabIndex = 4;
            this.Sonuc.Text = "Sonuc";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(146, 127);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(97, 31);
            this.btnTopla.TabIndex = 4;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // nuSayi1
            // 
            this.nuSayi1.Location = new System.Drawing.Point(258, 42);
            this.nuSayi1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuSayi1.Name = "nuSayi1";
            this.nuSayi1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nuSayi1.Size = new System.Drawing.Size(97, 26);
            this.nuSayi1.TabIndex = 1;
            // 
            // nuSayi2
            // 
            this.nuSayi2.Location = new System.Drawing.Point(258, 74);
            this.nuSayi2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuSayi2.Name = "nuSayi2";
            this.nuSayi2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nuSayi2.Size = new System.Drawing.Size(97, 26);
            this.nuSayi2.TabIndex = 3;
            // 
            // nuSonuc
            // 
            this.nuSonuc.Enabled = false;
            this.nuSonuc.Location = new System.Drawing.Point(258, 184);
            this.nuSonuc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuSonuc.Name = "nuSonuc";
            this.nuSonuc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nuSonuc.Size = new System.Drawing.Size(97, 26);
            this.nuSonuc.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 258);
            this.Controls.Add(this.nuSonuc);
            this.Controls.Add(this.nuSayi2);
            this.Controls.Add(this.nuSayi1);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hesap Formu";
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.NumericUpDown nuSayi1;
        private System.Windows.Forms.NumericUpDown nuSayi2;
        private System.Windows.Forms.NumericUpDown nuSonuc;
    }
}

