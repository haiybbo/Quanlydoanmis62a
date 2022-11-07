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
        public Phanquyen role(string query)
        {
            Phanquyen role = new Phanquyen();
            using (SqlConnection sqlConnetion = Connection.GetSqlConnection())
            {
                sqlConnetion.Open();
                sqlCommand = new SqlCommand(query, sqlConnetion);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    dataReader.GetString(3);
                }
                sqlConnetion.Close();
            }

            return role;
        }
    }

}
