using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DAL;

namespace QLBanHang.BUS
{
    class Func_TaiKhoan
    {
        QuanLyBanHangEntities db;
        public Func_TaiKhoan()
        {
            db = new QuanLyBanHangEntities();
        }

        ThongTinKhachHang searchKhachHangTheoMa(long ma)
        {
            ThongTinKhachHang tt = null;
            try
            {
                tt = (from tk in db.TAIKHOAN
                      join kh in db.KHACHHANG on tk.MATAIKHOAN equals kh.MATAIKHOAN
                      where kh.MAKH == ma
                      select new ThongTinKhachHang
                      {
                          maKhach = kh.MAKH,
                          maTaiKhoan = tk.MATAIKHOAN,
                          ten = tk.TEN,
                          diaChi = tk.DIACHI,
                          soDienThoai = tk.SDT,
                          isNhanVien = false,
                          gioiTinh = (bool)tk.GIOITINH,
                          ngaySinh = (DateTime)tk.NGAYSINH
                      }).Single();
            }
            catch (Exception ex) { }
            return tt;
        }

        ThongTinKhachHang searchNhanVienTheoMa(long ma)
        {
            ThongTinKhachHang tt = null;
            try
            {
                tt = (from tk in db.TAIKHOAN
                      join nv in db.NHANVIEN on tk.MATAIKHOAN equals nv.MATAIKHOAN
                      where nv.MANHANVIEN == ma
                      select new ThongTinKhachHang
                      {
                          maKhach = nv.MANHANVIEN,
                          maTaiKhoan = tk.MATAIKHOAN,
                          ten = tk.TEN,
                          diaChi = tk.DIACHI,
                          soDienThoai = tk.SDT,
                          isNhanVien = true,
                          gioiTinh = (bool)tk.GIOITINH,
                          ngaySinh = (DateTime)tk.NGAYSINH
                      }).Single();
            }
            catch (Exception ex) { }
            return tt;
        }

        List<ThongTinKhachHang> searchTaiKhoanTheoKey(string key)
        {
            List<TAIKHOAN> lst = null;
            try
            {
                lst = (from c in db.TAIKHOAN
                       where c.TEN.Contains(key)
                       select c).ToList();
            }
            catch (Exception ex) { }
            List<ThongTinKhachHang> resLst = null;
            if (lst != null)
            {
                resLst = new List<ThongTinKhachHang>();
                foreach (TAIKHOAN item in lst)
                {
                    bool isNhanVien = (bool)(from c in db.TAIKHOAN
                                       where c.MATAIKHOAN == item.MATAIKHOAN
                                       select c.ISNHANVIEN).Single();
                    if (isNhanVien == true)
                    {
                        // là nhân viên join với bản nhân viên để lấy mã
                        ThongTinKhachHang tt = (from c in db.TAIKHOAN
                                                join nv in db.NHANVIEN on c.MATAIKHOAN equals nv.MATAIKHOAN
                                                select new ThongTinKhachHang
                                                {
                                                    maKhach = nv.MANHANVIEN,
                                                    maTaiKhoan = c.MATAIKHOAN,
                                                    ten = c.TEN, 
                                                    diaChi = c.DIACHI, 
                                                    gioiTinh = (bool)c.GIOITINH, 
                                                    isNhanVien = true, 
                                                    ngaySinh = (DateTime)c.NGAYSINH,
                                                    soDienThoai = c.SDT
                                                }).Single();
                        resLst.Add(tt);
                    }
                    else
                    {
                        //là khách hàng join với bảng khách hàng để lấy mã
                        ThongTinKhachHang tt = (from c in db.TAIKHOAN
                                                join kh in db.KHACHHANG on c.MATAIKHOAN equals kh.MATAIKHOAN
                                                select new ThongTinKhachHang
                                                {
                                                    maKhach = kh.MAKH,
                                                    maTaiKhoan = c.MATAIKHOAN,
                                                    ten = c.TEN,
                                                    diaChi = c.DIACHI,
                                                    gioiTinh = (bool)c.GIOITINH,
                                                    isNhanVien = false,
                                                    ngaySinh = (DateTime)c.NGAYSINH,
                                                    soDienThoai = c.SDT
                                                }).Single();
                        resLst.Add(tt);
                    }
                }
            }
            return resLst;
        }

        public List<ThongTinKhachHang> timTaiKhoan(string key)
        {
            List<ThongTinKhachHang> lst = null;
            long maInput;
            if (long.TryParse(key, out maInput) == true)
            {
                // nếu là số
                if(searchNhanVienTheoMa(maInput) != null){
                    lst = new List<ThongTinKhachHang>();
                    ThongTinKhachHang tt = searchNhanVienTheoMa(maInput);
                    lst.Add(tt);
                }
                
                if (searchKhachHangTheoMa(maInput) != null)
                {
                    if(lst == null)
                        lst = new List<ThongTinKhachHang>();
                    ThongTinKhachHang tt = searchKhachHangTheoMa(maInput);
                    lst.Add(tt);
                }
                return lst;
            }
            else
            {
                //Là từ khóa giống tên
                lst = searchTaiKhoanTheoKey(key);
            }
            return lst;
        }
    }
}
