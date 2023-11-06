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
        }

        private void agrproducto_Load(object sender, EventArgs e)
        {
            PopulateCategoriaComboBox();
            PopulateSuplidorComboBox();
        }

        private void PopulateCategoriaComboBox()
        {
            categoriabox.Items.Clear();
            string query = "SELECT id, tipo FROM categoria";

            using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string tipo = reader["tipo"].ToString();
                        string displayText = $"{id} - {tipo}";
                        categoriabox.Items.Add(displayText);
                    }
                }
            }
        }

        private void PopulateSuplidorComboBox()
        {
            idsuplidortxt.Items.Clear();
            string query = "SELECT id, nombre FROM suplidor";

            using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
            {
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
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int stock = int.Parse(stocktxt.Text); // Validar y convertir stock a entero

                string insertQuery = @"
                    INSERT INTO producto (nombre, categoria, descripcion, stock, idsuplidor, seccion) 
                    VALUES (@nombre, @categoria, @descripcion, @stock, @idsuplidor, @seccion)";

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

                    databaseManager.GetConnection().Open();
                    command.ExecuteNonQuery();
                    databaseManager.GetConnection().Close();
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

        // Implementación de otros métodos y eventos según sea necesario...
    }
}