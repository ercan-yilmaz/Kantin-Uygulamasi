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
    
    public partial class GiderTipi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiderTipi()
        {
            this.Gider = new HashSet<Gider>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public bool SilindiMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gider> Gider { get; set; }
    }
}
