using _152120181039_HW2.Constants;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _152120181039_HW2.DataAccess
{
    public class DatabaseConnection
    {
        SqlConnection connection;

        public SqlConnection openConnection()
        {
            connection = new SqlConnection(Constant.ConnectionString);
            connection.Open();
            return connection;
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}