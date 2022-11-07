using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class forgotpass
    {
        public forgotpass()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public forgotpass quenmk(string query)
        {
            forgotpass quenmk = new forgotpass();
            using (SqlConnection sqlConnetion = Connection.GetSqlConnection())
            {
                sqlConnetion.Open();
                sqlCommand = new SqlCommand(query, sqlConnetion);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    dataReader.GetString(2);
                }
                sqlConnetion.Close();
            }

            return quenmk;
        }
    }
}
