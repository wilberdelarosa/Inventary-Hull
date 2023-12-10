using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventary_Hull
{
    public partial class prodistribucion0 : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        private SqlConnection connection;
        public prodistribucion0()
        {
            InitializeComponent();
           
        }

        private void prodistribucion0_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            
            // Abrir la conexión a la base de datos
            connection = dbManager.GetConnection();
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }

            // Rellenar el ComboBox con identificadores de producto de la tabla "producto"
            string query = ("select id FROM producto");
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    comboBoxProductIDs.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxProductIDs.Items.Add(reader["id"].ToString());
                    }
                }
                   
            }    
        }

        private void buttonseccionupdate_Click(object sender, EventArgs e)
        {
            
            if (comboBoxProductIDs.SelectedItem != null)
            {
                string selectedProductID = comboBoxProductIDs.SelectedItem.ToString();
                string newSeccionValue = textBoxNewSeccion.Text;

                // Compruebe si el valor de la nueva sección está vacío
                if (string.IsNullOrWhiteSpace(newSeccionValue))
                {
                    MessageBox.Show("Favor elegir una seccion.");
                }
                else
                {

                    // Actualizar la columna "seccion" en la tabla "producto"
                    string updateQuery = "UPDATE producto SET seccion = @newSeccion WHERE id = @productID";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newSeccion", newSeccionValue);
                        command.Parameters.AddWithValue("@productID", selectedProductID);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Seccion Actualizada Con Exito.");

                    // Actualizar el DataGridView para mostrar los datos actualizados
                    RefreshDataGridView();
                }

            }
            else
            {
                MessageBox.Show("por favor seleccione un ID desde el ComboBox.");
            }
        }

        private void RefreshDataGridView()
        {
            // Check if there's already a DataReader open and close it
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            // Retrieve data from the "producto" table
            string query = "SELECT * FROM producto";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Close the database connection when the form is closed
            dbManager.CloseConnection();
            base.OnFormClosing(e);
        }

        private void LoadDataIntoDataGridView()
        {
            string query = "SELECT * FROM producto";
            using (SqlCommand command = new SqlCommand(query, dbManager.GetConnection()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
               
            }
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxProductIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FillProductIDsComboBox();
        }


    }
}
