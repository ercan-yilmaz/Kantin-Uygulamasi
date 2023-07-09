using KariyerItData;
using KariyerItWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class MaasForm : FormAyarlari
    {
        public DataGridViewRow SeciliSatir { get; set; }

        public int SeciliMaasId => int.Parse(SeciliSatir.Cells[0].Value.ToString());

        public int SecilenKullaniciId { get; set; }


        public MaasForm()
        {
            InitializeComponent();
        }

        private void MaasForm_Load(object sender, EventArgs e)
        {
            MaasDataGridViewDoldur();
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

            list.AddRange(Entities.Kullanici.Where(y => y.PersonelMi && !y.SilindiMi));

            cboxMaasKullanici.DataSource = list;
            cboxMaasKullanici.DisplayMember = "Adi";
            cboxMaasKullanici.ValueMember = "Id";
        }

        private void MaasDataGridViewDoldur()
        {
            dgvMaas.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            List<GiderModel> giderler = Entities.Gider.Where(y => y.GiderTipiId == 1 && !y.SilindiMi)
                .Select(x => new GiderModel()
                {
                    Id = x.Id,
                    Tutar = x.Tutar,
                    Detay = x.Detay,
                    KullaniciId = Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Id,
                    KullaniciAdSoyad = Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Adi + " " + Entities.Kullanici.FirstOrDefault(y => y.Id == x.KullaniciId).Soyadi,
                    EklenmeTarihi = x.EklenmeTarihi
                })
                .OrderBy(x=> x.Id)
                .ToList();

            dgvMaas.DataSource = giderler;
            dgvMaas.Columns["Id"].Visible = false;
            dgvMaas.Columns["KullaniciId"].Visible = false;
            dgvMaas.Columns["KullaniciAdSoyad"].HeaderText = "Kullanıcı Ad Soyad";
            dgvMaas.Columns["EklenmeTarihi"].HeaderText = "Eklenme Tarihi";

            dgvMaas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DgvMaas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.SelectedRows.Count > 0)
            {
                SeciliSatir = dgv.SelectedRows[0] as DataGridViewRow;
                txtMaasTutar.Text = SeciliSatir.Cells["Tutar"].Value.ToString();
                txtMaasDetay.Text = SeciliSatir.Cells["Detay"].Value.ToString();
                cboxMaasKullanici.SelectedValue = SeciliSatir.Cells["KullaniciId"].Value;
            }
        }

        private void BtnMaasEkle_Click(object sender, EventArgs e)
        {
            if (SecilenKullaniciId == 0)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz kullanıcıyı seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMaasTutar.Text))
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Gider eklenecekGider = new Gider()
                    {
                        KullaniciId = SecilenKullaniciId
                    };
                    if (double.TryParse(txtMaasTutar.Text, out double parsedTutar))
                    {
                        eklenecekGider.Tutar = parsedTutar;
                    }
                    else
                    {
                        MessageBox.Show("Uygunsuz para formatı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    eklenecekGider.Detay = txtMaasDetay.Text;
                    eklenecekGider.GiderTipiId = 1;
                    eklenecekGider.EklenmeTarihi = DateTime.Now;

                    Entities.Gider.Add(eklenecekGider);

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MaasDataGridViewDoldur();
                    }

                    TextBoxTemizle();
                }
            }
        }

        private void TextBoxTemizle()
        {
            txtMaasTutar.Clear();
            txtMaasDetay.Clear();
        }

        private void BtnMaasGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz kullanıcıyı seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMaasTutar.Text))
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("İlgili maas giderini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Gider ekliGider = Entities.Gider.FirstOrDefault(x => x.Id == SeciliMaasId);

                        if (double.TryParse(txtMaasTutar.Text, out double parsedTutar))
                        {
                            ekliGider.Tutar = parsedTutar;
                        }

                        ekliGider.Detay = txtMaasDetay.Text;

                        //Başarılı 1 başarısız -1
                        if (Entities.SaveChanges() > 0)
                        {
                            MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MaasDataGridViewDoldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnMaasSil_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz maas bilgisini seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("İlgili maaş giderini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Gider eklenenGider = Entities.Gider.FirstOrDefault(x => x.Id == SeciliMaasId && !x.SilindiMi);
                    eklenenGider.SilindiMi = true;

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MaasDataGridViewDoldur();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
        }

        private void CboxMaasKullanici_SelectedValueChanged(object sender, EventArgs e)
        {
            //sender olayın tetıklendıgı nesneyi temsil eder.
            var selected = sender as ComboBox; //eğer combobox ise dönüştürme başarılı olur
             
            if (selected.SelectedIndex != 0 && selected.SelectedIndex != -1)
            {
                SecilenKullaniciId = Convert.ToInt32(selected.SelectedValue);
            }
        }
    }
}