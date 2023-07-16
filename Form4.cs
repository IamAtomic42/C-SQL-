using baocaodoan.model1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baocaodoan
{
    public partial class FSanPham : Form
    {
        QLCHDDEntities1 db = new QLCHDDEntities1();
        SanPham sp = new SanPham();
        public FSanPham()
        {
            InitializeComponent();
            Load_DGVSP();
        }
        private void Load_DGVSP()
        {
            dgvSanPham.DataSource = db.SanPhams.ToList<SanPham>();
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            txtMaSP.Text = "";
            txtTenSP.Clear();
            txtSoluong.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtChitiet.Clear();
            txtMaSP.Focus();
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public bool CheckData()
        {
            if (String.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Chưa nhập mã Sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSP.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtTenSP.Text))
            {
                MessageBox.Show("Chưa nhập tên Sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSP.Focus();
                return false;
            }

            else if (String.IsNullOrEmpty(txtChitiet.Text))
            {
                MessageBox.Show("Chưa nhập chi tiết Sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChitiet.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Chưa nhập số lượng Sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtGiaNhap.Text))
            {
                MessageBox.Show("Chưa điền giá nhập Sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaNhap.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Chưa điền giá nhập Sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaBan.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (QLCHDDEntities1 db = new QLCHDDEntities1())
                {
                    db.SanPhams.Add(sp);
                    db.SaveChanges();
                }
                Clear();
                Load_DGVSP();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                Load_DGVSP();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sp.TenSP = txtTenSP.Text.Trim();
            sp.MaSP = txtMaSP.Text.Trim();
            sp.GiaNhap = Convert.ToInt32(txtGiaNhap.Text.ToString());
            sp.GiaBan = Convert.ToInt32(txtGiaBan.Text.ToString());
            sp.Thongtinchitiet = txtChitiet.Text.Trim();
            sp.SoLuong = Convert.ToInt32(txtSoluong.Text.ToString());
            using (QLCHDDEntities1 db = new QLCHDDEntities1())
            {
                db.Entry(sp).State = EntityState.Modified;
                Clear();
                db.SaveChanges();
            }
            Load_DGVSP();
            MessageBox.Show("Sửa thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác định xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                using (QLCHDDEntities1 db = new QLCHDDEntities1())
                {
                    db.Entry(sp).State = EntityState.Modified;
                    db.SanPhams.Remove(sp);
                    db.SaveChanges();
                    Clear();
                    Load_DGVSP();
                    MessageBox.Show("Đã xóa thành công !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.CurrentRow.Index != -1)
            {
                sp.MaSP = dgvSanPham.CurrentRow.Cells["colMaSP"].Value.ToString();
                using (QLCHDDEntities1 db = new QLCHDDEntities1())
                {
                    sp = db.SanPhams.Where(x => x.MaSP == sp.MaSP).FirstOrDefault();
                    txtMaSP.Text = sp.MaSP;
                    txtTenSP.Text = sp.TenSP;
                    txtSoluong.Text = sp.SoLuong.ToString();
                    txtGiaBan.Text = sp.GiaBan.ToString();
                    txtGiaNhap.Text = sp.GiaNhap.ToString();
                    txtChitiet.Text = sp.Thongtinchitiet;
                }
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            }
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

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
