//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hoadon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoadon()
        {
            this.CTVes = new HashSet<CTVe>();
        }
    
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string Tinhtrang { get; set; }
        public string Mave { get; set; }
        public Nullable<int> Tongtien { get; set; }
        public Nullable<int> ThueVAT { get; set; }
        public string Makh { get; set; }
        public Nullable<System.DateTime> Nlap { get; set; }
        public string Magiovang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTVe> CTVes { get; set; }
        public virtual Nhanvien Nhanvien { get; set; }
        public virtual Khachhang Khachhang { get; set; }
    }
}
