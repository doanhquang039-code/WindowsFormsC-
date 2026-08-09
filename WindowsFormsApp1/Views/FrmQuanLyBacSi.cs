using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyBacSi : Form
    {
        private BacSiController controller;

        public FrmQuanLyBacSi()
        {
            InitializeComponent();
            controller = new BacSiController();
        }

        private void FrmQuanLyBacSi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvBacSi.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaBacSi.Clear();
            txtHoTen.Clear();
            txtChuyenKhoa.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBacSi.Rows[e.RowIndex];
                txtMaBacSi.Text = row.Cells["MaBacSi"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtChuyenKhoa.Text = row.Cells["MaChuyenKhoa"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BacSiDTO dto = new BacSiDTO
            {
                HoTen = txtHoTen.Text,
                MaChuyenKhoa = int.TryParse(txtChuyenKhoa.Text, out int mck) ? mck : 0,
                SoDienThoai = txtSoDienThoai.Text,
                Email = txtEmail.Text
            };

            if (controller.ThemBacSi(dto))
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
            if (string.IsNullOrEmpty(txtMaBacSi.Text))
            {
                MessageBox.Show("Vui lòng chọn một Bác sĩ để sửa.");
                return;
            }

            BacSiDTO dto = new BacSiDTO
            {
                MaBacSi = int.Parse(txtMaBacSi.Text),
                HoTen = txtHoTen.Text,
                MaChuyenKhoa = int.TryParse(txtChuyenKhoa.Text, out int mck) ? mck : 0,
                SoDienThoai = txtSoDienThoai.Text,
                Email = txtEmail.Text
            };

            if (controller.SuaBacSi(dto))
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
            if (string.IsNullOrEmpty(txtMaBacSi.Text))
            {
                MessageBox.Show("Vui lòng chọn một Bác sĩ để xóa.");
                return;
            }

            int id = int.Parse(txtMaBacSi.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bác sĩ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaBacSi(id))
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

        private void txtMaBacSi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
