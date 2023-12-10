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
using System.Configuration;

namespace Inventary_Hull
{
    public partial class prodistribucion : Form
    {

        private DatabaseManager dbManager;
        private SqlConnection connection;
        public prodistribucion()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();


            //LoadDataIntoDataGridView();

        }

        private void prodistribucion_Load(object sender, EventArgs e)
        {

            // Llenar el DataGridView con datos al cargar el formulario.
            // LoadDataIntoDataGridView();



        }

        private void LoadDataIntoDataGridView()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();

            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM producto"))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            RefreshDataGridView();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }
        private void buttonseccionupdate_Click(object sender, EventArgs e)
        {





        }
        private void RefreshDataGridView()
        {



            string query = "SELECT * FROM producto";
            using (SqlCommand command = new SqlCommand(query, dbManager.GetConnection()))
            {


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Vincular la tabla de datos a la vista DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }


        private void prodistribucion_Load_1(object sender, EventArgs e)
        {
            // Abrir la conexión a la base de datos
            connection = dbManager.GetConnection();

            // Rellenar el ComboBox con identificadores de producto de la tabla "producto"
            string query = ("select id FROM producto");
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProductIDs.Items.Add(reader["id"].ToString());

                }
            }

            // MUESTRA EN PANTALLA EL DataGridView
            LoadDataIntoDataGridView();


        }
        //anterior
        private void buttonseccionupdate_Click_1(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxProductIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT id FROM producto";
            using (SqlCommand command = new SqlCommand(query, dbManager.GetConnection()))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProductIDs.Items.Add(reader["id"].ToString());
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Cerrar la conexión de base de datos cuando se cierra el formulario
            dbManager.CloseConnection();
            base.OnFormClosing(e);
        }
        //TODO BTN ACTUALIZAR
        private void buttonseccionupdate_Click_(object sender, EventArgs e)
        {


            UpdateProductSection();


        }
        //TODO METODO 
        private void UpdateProductSection()
        {
            if (comboBoxProductIDs.SelectedItem != null)
            {
                string selectedProductID = comboBoxProductIDs.SelectedItem.ToString();
                string newSeccionValue = textBoxNewSeccion.Text;

                if (!string.IsNullOrWhiteSpace(newSeccionValue))
                {
                    string updateQuery = "UPDATE producto SET seccion = @newSeccion WHERE id = @productID";
                    using (SqlCommand command = new SqlCommand(updateQuery, dbManager.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@newSeccion", newSeccionValue);
                        command.Parameters.AddWithValue("@productID", selectedProductID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sección Actualizada Con Éxito.");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Favor elegir una sección.");
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un ID desde el ComboBox.");
            }
        }
    }
}
