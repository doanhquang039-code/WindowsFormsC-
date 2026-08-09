using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class BacSiRepository
    {
        private readonly Database database;

        public BacSiRepository()
        {
            database = new Database();
        }

        public List<BacSi> GetAll()
        {
            List<BacSi> danhSachBacSi = new List<BacSi>();

            string sql = @"
                SELECT
                    MaBacSi,
                    HoTen,
                    SoDienThoai,
                    Email,
                    MaChuyenKhoa,
                    TrangThai
                FROM BacSi";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BacSi bacSi = new BacSi
                        {
                            MaBacSi = Convert.ToInt32(reader["MaBacSi"]),
                            HoTen = reader["HoTen"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            Email = reader["Email"].ToString(),
                            MaChuyenKhoa = Convert.ToInt32(reader["MaChuyenKhoa"]),
                            TrangThai = Convert.ToBoolean(reader["TrangThai"])
                        };

                        danhSachBacSi.Add(bacSi);
                    }
                }
            }

            return danhSachBacSi;
        }

        public bool Insert(BacSiDTO bacSiDTO)
        {
            string sql = @"
                INSERT INTO BacSi
                (
                    HoTen,
                    SoDienThoai,
                    Email,
                    MaChuyenKhoa,
                    TrangThai
                )
                VALUES
                (
                    @HoTen,
                    @SoDienThoai,
                    @Email,
                    @MaChuyenKhoa,
                    1
                )";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@HoTen", bacSiDTO.HoTen);
                command.Parameters.AddWithValue("@SoDienThoai", bacSiDTO.SoDienThoai);
                command.Parameters.AddWithValue("@Email", bacSiDTO.Email);
                command.Parameters.AddWithValue("@MaChuyenKhoa", bacSiDTO.MaChuyenKhoa);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(BacSiDTO bacSiDTO)
        {
            string sql = @"
                UPDATE BacSi
                SET
                    HoTen = @HoTen,
                    SoDienThoai = @SoDienThoai,
                    Email = @Email,
                    MaChuyenKhoa = @MaChuyenKhoa
                WHERE MaBacSi = @MaBacSi";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaBacSi", bacSiDTO.MaBacSi);
                command.Parameters.AddWithValue("@HoTen", bacSiDTO.HoTen);
                command.Parameters.AddWithValue("@SoDienThoai", bacSiDTO.SoDienThoai);
                command.Parameters.AddWithValue("@Email", bacSiDTO.Email);
                command.Parameters.AddWithValue("@MaChuyenKhoa", bacSiDTO.MaChuyenKhoa);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maBacSi)
        {
            string sql = @"
                UPDATE BacSi
                SET TrangThai = 0
                WHERE MaBacSi = @MaBacSi";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaBacSi", maBacSi);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}