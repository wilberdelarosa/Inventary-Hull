using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Inventary_Hull
{
    public class DatabaseManager
    {
        private  sqlConnection connection 
        public DatabaseManager()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryHall"].ConnectionString;
            connection = new SqlConnection(connectionString);

        }

        public SqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlCommand command = new SqlCommand(query, GetConnection()))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
