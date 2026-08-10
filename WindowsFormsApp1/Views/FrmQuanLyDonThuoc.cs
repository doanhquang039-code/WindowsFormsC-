using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyDonThuoc : Form
    {
        private DonThuocController controller;

        public FrmQuanLyDonThuoc()
        {
            InitializeComponent();
            controller = new DonThuocController();
        }

        private void FrmQuanLyDonThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvDonThuoc.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaDonThuoc.Clear();
            txtMaPhieuKham.Clear();
            txtNgayKe.Clear();
            txtGhiChu.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonThuoc.Rows[e.RowIndex];
                txtMaDonThuoc.Text = row.Cells["MaDonThuoc"].Value?.ToString();
                txtMaPhieuKham.Text = row.Cells["MaPhieuKham"].Value?.ToString();
                
                var ngayKe = row.Cells["NgayKe"].Value;
                if (ngayKe != null && ngayKe is DateTime dt)
                    txtNgayKe.Text = dt.ToString("yyyy-MM-dd");
                else
                    txtNgayKe.Text = ngayKe?.ToString();

                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtNgayKe.Text, out DateTime dtNgay))
            {
                MessageBox.Show("Ngày kê không hợp lệ (định dạng yyyy-MM-dd).");
                return;
            }

            DonThuocDTO dto = new DonThuocDTO
            {
                MaPhieuKham = int.TryParse(txtMaPhieuKham.Text, out int mpk) ? mpk : 0,
                NgayKe = dtNgay,
                GhiChu = txtGhiChu.Text
            };

            if (controller.ThemDonThuoc(dto))
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
            if (string.IsNullOrEmpty(txtMaDonThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn một Đơn Thuốc để sửa.");
                return;
            }

            if (!DateTime.TryParse(txtNgayKe.Text, out DateTime dtNgay))
            {
                MessageBox.Show("Ngày kê không hợp lệ (định dạng yyyy-MM-dd).");
                return;
            }

            DonThuocDTO dto = new DonThuocDTO
            {
                MaDonThuoc = int.Parse(txtMaDonThuoc.Text),
                MaPhieuKham = int.TryParse(txtMaPhieuKham.Text, out int mpk) ? mpk : 0,
                NgayKe = dtNgay,
                GhiChu = txtGhiChu.Text
            };

            if (controller.SuaDonThuoc(dto))
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
            if (string.IsNullOrEmpty(txtMaDonThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn một Đơn Thuốc để xóa.");
                return;
            }

            int id = int.Parse(txtMaDonThuoc.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn thuốc này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaDonThuoc(id))
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
