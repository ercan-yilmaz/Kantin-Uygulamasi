using KariyerItData;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class UrunTip : FormAyarlari
    {
        public UrunTip()
        {
            InitializeComponent();
        }

        private void btnUrunTipEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunTip.Text))
            {
                MessageBox.Show("Lütfen ürün tipi adı alanının dolu olduğuna emin olunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UrunTipi tip = new UrunTipi
                {
                     Ad = txtUrunTip.Text,
                     SilindiMi = false,
                     EklenmeTarihi = DateTime.Now
                };

                Entities.UrunTipi.Add(tip);

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
        }

        private void UrunTip_Load(object sender, EventArgs e)
        {

        }
    }
}
