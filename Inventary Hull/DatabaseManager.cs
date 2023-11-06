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
        private SqlConnection connection; // Este es el objeto de conexión que vamos a usar.

        public DatabaseManager()
        {
            // Asegúrate de que la conexión se instancie aquí.
            connection = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryHall;Integrated Security=True;TrustServerCertificate=true");
        }

        public SqlConnection GetConnection()
        {
            // Verifica si el objeto de conexión es nulo antes de cualquier operación.
            if (connection == null)
            {
                throw new InvalidOperationException("La conexión de base de datos no ha sido inicializada.");
            }

            // Verifica el estado de la conexión antes de intentar abrirla.
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            // Cierra la conexión si está abierta.
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
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
