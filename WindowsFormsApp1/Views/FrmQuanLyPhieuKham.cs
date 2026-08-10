using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    public partial class FrmQuanLyPhieuKham : Form
    {
        private PhieuKhamController controller;

        public FrmQuanLyPhieuKham()
        {
            InitializeComponent();
            controller = new PhieuKhamController();
        }

        private void FrmQuanLyPhieuKham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvPhieuKham.DataSource = controller.GetAll();
        }

        private void ClearInputs()
        {
            txtMaPhieuKham.Clear();
            txtMaLichKham.Clear();
            txtMaBenhNhan.Clear();
            txtMaBacSi.Clear();
            txtNgayKham.Clear();
            txtTrieuChung.Clear();
            txtChanDoan.Clear();
            txtKetLuan.Clear();
            txtGhiChu.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void dgvPhieuKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuKham.Rows[e.RowIndex];
                txtMaPhieuKham.Text = row.Cells["MaPhieuKham"].Value?.ToString();
                txtMaLichKham.Text = row.Cells["MaLichKham"].Value?.ToString();
                txtMaBenhNhan.Text = row.Cells["MaBenhNhan"].Value?.ToString();
                txtMaBacSi.Text = row.Cells["MaBacSi"].Value?.ToString();
                
                var ngayKham = row.Cells["NgayKham"].Value;
                if (ngayKham != null && ngayKham is DateTime dt)
                    txtNgayKham.Text = dt.ToString("yyyy-MM-dd");
                else
                    txtNgayKham.Text = ngayKham?.ToString();

                txtTrieuChung.Text = row.Cells["TrieuChung"].Value?.ToString();
                txtChanDoan.Text = row.Cells["ChanDoan"].Value?.ToString();
                txtKetLuan.Text = row.Cells["KetLuan"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtNgayKham.Text, out DateTime dtNgay))
            {
                MessageBox.Show("Ngày khám không hợp lệ (định dạng yyyy-MM-dd).");
                return;
            }

            PhieuKhamDTO dto = new PhieuKhamDTO
            {
                MaLichKham = int.TryParse(txtMaLichKham.Text, out int mlk) ? mlk : 0,
                MaBenhNhan = int.TryParse(txtMaBenhNhan.Text, out int mbn) ? mbn : 0,
                MaBacSi = int.TryParse(txtMaBacSi.Text, out int mbs) ? mbs : 0,
                NgayKham = dtNgay,
                TrieuChung = txtTrieuChung.Text,
                ChanDoan = txtChanDoan.Text,
                KetLuan = txtKetLuan.Text,
                GhiChu = txtGhiChu.Text
            };

            if (controller.TaoPhieuKham(dto))
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
            if (string.IsNullOrEmpty(txtMaPhieuKham.Text))
            {
                MessageBox.Show("Vui lòng chọn một Phiếu khám để sửa.");
                return;
            }

            if (!DateTime.TryParse(txtNgayKham.Text, out DateTime dtNgay))
            {
                MessageBox.Show("Ngày khám không hợp lệ (định dạng yyyy-MM-dd).");
                return;
            }

            PhieuKhamDTO dto = new PhieuKhamDTO
            {
                MaPhieuKham = int.Parse(txtMaPhieuKham.Text),
                MaLichKham = int.TryParse(txtMaLichKham.Text, out int mlk) ? mlk : 0,
                MaBenhNhan = int.TryParse(txtMaBenhNhan.Text, out int mbn) ? mbn : 0,
                MaBacSi = int.TryParse(txtMaBacSi.Text, out int mbs) ? mbs : 0,
                NgayKham = dtNgay,
                TrieuChung = txtTrieuChung.Text,
                ChanDoan = txtChanDoan.Text,
                KetLuan = txtKetLuan.Text,
                GhiChu = txtGhiChu.Text
            };

            if (controller.SuaPhieuKham(dto))
            {
                MessageBox.Show("Sửa thành công!");
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
            }
        }
    }
}
