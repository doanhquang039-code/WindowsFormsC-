using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class DonThuocRepository
    {
        private readonly Database database;

        public DonThuocRepository()
        {
            database = new Database();
        }

        public List<DonThuoc> GetAll()
        {
            List<DonThuoc> danhSach = new List<DonThuoc>();
            string sql = @"
                SELECT
                    MaDonThuoc,
                    MaPhieuKham,
                    NgayKe,
                    GhiChu
                FROM DonThuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new DonThuoc
                        {
                            MaDonThuoc = Convert.ToInt32(reader["MaDonThuoc"]),
                            MaPhieuKham = Convert.ToInt32(reader["MaPhieuKham"]),
                            NgayKe = Convert.ToDateTime(reader["NgayKe"]),
                            GhiChu = reader["GhiChu"].ToString()
                        });
                    }
                }
            }
            return danhSach;
        }

        public bool Insert(DonThuocDTO dto)
        {
            string sql = @"
                INSERT INTO DonThuoc (MaPhieuKham, NgayKe, GhiChu)
                VALUES (@MaPhieuKham, @NgayKe, @GhiChu)";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaPhieuKham", dto.MaPhieuKham);
                command.Parameters.AddWithValue("@NgayKe", dto.NgayKe);
                command.Parameters.AddWithValue("@GhiChu", dto.GhiChu ?? (object)DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(DonThuocDTO dto)
        {
            string sql = @"
                UPDATE DonThuoc
                SET MaPhieuKham = @MaPhieuKham,
                    NgayKe = @NgayKe,
                    GhiChu = @GhiChu
                WHERE MaDonThuoc = @MaDonThuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaDonThuoc", dto.MaDonThuoc);
                command.Parameters.AddWithValue("@MaPhieuKham", dto.MaPhieuKham);
                command.Parameters.AddWithValue("@NgayKe", dto.NgayKe);
                command.Parameters.AddWithValue("@GhiChu", dto.GhiChu ?? (object)DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maDonThuoc)
        {
            string sql = "DELETE FROM DonThuoc WHERE MaDonThuoc = @MaDonThuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaDonThuoc", maDonThuoc);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
