namespace KariyerItWinForm
{
    partial class FaturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFaturaDetay = new System.Windows.Forms.TextBox();
            this.cboxFaturaKullanici = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFaturaTutar = new System.Windows.Forms.TextBox();
            this.btnFaturaGüncelle = new System.Windows.Forms.Button();
            this.btnFaturaSil = new System.Windows.Forms.Button();
            this.btnFaturaEkle = new System.Windows.Forms.Button();
            this.dgvFatura = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(227, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Detay : ";
            // 
            // txtFaturaDetay
            // 
            this.txtFaturaDetay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFaturaDetay.Location = new System.Drawing.Point(285, 323);
            this.txtFaturaDetay.Multiline = true;
            this.txtFaturaDetay.Name = "txtFaturaDetay";
            this.txtFaturaDetay.Size = new System.Drawing.Size(171, 84);
            this.txtFaturaDetay.TabIndex = 93;
            // 
            // cboxFaturaKullanici
            // 
            this.cboxFaturaKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFaturaKullanici.FormattingEnabled = true;
            this.cboxFaturaKullanici.Location = new System.Drawing.Point(85, 323);
            this.cboxFaturaKullanici.Name = "cboxFaturaKullanici";
            this.cboxFaturaKullanici.Size = new System.Drawing.Size(121, 21);
            this.cboxFaturaKullanici.TabIndex = 92;
            this.cboxFaturaKullanici.SelectedValueChanged += new System.EventHandler(this.CboxFaturaKullanici_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Tutar : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Kullanıcı :";
            // 
            // txtFaturaTutar
            // 
            this.txtFaturaTutar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFaturaTutar.Location = new System.Drawing.Point(85, 355);
            this.txtFaturaTutar.Name = "txtFaturaTutar";
            this.txtFaturaTutar.Size = new System.Drawing.Size(121, 20);
            this.txtFaturaTutar.TabIndex = 89;
            // 
            // btnFaturaGüncelle
            // 
            this.btnFaturaGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFaturaGüncelle.BackgroundImage")));
            this.btnFaturaGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFaturaGüncelle.Location = new System.Drawing.Point(588, 323);
            this.btnFaturaGüncelle.Name = "btnFaturaGüncelle";
            this.btnFaturaGüncelle.Size = new System.Drawing.Size(78, 84);
            this.btnFaturaGüncelle.TabIndex = 88;
            this.btnFaturaGüncelle.Text = "Güncelle";
            this.btnFaturaGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFaturaGüncelle.UseVisualStyleBackColor = true;
            this.btnFaturaGüncelle.Click += new System.EventHandler(this.BtnFaturaGuncelle_Click);
            // 
            // btnFaturaSil
            // 
            this.btnFaturaSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFaturaSil.BackgroundImage")));
            this.btnFaturaSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFaturaSil.Location = new System.Drawing.Point(694, 323);
            this.btnFaturaSil.Name = "btnFaturaSil";
            this.btnFaturaSil.Size = new System.Drawing.Size(78, 84);
            this.btnFaturaSil.TabIndex = 87;
            this.btnFaturaSil.Text = "Sil";
            this.btnFaturaSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFaturaSil.UseVisualStyleBackColor = true;
            this.btnFaturaSil.Click += new System.EventHandler(this.BtnFaturaSil_Click);
            // 
            // btnFaturaEkle
            // 
            this.btnFaturaEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFaturaEkle.BackgroundImage")));
            this.btnFaturaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFaturaEkle.Location = new System.Drawing.Point(482, 323);
            this.btnFaturaEkle.Name = "btnFaturaEkle";
            this.btnFaturaEkle.Size = new System.Drawing.Size(78, 84);
            this.btnFaturaEkle.TabIndex = 86;
            this.btnFaturaEkle.Text = "Ekle";
            this.btnFaturaEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFaturaEkle.UseVisualStyleBackColor = true;
            this.btnFaturaEkle.Click += new System.EventHandler(this.BtnFaturaEkle_Click);
            // 
            // dgvFatura
            // 
            this.dgvFatura.AllowUserToAddRows = false;
            this.dgvFatura.AllowUserToDeleteRows = false;
            this.dgvFatura.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatura.GridColor = System.Drawing.Color.Black;
            this.dgvFatura.Location = new System.Drawing.Point(12, 12);
            this.dgvFatura.MultiSelect = false;
            this.dgvFatura.Name = "dgvFatura";
            this.dgvFatura.ReadOnly = true;
            this.dgvFatura.Size = new System.Drawing.Size(760, 263);
            this.dgvFatura.TabIndex = 85;
            this.dgvFatura.SelectionChanged += new System.EventHandler(this.DgvFatura_SelectionChanged);
            // 
            // FaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFaturaDetay);
            this.Controls.Add(this.cboxFaturaKullanici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFaturaTutar);
            this.Controls.Add(this.btnFaturaGüncelle);
            this.Controls.Add(this.btnFaturaSil);
            this.Controls.Add(this.btnFaturaEkle);
            this.Controls.Add(this.dgvFatura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FaturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura İşlemleri";
            this.Load += new System.EventHandler(this.FaturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFaturaDetay;
        private System.Windows.Forms.ComboBox cboxFaturaKullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFaturaTutar;
        private System.Windows.Forms.Button btnFaturaGüncelle;
        private System.Windows.Forms.Button btnFaturaSil;
        private System.Windows.Forms.Button btnFaturaEkle;
        private System.Windows.Forms.DataGridView dgvFatura;
    }
}