using baocaodoan.model;
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
    public partial class FNhanVien : Form
    {
        QLCHDDEntities1 db = new QLCHDDEntities1();
        NhanVien nv = new NhanVien();
        public FNhanVien()
        {
            InitializeComponent();
            Load_Data();
        }

        void Load_Data()
        {
            dgvNhanVien.DataSource = db.NhanViens.ToList<NhanVien>();
        }
        private void FNhanVien_Load(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            txtTenNV.Text = txtDiaChi.Text = txtSDT.Text = "";
            cbxGT.Text = "";
            dtpkNgaySinh.Value = DateTime.Now;
            txtMaNV.Focus();
            btnXoa.Enabled = false;
            txtMaNV.Text = "NV";
            btnLuu.Enabled = true;
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

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentRow.Index != -1)
            {
                using (QLCHDDEntities1 db = new QLCHDDEntities1())
                {
                    nv.MaNV = dgvNhanVien.CurrentRow.Cells["colMaNV"].Value.ToString();

                    nv = db.NhanViens.Where(x => x.MaNV == nv.MaNV).FirstOrDefault();
                    txtMaNV.Text = nv.MaNV;
                    txtTenNV.Text = nv.TenNV;
                    txtDiaChi.Text = nv.Diachi;
                    txtSDT.Text = nv.SDT;
                    cbxGT.Text = nv.Gioitinh;
                    nv.NgaySinh = nv.NgaySinh;
                }
            }
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public bool checkData()
        {
            if (String.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chưa nhập mã Nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Chưa nhập tên Nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ Nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(cbxGT.Text))
            {
                MessageBox.Show("Chưa chọn giới tính Nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxGT.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(dtpkNgaySinh.Text))
            {
                MessageBox.Show("Chưa chọn ngày sinh Nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpkNgaySinh.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Chưa chọn ngày sinh Nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nv.TenNV = txtTenNV.Text.Trim();
                nv.MaNV = txtMaNV.Text.Trim();
                nv.Diachi = txtDiaChi.Text.Trim();
                nv.SDT = txtSDT.Text.Trim();
                nv.Gioitinh = cbxGT.Text.Trim();
                nv.NgaySinh = dtpkNgaySinh.Value;
                using (QLCHDDEntities1 db = new QLCHDDEntities1())
                {

                    db.NhanViens.Add(nv);
                    db.SaveChanges();
                }
                Load_Data();
                Clear();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_Data();
                Clear();
            }
            /*nv.TenNV = txtTenNV.Text.Trim();
            nv.MaNV = txtMaNV.Text.Trim();
            nv.Diachi = txtDiaChi.Text.Trim();
            nv.SDT = txtSDT.Text.Trim();
            nv.Gioitinh = cbxGT.Text.Trim();
            nv.NgaySinh = dtpkNgaySinh.Value;
            db.NhanViens.Add(nv);
            db.SaveChanges();*/


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nv.TenNV = txtTenNV.Text.Trim();
            nv.MaNV = txtMaNV.Text.Trim();
            nv.Diachi = txtDiaChi.Text.Trim();
            nv.SDT = txtSDT.Text.Trim();
            nv.Gioitinh = cbxGT.Text.Trim();
            nv.NgaySinh = dtpkNgaySinh.Value;

            using (QLCHDDEntities1 db = new QLCHDDEntities1())
            {
                db.Entry(nv).State = EntityState.Modified;

                db.SaveChanges();
            }

            Clear();
            Load_Data();
            MessageBox.Show("Sửa thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy không ?", "Xác định xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                using (QLCHDDEntities1 db = new QLCHDDEntities1())
                {
                    db.Entry(nv).State = EntityState.Modified;
                    db.NhanViens.Remove(nv);
                    db.SaveChanges();
                    Clear();
                    Load_Data();
                    MessageBox.Show("Đã hủy hóa đơn thành công !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
