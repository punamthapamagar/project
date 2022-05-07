using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public class DBConnection
    {
        public static SqlConnection DBconnect()
        {
            var conn = new SqlConnection();

            //code connectionString = "SERVER= localhost:8000:DATABASE"
            conn.ConnectionString = "Data Source=LAPTOP-RSUFFHAC\\SQLEXPRESS ; Initial Catalog = DbEcontact ; Integrated Security = True ";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }
        public static DataTable GetTableByQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBconnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBconnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
