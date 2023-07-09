using KariyerItData;
using KariyerItWinForm.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class UrunForm : FormAyarlari
    {
        public DataGridViewRow SeciliSatir { get; set; }

        public int SeciliUrunId => int.Parse(SeciliSatir.Cells[0].Value.ToString());

        public int SeciliUrunTipiId { get; set; }



        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            UrunDataGridViewDoldur();
            UrunTipiComboboxDoldur();
        }



        private void UrunTipiComboboxDoldur()
        {
            var list = new List<UrunTipi>
            {
                new UrunTipi
                {
                    Id = 0,
                    Ad = "Ürün Tipi seçiniz"
                }
            };

            list.AddRange(Entities.UrunTipi
                .Where(x => !x.SilindiMi)
                .OrderBy(x => x.Id)
            );

            cBoxUrunTip.DisplayMember = "Ad";
            cBoxUrunTip.ValueMember = "Id";
            cBoxUrunTip.DataSource = list;
        }

        public void UrunDataGridViewDoldur()
        {
            dgvUrun.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            List<UrunModel> urunler = Entities.Urun.Where(y => !y.SilindiMi)
                .Select(x => new UrunModel
                {
                    Id = x.Id,
                    Ad = x.Ad,
                    UrunTipiId = Entities.UrunTipi.FirstOrDefault(y => y.Id == x.UrunTipiId && !y.SilindiMi).Id,
                    UrunTipi = Entities.UrunTipi.FirstOrDefault(y => y.Id == x.UrunTipiId && !y.SilindiMi).Ad,
                    EklenmeTarihi = x.EklenmeTarihi
                })
                .OrderBy(x => x.Id)
                .ToList();

            dgvUrun.DataSource = urunler;

            dgvUrun.Columns["Id"].Visible = false;
            dgvUrun.Columns["UrunTipiId"].Visible = false;
            dgvUrun.Columns["UrunTipi"].HeaderText = "Ürün Tipi";
            dgvUrun.Columns["EklenmeTarihi"].HeaderText = "Ekleme Tarihi";

            dgvUrun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TextBoxTemizle()
        {
            txtUrunAdi.Clear();
        }

        private void DgvUrun_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.SelectedRows.Count > 0)
            {
                SeciliSatir = dgv.SelectedRows[0] as DataGridViewRow;
                txtUrunAdi.Text = SeciliSatir.Cells["Ad"].Value.ToString();
                cBoxUrunTip.SelectedValue = SeciliSatir.Cells["UrunTipiId"].Value;
            }
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || cBoxUrunTip.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Urun eklenecekUrun = new Urun()
                {
                    Ad = txtUrunAdi.Text,
                    UrunTipiId = SeciliUrunTipiId,
                    SilindiMi = false,
                    EklenmeTarihi = DateTime.Now
                };
                Entities.Urun.Add(eklenecekUrun);

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UrunDataGridViewDoldur();
                }

                TextBoxTemizle();
            }
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz ürünü seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || cBoxUrunTip.SelectedIndex == 0)
                {
                    MessageBox.Show("Lütfen alanların dolu olduğuna emin olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Urun eklenenUrun = Entities.Urun.FirstOrDefault(x => x.Id == SeciliUrunId && !x.SilindiMi);
                eklenenUrun.Ad = txtUrunAdi.Text;
                eklenenUrun.UrunTipiId = SeciliUrunTipiId;
                eklenenUrun.GuncellemeTarihi = DateTime.Now;

                //Başarılı 1 başarısız -1
                if (Entities.SaveChanges() > 0)
                {
                    MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UrunDataGridViewDoldur();
                }
            }
        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            if (SeciliSatir == null || SeciliSatir.Index == -1)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz ürünü seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("İlgili ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Urun eklenenUrun = Entities.Urun.FirstOrDefault(x => x.Id == SeciliUrunId && !x.SilindiMi);
                    eklenenUrun.SilindiMi = true;

                    //Başarılı 1 başarısız -1
                    if (Entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("İşlem başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UrunDataGridViewDoldur();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                  
            }
        }

        private void CBoxUrunTip_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = sender as ComboBox;

            if (selected.SelectedIndex != 0 && selected.SelectedIndex != -1)
            {
                SeciliUrunTipiId = Convert.ToInt32(selected.SelectedValue);
            }
        }

        private void lblUrunTipEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrunTip form = new UrunTip();
            form.FormClosed += Form_FormClosed;
            form.Show();
            form.BringToFront();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            UrunTipiComboboxDoldur();
        }
    }
}
