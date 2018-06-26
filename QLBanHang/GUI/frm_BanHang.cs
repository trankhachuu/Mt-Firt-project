using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.BUS;
using QLBanHang.DAL;

namespace QLBanHang.GUI
{
    public partial class frm_BanHang : Form
    {
        bool checkCloseForm = false;
        private double tongTien = 0.0, tienKhachTra = -1, tienTraLai = 0.0;
        public long idNhanVien;
        Func_BanHang funcBH;
        public HOADON hoadon;
        Dictionary<long, CTHOADON> lstCTHoaDon;
        TAIKHOAN nhanVien = null;
        ThongTinKhachHang khachHang = null;
        QuanLyBanHangEntities db;
        public frm_BanHang()
        {
            InitializeComponent();
            funcBH = new Func_BanHang();
            db = new QuanLyBanHangEntities();
            lstCTHoaDon = new Dictionary<long, CTHOADON>();
        }

        private bool check(long maHang)
        {
            if (lstCTHoaDon.ContainsKey(maHang))
            {
                return false;
            }
            return true;
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            hoadon = new HOADON();
            hoadon.MANHANVIEN = idNhanVien;
            hoadon.TONGTIEN = 0;
            hoadon.NGAYLAP = DateTime.Now;
            hoadon.TINHTRANG = 0;
            db.HOADON.Add(hoadon);
            db.SaveChanges();

            nhanVien = (from tk in db.TAIKHOAN
                        join nv in db.NHANVIEN on tk.MATAIKHOAN equals nv.MATAIKHOAN
                        where nv.MANHANVIEN == idNhanVien
                        select tk
                      ).Single();
            cb_NhanVien.Items.Add(nhanVien.TEN);
            cb_NhanVien.SelectedIndex = 0;

            List<HANG> lst = funcBH.getDanhMucHang();
            if (lst != null)
            {
                listView1.FullRowSelect = true;
                listView1.View = View.Details;

                foreach (HANG item in lst)
                {
                    ListViewItem lstViewItem = new ListViewItem();
                    lstViewItem.Text = item.MAHANG.ToString();
                    lstViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.TENHANG });
                    lstViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.GIA.ToString() });
                    lstViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.SOLUONG.ToString() });
                    listView1.Items.Add(lstViewItem);
                }
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void txt_KeySearchHang_TextChanged(object sender, EventArgs e)
        {
            List<HANG> lst = funcBH.searchHang(txt_KeySearchHang.Text);
            if (lst != null)
            {
                bindingSource1.DataSource = lst;
                cb_resHang.DataSource = bindingSource1.DataSource;
                cb_resHang.ValueMember = "MAHANG";
                cb_resHang.DisplayMember = "TENHANG";
            }
        }

        private void btn_ThemHang_Click(object sender, EventArgs e)
        {
            try {
                if (listView1.SelectedItems.Count > 0) {
                    foreach (ListViewItem item in listView1.SelectedItems) {
                        CTHOADON ct = new CTHOADON()
                        {
                            MAHOADON = hoadon.MAHOADON,
                            MAHANG = Int64.Parse(item.Text),
                            SOLUONG = 1
                        };
                        if (check(ct.MAHANG) == true)
                            lstCTHoaDon.Add(ct.MAHANG, ct);
                    }
                } else {
                    CTHOADON ct = new CTHOADON()
                    {
                        MAHOADON = hoadon.MAHOADON,
                        MAHANG = Int64.Parse(cb_resHang.SelectedValue.ToString()),
                        SOLUONG = 1
                    };
                    if (check(ct.MAHANG) == true)
                        lstCTHoaDon.Add(ct.MAHANG, ct);
                }
                fillDataGrindView();
            }
            catch (Exception ex) { }
        }

        private void fillDataGrindView()
        {
            infoHoaDonBindingSource1.Clear();
            tongTien = 0;
            List<InfoHoaDon> lst = funcBH.convertCTHDToInfoHoaDon(lstCTHoaDon);
            if (lst != null)
            {
                foreach (InfoHoaDon item in lst)
                {
                    infoHoaDonBindingSource1.Add(item);
                    tongTien += item.thanhTien;
                }
                tinhTien(tongTien);
            }
            
        }

        private void tinhTien(double tongTien)
        {
            try
            {
                lb_TongTien.Text = String.Format("{0:0,0 vnđ}", tongTien);
                if (float.Parse(richTextBox3.Text) < tongTien || richTextBox3.Text.Length < 3)
                    lb_TienTraLai.Text = "Không hợp lệ";
                else
                    lb_TienTraLai.Text = String.Format("{0:0,0 vnđ}", float.Parse(richTextBox3.Text) - tongTien);
            }
            catch (Exception ex) { }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(richTextBox3.Text) < tongTien || richTextBox3.Text.Length < 3)
                {
                    lb_TienTraLai.Text = "Không hợp lệ";
                } else{
                    tienKhachTra = double.Parse(richTextBox3.Text);
                    tienTraLai = double.Parse(richTextBox3.Text) - tongTien;
                    lb_TienTraLai.Text = String.Format("{0:0,0 vnđ}", tienTraLai);
                }
            }
            catch (Exception ex) { }
        }

        void upDateSoLuong(int rowIndex, long key)
        {
            try
            {
                int soLuong = int.Parse(grid_DSChiTiet.Rows[rowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString());
                lstCTHoaDon[key].SOLUONG = soLuong;
                fillDataGrindView();
            }
            catch (Exception ex) { }
        }

        private void grid_DSChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (grid_DSChiTiet.Columns[e.ColumnIndex].Name)
                {
                    case "tangSL":
                        if (Int32.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString()) < 1000)
                        {
                            grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value = Convert.ToString(Int32.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString()) + 1);
                            upDateSoLuong(e.RowIndex, Int64.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["maHangDataGridViewTextBoxColumn"].Value.ToString()));
                        }
                        break;
                    case "giamSL":
                        if (Int32.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString()) > 0)
                        {
                            grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value = Convert.ToString(Int32.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString()) - 1);
                            upDateSoLuong(e.RowIndex, Int64.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["maHangDataGridViewTextBoxColumn"].Value.ToString()));
                        }

                        break;
                    case "xoaTruong":
                        lstCTHoaDon.Remove(Int64.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["maHangDataGridViewTextBoxColumn"].Value.ToString()));
                        fillDataGrindView();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void txt_MaKhach_TextChanged(object sender, EventArgs e)
        {
            try{
                khachHang = (from tk in db.TAIKHOAN
                             join kh in db.KHACHHANG on tk.MATAIKHOAN equals kh.MATAIKHOAN
                             where tk.SDT == txt_MaKhach.Text
                             select new ThongTinKhachHang { 
                                maKhach = kh.MAKH, 
                                ten = tk.TEN, 
                                diaChi = tk.DIACHI, 
                                soDienThoai = tk.SDT
                             }).Single();
            }
            catch (Exception ex) { }
            if (txtMakhach == null)
            {
                khachHang = null;
            }
            if (khachHang != null)
            {
                txtLoaiKhach.Text = "Thành viên";
                txtMakhach.Text = khachHang.maKhach.ToString();
                txtTenKhach.Text = khachHang.ten;
                txtDiaChi.Text = khachHang.diaChi;
                txtSoDienThoai.Text = khachHang.soDienThoai;
            }
            else
            {
                txtLoaiKhach.Text = "Khách chơi qua đường";
                txtMakhach.Text = "";
                txtTenKhach.Text = "";
                txtDiaChi.Text = "";
                txtSoDienThoai.Text = "";
            }
        }

        private void frm_BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.checkCloseForm == false)
            {
                DialogResult res = MessageBox.Show("Đơn hàng của bạn chưa được thanh toán, đóng sẽ hủy bỏ toàn bộ đơn hàng. Bạn có muốn tiếp tục ?", "Cảnh báo", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    db.HOADON.Remove(hoadon);
                    db.SaveChanges();
                }
                else
                    e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thanhToan()
        {
            if (tienKhachTra >= tongTien)
            {
                if (funcBH.thanhToan(lstCTHoaDon) == true)
                {
                    if (khachHang != null)
                    {
                        hoadon.MAKH = khachHang.maKhach;
                    }
                    hoadon.TINHTRANG = 1;
                    hoadon.TIENKHACHTRA = tienKhachTra;
                    hoadon.TIENTRALAIKHACH = tienTraLai;
                    db.SaveChanges();
                    MessageBox.Show("Thanh toán hoàn tất. Đóng");
                    this.checkCloseForm = true;
                }
                else
                {
                    MessageBox.Show("Lổi vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng yêu cầu thanh toán trước");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thanhToan();
            if (checkCloseForm == true) this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            khachHang = null;
            txtLoaiKhach.Text = "Khách chơi qua đường";
            txtMakhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thanhToan();
            try
            {
                if (checkCloseForm == true)
                {
                    print_Dialog.Document = print_Document;
                    print_Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(print_Document_PrintPage);
                    print_Document.Print();
                }
            } 
            catch (Exception ex) { }
            if (checkCloseForm == true) this.Close();
        }

        private void print_Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontDam = new Font("Courier New", 30, FontStyle.Bold);
            Font fontBT = new Font("Courier New", 18, FontStyle.Regular);
            Font fontNghien = new Font("Courier New", 18, FontStyle.Italic);
            int stX = 10, stY = 10;
            int danDong = 40;

            // Vẽ tiêu đề
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG",fontDam , Brushes.Black, new Point(stX, stY));
            // Vẽ Header bảng
            e.Graphics.DrawString("Mã hàng".PadRight(10) + "Tên hàng".PadRight(20) + "Số lượng".PadRight(10) + "Thành tiền".PadRight(10), fontBT, new SolidBrush(Color.Black), new Point(stX, stY + danDong + 10));
            stY += danDong;
            e.Graphics.DrawString("----------------------------------------------------", fontBT, new SolidBrush(Color.Black), new Point(stX, stY + danDong + 10));
            List<InfoHoaDon> lst = funcBH.convertCTHDToInfoHoaDon(lstCTHoaDon);
            foreach (InfoHoaDon item in lst)
            {
                stY += danDong;
                e.Graphics.DrawString(item.maHang.ToString().PadRight(10) + item.tenHang.PadRight(20) + item.soLuong.ToString().PadRight(10) + String.Format("{0:0,0 vnđ}", item.thanhTien).PadRight(10), fontNghien, new SolidBrush(Color.Black), new Point(stX, stY + danDong));
            }
            stY += danDong;
            e.Graphics.DrawString("----------------------------------------------------", fontBT, new SolidBrush(Color.Black), new Point(stX, stY + danDong + 10));
            stY += danDong;
            e.Graphics.DrawString("Tổng tiền".PadRight(40) + String.Format("{0:0,0 vnđ}", tongTien).PadRight(10), fontNghien, new SolidBrush(Color.Black), new Point(stX, stY + danDong + 10));
            stY += danDong;
            e.Graphics.DrawString("Tiền khách trả".PadRight(40) + String.Format("{0:0,0 vnđ}", tienKhachTra).PadRight(10), fontNghien, new SolidBrush(Color.Black), new Point(stX, stY + danDong + 10));
            stY += danDong;
            e.Graphics.DrawString("Tiền trả lại".PadRight(40) + String.Format("{0:0,0 vnđ}", tienTraLai).PadRight(10), fontNghien, new SolidBrush(Color.Black), new Point(stX, stY + danDong + 10));
        }
    }
}
