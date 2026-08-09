using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class DonThuocController
    {
        private readonly DonThuocRepository repository;

        public DonThuocController()
        {
            repository = new DonThuocRepository();
        }

        public List<DonThuoc> GetAll()
        {
            return repository.GetAll();
        }

        public bool ThemDonThuoc(DonThuocDTO dto)
        {
            if (dto == null || dto.MaPhieuKham <= 0)
                return false;
            return repository.Insert(dto);
        }

        public bool SuaDonThuoc(DonThuocDTO dto)
        {
            if (dto == null || dto.MaDonThuoc <= 0)
                return false;
            return repository.Update(dto);
        }

        public bool XoaDonThuoc(int maDonThuoc)
        {
            if (maDonThuoc <= 0)
                return false;
            return repository.Delete(maDonThuoc);
        }
    }
}
