using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class LichKhamController
    {
        private readonly LichKhamRepository repository;

        public LichKhamController()
        {
            repository = new LichKhamRepository();
        }

        public List<LichKham> GetAll()
        {
            return repository.GetAll();
        }

        public bool ThemLichKham(LichKhamDTO dto)
        {
            if (dto == null || dto.MaBenhNhan <= 0 || dto.MaBacSi <= 0)
                return false;
            return repository.Insert(dto);
        }

        public bool SuaLichKham(LichKhamDTO dto)
        {
            if (dto == null || dto.MaLichKham <= 0)
                return false;
            return repository.Update(dto);
        }

        public bool XoaLichKham(int maLichKham)
        {
            if (maLichKham <= 0)
                return false;
            return repository.Delete(maLichKham);
        }
    }
}
