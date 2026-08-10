using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private NhanVienController controller;

        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            controller = new NhanVienController();
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvNhanVien.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtChucVu.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVienDTO dto = new NhanVienDTO
            {
                HoTen = txtHoTen.Text,
                SoDienThoai = txtSoDienThoai.Text,
                Email = txtEmail.Text,
                ChucVu = txtChucVu.Text
            };

            if (controller.ThemNhanVien(dto))
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
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn một Nhân Viên để sửa.");
                return;
            }

            NhanVienDTO dto = new NhanVienDTO
            {
                MaNhanVien = int.Parse(txtMaNhanVien.Text),
                HoTen = txtHoTen.Text,
                SoDienThoai = txtSoDienThoai.Text,
                Email = txtEmail.Text,
                ChucVu = txtChucVu.Text
            };

            if (controller.SuaNhanVien(dto))
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
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn một Nhân Viên để xóa.");
                return;
            }

            int id = int.Parse(txtMaNhanVien.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaNhanVien(id))
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
