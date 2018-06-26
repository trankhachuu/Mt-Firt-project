using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DAL;

namespace QLBanHang.BUS
{
    class Func_BanHang
    {
        QuanLyBanHangEntities db;

        public Func_BanHang()
        {
            db = new QuanLyBanHangEntities();
        }
        public List<HANG> getDanhMucHang()
        {
            List<HANG> lst = (from c in db.HANG
                              select c).Take(10).ToList();
            return lst;
        }

        public List<HANG> searchHang(string key)
        {
            List<HANG> lst = (from c in db.HANG
                              where c.TENHANG.Contains(key)
                              select c).ToList();
            return lst;
        }

        public List<InfoHoaDon> convertCTHDToInfoHoaDon(Dictionary<long, CTHOADON> lst)
        {
            List<InfoHoaDon> resLst = new List<InfoHoaDon>();;
            foreach (CTHOADON item in lst.Values)
            {
                InfoHoaDon iff = (from c in db.HANG
                                 where c.MAHANG == item.MAHANG
                                 select new InfoHoaDon
                                 {
                                     maHang = c.MAHANG, 
                                     tenHang = c.TENHANG, 
                                     soLuong = item.SOLUONG,
                                     thanhTien = c.GIA * item.SOLUONG
                                 }).Single();
                resLst.Add(iff);
            }
            return resLst;
        }

        public bool thanhToan(Dictionary<long , CTHOADON> lst)
        {
            try
            {
                foreach (CTHOADON item in lst.Values)
                {
                    db.CTHOADON.Add(item);
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
    }
}
