namespace KariyerItWinForm
{
    partial class UrunTip
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
            this.btnUrunTipEkle = new System.Windows.Forms.Button();
            this.txtUrunTip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUrunTipEkle
            // 
            this.btnUrunTipEkle.Location = new System.Drawing.Point(21, 96);
            this.btnUrunTipEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrunTipEkle.Name = "btnUrunTipEkle";
            this.btnUrunTipEkle.Size = new System.Drawing.Size(292, 55);
            this.btnUrunTipEkle.TabIndex = 0;
            this.btnUrunTipEkle.Text = "Ürün Tipi Ekle";
            this.btnUrunTipEkle.UseVisualStyleBackColor = true;
            this.btnUrunTipEkle.Click += new System.EventHandler(this.btnUrunTipEkle_Click);
            // 
            // txtUrunTip
            // 
            this.txtUrunTip.Location = new System.Drawing.Point(180, 31);
            this.txtUrunTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunTip.Name = "txtUrunTip";
            this.txtUrunTip.Size = new System.Drawing.Size(132, 22);
            this.txtUrunTip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Tip Adı";
            // 
            // UrunTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(344, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunTip);
            this.Controls.Add(this.btnUrunTipEkle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UrunTip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Tipi Ekle";
            this.Load += new System.EventHandler(this.UrunTip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunTipEkle;
        private System.Windows.Forms.TextBox txtUrunTip;
        private System.Windows.Forms.Label label1;
    }
}