using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class LichKhamRepository
    {
        private readonly Database database;

        public LichKhamRepository()
        {
            database = new Database();
        }

        public List<LichKham> GetAll()
        {
            List<LichKham> danhSach = new List<LichKham>();
            string sql = @"
                SELECT
                    MaLichKham,
                    MaBenhNhan,
                    MaBacSi,
                    NgayKham,
                    GioKham,
                    TrangThai,
                    LyDoKham
                FROM LichKham";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new LichKham
                        {
                            MaLichKham = Convert.ToInt32(reader["MaLichKham"]),
                            MaBenhNhan = Convert.ToInt32(reader["MaBenhNhan"]),
                            MaBacSi = Convert.ToInt32(reader["MaBacSi"]),
                            NgayKham = Convert.ToDateTime(reader["NgayKham"]),
                            GioKham = reader["GioKham"] != DBNull.Value ? (TimeSpan)reader["GioKham"] : TimeSpan.Zero,
                            TrangThai = Convert.ToInt32(reader["TrangThai"]),
                            LyDoKham = reader["LyDoKham"].ToString()
                        });
                    }
                }
            }
            return danhSach;
        }

        public bool Insert(LichKhamDTO dto)
        {
            string sql = @"
                INSERT INTO LichKham (MaBenhNhan, MaBacSi, NgayKham, GioKham, TrangThai, LyDoKham)
                VALUES (@MaBenhNhan, @MaBacSi, @NgayKham, @GioKham, @TrangThai, @LyDoKham)";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaBenhNhan", dto.MaBenhNhan);
                command.Parameters.AddWithValue("@MaBacSi", dto.MaBacSi);
                command.Parameters.AddWithValue("@NgayKham", dto.NgayKham);
                command.Parameters.AddWithValue("@GioKham", dto.NgayKham.TimeOfDay);
                command.Parameters.AddWithValue("@TrangThai", dto.TrangThai);
                command.Parameters.AddWithValue("@LyDoKham", dto.LyDoKham ?? (object)DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(LichKhamDTO dto)
        {
            string sql = @"
                UPDATE LichKham
                SET MaBenhNhan = @MaBenhNhan,
                    MaBacSi = @MaBacSi,
                    NgayKham = @NgayKham,
                    GioKham = @GioKham,
                    TrangThai = @TrangThai,
                    LyDoKham = @LyDoKham
                WHERE MaLichKham = @MaLichKham";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaLichKham", dto.MaLichKham);
                command.Parameters.AddWithValue("@MaBenhNhan", dto.MaBenhNhan);
                command.Parameters.AddWithValue("@MaBacSi", dto.MaBacSi);
                command.Parameters.AddWithValue("@NgayKham", dto.NgayKham);
                command.Parameters.AddWithValue("@GioKham", dto.NgayKham.TimeOfDay);
                command.Parameters.AddWithValue("@TrangThai", dto.TrangThai);
                command.Parameters.AddWithValue("@LyDoKham", dto.LyDoKham ?? (object)DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maLichKham)
        {
            string sql = "UPDATE LichKham SET TrangThai = 0 WHERE MaLichKham = @MaLichKham";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaLichKham", maLichKham);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
