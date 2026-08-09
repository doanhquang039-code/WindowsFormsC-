using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.DTOs
{
    public class TaiKhoanDTO
    {
        public int MaTaiKhoan { get; set; }

        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }

        public VaiTro VaiTro { get; set; }

        public bool TrangThai { get; set; }
    }
}