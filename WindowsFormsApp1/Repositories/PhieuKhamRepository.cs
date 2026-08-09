using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class PhieuKhamRepository
    {
        private readonly Database database;

        public PhieuKhamRepository()
        {
            database = new Database();
        }

        public List<PhieuKham> GetAll()
        {
            List<PhieuKham> danhSachPhieuKham = new List<PhieuKham>();

            string sql = @"
                SELECT
                    MaPhieuKham,
                    MaLichKham,
                    MaBenhNhan,
                    MaBacSi,
                    TrieuChung,
                    ChanDoan,
                    KetLuan,
                    GhiChu,
                    NgayKham
                FROM PhieuKham";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhieuKham phieuKham = new PhieuKham
                        {
                            MaPhieuKham = Convert.ToInt32(reader["MaPhieuKham"]),
                            MaLichKham = Convert.ToInt32(reader["MaLichKham"]),
                            MaBenhNhan = Convert.ToInt32(reader["MaBenhNhan"]),
                            MaBacSi = Convert.ToInt32(reader["MaBacSi"]),
                            TrieuChung = reader["TrieuChung"].ToString(),
                            ChanDoan = reader["ChanDoan"].ToString(),
                            KetLuan = reader["KetLuan"].ToString(),
                            GhiChu = reader["GhiChu"].ToString(),
                            NgayKham = Convert.ToDateTime(reader["NgayKham"])
                        };

                        danhSachPhieuKham.Add(phieuKham);
                    }
                }
            }

            return danhSachPhieuKham;
        }

        public bool Insert(PhieuKhamDTO phieuKhamDTO)
        {
            string sql = @"
                INSERT INTO PhieuKham
                (
                    MaLichKham,
                    MaBenhNhan,
                    MaBacSi,
                    TrieuChung,
                    ChanDoan,
                    KetLuan,
                    GhiChu,
                    NgayKham
                )
                VALUES
                (
                    @MaLichKham,
                    @MaBenhNhan,
                    @MaBacSi,
                    @TrieuChung,
                    @ChanDoan,
                    @KetLuan,
                    @GhiChu,
                    @NgayKham
                )";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaLichKham", phieuKhamDTO.MaLichKham);
                command.Parameters.AddWithValue("@MaBenhNhan", phieuKhamDTO.MaBenhNhan);
                command.Parameters.AddWithValue("@MaBacSi", phieuKhamDTO.MaBacSi);
                command.Parameters.AddWithValue("@TrieuChung", phieuKhamDTO.TrieuChung);
                command.Parameters.AddWithValue("@ChanDoan", phieuKhamDTO.ChanDoan);
                command.Parameters.AddWithValue("@KetLuan", phieuKhamDTO.KetLuan);
                command.Parameters.AddWithValue("@GhiChu", phieuKhamDTO.GhiChu);
                command.Parameters.AddWithValue("@NgayKham", phieuKhamDTO.NgayKham);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(PhieuKhamDTO phieuKhamDTO)
        {
            string sql = @"
                UPDATE PhieuKham
                SET
                    TrieuChung = @TrieuChung,
                    ChanDoan = @ChanDoan,
                    KetLuan = @KetLuan,
                    GhiChu = @GhiChu
                WHERE MaPhieuKham = @MaPhieuKham";

            using (SqlConnection connection = database.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaPhieuKham", phieuKhamDTO.MaPhieuKham);
                command.Parameters.AddWithValue("@TrieuChung", phieuKhamDTO.TrieuChung);
                command.Parameters.AddWithValue("@ChanDoan", phieuKhamDTO.ChanDoan);
                command.Parameters.AddWithValue("@KetLuan", phieuKhamDTO.KetLuan);
                command.Parameters.AddWithValue("@GhiChu", phieuKhamDTO.GhiChu);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}