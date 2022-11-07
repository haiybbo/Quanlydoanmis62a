using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Quản lý đồ án\quanlydoan\WindowsFormsApp1\banguser.mdf';Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }

}
