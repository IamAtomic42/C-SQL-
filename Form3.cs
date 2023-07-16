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
    public partial class FKhachHang : Form
    {
        QLCHDDEntities1 db = new QLCHDDEntities1();
        KhachHang kh = new KhachHang();
        public FKhachHang()
        {
            InitializeComponent();
            Load_DataKH();
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {

        }

        void Clear()
        {
            txtMaKH.Text = txtTenKH.Text = txtDiaChi.Text = txtSDT.Text = "";
            btnLuu.Enabled = true;
            txtMaKH.Focus();
            btnXoa.Enabled = false;
            txtMaKH.Text = "KH";
        }
        void Load_DataKH()
        {
                dgvKhachHang.DataSource = db.KhachHangs.ToList<KhachHang>();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban co chac muon xoa khong ?", "Xac dinh xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            using (QLCHDDEntities1 db = new QLCHDDEntities1())
            {
                db.Entry(kh).State = EntityState.Modified;
                db.KhachHangs.Remove(kh);
                db.SaveChanges();
                Clear();
                Load_DataKH();
                MessageBox.Show("Đã hủy hóa đơn thành công !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public bool CheckData()
        {
            if (String.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Chua nhap Ma Khach Hang", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return false;
            }
            else
                if (String.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Chua nhap Ten Khach Hang", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return false;
            }
            else
                if (String.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Chua nhap Dia Chi Khach Hang", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            else
                if (String.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Chua nhap SDT Khach Hang", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {

                MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kh.TenKH = txtTenKH.Text.Trim();
                kh.MaKH = txtMaKH.Text.Trim();
                kh.DiaChi = txtDiaChi.Text.Trim();
                kh.SDT = txtSDT.Text.Trim();
                using (QLCHDDEntities1 db = new QLCHDDEntities1())
                {
                    db.KhachHangs.Add(kh);
                    db.SaveChanges();
                }
                Clear();
                Load_DataKH();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.SaveChanges();
                Load_DataKH();
                Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kh.TenKH = txtTenKH.Text.Trim();
            kh.MaKH = txtMaKH.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.SDT = txtSDT.Text.Trim();
            using (QLCHDDEntities1 db = new QLCHDDEntities1())
            {
                db.Entry(kh).State = EntityState.Modified;
                Clear();
                db.SaveChanges();
            }

            Load_DataKH();
            MessageBox.Show("Sửa thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.CurrentRow.Index != -1)
            {
                kh.MaKH = dgvKhachHang.CurrentRow.Cells["colMaKH"].Value.ToString();
                using (QLCHDDEntities1 db = new QLCHDDEntities1())
                {
                    kh = db.KhachHangs.Where(x => x.MaKH == kh.MaKH).FirstOrDefault();
                    txtMaKH.Text = kh.MaKH;
                    txtTenKH.Text = kh.TenKH;
                    txtDiaChi.Text = kh.DiaChi;
                    txtSDT.Text = kh.SDT;
                }

                btnXoa.Enabled = true;
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
    }
}
