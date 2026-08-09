using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Repositories
{
    public class BenhNhanRepository
    {
        private readonly Database database;

        public BenhNhanRepository()
        {
            database = new Database();
        }

        // Lấy danh sách
        public List<BenhNhanDTO> GetAll()
        {
            List<BenhNhanDTO> list = new List<BenhNhanDTO>();

            string sql = @"
                SELECT 
                    MaBenhNhan,
                    HoTen,
                    NgaySinh,
                    GioiTinh,
                    SoDienThoai,
                    DiaChi,
                    Email
                FROM BenhNhan
                ORDER BY MaBenhNhan DESC";

            using (SqlConnection conn = database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BenhNhanDTO
                        {
                            MaBenhNhan = Convert.ToInt32(reader["MaBenhNhan"]),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = reader["NgaySinh"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        // Thêm
        public bool Insert(BenhNhanDTO benhNhan)
        {
            string sql = @"
                INSERT INTO BenhNhan
                (
                    HoTen,
                    NgaySinh,
                    GioiTinh,
                    SoDienThoai,
                    DiaChi,
                    Email
                )
                VALUES
                (
                    @HoTen,
                    @NgaySinh,
                    @GioiTinh,
                    @SoDienThoai,
                    @DiaChi,
                    @Email
                )";

            using (SqlConnection conn = database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@HoTen", benhNhan.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", benhNhan.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", benhNhan.GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", benhNhan.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", benhNhan.DiaChi);
                cmd.Parameters.AddWithValue("@Email", benhNhan.Email);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa
        public bool Update(BenhNhanDTO benhNhan)
        {
            string sql = @"
                UPDATE BenhNhan
                SET
                    HoTen = @HoTen,
                    NgaySinh = @NgaySinh,
                    GioiTinh = @GioiTinh,
                    SoDienThoai = @SoDienThoai,
                    DiaChi = @DiaChi,
                    Email = @Email
                WHERE MaBenhNhan = @MaBenhNhan";

            using (SqlConnection conn = database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaBenhNhan", benhNhan.MaBenhNhan);
                cmd.Parameters.AddWithValue("@HoTen", benhNhan.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", benhNhan.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", benhNhan.GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", benhNhan.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", benhNhan.DiaChi);
                cmd.Parameters.AddWithValue("@Email", benhNhan.Email);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa
        public bool Delete(int maBenhNhan)
        {
            string sql = @"
                DELETE FROM BenhNhan
                WHERE MaBenhNhan = @MaBenhNhan";

            using (SqlConnection conn = database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}