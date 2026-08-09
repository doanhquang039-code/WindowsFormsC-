using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Views
{
    public partial class FrmRegister : Form
    {
        private TaiKhoanController taiKhoanController;

        public FrmRegister()
        {
            InitializeComponent();
            taiKhoanController = new TaiKhoanController();
            cboVaiTro.SelectedIndex = 0;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;
            int role = cboVaiTro.SelectedIndex + 1; // 1: BenhNhan, 2: NhanVien, 3: BacSi

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                return;
            }

            bool result = taiKhoanController.DangKy(username, password, role);
            if (result)
            {
                MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập ngay bây giờ.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Tên đăng nhập có thể đã tồn tại.");
            }
        }
    }
}
