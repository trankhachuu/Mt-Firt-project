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
    public partial class frm_KhachHang : Form
    {
        Func_TaiKhoan funcTK;
        public frm_KhachHang()
        {
            InitializeComponent();
            funcTK = new Func_TaiKhoan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<ThongTinKhachHang> lst = funcTK.timTaiKhoan(txtSearch.Text);
            if (lst != null)
            {
                thongTinKhachHangBindingSource.Clear();
                foreach (ThongTinKhachHang item in lst)
                {
                    thongTinKhachHangBindingSource.Add(item);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(dataGridView1.Columns[e.RowIndex].Name == "clName_Edit")
            //long maTaiKhoan = long.Parse(dataGridView1.Rows[e.RowIndex].Cells["clName_MaTaiKhoan"].Value.ToString());
            //MessageBox.Show(maTaiKhoan.ToString());
        }
    }
}
