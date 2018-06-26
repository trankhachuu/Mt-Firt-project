using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    public class ThongTinKhachHang
    {
        public long maKhach { get; set; }
        public long maTaiKhoan { get; set; }
        public string ten { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public bool isNhanVien { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
    }
}
