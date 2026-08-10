using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyChuyenKhoa : Form
    {
        private ChuyenKhoaController controller;

        public FrmQuanLyChuyenKhoa()
        {
            InitializeComponent();
            controller = new ChuyenKhoaController();
        }

        private void FrmQuanLyChuyenKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvChuyenKhoa.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaChuyenKhoa.Clear();
            txtTenChuyenKhoa.Clear();
            txtMoTa.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvChuyenKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChuyenKhoa.Rows[e.RowIndex];
                txtMaChuyenKhoa.Text = row.Cells["MaChuyenKhoa"].Value?.ToString();
                txtTenChuyenKhoa.Text = row.Cells["TenChuyenKhoa"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChuyenKhoaDTO dto = new ChuyenKhoaDTO
            {
                TenChuyenKhoa = txtTenChuyenKhoa.Text,
                MoTa = txtMoTa.Text
            };

            if (controller.ThemChuyenKhoa(dto))
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
            if (string.IsNullOrEmpty(txtMaChuyenKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn một Chuyên Khoa để sửa.");
                return;
            }

            ChuyenKhoaDTO dto = new ChuyenKhoaDTO
            {
                MaChuyenKhoa = int.Parse(txtMaChuyenKhoa.Text),
                TenChuyenKhoa = txtTenChuyenKhoa.Text,
                MoTa = txtMoTa.Text
            };

            if (controller.SuaChuyenKhoa(dto))
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
            if (string.IsNullOrEmpty(txtMaChuyenKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn một Chuyên Khoa để xóa.");
                return;
            }

            int id = int.Parse(txtMaChuyenKhoa.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chuyên khoa này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaChuyenKhoa(id))
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
