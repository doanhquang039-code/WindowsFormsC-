using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class MainForm : Form
    {
        private WindowsFormsApp1.Enums.VaiTro currentRole;

        public MainForm(WindowsFormsApp1.Enums.VaiTro role)
        {
            InitializeComponent();
            currentRole = role;
            ApplyRole(currentRole);
        }

        private void ApplyRole(WindowsFormsApp1.Enums.VaiTro role)
        {
            if (role == WindowsFormsApp1.Enums.VaiTro.BenhNhan)
            {
                mnuBacSi.Visible = false;
                mnuBenhNhan.Visible = false;
                mnuLichKham.Visible = true;
                mnuPhieuKham.Visible = false;
                mnuThuoc.Visible = false;
                mnuChuyenKhoa.Visible = false;
                mnuNhanVien.Visible = false;
                mnuDonThuoc.Visible = false;
                mnuChiTietDonThuoc.Visible = false;
                mnuHoaDon.Visible = false;
            }
            else if (role == WindowsFormsApp1.Enums.VaiTro.NhanVien)
            {
                mnuBacSi.Visible = false;
                mnuBenhNhan.Visible = true;
                mnuLichKham.Visible = true;
                mnuPhieuKham.Visible = false;
                mnuThuoc.Visible = true;
                mnuChuyenKhoa.Visible = true;
                mnuNhanVien.Visible = true;
                mnuDonThuoc.Visible = false;
                mnuChiTietDonThuoc.Visible = false;
                mnuHoaDon.Visible = true;
            }
            else if (role == WindowsFormsApp1.Enums.VaiTro.BacSi)
            {
                mnuBacSi.Visible = false;
                mnuBenhNhan.Visible = true;
                mnuLichKham.Visible = true;
                mnuPhieuKham.Visible = true;
                mnuThuoc.Visible = true;
                mnuChuyenKhoa.Visible = true;
                mnuNhanVien.Visible = false;
                mnuDonThuoc.Visible = true;
                mnuChiTietDonThuoc.Visible = true;
                mnuHoaDon.Visible = false;
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBacSi_Click(object sender, EventArgs e)
        {
            FrmQuanLyBacSi frm = new FrmQuanLyBacSi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBenhNhan_Click(object sender, EventArgs e)
        {
            FrmQuanLyBenhNhan frm = new FrmQuanLyBenhNhan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLichKham_Click(object sender, EventArgs e)
        {
            FrmQuanLyLichKham frm = new FrmQuanLyLichKham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuPhieuKham_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhieuKham frm = new FrmQuanLyPhieuKham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuThuoc_Click(object sender, EventArgs e)
        {
            FrmQuanLyThuoc frm = new FrmQuanLyThuoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuChuyenKhoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyChuyenKhoa frm = new FrmQuanLyChuyenKhoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhanVien frm = new FrmQuanLyNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDonThuoc_Click(object sender, EventArgs e)
        {
            FrmQuanLyDonThuoc frm = new FrmQuanLyDonThuoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuChiTietDonThuoc_Click(object sender, EventArgs e)
        {
            FrmQuanLyChiTietDonThuoc frm = new FrmQuanLyChiTietDonThuoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            FrmQuanLyHoaDon frm = new FrmQuanLyHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
