using System.Collections.Generic;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    public class PhieuKhamController
    {
        private readonly PhieuKhamRepository phieuKhamRepository;

        public PhieuKhamController()
        {
            phieuKhamRepository = new PhieuKhamRepository();
        }

        public List<PhieuKham> GetAll()
        {
            return phieuKhamRepository.GetAll();
        }

        public bool TaoPhieuKham(PhieuKhamDTO phieuKhamDTO)
        {
            if (phieuKhamDTO == null)
                return false;

            if (phieuKhamDTO.MaLichKham <= 0)
                return false;

            if (phieuKhamDTO.MaBenhNhan <= 0)
                return false;

            if (phieuKhamDTO.MaBacSi <= 0)
                return false;

            return phieuKhamRepository.Insert(phieuKhamDTO);
        }

        public bool SuaPhieuKham(PhieuKhamDTO phieuKhamDTO)
        {
            if (phieuKhamDTO == null)
                return false;

            if (phieuKhamDTO.MaPhieuKham <= 0)
                return false;

            return phieuKhamRepository.Update(phieuKhamDTO);
        }
    }
}