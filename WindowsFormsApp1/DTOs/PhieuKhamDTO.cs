using System;

namespace WindowsFormsApp1.DTOs
{
    public class PhieuKhamDTO
    {
        public int MaPhieuKham { get; set; }

        public int MaLichKham { get; set; }

        public int MaBenhNhan { get; set; }

        public int MaBacSi { get; set; }

        public DateTime NgayKham { get; set; }

        public string TrieuChung { get; set; }

        public string ChanDoan { get; set; }

        public string KetLuan { get; set; }

        public string GhiChu { get; set; }
    }
}