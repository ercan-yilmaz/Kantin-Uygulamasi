using System;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class GirisForm : FormAyarlari
    {   
        public GirisForm()
        {
            InitializeComponent();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            lblHakkinda.Text = DateTime.Now.Year.ToString();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string mail = txtMail.Text;
            string password = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Yonetici = Entities.Yonetici.FirstOrDefault(yonetici => yonetici.Mail == mail && yonetici.Sifre == password && !yonetici.SilindiMi);

                if (Yonetici == null)
                {
                    MessageBox.Show("Bilgilere ait yönetici bulunamadı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Hide();
                
                AnaSayfaForm anaSayfa = new AnaSayfaForm();
                anaSayfa.Show(this);

            }
        }

        private void LblSifunuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum form = new SifremiUnuttum();
            form.Show();
        }

        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    btnGiris.PerformClick();
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    btnGiris.PerformClick();
        }
    }
}
