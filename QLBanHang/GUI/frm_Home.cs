using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.DAL;
using QLBanHang.BUS;

namespace QLBanHang.GUI
{
    public partial class frm_Home : Form
    {
        Func_Home funHome;
        public frm_Home()
        {
            InitializeComponent();
            funHome = new Func_Home();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_BanHang frmBH = new frm_BanHang();
            frmBH.idNhanVien = 1;
            frmBH.Show();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            List<DonHangNew> lst = funHome.getDonHangMoi();
            if (lst != null)
            {
                listViewHoaDonGanDay.FullRowSelect = true;
                listViewHoaDonGanDay.View = View.Details;

                foreach (DonHangNew item in lst)
                {
                    ListViewItem lstViewItem = new ListViewItem();
                    lstViewItem.Text = item.maDonHang.ToString();
                    lstViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.tenKhachHang });
                    lstViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.ngayMua.ToString() });
                    lstViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.thanhTien.ToString() });
                    listViewHoaDonGanDay.Items.Add(lstViewItem);
                }
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_TraHang frmTH = new frm_TraHang();
            frmTH.TopLevel = false;
            panel1.Controls.Add(frmTH);
            frmTH.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_KhachHang frmTH = new frm_KhachHang();
            frmTH.TopLevel = false;
            panel1.Controls.Add(frmTH);
            frmTH.Show();
        }
    }
}
