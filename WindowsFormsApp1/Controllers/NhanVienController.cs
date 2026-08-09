using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class NhanVienController
    {
        private readonly NhanVienRepository nhanVienRepository;

        public NhanVienController()
        {
            nhanVienRepository = new NhanVienRepository();
        }

        public List<NhanVien> GetAll()
        {
            return nhanVienRepository.GetAll();
        }

        public NhanVien GetById(int maNhanVien)
        {
            return nhanVienRepository.GetById(maNhanVien);
        }

        public bool ThemNhanVien(NhanVienDTO nhanVienDTO)
        {
            if (nhanVienDTO == null)
                return false;

            if (string.IsNullOrWhiteSpace(nhanVienDTO.HoTen))
                return false;

            return nhanVienRepository.Insert(nhanVienDTO);
        }

        public bool SuaNhanVien(NhanVienDTO nhanVienDTO)
        {
            if (nhanVienDTO == null)
                return false;

            if (nhanVienDTO.MaNhanVien <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(nhanVienDTO.HoTen))
                return false;

            return nhanVienRepository.Update(nhanVienDTO);
        }

        public bool XoaNhanVien(int maNhanVien)
        {
            if (maNhanVien <= 0)
                return false;

            return nhanVienRepository.Delete(maNhanVien);
        }
    }
}