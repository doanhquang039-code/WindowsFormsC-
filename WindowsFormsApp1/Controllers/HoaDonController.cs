using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class HoaDonController
    {
        private readonly HoaDonRepository repository;

        public HoaDonController()
        {
            repository = new HoaDonRepository();
        }

        public List<HoaDon> GetAll()
        {
            return repository.GetAll();
        }

        public bool ThemHoaDon(HoaDonDTO dto)
        {
            if (dto == null || dto.MaBenhNhan <= 0 || dto.MaPhieuKham <= 0)
                return false;
            return repository.Insert(dto);
        }

        public bool SuaHoaDon(HoaDonDTO dto)
        {
            if (dto == null || dto.MaHoaDon <= 0)
                return false;
            return repository.Update(dto);
        }

        public bool XoaHoaDon(int maHoaDon)
        {
            if (maHoaDon <= 0)
                return false;
            return repository.Delete(maHoaDon);
        }
    }
}
