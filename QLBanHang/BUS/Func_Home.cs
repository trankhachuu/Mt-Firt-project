using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DAL;

namespace QLBanHang.BUS
{
    class Func_Home
    {
        QuanLyBanHangEntities db;
        public Func_Home()
        {
            db = new QuanLyBanHangEntities();
        }
        public List<DonHangNew> getDonHangMoi()
        {
            List<DonHangNew> lst = null;
            try
            {
                lst = (from hd in db.HOADON
                       join kh in db.KHACHHANG on hd.MAKH equals kh.MAKH
                       join tk in db.TAIKHOAN on kh.MATAIKHOAN equals tk.MATAIKHOAN
                       select new DonHangNew
                       {
                           maDonHang = hd.MAHOADON,
                           tenKhachHang = tk.TEN,
                           thanhTien = hd.TONGTIEN,
                           ngayMua = hd.NGAYLAP
                       }).ToList();
            }
            catch (Exception e) { }
            return lst;
        }
    }

    
}
