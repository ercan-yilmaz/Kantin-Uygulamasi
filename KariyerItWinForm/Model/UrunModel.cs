using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerItWinForm.Model
{
    public class UrunModel
    {
        public int Id { get; internal set; }
        public string Ad { get; internal set; }
        public DateTime EklenmeTarihi { get; internal set; }
        public string UrunTipi { get; internal set; }
        public int UrunTipiId { get; internal set; }
    }
}
