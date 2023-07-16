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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
            txtTaiKhoan.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login()
        {
            if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
                MessageBox.Show("Chua dien thong tin !", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (this.txtTaiKhoan.Text.Length == 0)
                MessageBox.Show("Chua dien tai khoan !", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (this.txtMatKhau.Text.Length == 0)
                MessageBox.Show("Chua dien may khau !", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (this.txtTaiKhoan.Text == "Admin" && this.txtMatKhau.Text == "1234")
                MessageBox.Show("Dang Nhap thanh cong ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("thong bao khong dung !", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            FDanhMuc m = new FDanhMuc();
            if(this.txtTaiKhoan.Text == "Admin" && this.txtMatKhau.Text == "1234")
            {
                m.Show();
            }
            login();
            this.Hide();
            txtMatKhau.Text = txtTaiKhoan.Text = "1234";
        }
    }
    }

