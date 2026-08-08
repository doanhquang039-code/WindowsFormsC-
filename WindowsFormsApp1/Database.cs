using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class Database
    {
        private readonly string connectionString;

        public Database()
        {
            connectionString =
                ConfigurationManager
                .ConnectionStrings["QuanLyPhongKham"]
                .ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}