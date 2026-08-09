using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class ThuocRepository
    {
        private readonly Database database;

        public ThuocRepository()
        {
            database = new Database();
        }

        public List<Thuoc> GetAll()
        {
            List<Thuoc> danhSach = new List<Thuoc>();
            string sql = @"
                SELECT
                    MaThuoc,
                    TenThuoc,
                    DonViTinh,
                    DonGia,
                    SoLuongTon,
                    CachDung,
                    TrangThai
                FROM Thuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new Thuoc
                        {
                            MaThuoc = Convert.ToInt32(reader["MaThuoc"]),
                            TenThuoc = reader["TenThuoc"].ToString(),
                            DonViTinh = reader["DonViTinh"].ToString(),
                            DonGia = Convert.ToDecimal(reader["DonGia"]),
                            SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                            CachDung = reader["CachDung"].ToString(),
                            TrangThai = Convert.ToBoolean(reader["TrangThai"])
                        });
                    }
                }
            }
            return danhSach;
        }

        public bool Insert(ThuocDTO dto)
        {
            string sql = @"
                INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon, CachDung, TrangThai)
                VALUES (@TenThuoc, @DonViTinh, @DonGia, @SoLuongTon, @CachDung, 1)";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@TenThuoc", dto.TenThuoc ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DonViTinh", dto.DonViTinh ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DonGia", dto.DonGia);
                command.Parameters.AddWithValue("@SoLuongTon", dto.SoLuong);
                command.Parameters.AddWithValue("@CachDung", dto.CachDung ?? (object)DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(ThuocDTO dto)
        {
            string sql = @"
                UPDATE Thuoc
                SET TenThuoc = @TenThuoc,
                    DonViTinh = @DonViTinh,
                    DonGia = @DonGia,
                    SoLuongTon = @SoLuongTon,
                    CachDung = @CachDung
                WHERE MaThuoc = @MaThuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaThuoc", dto.MaThuoc);
                command.Parameters.AddWithValue("@TenThuoc", dto.TenThuoc ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DonViTinh", dto.DonViTinh ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DonGia", dto.DonGia);
                command.Parameters.AddWithValue("@SoLuongTon", dto.SoLuong);
                command.Parameters.AddWithValue("@CachDung", dto.CachDung ?? (object)DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maThuoc)
        {
            string sql = "UPDATE Thuoc SET TrangThai = 0 WHERE MaThuoc = @MaThuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaThuoc", maThuoc);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
