using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace _100stesNeuesProjektWeilNixGeht
{
    class DataClass
    {
        private SQLiteConnection connection;
        private Market market;

        public DataClass(Market market)
        {
            //This part killed me in the beginning.  I was specifying "DataSource"
            //instead of "Data Source"
            //sqlite = new SQLiteConnection("Data Source=database.sqlLite;");
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            connection = new SQLiteConnection(connectionString);
            this.market = market;
            createTable();

        }

        public void login(string id)
        {
            if (isExisting(id))
            {
                
            }

        }
        public bool isExisting(string id)
        {
            string query = "SELECT * FROM users WHERE name LIKE @id";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                // Check if there are any results
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Assume 'name' is a string column; modify as necessary for your schema
                        string name = reader["name"].ToString();
                        return true;
                    }
                }
            }
            return false;
        }
        private void createTable()
        {
            string createTableSql = "CREATE TABLE IF NOT EXISTS users (name TEXT PRIMARY KEY)";
            SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
            try
            {
                connection.Open();
                createTableCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                market.printOut($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public void login()
        {
            string insertSql = "INSERT INTO users (name) VALUES ('name')";

            SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                market.printOut("Table created and data inserted!");
            }
            catch (Exception ex)
            {
                market.printOut($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
