﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class babaa : DbContext
    {
        public babaa()
            : base("name=babaa")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gelir> Gelir { get; set; }
        public virtual DbSet<GelirTipi> GelirTipi { get; set; }
        public virtual DbSet<Gider> Gider { get; set; }
        public virtual DbSet<GiderTipi> GiderTipi { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Stok> Stok { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<UrunTipi> UrunTipi { get; set; }
        public virtual DbSet<Yonetici> Yonetici { get; set; }
    }
}
