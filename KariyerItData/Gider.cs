//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KariyerItData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gider
    {
        public int Id { get; set; }
        public Nullable<int> KullaniciId { get; set; }
        public double Tutar { get; set; }
        public string Detay { get; set; }
        public int GiderTipiId { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public Nullable<System.DateTime> GuncellenmeTarihi { get; set; }
        public bool SilindiMi { get; set; }
    
        public virtual GiderTipi GiderTipi { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}