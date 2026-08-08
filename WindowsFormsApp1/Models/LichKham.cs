using System;

namespace WindowsFormsApp1.Models
{
    public class LichKham
    {
        public int MaLichKham { get; set; }

        public int MaBenhNhan { get; set; }

        public int MaBacSi { get; set; }

        public DateTime NgayKham { get; set; }

        public TimeSpan GioKham { get; set; }

        public string TrangThai { get; set; }

        public string LyDoKham { get; set; }
    }
}