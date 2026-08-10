using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyThuoc : Form
    {
        private ThuocController controller;

        public FrmQuanLyThuoc()
        {
            InitializeComponent();
            controller = new ThuocController();
        }

        private void FrmQuanLyThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvThuoc.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaThuoc.Clear();
            txtTenThuoc.Clear();
            txtDonViTinh.Clear();
            txtDonGia.Clear();
            txtSoLuongTon.Clear();
            txtCachDung.Clear();
            txtTrangThai.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThuoc.Rows[e.RowIndex];
                txtMaThuoc.Text = row.Cells["MaThuoc"].Value?.ToString();
                txtTenThuoc.Text = row.Cells["TenThuoc"].Value?.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString();
                txtCachDung.Text = row.Cells["CachDung"].Value?.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThuocDTO dto = new ThuocDTO
            {
                TenThuoc = txtTenThuoc.Text,
                DonViTinh = txtDonViTinh.Text,
                DonGia = decimal.TryParse(txtDonGia.Text, out decimal dg) ? dg : 0,
                SoLuong = int.TryParse(txtSoLuongTon.Text, out int sl) ? sl : 0,
                CachDung = txtCachDung.Text
            };

            if (controller.ThemThuoc(dto))
            {
                MessageBox.Show("Thêm thành công!");
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại thông tin.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn một Thuốc để sửa.");
                return;
            }

            ThuocDTO dto = new ThuocDTO
            {
                MaThuoc = int.Parse(txtMaThuoc.Text),
                TenThuoc = txtTenThuoc.Text,
                DonViTinh = txtDonViTinh.Text,
                DonGia = decimal.TryParse(txtDonGia.Text, out decimal dg) ? dg : 0,
                SoLuong = int.TryParse(txtSoLuongTon.Text, out int sl) ? sl : 0,
                CachDung = txtCachDung.Text
            };

            if (controller.SuaThuoc(dto))
            {
                MessageBox.Show("Sửa thành công!");
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn một Thuốc để xóa.");
                return;
            }

            int id = int.Parse(txtMaThuoc.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaThuoc(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }
    }
}
