﻿using System.Collections.Generic;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<Taikhoan> Taikhoans(string query)
        {
            List<Taikhoan> Taikhoans = new List<Taikhoan>();

            using (SqlConnection sqlConnetion = Connection.GetSqlConnection())
            {
                sqlConnetion.Open();
                sqlCommand = new SqlCommand(query, sqlConnetion);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Taikhoans.Add(new Taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }

                sqlConnetion.Close();
            }

            return Taikhoans;
        }
    }
}
