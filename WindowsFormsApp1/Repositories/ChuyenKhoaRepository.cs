using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class ChuyenKhoaRepository
    {
        private readonly Database database;

        public ChuyenKhoaRepository()
        {
            database = new Database();
        }

        // Lấy tất cả chuyên khoa
        public List<ChuyenKhoa> GetAll()
        {
            List<ChuyenKhoa> danhSachChuyenKhoa = new List<ChuyenKhoa>();

            string sql = @"
                SELECT 
                    MaChuyenKhoa,
                    TenChuyenKhoa,
                    MoTa
                FROM ChuyenKhoa";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChuyenKhoa chuyenKhoa = new ChuyenKhoa
                        {
                            MaChuyenKhoa = Convert.ToInt32(reader["MaChuyenKhoa"]),
                            TenChuyenKhoa = reader["TenChuyenKhoa"].ToString(),
                            MoTa = reader["MoTa"].ToString()
                        };

                        danhSachChuyenKhoa.Add(chuyenKhoa);
                    }
                }
            }

            return danhSachChuyenKhoa;
        }

        // Lấy chuyên khoa theo mã
        public ChuyenKhoa GetById(int maChuyenKhoa)
        {
            string sql = @"
                SELECT 
                    MaChuyenKhoa,
                    TenChuyenKhoa,
                    MoTa
                FROM ChuyenKhoa
                WHERE MaChuyenKhoa = @MaChuyenKhoa";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue(
                    "@MaChuyenKhoa",
                    maChuyenKhoa
                );

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ChuyenKhoa
                        {
                            MaChuyenKhoa = Convert.ToInt32(
                                reader["MaChuyenKhoa"]
                            ),

                            TenChuyenKhoa = reader["TenChuyenKhoa"].ToString(),

                            MoTa = reader["MoTa"].ToString()
                        };
                    }
                }
            }

            return null;
        }

        // Thêm chuyên khoa
        public bool Insert(ChuyenKhoaDTO chuyenKhoaDTO)
        {
            string sql = @"
                INSERT INTO ChuyenKhoa
                (
                    TenChuyenKhoa,
                    MoTa
                )
                VALUES
                (
                    @TenChuyenKhoa,
                    @MoTa
                )";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue(
                    "@TenChuyenKhoa",
                    chuyenKhoaDTO.TenChuyenKhoa
                );

                command.Parameters.AddWithValue(
                    "@MoTa",
                    chuyenKhoaDTO.MoTa
                );

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật chuyên khoa
        public bool Update(ChuyenKhoaDTO chuyenKhoaDTO)
        {
            string sql = @"
                UPDATE ChuyenKhoa
                SET 
                    TenChuyenKhoa = @TenChuyenKhoa,
                    MoTa = @MoTa
                WHERE MaChuyenKhoa = @MaChuyenKhoa";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue(
                    "@MaChuyenKhoa",
                    chuyenKhoaDTO.MaChuyenKhoa
                );

                command.Parameters.AddWithValue(
                    "@TenChuyenKhoa",
                    chuyenKhoaDTO.TenChuyenKhoa
                );

                command.Parameters.AddWithValue(
                    "@MoTa",
                    chuyenKhoaDTO.MoTa
                );

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        // Xóa chuyên khoa
        public bool Delete(int maChuyenKhoa)
        {
            string sql = @"
                DELETE FROM ChuyenKhoa
                WHERE MaChuyenKhoa = @MaChuyenKhoa";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue(
                    "@MaChuyenKhoa",
                    maChuyenKhoa
                );

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}