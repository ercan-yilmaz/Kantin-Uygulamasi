using KariyerItData;
using KariyerItWinForm.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KariyerItWinForm
{
    public partial class FaturaForm : FormAyarlari
    {
        public DataGridViewRow SeciliSatir { get; set; }

        public int SeciliFaturaId => int.Parse(SeciliSatir.Cells[0].Value.ToString());

        public int SecilenKullaniciId { get; set; }



        public FaturaForm()
        {
            InitializeComponent();
        }



        private void FaturaForm_Load(object sender, EventArgs e)
        {
            FaturaDataGridViewDoldur();
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

            cboxFaturaKullanici.DataSource = list;
            cboxFaturaKullanici.DisplayMember = "Adi";
            cboxFaturaKullanici.ValueMember = "Id";
        }

        private void FaturaDataGridViewDoldur()
        {
            dgvFatura.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            List<GiderModel> giderler = Entities.Gider.Where(y => y.GiderTipiId == 2 && !y.SilindiMi)
                .Select(x => new GiderModel()  // gider verilerini yeni bir gidermodel nesnesine dönüştürdüm
                {
                    Id = x.Id,
                    Tutar = x.Tutar,
                    Detay = x.Detay,
                    KullaniciId = Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Id,
                    KullaniciAdSoyad = Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Adi + " " + Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Soyadi,
                    EklenmeTarihi = x.EklenmeTarihi
                }).ToList();

            dgvFatura.DataSource = giderler;
            dgvFatura.Columns["Id"].Visible = false;
            dgvFatura.Columns["KullaniciId"].Visible = false;
            dgvFatura.Columns["KullaniciAdSoyad"].HeaderText = "Kullanıcı Ad Soyad";
            dgvFatura.Columns["EklenmeTarihi"].HeaderText = "Eklenme Tarihi";

            dgvFatura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DgvFatura_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.SelectedRows.Count > 0)
            {
                SeciliSatir = dgv.SelectedRows[0] as DataGridViewRow;
                txtFaturaTutar.Text = SeciliSatir.Cells["Tutar"].Value.ToString();
                txtFaturaDetay.Text = SeciliSatir.Cells["Detay"].Value.ToString();
                cboxFaturaKullanici.SelectedValue = SeciliSatir.Cells["KullaniciId"].Value;
            }
        }

        private void BtnFaturaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFaturaTutar.Text))
            {
                MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Gider eklenecekGider = new Gider()
                {
                    KullaniciId = SecilenKullaniciId
                };
                if (double.TryParse(txtFaturaTutar.Text, out double parsedTutar))
                {
                    eklenecekGider.Tutar = parsedTutar;
                }
                else
                {
                    MessageBox.Show("Uygunsuz para formatı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                eklenecekGider.Detay = txtFaturaDetay.Text;
                eklenecekGider.GiderTipiId = 2;
                eklenecekGider.EklenmeTarihi = DateTime.Now;

                Entities.Gider.Add(eklenecekGider);

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FaturaDataGridViewDoldur();
                }

                TextBoxTemizle();
            }
        }

        private void TextBoxTemizle()
        {
            txtFaturaTutar.Clear();
            txtFaturaDetay.Clear();
        }

        private void BtnFaturaGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz kullanıcıyı seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtFaturaTutar.Text))
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("İlgili fatura giderini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Gider ekliGider = Entities.Gider.FirstOrDefault(x => x.Id == SeciliFaturaId);

                        if (double.TryParse(txtFaturaTutar.Text, out double parsedTutar))
                        {
                            ekliGider.Tutar = parsedTutar;
                        }
                        else
                        {
                            MessageBox.Show("Uygunsuz para formatı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        ekliGider.Detay = txtFaturaDetay.Text;

                        //Başarılı 1 başarısız -1
                        if (Entities.SaveChanges() > 0)
                        {
                            MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FaturaDataGridViewDoldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnFaturaSil_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz fatura bilgisini seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("İlgili personeli silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Gider eklenenGider = Entities.Gider.FirstOrDefault(x => x.Id == SeciliFaturaId && !x.SilindiMi);
                    eklenenGider.SilindiMi = true;

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FaturaDataGridViewDoldur();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CboxFaturaKullanici_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = sender as ComboBox;

            if (selected.SelectedIndex != 0 && selected.SelectedIndex != -1)
            {
                SecilenKullaniciId = Convert.ToInt32(selected.SelectedValue);
            }
        }
    }
}