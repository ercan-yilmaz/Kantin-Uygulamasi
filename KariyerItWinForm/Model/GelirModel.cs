using System;

namespace KariyerItWinForm.Model
{
    public class GelirModel
    {
        public int Id { get; set; }

        public string KullaniciAdSoyad { get; set; }

        public double Tutar { get; set; }

        public string Detay { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public int KullaniciId { get; internal set; }
    }
}
