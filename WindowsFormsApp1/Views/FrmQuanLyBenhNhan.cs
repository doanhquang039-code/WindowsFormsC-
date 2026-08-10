using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyBenhNhan : Form
    {
        private BenhNhanController controller;

        public FrmQuanLyBenhNhan()
        {
            InitializeComponent();
            controller = new BenhNhanController();
        }

        private void FrmQuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvBenhNhan.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaBenhNhan.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtGioiTinh.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBenhNhan.Rows[e.RowIndex];
                txtMaBenhNhan.Text = row.Cells["MaBenhNhan"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                
                // Format NgaySinh safely
                var ngaySinh = row.Cells["NgaySinh"].Value;
                if (ngaySinh != null && ngaySinh is DateTime dt)
                    txtNgaySinh.Text = dt.ToString("yyyy-MM-dd");
                else
                    txtNgaySinh.Text = ngaySinh?.ToString();

                txtGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BenhNhanDTO dto = new BenhNhanDTO
            {
                HoTen = txtHoTen.Text,
                NgaySinh = txtNgaySinh.Text,
                GioiTinh = txtGioiTinh.Text,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text
            };

            if (controller.ThemBenhNhan(dto))
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
            if (string.IsNullOrEmpty(txtMaBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng chọn một Bệnh nhân để sửa.");
                return;
            }

            BenhNhanDTO dto = new BenhNhanDTO
            {
                MaBenhNhan = int.Parse(txtMaBenhNhan.Text),
                HoTen = txtHoTen.Text,
                NgaySinh = txtNgaySinh.Text,
                GioiTinh = txtGioiTinh.Text,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text
            };

            if (controller.SuaBenhNhan(dto))
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
            if (string.IsNullOrEmpty(txtMaBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng chọn một Bệnh nhân để xóa.");
                return;
            }

            int id = int.Parse(txtMaBenhNhan.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaBenhNhan(id))
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
