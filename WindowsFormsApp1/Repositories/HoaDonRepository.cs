using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class HoaDonRepository
    {
        private readonly Database database;

        public HoaDonRepository()
        {
            database = new Database();
        }

        public List<HoaDon> GetAll()
        {
            List<HoaDon> danhSach = new List<HoaDon>();
            string sql = @"
                SELECT
                    MaHoaDon,
                    MaBenhNhan,
                    MaPhieuKham,
                    NgayLap,
                    TienKham,
                    TienThuoc,
                    TongTien,
                    TrangThai
                FROM HoaDon";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new HoaDon
                        {
                            MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
                            MaBenhNhan = Convert.ToInt32(reader["MaBenhNhan"]),
                            MaPhieuKham = Convert.ToInt32(reader["MaPhieuKham"]),
                            NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                            TienKham = Convert.ToDecimal(reader["TienKham"]),
                            TienThuoc = Convert.ToDecimal(reader["TienThuoc"]),
                            TongTien = Convert.ToDecimal(reader["TongTien"]),
                            TrangThai = Convert.ToInt32(reader["TrangThai"])
                        });
                    }
                }
            }
            return danhSach;
        }

        public bool Insert(HoaDonDTO dto)
        {
            string sql = @"
                INSERT INTO HoaDon (MaBenhNhan, MaPhieuKham, NgayLap, TienKham, TienThuoc, TongTien, TrangThai)
                VALUES (@MaBenhNhan, @MaPhieuKham, @NgayLap, @TienKham, @TienThuoc, @TongTien, @TrangThai)";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaBenhNhan", dto.MaBenhNhan);
                command.Parameters.AddWithValue("@MaPhieuKham", dto.MaPhieuKham);
                command.Parameters.AddWithValue("@NgayLap", dto.NgayLap);
                command.Parameters.AddWithValue("@TienKham", dto.TienKham);
                command.Parameters.AddWithValue("@TienThuoc", dto.TienThuoc);
                command.Parameters.AddWithValue("@TongTien", dto.TongTien);
                command.Parameters.AddWithValue("@TrangThai", dto.TrangThai);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(HoaDonDTO dto)
        {
            string sql = @"
                UPDATE HoaDon
                SET MaBenhNhan = @MaBenhNhan,
                    MaPhieuKham = @MaPhieuKham,
                    NgayLap = @NgayLap,
                    TienKham = @TienKham,
                    TienThuoc = @TienThuoc,
                    TongTien = @TongTien,
                    TrangThai = @TrangThai
                WHERE MaHoaDon = @MaHoaDon";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaHoaDon", dto.MaHoaDon);
                command.Parameters.AddWithValue("@MaBenhNhan", dto.MaBenhNhan);
                command.Parameters.AddWithValue("@MaPhieuKham", dto.MaPhieuKham);
                command.Parameters.AddWithValue("@NgayLap", dto.NgayLap);
                command.Parameters.AddWithValue("@TienKham", dto.TienKham);
                command.Parameters.AddWithValue("@TienThuoc", dto.TienThuoc);
                command.Parameters.AddWithValue("@TongTien", dto.TongTien);
                command.Parameters.AddWithValue("@TrangThai", dto.TrangThai);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maHoaDon)
        {
            string sql = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
