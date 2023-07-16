using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baocaodoan
{
    public partial class FDanhMuc : Form
    {
        public FDanhMuc()
        {
            InitializeComponent();
        }

        private void mnsKH_Click(object sender, EventArgs e)
        {
            FKhachHang kh = new FKhachHang();
            kh.Show();
        }

        private void mnsSP_Click(object sender, EventArgs e)
        {
            FSanPham sp = new FSanPham();
            sp.Show();
        }

        private void mnsNV_Click(object sender, EventArgs e)
        {
            FNhanVien nv = new FNhanVien();
            nv.Show();
        }




        private void mnsTKHD_Click(object sender, EventArgs e)
        {
            FTimKiemHoaDon tk = new FTimKiemHoaDon();
            tk.Show();
        }

        private void mnsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
