using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Inventary_Hull
{
    public class DatabaseManager
    {

        private SqlConnection connection;
        //private sqlConnection connection 
        public DatabaseManager()
        {
            // Asegúrate de que la conexión se instancie aquí.
            connection = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryHall;Integrated Security=True;TrustServerCertificate=true");
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
            // Cierra la conexión si está abierta.
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
