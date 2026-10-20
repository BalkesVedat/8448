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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
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
            this.dgvUrunListesi.Location = new System.Drawing.Point(0, 314);
            this.dgvUrunListesi.Name = "dgvUrunListesi";
            this.dgvUrunListesi.RowHeadersWidth = 51;
            this.dgvUrunListesi.RowTemplate.Height = 24;
            this.dgvUrunListesi.Size = new System.Drawing.Size(918, 279);
            this.dgvUrunListesi.TabIndex = 2;
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
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 593);
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
    }
}

