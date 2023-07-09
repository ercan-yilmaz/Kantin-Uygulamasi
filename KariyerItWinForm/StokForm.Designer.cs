namespace KariyerItWinForm
{
    partial class StokForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_StokGuncelle = new System.Windows.Forms.Button();
            this.btnStokSil = new System.Windows.Forms.Button();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.cboxUrun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Stok : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(22, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ürün : ";
            // 
            // btn_StokGuncelle
            // 
            this.btn_StokGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StokGuncelle.BackgroundImage")));
            this.btn_StokGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_StokGuncelle.Location = new System.Drawing.Point(588, 326);
            this.btn_StokGuncelle.Name = "btn_StokGuncelle";
            this.btn_StokGuncelle.Size = new System.Drawing.Size(78, 84);
            this.btn_StokGuncelle.TabIndex = 63;
            this.btn_StokGuncelle.Text = "Güncelle";
            this.btn_StokGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_StokGuncelle.UseVisualStyleBackColor = true;
            this.btn_StokGuncelle.Click += new System.EventHandler(this.Btn_StokGuncelle_Click);
            // 
            // btnStokSil
            // 
            this.btnStokSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStokSil.BackgroundImage")));
            this.btnStokSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStokSil.Location = new System.Drawing.Point(694, 326);
            this.btnStokSil.Name = "btnStokSil";
            this.btnStokSil.Size = new System.Drawing.Size(78, 84);
            this.btnStokSil.TabIndex = 62;
            this.btnStokSil.Text = "Sil";
            this.btnStokSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStokSil.UseVisualStyleBackColor = true;
            this.btnStokSil.Click += new System.EventHandler(this.BtnStokSil_Click);
            // 
            // txtStok
            // 
            this.txtStok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStok.Location = new System.Drawing.Point(95, 367);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(121, 20);
            this.txtStok.TabIndex = 59;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStokEkle.BackgroundImage")));
            this.btnStokEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStokEkle.Location = new System.Drawing.Point(482, 326);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(78, 84);
            this.btnStokEkle.TabIndex = 57;
            this.btnStokEkle.Text = "Ekle";
            this.btnStokEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.BtnStokEkle_Click);
            // 
            // dgvStok
            // 
            this.dgvStok.AllowUserToAddRows = false;
            this.dgvStok.AllowUserToDeleteRows = false;
            this.dgvStok.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvStok.GridColor = System.Drawing.Color.Coral;
            this.dgvStok.Location = new System.Drawing.Point(12, 12);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.ReadOnly = true;
            this.dgvStok.Size = new System.Drawing.Size(760, 263);
            this.dgvStok.TabIndex = 56;
            this.dgvStok.SelectionChanged += new System.EventHandler(this.DgvStok_SelectionChanged);
            // 
            // cboxUrun
            // 
            this.cboxUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUrun.FormattingEnabled = true;
            this.cboxUrun.Location = new System.Drawing.Point(95, 335);
            this.cboxUrun.Name = "cboxUrun";
            this.cboxUrun.Size = new System.Drawing.Size(121, 21);
            this.cboxUrun.TabIndex = 68;
            this.cboxUrun.SelectedIndexChanged += new System.EventHandler(this.CboxUrun_SelectedIndexChanged);
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cboxUrun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_StokGuncelle);
            this.Controls.Add(this.btnStokSil);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.dgvStok);
            this.MaximizeBox = false;
            this.Name = "StokForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İşlemleri";
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_StokGuncelle;
        private System.Windows.Forms.Button btnStokSil;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.ComboBox cboxUrun;
    }
}