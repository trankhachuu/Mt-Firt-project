//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBanHang.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAIKHOAN
    {
        public TAIKHOAN()
        {
            this.KHACHHANG = new HashSet<KHACHHANG>();
            this.NHANVIEN = new HashSet<NHANVIEN>();
        }
    
        public long MATAIKHOAN { get; set; }
        public string TEN { get; set; }
        public string DIACHI { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public string SDT { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
    
        public virtual ICollection<KHACHHANG> KHACHHANG { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIEN { get; set; }
    }
}
