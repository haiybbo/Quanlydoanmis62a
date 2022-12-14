using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Phanquyen
    {
        public Phanquyen()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<Taikhoan> role(string query)
        {
            List<Taikhoan> role = new List<Taikhoan>();
            using (SqlConnection sqlConnetion = Connection.GetSqlConnection())
            {
                sqlConnetion.Open();
                sqlCommand = new SqlCommand(query, sqlConnetion);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    role.Add(new Taikhoan(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3)));
                }

                sqlConnetion.Close();
            }

            return role; 
        }
    }

}
