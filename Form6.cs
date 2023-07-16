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
    public partial class FTimKiemHoaDon : Form
    {
        public FTimKiemHoaDon()
        {
            InitializeComponent();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == null)
                MessageBox.Show("Không có Mã hóa đơn đó !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Show_HD();
        }
    }
}
