using KariyerItData;
using KariyerItWinForm.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class KantinForm : FormAyarlari
    {
        public DataGridViewRow SeciliSatir { get; set; }

        public int SeciliKantinId => int.Parse(SeciliSatir.Cells[0].Value.ToString());

        public int SecilenKullaniciId { get; set; }




        public KantinForm()
        {
            InitializeComponent();
        }

        private void KantinForm_Load(object sender, EventArgs e)
        {
            KantinDataGridViewDoldur();
            KullaniciComboboxDoldur();
        }

        private void KullaniciComboboxDoldur()
        {
            var list = new List<KullaniciModel>
            {
                new KullaniciModel
                {
                    Id = 0,
                    Adi = "Kullanıcı seçiniz..."
                }
            };

            list.AddRange(Entities.Kullanici.Where(y => !y.SilindiMi)
                .Select(x => new KullaniciModel
                {
                    Id = x.Id,
                    Adi = x.Adi + " " + x.Soyadi
                }));

            cboxKantinKullanici.DataSource = list;
            cboxKantinKullanici.DisplayMember = "Adi";
            cboxKantinKullanici.ValueMember = "Id";
        }

        private void KantinDataGridViewDoldur()
        {
            dgvKantin.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            List<GelirModel> gelirler = Entities.Gelir.Where(y => y.GelirTipiId == 2 && !y.SilindiMi)
                .Select(x => new GelirModel()
                {
                    Id = x.Id,
                    Tutar = x.Tutar,
                    Detay = x.Detay,
                    KullaniciId = Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Id,
                    KullaniciAdSoyad = Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Adi + " " + Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Soyadi,
                    EklenmeTarihi = x.EklenmeTarihi
                })
                .OrderBy(x => x.Id)
                .ToList();

            dgvKantin.DataSource = gelirler;
            dgvKantin.Columns["Id"].Visible = false;
            dgvKantin.Columns["KullaniciId"].Visible = false;
            dgvKantin.Columns["KullaniciAdSoyad"].HeaderText = "Kullanıcı Ad Soyad";
            dgvKantin.Columns["EklenmeTarihi"].HeaderText = "Eklenme Tarihi";

            dgvKantin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DgvKantin_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.SelectedRows.Count > 0)
            {
                SeciliSatir = dgv.SelectedRows[0] as DataGridViewRow;
                txtKantinTutar.Text = SeciliSatir.Cells["Tutar"].Value.ToString();
                txtKantinDetay.Text = SeciliSatir.Cells["Detay"].Value.ToString();
                cboxKantinKullanici.SelectedValue = SeciliSatir.Cells["KullaniciId"].Value;
            }
        }

        private void BtnKantinEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKantinTutar.Text))
            {
                MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Gelir eklenecekGelir = new Gelir()
                {
                    KullaniciId = SecilenKullaniciId
                };
                if (double.TryParse(txtKantinTutar.Text, out double parsedTutar))
                {
                    eklenecekGelir.Tutar = parsedTutar;
                }
                else
                {
                    MessageBox.Show("Uygunsuz para formatı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                eklenecekGelir.Detay = txtKantinDetay.Text;
                eklenecekGelir.GelirTipiId = 2;
                eklenecekGelir.EklenmeTarihi = DateTime.Now;

                Entities.Gelir.Add(eklenecekGelir);

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    KantinDataGridViewDoldur();
                }

                TextBoxTemizle();
            }
        }

        private void TextBoxTemizle()
        {
            txtKantinTutar.Clear();
            txtKantinDetay.Clear();
        }

        private void BtnKantinGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz kullanıcıyı seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtKantinTutar.Text))
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("İlgili kantin gelirini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Gelir ekliGelir = Entities.Gelir.FirstOrDefault(x => x.Id == SeciliKantinId);

                        if (double.TryParse(txtKantinTutar.Text, out double parsedTutar))
                        {
                            ekliGelir.Tutar = parsedTutar;
                        }

                        ekliGelir.Detay = txtKantinDetay.Text;

                        //Başarılı 1 başarısız -1
                        if (Entities.SaveChanges() > 0)
                        {
                            MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            KantinDataGridViewDoldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnKantinSil_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz kantin bilgisini seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("İlgili kantin gelirini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Gelir eklenenGelir = Entities.Gelir.FirstOrDefault(x => x.Id == SeciliKantinId && !x.SilindiMi);
                    eklenenGelir.SilindiMi = true;

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        KantinDataGridViewDoldur();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CboxKantinKullanici_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = sender as ComboBox;

            if (selected.SelectedIndex != 0 && selected.SelectedIndex != -1)
            {
                SecilenKullaniciId = Convert.ToInt32(selected.SelectedValue);
            }
        }
    }
}