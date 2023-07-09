using KariyerItData;
using System;

namespace KariyerItWinForm.Model
{
    public class StokModel
    {
        public int Id { get; set; }

        public int StokSayısı { get; set; }

        public int UrunId { get; set; }

        public DateTime EklemeTarihi { get; set; }

        public string UrunAd { get; set; }
    }
}