//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoDB2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAIXE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIXE()
        {
            this.CHITIETHOPDONGs = new HashSet<CHITIETHOPDONG>();
            this.XEs = new HashSet<XE>();
        }
    
        public int MALOAIXE { get; set; }
        public string TENLOAIXE { get; set; }
        public Nullable<int> SOCHO { get; set; }
        public Nullable<int> SOLUONGXE { get; set; }
        public string HANGSANXUAT { get; set; }
        public string HINHANH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOPDONG> CHITIETHOPDONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XE> XEs { get; set; }
    }
}