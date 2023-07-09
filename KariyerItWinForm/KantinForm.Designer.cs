namespace KariyerItWinForm
{
    partial class KantinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KantinForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKantinDetay = new System.Windows.Forms.TextBox();
            this.cboxKantinKullanici = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKantinTutar = new System.Windows.Forms.TextBox();
            this.btnVrGüncelle = new System.Windows.Forms.Button();
            this.btnVrSil = new System.Windows.Forms.Button();
            this.btnVrEkle = new System.Windows.Forms.Button();
            this.dgvKantin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKantin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(220, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Detay : ";
            // 
            // txtKantinDetay
            // 
            this.txtKantinDetay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtKantinDetay.Location = new System.Drawing.Point(278, 317);
            this.txtKantinDetay.Multiline = true;
            this.txtKantinDetay.Name = "txtKantinDetay";
            this.txtKantinDetay.Size = new System.Drawing.Size(171, 84);
            this.txtKantinDetay.TabIndex = 83;
            // 
            // cboxKantinKullanici
            // 
            this.cboxKantinKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKantinKullanici.FormattingEnabled = true;
            this.cboxKantinKullanici.Location = new System.Drawing.Point(84, 318);
            this.cboxKantinKullanici.Name = "cboxKantinKullanici";
            this.cboxKantinKullanici.Size = new System.Drawing.Size(121, 21);
            this.cboxKantinKullanici.TabIndex = 82;
            this.cboxKantinKullanici.SelectedValueChanged += new System.EventHandler(this.CboxKantinKullanici_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Tutar : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Kullanıcı :";
            // 
            // txtKantinTutar
            // 
            this.txtKantinTutar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtKantinTutar.Location = new System.Drawing.Point(84, 350);
            this.txtKantinTutar.Name = "txtKantinTutar";
            this.txtKantinTutar.Size = new System.Drawing.Size(121, 20);
            this.txtKantinTutar.TabIndex = 79;
            // 
            // btnVrGüncelle
            // 
            this.btnVrGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVrGüncelle.BackgroundImage")));
            this.btnVrGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVrGüncelle.Location = new System.Drawing.Point(588, 317);
            this.btnVrGüncelle.Name = "btnVrGüncelle";
            this.btnVrGüncelle.Size = new System.Drawing.Size(78, 84);
            this.btnVrGüncelle.TabIndex = 78;
            this.btnVrGüncelle.Text = "Güncelle";
            this.btnVrGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVrGüncelle.UseVisualStyleBackColor = true;
            this.btnVrGüncelle.Click += new System.EventHandler(this.BtnKantinGuncelle_Click);
            // 
            // btnVrSil
            // 
            this.btnVrSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVrSil.BackgroundImage")));
            this.btnVrSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVrSil.Location = new System.Drawing.Point(694, 317);
            this.btnVrSil.Name = "btnVrSil";
            this.btnVrSil.Size = new System.Drawing.Size(78, 84);
            this.btnVrSil.TabIndex = 77;
            this.btnVrSil.Text = "Sil";
            this.btnVrSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVrSil.UseVisualStyleBackColor = true;
            this.btnVrSil.Click += new System.EventHandler(this.BtnKantinSil_Click);
            // 
            // btnVrEkle
            // 
            this.btnVrEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVrEkle.BackgroundImage")));
            this.btnVrEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVrEkle.Location = new System.Drawing.Point(482, 317);
            this.btnVrEkle.Name = "btnVrEkle";
            this.btnVrEkle.Size = new System.Drawing.Size(78, 84);
            this.btnVrEkle.TabIndex = 76;
            this.btnVrEkle.Text = "Ekle";
            this.btnVrEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVrEkle.UseVisualStyleBackColor = true;
            this.btnVrEkle.Click += new System.EventHandler(this.BtnKantinEkle_Click);
            // 
            // dgvKantin
            // 
            this.dgvKantin.AllowUserToAddRows = false;
            this.dgvKantin.AllowUserToDeleteRows = false;
            this.dgvKantin.BackgroundColor = System.Drawing.Color.White;
            this.dgvKantin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKantin.GridColor = System.Drawing.Color.Black;
            this.dgvKantin.Location = new System.Drawing.Point(12, 12);
            this.dgvKantin.MultiSelect = false;
            this.dgvKantin.Name = "dgvKantin";
            this.dgvKantin.ReadOnly = true;
            this.dgvKantin.Size = new System.Drawing.Size(760, 263);
            this.dgvKantin.TabIndex = 75;
            this.dgvKantin.SelectionChanged += new System.EventHandler(this.DgvKantin_SelectionChanged);
            // 
            // KantinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKantinDetay);
            this.Controls.Add(this.cboxKantinKullanici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKantinTutar);
            this.Controls.Add(this.btnVrGüncelle);
            this.Controls.Add(this.btnVrSil);
            this.Controls.Add(this.btnVrEkle);
            this.Controls.Add(this.dgvKantin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KantinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kantin İşlemleri";
            this.Load += new System.EventHandler(this.KantinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKantin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKantinDetay;
        private System.Windows.Forms.ComboBox cboxKantinKullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKantinTutar;
        private System.Windows.Forms.Button btnVrGüncelle;
        private System.Windows.Forms.Button btnVrSil;
        private System.Windows.Forms.Button btnVrEkle;
        private System.Windows.Forms.DataGridView dgvKantin;
    }
}