using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class ThuocController
    {
        private readonly ThuocRepository repository;

        public ThuocController()
        {
            repository = new ThuocRepository();
        }

        public List<Thuoc> GetAll()
        {
            return repository.GetAll();
        }

        public bool ThemThuoc(ThuocDTO dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.TenThuoc))
                return false;
            return repository.Insert(dto);
        }

        public bool SuaThuoc(ThuocDTO dto)
        {
            if (dto == null || dto.MaThuoc <= 0)
                return false;
            return repository.Update(dto);
        }

        public bool XoaThuoc(int maThuoc)
        {
            if (maThuoc <= 0)
                return false;
            return repository.Delete(maThuoc);
        }
    }
}
