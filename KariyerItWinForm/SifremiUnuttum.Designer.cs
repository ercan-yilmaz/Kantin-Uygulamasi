namespace KariyerItWinForm
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.btnSifreIste = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSifreIste
            // 
            this.btnSifreIste.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreIste.Location = new System.Drawing.Point(39, 86);
            this.btnSifreIste.Name = "btnSifreIste";
            this.btnSifreIste.Size = new System.Drawing.Size(184, 42);
            this.btnSifreIste.TabIndex = 5;
            this.btnSifreIste.Text = "Şifre İste";
            this.btnSifreIste.UseVisualStyleBackColor = true;
            this.btnSifreIste.Click += new System.EventHandler(this.BtnSifreIste_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(91, 34);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(132, 23);
            this.txtMail.TabIndex = 4;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(36, 34);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(46, 16);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail : ";
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(258, 153);
            this.Controls.Add(this.btnSifreIste);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSifreIste;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
    }
}