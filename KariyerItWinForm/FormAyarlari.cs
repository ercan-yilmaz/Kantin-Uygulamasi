using KariyerItData;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public class FormAyarlari : Form
    {
        public static KariyerITEntities Entities { get; set; }
   
        public static Yonetici Yonetici { get; set; }

        static FormAyarlari() //incelee
        {
            Entities = new KariyerITEntities();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormAyarlari
            // 
            this.ClientSize = new System.Drawing.Size(276, 236);
            this.Enabled = false;
            this.Name = "FormAyarlari";
            this.Load += new System.EventHandler(this.FormAyarlari_Load);
            this.ResumeLayout(false);

        }

        private void FormAyarlari_Load(object sender, System.EventArgs e)
        {
            // Form yüklendiğinde yapılması gereken işlemler..
            // Örneğin, başlangıç ayarları, veritabanı bağlantısı, kontrol değerleri ayarı vb.
        }
    }
}
