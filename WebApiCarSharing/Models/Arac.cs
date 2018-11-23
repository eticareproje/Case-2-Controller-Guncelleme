//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Arac
    {
        public int AracId { get; set; }
        public int UserId { get; set; }
        public string XKoordinat { get; set; }
        public string YKoordinat { get; set; }
        public int MarkaId { get; set; }
        public int ModelId { get; set; }
        public Nullable<double> Ucret { get; set; }
        public Nullable<int> KM { get; set; }
        public string Yakit { get; set; }
        public string Kasa { get; set; }
        public string Yil { get; set; }
        public string Vites { get; set; }
        public string Aciklama { get; set; }
        public int Goruntulenme { get; set; }
        public byte OrtalamaPuan { get; set; }
        public string AracDurum { get; set; }
    
        public virtual Marka Marka { get; set; }
        public virtual Model Model { get; set; }
        public virtual UyeBilgi UyeBilgi { get; set; }
        public virtual Resim Resim { get; set; }
    }
}
