namespace KariyerItWinForm
{
    partial class AnaSayfaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfaForm));
            this.tblLayPnlGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaasForm = new System.Windows.Forms.Button();
            this.btnFaturaForm = new System.Windows.Forms.Button();
            this.btnKantinForm = new System.Windows.Forms.Button();
            this.btnVr = new System.Windows.Forms.Button();
            this.btnUrunForm = new System.Windows.Forms.Button();
            this.btnOgrenciler = new System.Windows.Forms.Button();
            this.btnStokForm = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.tblLayPnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayPnlGrid
            // 
            this.tblLayPnlGrid.ColumnCount = 4;
            this.tblLayPnlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPnlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPnlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPnlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPnlGrid.Controls.Add(this.btnVr, 0, 3);
            this.tblLayPnlGrid.Controls.Add(this.btnKantinForm, 0, 3);
            this.tblLayPnlGrid.Controls.Add(this.btnPersoneller, 0, 0);
            this.tblLayPnlGrid.Controls.Add(this.btnFaturaForm, 3, 3);
            this.tblLayPnlGrid.Controls.Add(this.btnStokForm, 3, 0);
            this.tblLayPnlGrid.Controls.Add(this.btnOgrenciler, 1, 0);
            this.tblLayPnlGrid.Controls.Add(this.btnUrunForm, 2, 0);
            this.tblLayPnlGrid.Controls.Add(this.btnMaasForm, 2, 3);
            this.tblLayPnlGrid.Location = new System.Drawing.Point(14, 12);
            this.tblLayPnlGrid.Name = "tblLayPnlGrid";
            this.tblLayPnlGrid.RowCount = 4;
            this.tblLayPnlGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayPnlGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayPnlGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayPnlGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayPnlGrid.Size = new System.Drawing.Size(969, 409);
            this.tblLayPnlGrid.TabIndex = 2;
            this.tblLayPnlGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.TblLayPnlGrid_Paint);
            // 
            // btnMaasForm
            // 
            this.btnMaasForm.BackColor = System.Drawing.Color.Silver;
            this.btnMaasForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaasForm.BackgroundImage")));
            this.btnMaasForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaasForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaasForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaasForm.Location = new System.Drawing.Point(487, 207);
            this.btnMaasForm.Name = "btnMaasForm";
            this.btnMaasForm.Size = new System.Drawing.Size(236, 200);
            this.btnMaasForm.TabIndex = 23;
            this.btnMaasForm.Text = "Maaş İşlemleri";
            this.btnMaasForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaasForm.UseVisualStyleBackColor = false;
            this.btnMaasForm.Click += new System.EventHandler(this.BtnMaasForm_Click);
            // 
            // btnFaturaForm
            // 
            this.btnFaturaForm.BackColor = System.Drawing.Color.Silver;
            this.btnFaturaForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFaturaForm.BackgroundImage")));
            this.btnFaturaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFaturaForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFaturaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturaForm.Location = new System.Drawing.Point(729, 207);
            this.btnFaturaForm.Name = "btnFaturaForm";
            this.btnFaturaForm.Size = new System.Drawing.Size(237, 200);
            this.btnFaturaForm.TabIndex = 25;
            this.btnFaturaForm.Text = "Fatura İşlemleri";
            this.btnFaturaForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFaturaForm.UseVisualStyleBackColor = false;
            this.btnFaturaForm.Click += new System.EventHandler(this.BtnFaturaForm_Click);
            // 
            // btnKantinForm
            // 
            this.btnKantinForm.BackColor = System.Drawing.Color.White;
            this.btnKantinForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKantinForm.BackgroundImage")));
            this.btnKantinForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKantinForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKantinForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKantinForm.Location = new System.Drawing.Point(245, 207);
            this.btnKantinForm.Name = "btnKantinForm";
            this.btnKantinForm.Size = new System.Drawing.Size(236, 200);
            this.btnKantinForm.TabIndex = 20;
            this.btnKantinForm.Text = "Kantin İşlemleri";
            this.btnKantinForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKantinForm.UseVisualStyleBackColor = false;
            this.btnKantinForm.Click += new System.EventHandler(this.BtnKantinForm_Click);
            // 
            // btnVr
            // 
            this.btnVr.BackColor = System.Drawing.Color.White;
            this.btnVr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVr.BackgroundImage")));
            this.btnVr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVr.Location = new System.Drawing.Point(3, 207);
            this.btnVr.Name = "btnVr";
            this.btnVr.Size = new System.Drawing.Size(236, 200);
            this.btnVr.TabIndex = 18;
            this.btnVr.Text = "Vr Oyunları İşlemleri";
            this.btnVr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVr.UseVisualStyleBackColor = false;
            this.btnVr.Click += new System.EventHandler(this.BtnVr_Click);
            // 
            // btnUrunForm
            // 
            this.btnUrunForm.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUrunForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunForm.BackgroundImage")));
            this.btnUrunForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUrunForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUrunForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunForm.Location = new System.Drawing.Point(487, 3);
            this.btnUrunForm.Name = "btnUrunForm";
            this.btnUrunForm.Size = new System.Drawing.Size(236, 200);
            this.btnUrunForm.TabIndex = 26;
            this.btnUrunForm.Text = "Ürün İşlemleri";
            this.btnUrunForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunForm.UseVisualStyleBackColor = false;
            this.btnUrunForm.Click += new System.EventHandler(this.BtnUrunForm_Click);
            // 
            // btnOgrenciler
            // 
            this.btnOgrenciler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOgrenciler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenciler.BackgroundImage")));
            this.btnOgrenciler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOgrenciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciler.Location = new System.Drawing.Point(245, 3);
            this.btnOgrenciler.Name = "btnOgrenciler";
            this.btnOgrenciler.Size = new System.Drawing.Size(236, 200);
            this.btnOgrenciler.TabIndex = 21;
            this.btnOgrenciler.Text = "Öğrenci İşlemleri";
            this.btnOgrenciler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenciler.UseVisualStyleBackColor = false;
            this.btnOgrenciler.Click += new System.EventHandler(this.BtnOgrenciler_Click);
            // 
            // btnStokForm
            // 
            this.btnStokForm.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnStokForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStokForm.BackgroundImage")));
            this.btnStokForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStokForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStokForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokForm.Location = new System.Drawing.Point(729, 3);
            this.btnStokForm.Name = "btnStokForm";
            this.btnStokForm.Size = new System.Drawing.Size(237, 200);
            this.btnStokForm.TabIndex = 19;
            this.btnStokForm.Text = "Stok İşlemleri";
            this.btnStokForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStokForm.UseVisualStyleBackColor = false;
            this.btnStokForm.Click += new System.EventHandler(this.BtnStokForm_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersoneller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.BackgroundImage")));
            this.btnPersoneller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPersoneller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersoneller.Location = new System.Drawing.Point(3, 3);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(236, 200);
            this.btnPersoneller.TabIndex = 22;
            this.btnPersoneller.Text = "Personel İşlemleri";
            this.btnPersoneller.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.BtnPersoneller_Click);
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(997, 432);
            this.Controls.Add(this.tblLayPnlGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaSayfaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfaForm_FormClosing);
            this.tblLayPnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayPnlGrid;
        private System.Windows.Forms.Button btnVr;
        private System.Windows.Forms.Button btnKantinForm;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnFaturaForm;
        private System.Windows.Forms.Button btnStokForm;
        private System.Windows.Forms.Button btnOgrenciler;
        private System.Windows.Forms.Button btnUrunForm;
        private System.Windows.Forms.Button btnMaasForm;
    }
}