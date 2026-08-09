using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class BenhNhanController
    {
        private readonly BenhNhanRepository repository;

        public BenhNhanController()
        {
            repository = new BenhNhanRepository();
        }

        public List<BenhNhanDTO> GetAll()
        {
            return repository.GetAll();
        }

        public bool ThemBenhNhan(BenhNhanDTO benhNhan)
        {
            if (benhNhan == null)
                return false;

            if (string.IsNullOrWhiteSpace(benhNhan.HoTen))
                return false;

            if (string.IsNullOrWhiteSpace(benhNhan.SoDienThoai))
                return false;

            return repository.Insert(benhNhan);
        }

        public bool SuaBenhNhan(BenhNhanDTO benhNhan)
        {
            if (benhNhan == null)
                return false;

            if (benhNhan.MaBenhNhan <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(benhNhan.HoTen))
                return false;

            return repository.Update(benhNhan);
        }

        public bool XoaBenhNhan(int maBenhNhan)
        {
            if (maBenhNhan <= 0)
                return false;

            return repository.Delete(maBenhNhan);
        }
    }
}