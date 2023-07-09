namespace KariyerItWinForm
{
    partial class VrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VrForm));
            this.btnVrGüncelle = new System.Windows.Forms.Button();
            this.btnVrSil = new System.Windows.Forms.Button();
            this.btnVrEkle = new System.Windows.Forms.Button();
            this.dgvVr = new System.Windows.Forms.DataGridView();
            this.cboxVrKullanici = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVrTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrDetay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVrGüncelle
            // 
            this.btnVrGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVrGüncelle.BackgroundImage")));
            this.btnVrGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVrGüncelle.Location = new System.Drawing.Point(588, 310);
            this.btnVrGüncelle.Name = "btnVrGüncelle";
            this.btnVrGüncelle.Size = new System.Drawing.Size(78, 84);
            this.btnVrGüncelle.TabIndex = 55;
            this.btnVrGüncelle.Text = "Güncelle";
            this.btnVrGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVrGüncelle.UseVisualStyleBackColor = true;
            this.btnVrGüncelle.Click += new System.EventHandler(this.BtnVrGuncelle_Click);
            // 
            // btnVrSil
            // 
            this.btnVrSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVrSil.BackgroundImage")));
            this.btnVrSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVrSil.Location = new System.Drawing.Point(694, 310);
            this.btnVrSil.Name = "btnVrSil";
            this.btnVrSil.Size = new System.Drawing.Size(78, 84);
            this.btnVrSil.TabIndex = 54;
            this.btnVrSil.Text = "Sil";
            this.btnVrSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVrSil.UseVisualStyleBackColor = true;
            this.btnVrSil.Click += new System.EventHandler(this.BtnVrSil_Click);
            // 
            // btnVrEkle
            // 
            this.btnVrEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVrEkle.BackgroundImage")));
            this.btnVrEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVrEkle.Location = new System.Drawing.Point(482, 310);
            this.btnVrEkle.Name = "btnVrEkle";
            this.btnVrEkle.Size = new System.Drawing.Size(78, 84);
            this.btnVrEkle.TabIndex = 53;
            this.btnVrEkle.Text = "Ekle";
            this.btnVrEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVrEkle.UseVisualStyleBackColor = true;
            this.btnVrEkle.Click += new System.EventHandler(this.BtnVrEkle_Click);
            // 
            // dgvVr
            // 
            this.dgvVr.AllowUserToAddRows = false;
            this.dgvVr.AllowUserToDeleteRows = false;
            this.dgvVr.BackgroundColor = System.Drawing.Color.White;
            this.dgvVr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVr.GridColor = System.Drawing.Color.Black;
            this.dgvVr.Location = new System.Drawing.Point(12, 12);
            this.dgvVr.MultiSelect = false;
            this.dgvVr.Name = "dgvVr";
            this.dgvVr.ReadOnly = true;
            this.dgvVr.Size = new System.Drawing.Size(760, 263);
            this.dgvVr.TabIndex = 52;
            this.dgvVr.SelectionChanged += new System.EventHandler(this.DgvVr_SelectionChanged);
            // 
            // cboxVrKullanici
            // 
            this.cboxVrKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxVrKullanici.FormattingEnabled = true;
            this.cboxVrKullanici.Location = new System.Drawing.Point(83, 310);
            this.cboxVrKullanici.Name = "cboxVrKullanici";
            this.cboxVrKullanici.Size = new System.Drawing.Size(121, 21);
            this.cboxVrKullanici.TabIndex = 72;
            this.cboxVrKullanici.SelectedIndexChanged += new System.EventHandler(this.CboxVrKullanici_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Tutar : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(14, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Kullanıcı :";
            // 
            // txtVrTutar
            // 
            this.txtVrTutar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVrTutar.Location = new System.Drawing.Point(83, 349);
            this.txtVrTutar.Name = "txtVrTutar";
            this.txtVrTutar.Size = new System.Drawing.Size(121, 20);
            this.txtVrTutar.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(220, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Detay : ";
            // 
            // txtVrDetay
            // 
            this.txtVrDetay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVrDetay.Location = new System.Drawing.Point(278, 310);
            this.txtVrDetay.Multiline = true;
            this.txtVrDetay.Name = "txtVrDetay";
            this.txtVrDetay.Size = new System.Drawing.Size(171, 84);
            this.txtVrDetay.TabIndex = 73;
            // 
            // VrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVrDetay);
            this.Controls.Add(this.cboxVrKullanici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVrTutar);
            this.Controls.Add(this.btnVrGüncelle);
            this.Controls.Add(this.btnVrSil);
            this.Controls.Add(this.btnVrEkle);
            this.Controls.Add(this.dgvVr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vr İşlemleri";
            this.Load += new System.EventHandler(this.VrForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVrGüncelle;
        private System.Windows.Forms.Button btnVrSil;
        private System.Windows.Forms.Button btnVrEkle;
        private System.Windows.Forms.DataGridView dgvVr;
        private System.Windows.Forms.ComboBox cboxVrKullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVrTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrDetay;
    }
}