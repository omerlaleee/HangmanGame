using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _152120181039_HW2.DataAccess
{
    public class DatabaseConnection
    {
        string connectionString = @"Server=OMER;Database=HW2;Trusted_Connection=True";
        SqlConnection connection;

        public SqlConnection openConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}