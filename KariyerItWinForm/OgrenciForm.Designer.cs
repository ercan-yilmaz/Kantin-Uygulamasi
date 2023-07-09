namespace KariyerItWinForm
{
    partial class OgrenciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciForm));
            this.btn_OgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.txtÖgrenciMail = new System.Windows.Forms.TextBox();
            this.txtÖgrenciTel = new System.Windows.Forms.TextBox();
            this.txtÖgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.txtÖgrenciAdi = new System.Windows.Forms.TextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.dgvOgrenci = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OgrenciGuncelle
            // 
            this.btn_OgrenciGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OgrenciGuncelle.BackgroundImage")));
            this.btn_OgrenciGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OgrenciGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OgrenciGuncelle.Location = new System.Drawing.Point(588, 333);
            this.btn_OgrenciGuncelle.Name = "btn_OgrenciGuncelle";
            this.btn_OgrenciGuncelle.Size = new System.Drawing.Size(78, 84);
            this.btn_OgrenciGuncelle.TabIndex = 40;
            this.btn_OgrenciGuncelle.Text = "Düzenle";
            this.btn_OgrenciGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_OgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btn_OgrenciGuncelle.Click += new System.EventHandler(this.BtnOgrenciGuncelle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenciSil.BackgroundImage")));
            this.btnOgrenciSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOgrenciSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOgrenciSil.Location = new System.Drawing.Point(694, 333);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(78, 84);
            this.btnOgrenciSil.TabIndex = 39;
            this.btnOgrenciSil.Text = "Sil";
            this.btnOgrenciSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.BtnOgrenciSil_Click);
            // 
            // txtÖgrenciMail
            // 
            this.txtÖgrenciMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtÖgrenciMail.Location = new System.Drawing.Point(131, 397);
            this.txtÖgrenciMail.Name = "txtÖgrenciMail";
            this.txtÖgrenciMail.Size = new System.Drawing.Size(100, 20);
            this.txtÖgrenciMail.TabIndex = 27;
            // 
            // txtÖgrenciTel
            // 
            this.txtÖgrenciTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtÖgrenciTel.Location = new System.Drawing.Point(131, 371);
            this.txtÖgrenciTel.Name = "txtÖgrenciTel";
            this.txtÖgrenciTel.Size = new System.Drawing.Size(100, 20);
            this.txtÖgrenciTel.TabIndex = 26;
            // 
            // txtÖgrenciSoyadi
            // 
            this.txtÖgrenciSoyadi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtÖgrenciSoyadi.Location = new System.Drawing.Point(131, 345);
            this.txtÖgrenciSoyadi.Name = "txtÖgrenciSoyadi";
            this.txtÖgrenciSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtÖgrenciSoyadi.TabIndex = 25;
            // 
            // txtÖgrenciAdi
            // 
            this.txtÖgrenciAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtÖgrenciAdi.Location = new System.Drawing.Point(131, 318);
            this.txtÖgrenciAdi.Name = "txtÖgrenciAdi";
            this.txtÖgrenciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtÖgrenciAdi.TabIndex = 24;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenciEkle.BackgroundImage")));
            this.btnOgrenciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOgrenciEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(482, 333);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(78, 84);
            this.btnOgrenciEkle.TabIndex = 23;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // dgvOgrenci
            // 
            this.dgvOgrenci.AllowUserToAddRows = false;
            this.dgvOgrenci.AllowUserToDeleteRows = false;
            this.dgvOgrenci.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenci.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvOgrenci.GridColor = System.Drawing.Color.Black;
            this.dgvOgrenci.Location = new System.Drawing.Point(12, 12);
            this.dgvOgrenci.Name = "dgvOgrenci";
            this.dgvOgrenci.ReadOnly = true;
            this.dgvOgrenci.Size = new System.Drawing.Size(760, 263);
            this.dgvOgrenci.TabIndex = 22;
            this.dgvOgrenci.SelectionChanged += new System.EventHandler(this.DgvÖgrenci_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "E-Posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Telefon No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Soyadı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Adı";
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_OgrenciGuncelle);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.txtÖgrenciMail);
            this.Controls.Add(this.txtÖgrenciTel);
            this.Controls.Add(this.txtÖgrenciSoyadi);
            this.Controls.Add(this.txtÖgrenciAdi);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.dgvOgrenci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OgrenciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.Ogrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OgrenciGuncelle;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.TextBox txtÖgrenciMail;
        private System.Windows.Forms.TextBox txtÖgrenciTel;
        private System.Windows.Forms.TextBox txtÖgrenciSoyadi;
        private System.Windows.Forms.TextBox txtÖgrenciAdi;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.DataGridView dgvOgrenci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}