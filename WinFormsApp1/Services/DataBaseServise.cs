using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1.Services
{
    internal class DataBaseServise
    {
        public bool CreateCommand(string queryString, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            if (connection.State == ConnectionState.Open)
            {
                // закрываем подключение
                connection.Close();
                return true;
            }
            return false;
        }
    }
}
