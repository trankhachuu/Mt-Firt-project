using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    class InfoHoaDon
    {
        public long maHang { get; set; }
        public string tenHang { get; set; }
        public int soLuong { get; set; }
        public double thanhTien { get; set; }
        public InfoHoaDon()
        {

        }

        public InfoHoaDon(long maHang, string tenHang, int soLuong, float thanhTien)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
        }
    }
}
