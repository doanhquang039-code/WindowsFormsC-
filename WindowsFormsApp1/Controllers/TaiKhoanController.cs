using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class TaiKhoanController
    {
        private readonly TaiKhoanRepository repository;

        public TaiKhoanController()
        {
            repository = new TaiKhoanRepository();
        }

        public TaiKhoanDTO DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                return null;

            if (string.IsNullOrWhiteSpace(matKhau))
                return null;

            return repository.DangNhap(tenDangNhap, matKhau);
        }
    }
}