//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH()
        {
            this.DONDATXEs = new HashSet<DONDATXE>();
        }
    
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string TenCoQuan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONDATXE> DONDATXEs { get; set; }
    }
}