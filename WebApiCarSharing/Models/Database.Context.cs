﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiCarSharing.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RentACarEntities : DbContext
    {
        public RentACarEntities()
            : base("name=RentACarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Odemeler> Odemeler { get; set; }
        public virtual DbSet<Onay> Onay { get; set; }
        public virtual DbSet<Resim> Resim { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UyeBilgi> UyeBilgi { get; set; }
        public virtual DbSet<Yolculuk> Yolculuk { get; set; }
    }
}
