using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyLichKham : Form
    {
        private LichKhamController controller;

        public FrmQuanLyLichKham()
        {
            InitializeComponent();
            controller = new LichKhamController();
        }

        private void FrmQuanLyLichKham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvLichKham.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaLichKham.Clear();
            txtMaBenhNhan.Clear();
            txtMaBacSi.Clear();
            txtNgayKham.Clear();
            txtLyDoKham.Clear();
            txtTrangThai.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvLichKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLichKham.Rows[e.RowIndex];
                txtMaLichKham.Text = row.Cells["MaLichKham"].Value?.ToString();
                txtMaBenhNhan.Text = row.Cells["MaBenhNhan"].Value?.ToString();
                txtMaBacSi.Text = row.Cells["MaBacSi"].Value?.ToString();
                
                var ngayKham = row.Cells["NgayKham"].Value;
                if (ngayKham != null && ngayKham is DateTime dt)
                    txtNgayKham.Text = dt.ToString("yyyy-MM-dd");
                else
                    txtNgayKham.Text = ngayKham?.ToString();

                txtLyDoKham.Text = row.Cells["LyDoKham"].Value?.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtNgayKham.Text, out DateTime dtNgay))
            {
                MessageBox.Show("Ngày khám không hợp lệ (định dạng yyyy-MM-dd).");
                return;
            }

            LichKhamDTO dto = new LichKhamDTO
            {
                MaBenhNhan = int.TryParse(txtMaBenhNhan.Text, out int mbn) ? mbn : 0,
                MaBacSi = int.TryParse(txtMaBacSi.Text, out int mbs) ? mbs : 0,
                NgayKham = dtNgay,
                LyDoKham = txtLyDoKham.Text,
                TrangThai = int.TryParse(txtTrangThai.Text, out int tt) ? tt : 1
            };

            if (controller.ThemLichKham(dto))
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
            if (string.IsNullOrEmpty(txtMaLichKham.Text))
            {
                MessageBox.Show("Vui lòng chọn một Lịch khám để sửa.");
                return;
            }

            if (!DateTime.TryParse(txtNgayKham.Text, out DateTime dtNgay))
            {
                MessageBox.Show("Ngày khám không hợp lệ (định dạng yyyy-MM-dd).");
                return;
            }

            LichKhamDTO dto = new LichKhamDTO
            {
                MaLichKham = int.Parse(txtMaLichKham.Text),
                MaBenhNhan = int.TryParse(txtMaBenhNhan.Text, out int mbn) ? mbn : 0,
                MaBacSi = int.TryParse(txtMaBacSi.Text, out int mbs) ? mbs : 0,
                NgayKham = dtNgay,
                LyDoKham = txtLyDoKham.Text,
                TrangThai = int.TryParse(txtTrangThai.Text, out int tt) ? tt : 1
            };

            if (controller.SuaLichKham(dto))
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
            if (string.IsNullOrEmpty(txtMaLichKham.Text))
            {
                MessageBox.Show("Vui lòng chọn một Lịch khám để xóa.");
                return;
            }

            int id = int.Parse(txtMaLichKham.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch khám này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaLichKham(id))
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
