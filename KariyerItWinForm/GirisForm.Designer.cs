namespace KariyerItWinForm
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSifunuttum = new System.Windows.Forms.LinkLabel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblHakkinda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(189, 24);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(46, 16);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail : ";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(244, 24);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(132, 23);
            this.txtMail.TabIndex = 1;
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMail_KeyDown);
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(192, 91);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(184, 42);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(244, 62);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(132, 23);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(189, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Şifre : ";
            // 
            // lblSifunuttum
            // 
            this.lblSifunuttum.AutoSize = true;
            this.lblSifunuttum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifunuttum.Location = new System.Drawing.Point(265, 146);
            this.lblSifunuttum.Name = "lblSifunuttum";
            this.lblSifunuttum.Size = new System.Drawing.Size(111, 16);
            this.lblSifunuttum.TabIndex = 4;
            this.lblSifunuttum.TabStop = true;
            this.lblSifunuttum.Text = "Şifremi Unuttum";
            this.lblSifunuttum.Click += new System.EventHandler(this.LblSifunuttum_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlLogo.Location = new System.Drawing.Point(20, 21);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(139, 127);
            this.pnlLogo.TabIndex = 5;
            // 
            // lblHakkinda
            // 
            this.lblHakkinda.AutoSize = true;
            this.lblHakkinda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHakkinda.Location = new System.Drawing.Point(376, 183);
            this.lblHakkinda.Name = "lblHakkinda";
            this.lblHakkinda.Size = new System.Drawing.Size(0, 16);
            this.lblHakkinda.TabIndex = 7;
            // 
            // GirisForm
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(402, 208);
            this.Controls.Add(this.lblHakkinda);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblSifunuttum);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.LinkLabel lblSifunuttum;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblHakkinda;
    }
}

