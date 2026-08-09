using System;

namespace WindowsFormsApp1.Models
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }

        public int MaBenhNhan { get; set; }

        public int MaPhieuKham { get; set; }

        public DateTime NgayLap { get; set; }

        public decimal TienKham { get; set; }

        public decimal TienThuoc { get; set; }

        public decimal TongTien { get; set; }

        public int TrangThai { get; set; }
    }
}