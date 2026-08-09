using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Views
{
    public partial class FrmLogin : Form
    {
        private TaiKhoanController taiKhoanController;

        public FrmLogin()
        {
            InitializeComponent();
            taiKhoanController = new TaiKhoanController();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                return;
            }

            var account = taiKhoanController.DangNhap(username, password);
            if (account != null)
            {
                MessageBox.Show($"Đăng nhập thành công! Vai trò: {account.VaiTro}");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
        }
    }
}
