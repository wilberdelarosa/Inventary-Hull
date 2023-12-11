﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventary_Hull
{
    public partial class agrproducto : Form
    {


        private DatabaseManager databaseManager;

        public agrproducto()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            categoriabox.SelectedIndexChanged += new EventHandler(categoriabox_SelectedIndexChanged);

        }
        // Se llama una vez al cargar el formulario para llenar los ComboBoxes
        private void agrproducto_Load(object sender, EventArgs e)
        {
           PopulateCategoriaComboBox();

            PopulateSuplidorComboBox();

            PopulateseccionComboBox();
        }
        private void PopulateseccionComboBox()

        {
            // Llenar el ComboBox de Categoría aquí...
            categoriabox.Items.Clear();
            string query = "SELECT id, tipo, seccion FROM categoria";

            try
            {
                using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string seccion = reader["seccion"].ToString();
                        string id = reader["id"].ToString();
                        string tipo = reader["tipo"].ToString();
                        string displayText = $"{id} - {tipo} - seccion {seccion}";
                        categoriabox.Items.Add(displayText);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener categorías: " + ex.Message);
            }
            finally
            {
                // cerrar la conexión aquí.
                databaseManager.CloseConnection();
            }

        }


        private void PopulateCategoriaComboBox()
        {
            // Llenar el ComboBox de Categoría aquí...
           categoriabox.Items.Clear();
            string query = "SELECT id, tipo, seccion FROM categoria";

            try
            {
                using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string seccion = reader["seccion"].ToString();
                        string id = reader["id"].ToString();
                        string tipo = reader["tipo"].ToString();
                        string displayText = $"{id} - {tipo} -  {seccion}";
                        categoriabox.Items.Add(displayText);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener categorías: " + ex.Message);
            }
            finally
            {
                // cerrar la conexión aquí.
                databaseManager.CloseConnection();
            }

        }


        private void PopulateSuplidorComboBox()
        {
            // Llenar el ComboBox de Suplidor aquí...
            idsuplidortxt.Items.Clear();
            string query = "SELECT id, nombre FROM suplidor";

            try
            {
                using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string nombre = reader["nombre"].ToString();

                        string displayText = $"{id} - {nombre}";
                        idsuplidortxt.Items.Add(displayText);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener suplidores: " + ex.Message);
            }
            finally
            {
                // Asegúrate de cerrar la conexión aquí.
                databaseManager.CloseConnection();
            }
        }

        // Este evento ahora no debería limpiar y repoblar el ComboBox, puede que ni siquiera sea necesario
        private void nombretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriabox_SelectedIndexChanged(object sender, EventArgs e)
        {

           
         

                //PopulateCategoriaComboBox();
                //PopulateSuplidorComboBox();
                if (categoriabox.SelectedItem != null)
                  {
                      string selectedCategory = categoriabox.SelectedItem.ToString();
                      string seccion = selectedCategory.Split(new[] { " - " }, StringSplitOptions.None)[2].Trim(); // Asumiendo que el formato es "id - tipo - sección"
                      UpdateSeccionComboBox(seccion);
                      // El resto de tu código que depende de selectedCategory viene aquí...
                  }


            }
        private void UpdateSeccionComboBox(string seccion)
        {
            secciontxt.Items.Clear();
            for (int i = 1; i <= 3; i++)
            {
                secciontxt.Items.Add($"{seccion}-{i}");
            }
        }

        private void stocktxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void secciontxt_TextChanged(object sender, EventArgs e)
        {
            if (secciontxt.SelectedIndex != 0)
            {
                string selectedseccion = secciontxt.SelectedItem.ToString();
                // Resto de tu código que depende de selectedSeccion
            }
        }
        private void idsuplidortxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idsuplidortxt.SelectedItem != null)
            {
                string selectedSuplidor = idsuplidortxt.SelectedItem.ToString();
                // El resto de tu código que depende de selectedSuplidor viene aquí...
            }
        }

        private void descripciontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            descripciontxt.Enabled = true;
            stocktxt.Enabled = true;
            idsuplidortxt.Enabled = true;
            secciontxt.Enabled = true;
            categoriabox.Enabled = true;

            nombretxt.BackColor = Color.White;
            descripciontxt.BackColor = Color.White;
            stocktxt.BackColor = Color.White;
            idsuplidortxt.BackColor = Color.White;
            secciontxt.BackColor = Color.White;
            categoriabox.BackColor = Color.White;
        }
        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int stock = int.Parse(stocktxt.Text); // Validar y convertir stock a entero

                string insertQuery = "INSERT INTO producto(nombre, categoria, descripcion, stock, idsuplidor, seccion)" +
                    "VALUES (@nombre, @categoria, @descripcion, @stock, @idsuplidor, @seccion)";

                using (SqlCommand command = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    command.Parameters.AddWithValue("@nombre", nombretxt.Text);
                    string selectedCategory = categoriabox.SelectedItem.ToString();
                    string[] categoryParts = selectedCategory.Split(new[] { " - " }, StringSplitOptions.None);
                    command.Parameters.AddWithValue("@categoria", categoryParts[0]);

                    command.Parameters.AddWithValue("@descripcion", descripciontxt.Text);
                    command.Parameters.AddWithValue("@stock", stock);

                    string selectedSuplidor = idsuplidortxt.SelectedItem.ToString();
                    string[] suplidorParts = selectedSuplidor.Split(new[] { " - " }, StringSplitOptions.None);
                    command.Parameters.AddWithValue("@idsuplidor", suplidorParts[0]);

                    command.Parameters.AddWithValue("@seccion", secciontxt.Text);

                    command.ExecuteNonQuery();

                }


                MessageBox.Show("Producto insertado correctamente.");

                // Limpiar los campos después de la inserción
                nombretxt.Text = "";
                categoriabox.SelectedIndex = -1;
                descripciontxt.Text = "";
                stocktxt.Text = "";
                idsuplidortxt.SelectedIndex = -1;
                secciontxt.Text = "";
            }

            catch (FormatException)
            {
                MessageBox.Show("El stock debe ser un número entero válido.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar los datos en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void agrproducto_Load_1(object sender, EventArgs e)
        {
            PopulateCategoriaComboBox();
            PopulateCategoriaComboBox();
            PopulateSuplidorComboBox();

        }

        // Implementación de otros métodos y eventos según sea necesario...
    }
}