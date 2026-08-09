using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class ChuyenKhoaController
    {
        private readonly ChuyenKhoaRepository chuyenKhoaRepository;

        public ChuyenKhoaController()
        {
            chuyenKhoaRepository = new ChuyenKhoaRepository();
        }

        // Lấy danh sách chuyên khoa
        public List<ChuyenKhoa> GetAll()
        {
            return chuyenKhoaRepository.GetAll();
        }

        // Lấy chuyên khoa theo mã
        public ChuyenKhoa GetById(int maChuyenKhoa)
        {
            return chuyenKhoaRepository.GetById(maChuyenKhoa);
        }

        // Thêm chuyên khoa
        public bool ThemChuyenKhoa(ChuyenKhoaDTO chuyenKhoaDTO)
        {
            if (chuyenKhoaDTO == null)
                return false;

            if (string.IsNullOrWhiteSpace(
                chuyenKhoaDTO.TenChuyenKhoa))
            {
                return false;
            }

            return chuyenKhoaRepository.Insert(chuyenKhoaDTO);
        }

        // Sửa chuyên khoa
        public bool SuaChuyenKhoa(ChuyenKhoaDTO chuyenKhoaDTO)
        {
            if (chuyenKhoaDTO == null)
                return false;

            if (chuyenKhoaDTO.MaChuyenKhoa <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(
                chuyenKhoaDTO.TenChuyenKhoa))
            {
                return false;
            }

            return chuyenKhoaRepository.Update(chuyenKhoaDTO);
        }

        // Xóa chuyên khoa
        public bool XoaChuyenKhoa(int maChuyenKhoa)
        {
            if (maChuyenKhoa <= 0)
                return false;

            return chuyenKhoaRepository.Delete(maChuyenKhoa);
        }
    }
}