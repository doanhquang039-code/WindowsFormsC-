using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class BacSiController
    {
        private readonly BacSiRepository bacSiRepository;

        public BacSiController()
        {
            bacSiRepository = new BacSiRepository();
        }

        public List<BacSi> GetAll()
        {
            return bacSiRepository.GetAll();
        }

        public bool ThemBacSi(BacSiDTO bacSiDTO)
        {
            if (bacSiDTO == null)
                return false;

            if (string.IsNullOrWhiteSpace(bacSiDTO.HoTen))
                return false;

            return bacSiRepository.Insert(bacSiDTO);
        }

        public bool SuaBacSi(BacSiDTO bacSiDTO)
        {
            if (bacSiDTO == null || bacSiDTO.MaBacSi <= 0)
                return false;

            return bacSiRepository.Update(bacSiDTO);
        }

        public bool XoaBacSi(int maBacSi)
        {
            if (maBacSi <= 0)
                return false;

            return bacSiRepository.Delete(maBacSi);
        }
    }
}