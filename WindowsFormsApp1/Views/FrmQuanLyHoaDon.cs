using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyHoaDon : Form
    {
        private HoaDonController controller;

        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
            controller = new HoaDonController();
        }

        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvHoaDon.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaHoaDon.Clear();
            txtMaBenhNhan.Clear();
            txtMaPhieuKham.Clear();
            txtNgayLap.Clear();
            txtTienKham.Clear();
            txtTienThuoc.Clear();
            txtTongTien.Clear();
            txtTrangThai.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells["MaHoaDon"].Value?.ToString();
                txtMaBenhNhan.Text = row.Cells["MaBenhNhan"].Value?.ToString();
                txtMaPhieuKham.Text = row.Cells["MaPhieuKham"].Value?.ToString();
                
                var ngayLap = row.Cells["NgayLap"].Value;
                if (ngayLap != null && ngayLap is DateTime dt)
                    txtNgayLap.Text = dt.ToString("yyyy-MM-dd");
                else
                    txtNgayLap.Text = ngayLap?.ToString();

                txtTienKham.Text = row.Cells["TienKham"].Value?.ToString();
                txtTienThuoc.Text = row.Cells["TienThuoc"].Value?.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value?.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtNgayLap.Text, out DateTime dtNgay))
            {
                MessageBox.Show("Ngày lập không hợp lệ (định dạng yyyy-MM-dd).");
                return;
            }

            HoaDonDTO dto = new HoaDonDTO
            {
                MaBenhNhan = int.TryParse(txtMaBenhNhan.Text, out int mbn) ? mbn : 0,
                MaPhieuKham = int.TryParse(txtMaPhieuKham.Text, out int mpk) ? mpk : 0,
                NgayLap = dtNgay,
                TienKham = decimal.TryParse(txtTienKham.Text, out decimal tk) ? tk : 0,
                TienThuoc = decimal.TryParse(txtTienThuoc.Text, out decimal tt) ? tt : 0,
                TongTien = decimal.TryParse(txtTongTien.Text, out decimal tong) ? tong : 0,
                TrangThai = int.TryParse(txtTrangThai.Text, out int trt) ? trt : 1
            };

            if (controller.ThemHoaDon(dto))
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
            if (string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                MessageBox.Show("Vui lòng chọn một Hóa đơn để sửa.");
                return;
            }

            if (!DateTime.TryParse(txtNgayLap.Text, out DateTime dtNgay))
            {
                MessageBox.Show("Ngày lập không hợp lệ (định dạng yyyy-MM-dd).");
                return;
            }

            HoaDonDTO dto = new HoaDonDTO
            {
                MaHoaDon = int.Parse(txtMaHoaDon.Text),
                MaBenhNhan = int.TryParse(txtMaBenhNhan.Text, out int mbn) ? mbn : 0,
                MaPhieuKham = int.TryParse(txtMaPhieuKham.Text, out int mpk) ? mpk : 0,
                NgayLap = dtNgay,
                TienKham = decimal.TryParse(txtTienKham.Text, out decimal tk) ? tk : 0,
                TienThuoc = decimal.TryParse(txtTienThuoc.Text, out decimal tt) ? tt : 0,
                TongTien = decimal.TryParse(txtTongTien.Text, out decimal tong) ? tong : 0,
                TrangThai = int.TryParse(txtTrangThai.Text, out int trt) ? trt : 1
            };

            if (controller.SuaHoaDon(dto))
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
            if (string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                MessageBox.Show("Vui lòng chọn một Hóa đơn để xóa.");
                return;
            }

            int id = int.Parse(txtMaHoaDon.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaHoaDon(id))
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
