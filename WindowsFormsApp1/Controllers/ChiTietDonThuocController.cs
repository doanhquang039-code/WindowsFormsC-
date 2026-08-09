using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class ChiTietDonThuocController
    {
        private readonly ChiTietDonThuocRepository repository;

        public ChiTietDonThuocController()
        {
            repository = new ChiTietDonThuocRepository();
        }

        public List<ChiTietDonThuoc> GetAll()
        {
            return repository.GetAll();
        }

        public bool ThemChiTiet(ChiTietDonThuocDTO dto)
        {
            if (dto == null || dto.MaDonThuoc <= 0 || dto.MaThuoc <= 0)
                return false;
            return repository.Insert(dto);
        }

        public bool SuaChiTiet(ChiTietDonThuocDTO dto)
        {
            if (dto == null || dto.MaDonThuoc <= 0 || dto.MaThuoc <= 0)
                return false;
            return repository.Update(dto);
        }

        public bool XoaChiTiet(int maDonThuoc, int maThuoc)
        {
            if (maDonThuoc <= 0 || maThuoc <= 0)
                return false;
            return repository.Delete(maDonThuoc, maThuoc);
        }
    }
}
