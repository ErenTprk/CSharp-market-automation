//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ornekproje
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblurun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblurun()
        {
            this.tblsatis = new HashSet<tblsatis>();
        }
    
        public int urun_id { get; set; }
        public string urun_tur { get; set; }
        public string urun_miktar { get; set; }
        public string urun_kategori { get; set; }
        public string urun_ad { get; set; }
        public int kullanici_id { get; set; }
        public int kategori_id { get; set; }
        public string urun_fiyat { get; set; }
    
        public virtual tblkullanici tblkullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblsatis> tblsatis { get; set; }
        public virtual tblkategori tblkategori { get; set; }
    }
}
