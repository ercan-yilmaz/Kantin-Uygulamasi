namespace KariyerItWinForm
{
    partial class UrunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunForm));
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dgvUrun = new System.Windows.Forms.DataGridView();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxUrunTip = new System.Windows.Forms.ComboBox();
            this.lblUrunTipEkle = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunGuncelle.BackgroundImage")));
            this.btnUrunGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(588, 324);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(78, 84);
            this.btnUrunGuncelle.TabIndex = 73;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.BackgroundImage")));
            this.btnUrunSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunSil.Location = new System.Drawing.Point(694, 324);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(78, 84);
            this.btnUrunSil.TabIndex = 72;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.BtnUrunSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.BackgroundImage")));
            this.btnUrunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunEkle.Location = new System.Drawing.Point(482, 324);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(78, 84);
            this.btnUrunEkle.TabIndex = 70;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // dgvUrun
            // 
            this.dgvUrun.AllowUserToAddRows = false;
            this.dgvUrun.AllowUserToDeleteRows = false;
            this.dgvUrun.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrun.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvUrun.GridColor = System.Drawing.Color.Coral;
            this.dgvUrun.Location = new System.Drawing.Point(12, 12);
            this.dgvUrun.Name = "dgvUrun";
            this.dgvUrun.ReadOnly = true;
            this.dgvUrun.Size = new System.Drawing.Size(760, 263);
            this.dgvUrun.TabIndex = 69;
            this.dgvUrun.SelectionChanged += new System.EventHandler(this.DgvUrun_SelectionChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(155, 339);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(121, 20);
            this.txtUrunAdi.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Ürün Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Ürün Tip : ";
            // 
            // cBoxUrunTip
            // 
            this.cBoxUrunTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUrunTip.Location = new System.Drawing.Point(155, 377);
            this.cBoxUrunTip.Name = "cBoxUrunTip";
            this.cBoxUrunTip.Size = new System.Drawing.Size(121, 21);
            this.cBoxUrunTip.TabIndex = 80;
            this.cBoxUrunTip.SelectedValueChanged += new System.EventHandler(this.CBoxUrunTip_SelectedValueChanged);
            // 
            // lblUrunTipEkle
            // 
            this.lblUrunTipEkle.AutoSize = true;
            this.lblUrunTipEkle.LinkColor = System.Drawing.Color.Black;
            this.lblUrunTipEkle.Location = new System.Drawing.Point(283, 384);
            this.lblUrunTipEkle.Name = "lblUrunTipEkle";
            this.lblUrunTipEkle.Size = new System.Drawing.Size(46, 13);
            this.lblUrunTipEkle.TabIndex = 81;
            this.lblUrunTipEkle.TabStop = true;
            this.lblUrunTipEkle.Text = "Tip Ekle";
            this.lblUrunTipEkle.VisitedLinkColor = System.Drawing.Color.White;
            this.lblUrunTipEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUrunTipEkle_LinkClicked);
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblUrunTipEkle);
            this.Controls.Add(this.cBoxUrunTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.dgvUrun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UrunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.UrunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.DataGridView dgvUrun;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxUrunTip;
        private System.Windows.Forms.LinkLabel lblUrunTipEkle;
    }
}