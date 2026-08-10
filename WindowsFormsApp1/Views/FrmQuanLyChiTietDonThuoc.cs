using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyChiTietDonThuoc : Form
    {
        private ChiTietDonThuocController controller;

        public FrmQuanLyChiTietDonThuoc()
        {
            InitializeComponent();
            controller = new ChiTietDonThuocController();
        }

        private void FrmQuanLyChiTietDonThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvChiTiet.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaDonThuoc.Clear();
            txtMaThuoc.Clear();
            txtSoLuong.Clear();
            txtLieuDung.Clear();
            txtCachDung.Clear();
            txtDonGia.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];
                txtMaDonThuoc.Text = row.Cells["MaDonThuoc"].Value?.ToString();
                txtMaThuoc.Text = row.Cells["MaThuoc"].Value?.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
                txtLieuDung.Text = row.Cells["LieuDung"].Value?.ToString();
                txtCachDung.Text = row.Cells["CachDung"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietDonThuocDTO dto = new ChiTietDonThuocDTO
            {
                MaDonThuoc = int.TryParse(txtMaDonThuoc.Text, out int mdt) ? mdt : 0,
                MaThuoc = int.TryParse(txtMaThuoc.Text, out int mt) ? mt : 0,
                SoLuong = int.TryParse(txtSoLuong.Text, out int sl) ? sl : 0,
                LieuDung = txtLieuDung.Text,
                CachDung = txtCachDung.Text,
                DonGia = decimal.TryParse(txtDonGia.Text, out decimal dg) ? dg : 0
            };

            if (controller.ThemChiTiet(dto))
            {
                MessageBox.Show("Thêm thành công!");
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra mã đơn thuốc và mã thuốc.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDonThuoc.Text) || string.IsNullOrEmpty(txtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn một Chi tiết để sửa.");
                return;
            }

            ChiTietDonThuocDTO dto = new ChiTietDonThuocDTO
            {
                MaDonThuoc = int.Parse(txtMaDonThuoc.Text),
                MaThuoc = int.Parse(txtMaThuoc.Text),
                SoLuong = int.TryParse(txtSoLuong.Text, out int sl) ? sl : 0,
                LieuDung = txtLieuDung.Text,
                CachDung = txtCachDung.Text,
                DonGia = decimal.TryParse(txtDonGia.Text, out decimal dg) ? dg : 0
            };

            if (controller.SuaChiTiet(dto))
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
            if (string.IsNullOrEmpty(txtMaDonThuoc.Text) || string.IsNullOrEmpty(txtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn một Chi tiết để xóa.");
                return;
            }

            int mdt = int.Parse(txtMaDonThuoc.Text);
            int mt = int.Parse(txtMaThuoc.Text);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.XoaChiTiet(mdt, mt))
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
