using System;
using System.Windows.Forms;

namespace KariyerItWinForm
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }

        private void BtnStokForm_Click(object sender, EventArgs e)
        {
            StokForm stokForm = new StokForm();
            stokForm.Show();
            SendToBack();
            stokForm.BringToFront();
        }

        private void BtnPersoneller_Click(object sender, EventArgs e)
        {
            PersonelForm personeller = new PersonelForm();
            personeller.Show();
            SendToBack();
            personeller.BringToFront();
        }

        private void BtnOgrenciler_Click(object sender, EventArgs e)
        {
            OgrenciForm ogrenciler = new OgrenciForm();
            ogrenciler.Show();
            SendToBack();
            ogrenciler.BringToFront();
        }

        private void BtnVr_Click(object sender, EventArgs e)
        {
            VrForm vrForm = new VrForm();
            vrForm.Show();
            SendToBack();
            vrForm.BringToFront();
        }

        private void BtnMaasForm_Click(object sender, EventArgs e)
        {
            MaasForm maasForm = new MaasForm();
            maasForm.Show();
            SendToBack();
            maasForm.BringToFront();
        }

        private void BtnKantinForm_Click(object sender, EventArgs e)
        {
            KantinForm kantinForm = new KantinForm();
            kantinForm.Show();
            SendToBack();
            kantinForm.BringToFront();
        }

        private void BtnFaturaForm_Click(object sender, EventArgs e)
        {
            FaturaForm faturaForm = new FaturaForm();
            faturaForm.Show();
            SendToBack();
            faturaForm.BringToFront();
        }

        private void BtnUrunForm_Click(object sender, EventArgs e)
        {
            UrunForm urunForm = new UrunForm();
            urunForm.Show();
            SendToBack();
            urunForm.BringToFront();
        }

        private void AnaSayfaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show(this, "Programdan çıkılacak. Emin misiniz?", "Uyarı",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }       
        }

        private void TblLayPnlGrid_Paint(object sender, PaintEventArgs e)
        {
            tblLayPnlGrid.Left = (ClientSize.Width - tblLayPnlGrid.Width) / 2;
            tblLayPnlGrid.Top = (ClientSize.Height - tblLayPnlGrid.Height) / 2;
        }
    }
}
