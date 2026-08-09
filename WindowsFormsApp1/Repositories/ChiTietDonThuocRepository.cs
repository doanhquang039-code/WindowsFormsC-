using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class ChiTietDonThuocRepository
    {
        private readonly Database database;

        public ChiTietDonThuocRepository()
        {
            database = new Database();
        }

        public List<ChiTietDonThuoc> GetAll()
        {
            List<ChiTietDonThuoc> danhSach = new List<ChiTietDonThuoc>();
            string sql = @"
                SELECT
                    MaDonThuoc,
                    MaThuoc,
                    SoLuong,
                    LieuDung,
                    CachDung,
                    DonGia
                FROM ChiTietDonThuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new ChiTietDonThuoc
                        {
                            MaDonThuoc = Convert.ToInt32(reader["MaDonThuoc"]),
                            MaThuoc = Convert.ToInt32(reader["MaThuoc"]),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            LieuDung = reader["LieuDung"].ToString(),
                            CachDung = reader["CachDung"].ToString(),
                            DonGia = Convert.ToDecimal(reader["DonGia"])
                        });
                    }
                }
            }
            return danhSach;
        }

        public bool Insert(ChiTietDonThuocDTO dto)
        {
            string sql = @"
                INSERT INTO ChiTietDonThuoc
                (MaDonThuoc, MaThuoc, SoLuong, LieuDung, CachDung, DonGia)
                VALUES
                (@MaDonThuoc, @MaThuoc, @SoLuong, @LieuDung, @CachDung, @DonGia)";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaDonThuoc", dto.MaDonThuoc);
                command.Parameters.AddWithValue("@MaThuoc", dto.MaThuoc);
                command.Parameters.AddWithValue("@SoLuong", dto.SoLuong);
                command.Parameters.AddWithValue("@LieuDung", dto.LieuDung ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CachDung", dto.CachDung ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DonGia", dto.DonGia);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(ChiTietDonThuocDTO dto)
        {
            string sql = @"
                UPDATE ChiTietDonThuoc
                SET
                    SoLuong = @SoLuong,
                    LieuDung = @LieuDung,
                    CachDung = @CachDung,
                    DonGia = @DonGia
                WHERE MaDonThuoc = @MaDonThuoc AND MaThuoc = @MaThuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaDonThuoc", dto.MaDonThuoc);
                command.Parameters.AddWithValue("@MaThuoc", dto.MaThuoc);
                command.Parameters.AddWithValue("@SoLuong", dto.SoLuong);
                command.Parameters.AddWithValue("@LieuDung", dto.LieuDung ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CachDung", dto.CachDung ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DonGia", dto.DonGia);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maDonThuoc, int maThuoc)
        {
            string sql = "DELETE FROM ChiTietDonThuoc WHERE MaDonThuoc = @MaDonThuoc AND MaThuoc = @MaThuoc";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaDonThuoc", maDonThuoc);
                command.Parameters.AddWithValue("@MaThuoc", maThuoc);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
