//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCStokTakipSistemi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLURUN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLURUN()
        {
            this.TBLSATIŞ = new HashSet<TBLSATIŞ>();
        }
    
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public Nullable<short> URUKATEGORİ { get; set; }
        public Nullable<int> FİYAT { get; set; }
        public string URUNMARKA { get; set; }
        public Nullable<int> STOK { get; set; }
    
        public virtual TBLKATEGORI TBLKATEGORI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATIŞ> TBLSATIŞ { get; set; }
    }
}