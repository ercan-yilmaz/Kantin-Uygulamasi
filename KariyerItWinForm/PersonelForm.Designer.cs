namespace KariyerItWinForm
{
    partial class PersonelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelForm));
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.btnPersonelGüncelle = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelMail = new System.Windows.Forms.TextBox();
            this.txtPersonelTelefon = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AllowUserToAddRows = false;
            this.dgvPersonel.AllowUserToDeleteRows = false;
            this.dgvPersonel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.GridColor = System.Drawing.Color.Black;
            this.dgvPersonel.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonel.MultiSelect = false;
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.ReadOnly = true;
            this.dgvPersonel.Size = new System.Drawing.Size(760, 263);
            this.dgvPersonel.TabIndex = 0;
            this.dgvPersonel.SelectionChanged += new System.EventHandler(this.DgvPersonel_SelectionChanged);
            // 
            // btnPersonelGüncelle
            // 
            this.btnPersonelGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelGüncelle.BackgroundImage")));
            this.btnPersonelGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersonelGüncelle.Location = new System.Drawing.Point(588, 328);
            this.btnPersonelGüncelle.Name = "btnPersonelGüncelle";
            this.btnPersonelGüncelle.Size = new System.Drawing.Size(78, 84);
            this.btnPersonelGüncelle.TabIndex = 43;
            this.btnPersonelGüncelle.Text = "Güncelle";
            this.btnPersonelGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelGüncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGüncelle.Click += new System.EventHandler(this.BtnPersonelGüncelle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelSil.BackgroundImage")));
            this.btnPersonelSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersonelSil.Location = new System.Drawing.Point(694, 328);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(78, 84);
            this.btnPersonelSil.TabIndex = 42;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.BtnPersonelSil_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelEkle.BackgroundImage")));
            this.btnPersonelEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersonelEkle.Location = new System.Drawing.Point(482, 328);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(78, 84);
            this.btnPersonelEkle.TabIndex = 41;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.BtnPersonelEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "E-Posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Telefon No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Adı";
            // 
            // txtPersonelMail
            // 
            this.txtPersonelMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPersonelMail.Location = new System.Drawing.Point(137, 392);
            this.txtPersonelMail.Name = "txtPersonelMail";
            this.txtPersonelMail.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelMail.TabIndex = 47;
            // 
            // txtPersonelTelefon
            // 
            this.txtPersonelTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPersonelTelefon.Location = new System.Drawing.Point(137, 366);
            this.txtPersonelTelefon.Name = "txtPersonelTelefon";
            this.txtPersonelTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelTelefon.TabIndex = 46;
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(137, 340);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelSoyadi.TabIndex = 45;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPersonelAdi.Location = new System.Drawing.Point(137, 313);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelAdi.TabIndex = 44;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonelMail);
            this.Controls.Add(this.txtPersonelTelefon);
            this.Controls.Add(this.txtPersonelSoyadi);
            this.Controls.Add(this.txtPersonelAdi);
            this.Controls.Add(this.btnPersonelGüncelle);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.dgvPersonel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Button btnPersonelGüncelle;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelMail;
        private System.Windows.Forms.TextBox txtPersonelTelefon;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.TextBox txtPersonelAdi;
    }
}