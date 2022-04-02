using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _152120181039_HW2.DataAccess
{
    public class DatabaseManager
    {
        DatabaseConnection databaseConnection;
        public DatabaseManager(DatabaseConnection _databaseConnection)
        {
            databaseConnection = _databaseConnection;
        }
        public List<string> GetAll()
        {
            List<string> allWords = new List<string>();
            string commnadString = "Select * from Words";
            SqlCommand command = new SqlCommand(commnadString, databaseConnection.openConnection());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                allWords.Add(dataReader.GetValue(1).ToString());
            }
            databaseConnection.closeConnection();
            return allWords;
        }

        public List<int> IdsOfWords()
        {
            List<int> allIdsOfWords = new List<int>();
            string commnadString = "Select * from Words";
            SqlCommand command = new SqlCommand(commnadString, databaseConnection.openConnection());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                allIdsOfWords.Add(Int32.Parse(dataReader.GetValue(0).ToString()));
            }
            databaseConnection.closeConnection();
            return allIdsOfWords;
        }

        public string FindWordById(int id)
        {
            List<int> allIdsOfWords = IdsOfWords();
            List<string> allWords = GetAll();
            for(int i = 0; i < allIdsOfWords.Count; i++)
            {
                if (id == allIdsOfWords[i])
                {
                    return allWords[i];
                }
            }
            return null;
        }

        public void Add(string wordName, string hintName)
        {
            databaseConnection.openConnection();
            String commnadString = "INSERT INTO Words (Word, Hint) Values (@wordName, @hintName)";
            SqlCommand command = new SqlCommand(commnadString, databaseConnection.openConnection());
            command.Parameters.AddWithValue("@wordName", wordName);
            command.Parameters.AddWithValue("@hintName", hintName);
            command.ExecuteNonQuery();
            databaseConnection.closeConnection();
        }

        public void Delete(string wordName)
        {
            databaseConnection.openConnection();
            String commnadString = "Delete from Words where Word = '" + wordName + "'";
            SqlCommand command = new SqlCommand(commnadString, databaseConnection.openConnection());
            command.ExecuteNonQuery();
            databaseConnection.closeConnection();
        }
    }
}