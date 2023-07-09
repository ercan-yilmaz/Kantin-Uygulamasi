using KariyerItData;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class SifremiUnuttum : FormAyarlari
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void BtnSifreIste_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;

            if (string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Lütfen mailin dolu olduğuna emin olunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Yonetici yon = Entities.Yonetici.FirstOrDefault(y => y.Mail == mail && !y.SilindiMi);

                if (yon == null)
                {
                    MessageBox.Show("Böyle bir yönetici yoktur...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Random rnd = new Random();
                    int sifre = rnd.Next(100000, 1000000);

                    yon.Sifre = sifre.ToString();
                    Entities.SaveChanges();

                    MessageBox.Show(string.Format("Şifre değişikliği gerçekleştirilmiştir. Yeni şifreniz : {0} ", sifre), "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //MessageBox.Show($"Şifre değişikliği gerçekleştirilmiştir. Yeni şifreniz: {sifre}", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Close();
                }
            }


        }
    }
}
