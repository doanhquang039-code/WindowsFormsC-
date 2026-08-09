using System;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Repositories
{
    public class TaiKhoanRepository
    {
        private readonly Database database;

        public TaiKhoanRepository()
        {
            database = new Database();
        }

        public TaiKhoanDTO DangNhap(string tenDangNhap, string matKhau)
        {
            string sql = @"
                SELECT 
                    MaTaiKhoan,
                    TenDangNhap,
                    MatKhau,
                    VaiTro,
                    TrangThai
                FROM TaiKhoan
                WHERE TenDangNhap = @TenDangNhap
                  AND MatKhau = @MatKhau
                  AND TrangThai = 1";

            using (SqlConnection conn = database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new TaiKhoanDTO
                        {
                            MaTaiKhoan = Convert.ToInt32(reader["MaTaiKhoan"]),
                            TenDangNhap = reader["TenDangNhap"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            VaiTro = (Enums.VaiTro)Convert.ToInt32(reader["VaiTro"]),
                            TrangThai = Convert.ToBoolean(reader["TrangThai"])
                        };
                    }
                }
            }

            return null;
        }
    }
}