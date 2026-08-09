using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class NhanVienRepository
    {
        private readonly Database database;

        public NhanVienRepository()
        {
            database = new Database();
        }

        public List<NhanVien> GetAll()
        {
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            string sql = @"
                SELECT
                    MaNhanVien,
                    HoTen,
                    SoDienThoai,
                    Email,
                    ChucVu,
                    TrangThai
                FROM NhanVien";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NhanVien nhanVien = new NhanVien
                        {
                            MaNhanVien = Convert.ToInt32(
                                reader["MaNhanVien"]
                            ),

                            HoTen = reader["HoTen"].ToString(),

                            SoDienThoai = reader["SoDienThoai"].ToString(),

                            Email = reader["Email"].ToString(),

                            ChucVu = reader["ChucVu"].ToString(),

                            TrangThai = Convert.ToBoolean(
                                reader["TrangThai"]
                            )
                        };

                        danhSachNhanVien.Add(nhanVien);
                    }
                }
            }

            return danhSachNhanVien;
        }

        public NhanVien GetById(int maNhanVien)
        {
            string sql = @"
                SELECT
                    MaNhanVien,
                    HoTen,
                    SoDienThoai,
                    Email,
                    ChucVu,
                    TrangThai
                FROM NhanVien
                WHERE MaNhanVien = @MaNhanVien";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue(
                    "@MaNhanVien",
                    maNhanVien
                );

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new NhanVien
                        {
                            MaNhanVien = Convert.ToInt32(
                                reader["MaNhanVien"]
                            ),

                            HoTen = reader["HoTen"].ToString(),

                            SoDienThoai = reader["SoDienThoai"].ToString(),

                            Email = reader["Email"].ToString(),

                            ChucVu = reader["ChucVu"].ToString(),

                            TrangThai = Convert.ToBoolean(
                                reader["TrangThai"]
                            )
                        };
                    }
                }
            }

            return null;
        }

        public bool Insert(NhanVienDTO nhanVienDTO)
        {
            string sql = @"
                INSERT INTO NhanVien
                (
                    HoTen,
                    SoDienThoai,
                    Email,
                    ChucVu,
                    TrangThai
                )
                VALUES
                (
                    @HoTen,
                    @SoDienThoai,
                    @Email,
                    @ChucVu,
                    1
                )";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue(
                    "@HoTen",
                    nhanVienDTO.HoTen
                );

                command.Parameters.AddWithValue(
                    "@SoDienThoai",
                    nhanVienDTO.SoDienThoai
                );

                command.Parameters.AddWithValue(
                    "@Email",
                    nhanVienDTO.Email
                );

                command.Parameters.AddWithValue(
                    "@ChucVu",
                    nhanVienDTO.ChucVu
                );

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(NhanVienDTO nhanVienDTO)
        {
            string sql = @"
                UPDATE NhanVien
                SET
                    HoTen = @HoTen,
                    SoDienThoai = @SoDienThoai,
                    Email = @Email,
                    ChucVu = @ChucVu
                WHERE MaNhanVien = @MaNhanVien";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue(
                    "@MaNhanVien",
                    nhanVienDTO.MaNhanVien
                );

                command.Parameters.AddWithValue(
                    "@HoTen",
                    nhanVienDTO.HoTen
                );

                command.Parameters.AddWithValue(
                    "@SoDienThoai",
                    nhanVienDTO.SoDienThoai
                );

                command.Parameters.AddWithValue(
                    "@Email",
                    nhanVienDTO.Email
                );

                command.Parameters.AddWithValue(
                    "@ChucVu",
                    nhanVienDTO.ChucVu
                );

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maNhanVien)
        {
            string sql = @"
                UPDATE NhanVien
                SET TrangThai = 0
                WHERE MaNhanVien = @MaNhanVien";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue(
                    "@MaNhanVien",
                    maNhanVien
                );

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}