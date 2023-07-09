using KariyerItData;
using KariyerItWinForm.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class OgrenciForm : FormAyarlari
    {
        public DataGridViewRow SeciliSatir { get ; set; }
      
        public int SeciliOgrenciId => int.Parse(SeciliSatir.Cells[0].Value.ToString());

        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            OgrenciDataGridViewDoldur();
        }

        private void OgrenciDataGridViewDoldur()
        {
            dgvOgrenci.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            List<KullaniciModel> ogrenciler = Entities.Kullanici.Where(y => !y.PersonelMi && !y.SilindiMi).Select(x => new KullaniciModel()
            {
                Id = x.Id,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                TelNo = x.TelNo.Value.ToString(),
                Mail = x.Mail
            }).ToList();

            dgvOgrenci.DataSource = ogrenciler;
            dgvOgrenci.Columns["Id"].Visible = false;
            dgvOgrenci.Columns["Adi"].HeaderText = "Adı";
            dgvOgrenci.Columns["Soyadi"].HeaderText = "Soyadı";
            dgvOgrenci.Columns["TelNo"].HeaderText = "Telefon";

            dgvOgrenci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TextBoxTemizle()
        {
            txtÖgrenciAdi.Clear();
            txtÖgrenciSoyadi.Clear();
            txtÖgrenciTel.Clear();
            txtÖgrenciMail.Clear();
        }

        private void DgvÖgrenci_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.SelectedRows.Count > 0)
            {
                SeciliSatir = dgv.SelectedRows[0] as DataGridViewRow;

                txtÖgrenciAdi.Text = SeciliSatir.Cells["Adi"].Value.ToString();
                txtÖgrenciSoyadi.Text = SeciliSatir.Cells["Soyadi"].Value.ToString();
                txtÖgrenciTel.Text = SeciliSatir.Cells["TelNo"].Value.ToString();
                txtÖgrenciMail.Text = SeciliSatir.Cells["Mail"].Value.ToString();
            }
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtÖgrenciAdi.Text)
             || string.IsNullOrWhiteSpace(txtÖgrenciSoyadi.Text)
             || string.IsNullOrWhiteSpace(txtÖgrenciTel.Text)
             || string.IsNullOrWhiteSpace(txtÖgrenciMail.Text))
            {
                MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Kullanici eklenecekPersonel = new Kullanici()
                {
                    Adi = txtÖgrenciAdi.Text,
                    Soyadi = txtÖgrenciSoyadi.Text
                };
                if (int.TryParse(txtÖgrenciTel.Text, out int parsedNo))
                {
                    eklenecekPersonel.TelNo = parsedNo;
                }
                else
                {
                    eklenecekPersonel.TelNo = 0;
                }

                eklenecekPersonel.Mail = txtÖgrenciMail.Text;
                eklenecekPersonel.SilindiMi = false;
                eklenecekPersonel.PersonelMi = false;
                eklenecekPersonel.EklenmeTarihi = DateTime.Now;

                Entities.Kullanici.Add(eklenecekPersonel);

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OgrenciDataGridViewDoldur();
                }

                TextBoxTemizle();
            }
        }

        private void BtnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz öğrenciyi seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtÖgrenciAdi.Text)
                    || string.IsNullOrWhiteSpace(txtÖgrenciSoyadi.Text)
                    || string.IsNullOrWhiteSpace(txtÖgrenciTel.Text)
                    || string.IsNullOrWhiteSpace(txtÖgrenciMail.Text))
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("İlgili öğrenciyi güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Kullanici ekliOgrenci = Entities.Kullanici.FirstOrDefault(x => x.Id == SeciliOgrenciId);
                        ekliOgrenci.Adi = txtÖgrenciAdi.Text;
                        ekliOgrenci.Soyadi = txtÖgrenciSoyadi.Text;

                        if (int.TryParse(txtÖgrenciTel.Text, out int parsedNo))
                        {
                            ekliOgrenci.TelNo = parsedNo;
                        }
                        else
                        {
                            ekliOgrenci.TelNo = 0;
                        }

                        ekliOgrenci.Mail = txtÖgrenciMail.Text;

                        //Başarılı 1 başarısız -1
                        if (Entities.SaveChanges() > 0)
                        {
                            dgvOgrenci.Rows[SeciliSatir.Index].Selected = true;
                            MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            OgrenciDataGridViewDoldur();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz öğrenciyi seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("İlgili öğrenciyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    Kullanici silinecekOgrenci = Entities.Kullanici.FirstOrDefault(x => x.Id == SeciliOgrenciId);
                    silinecekOgrenci.SilindiMi = true;

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OgrenciDataGridViewDoldur();
                    }

                    TextBoxTemizle();
                }
                else
                {
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
