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
        private double tongTien = 0.0;
        public long idNhanVien;
        Func_BanHang funcBH;
        public HOADON hoadon;
        Dictionary<long, CTHOADON> lstCTHoaDon;
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
        }

        private void txt_KeySearchHang_TextChanged(object sender, EventArgs e)
        {
            List<HANG> lst = funcBH.searchHang(txt_KeySearchHang.Text);
            bindingSource1.DataSource = lst;
            cb_resHang.DataSource = bindingSource1.DataSource;
            cb_resHang.ValueMember = "MAHANG";
            cb_resHang.DisplayMember = "TENHANG";
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
                MessageBox.Show(lstCTHoaDon.Count.ToString());
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
                    lb_TienTraLai.Text = "Không hợp lệ";
                else
                    lb_TienTraLai.Text = String.Format("{0:0,0 vnđ}", float.Parse(richTextBox3.Text) - tongTien);
            }
            catch (Exception ex) { }
        }

        private void grid_DSChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (grid_DSChiTiet.Columns[e.ColumnIndex].Name)
            {
                case "tangSL":
                    if (Int32.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuong"].Value.ToString()) < 1000)
                    {
                        grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuong"].Value = Convert.ToString(Int32.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuong"].Value.ToString()) + 1);
                        upDateSoLuong(e.RowIndex);
                    }
                    break;
                case "giamSL":
                    if (Int32.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuong"].Value.ToString()) > 0)
                    {
                        grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuong"].Value = Convert.ToString(Int32.Parse(grid_DSChiTiet.Rows[e.RowIndex].Cells["soLuong"].Value.ToString()) - 1);
                        upDateSoLuong(e.RowIndex);
                    }

                    break;
                case "xoaTruong":
                    MessageBox.Show("Xoas truong");
                    break;
                default:
                    break;
            }
        }
    }
}
