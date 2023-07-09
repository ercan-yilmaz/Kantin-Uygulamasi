using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using KariyerItData;
using KariyerItWinForm.Model;

namespace KariyerItWinForm
{
    public partial class PersonelForm : FormAyarlari
    {
        public DataGridViewRow SeciliSatir { get; set; }

        public int SeciliPersonelId => int.Parse(SeciliSatir.Cells[0].Value.ToString());

        public PersonelForm()
        {
            InitializeComponent();
            PersonelDataGridViewDoldur();
        }

        private void PersonelDataGridViewDoldur()
        {
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            List<KullaniciModel> personeller = Entities.Kullanici.Where(x => x.PersonelMi && !x.SilindiMi)
                .Select(x => new KullaniciModel
                {
                    Id = x.Id,
                    Adi = x.Adi,
                    Soyadi = x.Soyadi,
                    TelNo = x.TelNo.ToString(),
                    Mail = x.Mail
                })
                .ToList();

            dgvPersonel.DataSource = personeller;
            dgvPersonel.Columns["Id"].Visible = false;
            dgvPersonel.Columns["Adi"].HeaderText = "Adı";
            dgvPersonel.Columns["Soyadi"].HeaderText = "Soyadı";
            dgvPersonel.Columns["TelNo"].HeaderText = "Telefon";

            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TextBoxTemizle()
        {
            txtPersonelAdi.Clear();
            txtPersonelSoyadi.Clear();
            txtPersonelMail.Clear();
            txtPersonelTelefon.Clear();
        }

        private void DgvPersonel_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.SelectedRows.Count > 0)
            {
                SeciliSatir = dgv.SelectedRows[0] as DataGridViewRow;

                txtPersonelAdi.Text = SeciliSatir.Cells["Adi"].Value.ToString();
                txtPersonelSoyadi.Text = SeciliSatir.Cells["Soyadi"].Value.ToString();
                txtPersonelTelefon.Text = SeciliSatir.Cells["TelNo"].Value.ToString();
                txtPersonelMail.Text = SeciliSatir.Cells["Mail"].Value.ToString();
            }
        }

        private void BtnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonelAdi.Text)
             || string.IsNullOrWhiteSpace(txtPersonelSoyadi.Text)
             || string.IsNullOrWhiteSpace(txtPersonelTelefon.Text)
             || string.IsNullOrWhiteSpace(txtPersonelMail.Text))
            {
                MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Kullanici eklenecekPersonel = new Kullanici()
                {
                    Adi = txtPersonelAdi.Text,
                    Soyadi = txtPersonelSoyadi.Text
                };
                if (int.TryParse(txtPersonelTelefon.Text, out int parsedNo))
                {
                    eklenecekPersonel.TelNo = parsedNo;
                }
                else
                {
                    eklenecekPersonel.TelNo = 0;
                }

                eklenecekPersonel.Mail = txtPersonelMail.Text;
                eklenecekPersonel.SilindiMi = false;
                eklenecekPersonel.PersonelMi = true;
                eklenecekPersonel.EklenmeTarihi = DateTime.Now;

                Entities.Kullanici.Add(eklenecekPersonel);

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PersonelDataGridViewDoldur();
                }

                TextBoxTemizle();
            }
        }

        private void BtnPersonelGüncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz personeli seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtPersonelAdi.Text)
                    || string.IsNullOrWhiteSpace(txtPersonelSoyadi.Text)
                    || string.IsNullOrWhiteSpace(txtPersonelTelefon.Text)
                    || string.IsNullOrWhiteSpace(txtPersonelMail.Text))
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("İlgili personeli güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Kullanici ekliPersonel = Entities.Kullanici.FirstOrDefault(x => x.Id == SeciliPersonelId);
                        ekliPersonel.Adi = txtPersonelAdi.Text;
                        ekliPersonel.Soyadi = txtPersonelSoyadi.Text;

                        if (int.TryParse(txtPersonelTelefon.Text, out int parsedNo))
                        {
                            ekliPersonel.TelNo = parsedNo;
                        }
                        else
                        {
                            ekliPersonel.TelNo = 0;
                        }

                        ekliPersonel.Mail = txtPersonelMail.Text;

                        //Başarılı 1 başarısız -1
                        if (Entities.SaveChanges() > 0)
                        {
                            MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            PersonelDataGridViewDoldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnPersonelSil_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz personeli seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("İlgili personeli silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    Kullanici silinecekPersonel = Entities.Kullanici.FirstOrDefault(x => x.Id == SeciliPersonelId);
                    silinecekPersonel.SilindiMi = true;

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PersonelDataGridViewDoldur();
                    }

                    TextBoxTemizle();
                }
                else
                {
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {

        }
    }
}