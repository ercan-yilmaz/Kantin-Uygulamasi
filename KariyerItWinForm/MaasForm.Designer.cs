namespace KariyerItWinForm
{
    partial class MaasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaasForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaasDetay = new System.Windows.Forms.TextBox();
            this.cboxMaasKullanici = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaasTutar = new System.Windows.Forms.TextBox();
            this.btnMaasGüncelle = new System.Windows.Forms.Button();
            this.btnMaasSil = new System.Windows.Forms.Button();
            this.btnMaasEkle = new System.Windows.Forms.Button();
            this.dgvMaas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(220, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Detay : ";
            // 
            // txtMaasDetay
            // 
            this.txtMaasDetay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaasDetay.Location = new System.Drawing.Point(278, 324);
            this.txtMaasDetay.Multiline = true;
            this.txtMaasDetay.Name = "txtMaasDetay";
            this.txtMaasDetay.Size = new System.Drawing.Size(171, 84);
            this.txtMaasDetay.TabIndex = 93;
            // 
            // cboxMaasKullanici
            // 
            this.cboxMaasKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMaasKullanici.FormattingEnabled = true;
            this.cboxMaasKullanici.Location = new System.Drawing.Point(84, 325);
            this.cboxMaasKullanici.Name = "cboxMaasKullanici";
            this.cboxMaasKullanici.Size = new System.Drawing.Size(121, 21);
            this.cboxMaasKullanici.TabIndex = 92;
            this.cboxMaasKullanici.SelectedValueChanged += new System.EventHandler(this.CboxMaasKullanici_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 360);
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
            this.label8.Location = new System.Drawing.Point(11, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Kullanıcı :";
            // 
            // txtMaasTutar
            // 
            this.txtMaasTutar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaasTutar.Location = new System.Drawing.Point(84, 357);
            this.txtMaasTutar.Name = "txtMaasTutar";
            this.txtMaasTutar.Size = new System.Drawing.Size(121, 20);
            this.txtMaasTutar.TabIndex = 89;
            // 
            // btnMaasGüncelle
            // 
            this.btnMaasGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaasGüncelle.BackgroundImage")));
            this.btnMaasGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaasGüncelle.Location = new System.Drawing.Point(588, 324);
            this.btnMaasGüncelle.Name = "btnMaasGüncelle";
            this.btnMaasGüncelle.Size = new System.Drawing.Size(78, 84);
            this.btnMaasGüncelle.TabIndex = 88;
            this.btnMaasGüncelle.Text = "Güncelle";
            this.btnMaasGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaasGüncelle.UseVisualStyleBackColor = true;
            this.btnMaasGüncelle.Click += new System.EventHandler(this.BtnMaasGuncelle_Click);
            // 
            // btnMaasSil
            // 
            this.btnMaasSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaasSil.BackgroundImage")));
            this.btnMaasSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaasSil.Location = new System.Drawing.Point(694, 324);
            this.btnMaasSil.Name = "btnMaasSil";
            this.btnMaasSil.Size = new System.Drawing.Size(78, 84);
            this.btnMaasSil.TabIndex = 87;
            this.btnMaasSil.Text = "Sil";
            this.btnMaasSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaasSil.UseVisualStyleBackColor = true;
            this.btnMaasSil.Click += new System.EventHandler(this.BtnMaasSil_Click);
            // 
            // btnMaasEkle
            // 
            this.btnMaasEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaasEkle.BackgroundImage")));
            this.btnMaasEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaasEkle.Location = new System.Drawing.Point(482, 324);
            this.btnMaasEkle.Name = "btnMaasEkle";
            this.btnMaasEkle.Size = new System.Drawing.Size(78, 84);
            this.btnMaasEkle.TabIndex = 86;
            this.btnMaasEkle.Text = "Ekle";
            this.btnMaasEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaasEkle.UseVisualStyleBackColor = true;
            this.btnMaasEkle.Click += new System.EventHandler(this.BtnMaasEkle_Click);
            // 
            // dgvMaas
            // 
            this.dgvMaas.AllowUserToAddRows = false;
            this.dgvMaas.AllowUserToDeleteRows = false;
            this.dgvMaas.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaas.GridColor = System.Drawing.Color.Black;
            this.dgvMaas.Location = new System.Drawing.Point(12, 12);
            this.dgvMaas.MultiSelect = false;
            this.dgvMaas.Name = "dgvMaas";
            this.dgvMaas.ReadOnly = true;
            this.dgvMaas.Size = new System.Drawing.Size(760, 263);
            this.dgvMaas.TabIndex = 85;
            this.dgvMaas.SelectionChanged += new System.EventHandler(this.DgvMaas_SelectionChanged);
            // 
            // MaasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaasDetay);
            this.Controls.Add(this.cboxMaasKullanici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaasTutar);
            this.Controls.Add(this.btnMaasGüncelle);
            this.Controls.Add(this.btnMaasSil);
            this.Controls.Add(this.btnMaasEkle);
            this.Controls.Add(this.dgvMaas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MaasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maaş İşlemleri";
            this.Load += new System.EventHandler(this.MaasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaasDetay;
        private System.Windows.Forms.ComboBox cboxMaasKullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaasTutar;
        private System.Windows.Forms.Button btnMaasGüncelle;
        private System.Windows.Forms.Button btnMaasSil;
        private System.Windows.Forms.Button btnMaasEkle;
        private System.Windows.Forms.DataGridView dgvMaas;
    }
}