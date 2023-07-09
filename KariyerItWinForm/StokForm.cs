using KariyerItData;
using KariyerItWinForm.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class StokForm : FormAyarlari
    {
        public DataGridViewRow SeciliSatir { get; set; }

        public int SeciliStokId => int.Parse(SeciliSatir.Cells[0].Value.ToString());

        public int SeciliUrunId { get; set; }


        public StokForm()
        {
            InitializeComponent();
        }




        private void Stok_Load(object sender, EventArgs e)
        {
            StokDataGridViewDoldur();
            UrunComboboxDoldur();
        }

        private void UrunComboboxDoldur()
        {
            var list = new List<UrunModel>
            {
                new UrunModel
                {
                    Id = 0,
                    Ad = "Urun seçiniz"
                }
            };

            list.AddRange(Entities.Urun.Where(x => x.Stok.Count == 0 && !x.SilindiMi)
                .OrderBy(x => x.Id)
                .Select(x => new UrunModel
                {
                    Id = x.Id,
                    Ad = x.Ad
                })
            );

            cboxUrun.DataSource = list;
            cboxUrun.DisplayMember = "Ad";
            cboxUrun.ValueMember = "Id";
        }

        private void StokDataGridViewDoldur()
        {
            dgvStok.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            List<StokModel> stoklar = Entities.Stok.Where(y => !y.SilindiMi)
                .Select(x => new StokModel
                {
                    Id = x.Id,
                    UrunAd = x.Urun.Ad,
                    UrunId = x.Urun.Id,
                    StokSayısı = x.StokSayısı,
                    EklemeTarihi = x.EklemeTarihi
                })
                .OrderBy(x => x.Id)
                .ToList();

            dgvStok.DataSource = stoklar;
            dgvStok.Columns["Id"].Visible = false;
            dgvStok.Columns["UrunId"].Visible = false;
            dgvStok.Columns["UrunAd"].HeaderText = "Ürün Adı";
            dgvStok.Columns["StokSayısı"].HeaderText = "Stok Sayısı";
            dgvStok.Columns["EklemeTarihi"].HeaderText = "Ekleme Tarihi";

            dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TextBoxTemizle()
        {
            txtStok.Clear();
        }

        private void DgvStok_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.SelectedRows.Count > 0)
            {
                SeciliSatir = dgv.SelectedRows[0] as DataGridViewRow;
                txtStok.Text = SeciliSatir.Cells["StokSayısı"].Value.ToString();
                cboxUrun.SelectedValue = SeciliSatir.Cells["UrunId"].Value;
            }
        }

        private void BtnStokEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Stok eklenecekStok = new Stok();

                if (int.TryParse(txtStok.Text, out int parsedStok))
                {
                    eklenecekStok.StokSayısı = parsedStok;
                }
                else
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                eklenecekStok.UrunId = SeciliUrunId;
                eklenecekStok.SilindiMi = false;
                eklenecekStok.EklemeTarihi = DateTime.Now;

                Entities.Stok.Add(eklenecekStok);

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StokDataGridViewDoldur();
                }

                TextBoxTemizle();
            }
        }

        private void Btn_StokGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz öğrenciyi seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Stok eklenenStok = Entities.Stok.FirstOrDefault(x => x.Id == SeciliStokId && !x.SilindiMi);

                if (int.TryParse(txtStok.Text, out int parsedStok))
                {
                    eklenenStok.StokSayısı = parsedStok;
                }
                else
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                eklenenStok.GuncellenmeTarihi = DateTime.Now;

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StokDataGridViewDoldur();
                }
            }
        }

        private void BtnStokSil_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz öğrenciyi seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("İlgili stok bilgisini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Stok eklenenStok = Entities.Stok.FirstOrDefault(x => x.Id == SeciliStokId && !x.SilindiMi);
                    eklenenStok.SilindiMi = true;

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        StokDataGridViewDoldur();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CboxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = sender as ComboBox;

            if (selected.SelectedIndex != 0 && selected.SelectedIndex != -1)
            {
                SeciliUrunId = Convert.ToInt32(selected.SelectedValue);
            }
        }
    }
}