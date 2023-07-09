using KariyerItData;
using KariyerItWinForm.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class VrForm : FormAyarlari
    {
        public static DataGridViewRow SeciliSatir { get; set; }

        public int SeciliVrId => int.Parse(SeciliSatir.Cells[0].Value.ToString());

        public int SecilenKullaniciId { get; set; }


        public VrForm()
        {
            InitializeComponent();
        }

        private void VrForm_Load(object sender, EventArgs e)
        {
            VrDataGridViewDoldur();
            KullaniciComboboxDoldur();
        }

        private void KullaniciComboboxDoldur()
        {
            var list = new List<Kullanici>
            {
                new Kullanici
                {
                    Id = 0,
                    Adi = "Kullanıcı seçiniz..."
                }
            };

            list.AddRange(Entities.Kullanici.Where(y => !y.SilindiMi));

            cboxVrKullanici.DataSource = list;

            cboxVrKullanici.DisplayMember = "Adi";
            cboxVrKullanici.ValueMember = "Id";
        }

        private void VrDataGridViewDoldur()
        {
            dgvVr.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            List<GelirModel> gelirler = Entities.Gelir.Where(y => !y.SilindiMi)
                .Select(x => new GelirModel()
                {
                    Id = x.Id,
                    KullaniciId = Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Id,
                    KullaniciAdSoyad = Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Adi + " " + Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Soyadi,
                    Detay = x.Detay,
                    Tutar = x.Tutar,
                    EklenmeTarihi = x.EklenmeTarihi
                }).ToList();

            dgvVr.DataSource = gelirler;
            dgvVr.Columns["Id"].Visible = false;
            dgvVr.Columns["KullaniciId"].Visible = false;
            dgvVr.Columns["KullaniciAdSoyad"].HeaderText = "Kullanıcı Ad Soyad";
            dgvVr.Columns["EklenmeTarihi"].HeaderText = "Ekleme Tarihi";

            dgvVr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DgvVr_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.SelectedRows.Count > 0)
            {
                SeciliSatir = dgv.SelectedRows[0] as DataGridViewRow;
                txtVrTutar.Text = SeciliSatir.Cells["Tutar"].Value.ToString();
                txtVrDetay.Text = SeciliSatir.Cells["Detay"].Value.ToString();
                cboxVrKullanici.SelectedValue = SeciliSatir.Cells["KullaniciId"].Value;
            }
        }

        private void BtnVrEkle_Click(object sender, EventArgs e)
        {
            if (SecilenKullaniciId == 0)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz kullanıcıyı seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtVrTutar.Text))
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Gelir eklenecekGelir = new Gelir()
                    {
                        KullaniciId = SecilenKullaniciId
                    };
                    if (double.TryParse(txtVrTutar.Text, out double parsedTutar))
                    {
                        eklenecekGelir.Tutar = parsedTutar;
                    }
                    else
                    {
                        MessageBox.Show("Uygunsuz para formatı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    eklenecekGelir.Detay = txtVrDetay.Text;
                    eklenecekGelir.GelirTipiId = 1;
                    eklenecekGelir.EklenmeTarihi = DateTime.Now;

                    Entities.Gelir.Add(eklenecekGelir);

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        VrDataGridViewDoldur();
                    }

                    TextBoxTemizle();
                }
            }
        }

        private void TextBoxTemizle()
        {
            txtVrTutar.Clear();
            txtVrDetay.Clear();
        }

        private void BtnVrGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz kullanıcıyı seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtVrTutar.Text))
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("İlgili Vr gelirini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Gelir ekliGelir = Entities.Gelir.FirstOrDefault(x => x.Id == SeciliVrId);

                        if (double.TryParse(txtVrTutar.Text, out double parsedTutar))
                        {
                            ekliGelir.Tutar = parsedTutar;
                        }

                        ekliGelir.Detay = txtVrDetay.Text;

                        //Başarılı 1 başarısız -1
                        if (Entities.SaveChanges() > 0)
                        {
                            MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            VrDataGridViewDoldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnVrSil_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz vr bilgisini seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("İlgili vr gelirini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Gelir eklenenGelir = Entities.Gelir.FirstOrDefault(x => x.Id == SeciliVrId && !x.SilindiMi);
                    eklenenGelir.SilindiMi = true;

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        VrDataGridViewDoldur();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CboxVrKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = sender as ComboBox;

            if (selected.SelectedIndex != 0 && selected.SelectedIndex != -1)
            {
                SecilenKullaniciId = Convert.ToInt32(selected.SelectedValue);
            }
        }
    }
}
