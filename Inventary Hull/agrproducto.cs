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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


// Definición del espacio de nombres que organiza clases y otros elementos relacionados con Inventary_Hull.

namespace Inventary_Hull
{
    public partial class agrproducto : Form
    {

        // Declaración de una variable 'databaseManager' para gestionar las operaciones con la base de datos.

        private DatabaseManager databaseManager;

        // Constructor del formulario 'agrproducto'.

        public agrproducto()
        {
            // Llamada al método 'InitializeComponent' que configura los componentes del formulario,
            InitializeComponent();

            // Instanciación del 'DatabaseManager' para conectar y realizar operaciones con la base de datos.
            databaseManager = new DatabaseManager();

            // Asignación de un manejador de eventos al evento 'SelectedIndexChanged' del ComboBox 'categoriabox'.
            // Esto asegura que cuando se seleccione un ítem diferente en 'categoriabox', se llame el metodo para el llenado de seccion.
            categoriabox.SelectedIndexChanged += new EventHandler(categoriabox_SelectedIndexChanged);

        }
        private void agrproducto_Load(object sender, EventArgs e)
        {
        
        }
        #region Metodo POPULATE Combobox seccion
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

        #endregion

        #region Metodo POPULATE Combobox Suplidor
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

        #endregion
        private void nombretxt_TextChanged(object sender, EventArgs e)
        {

        }

        #region evento categoria y llenado de seccion 

        private void categoriabox_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Verifica si se ha seleccionado un ítem en 'categoriabox'.
            // Obtiene el ítem seleccionado como una cadena de texto.

            if (categoriabox.SelectedItem != null)
            {


                // Agrega ítems al ComboBox 'secciontxt', generando combinaciones basadas en la sección dada.

                string selectedCategory = categoriabox.SelectedItem.ToString();
                string seccion = selectedCategory.Split(new[] { " - " }, StringSplitOptions.None)[2].Trim();
                // Asumiendo que el formato es "id - tipo - sección"

                // Llama al método 'UpdateSeccionComboBox' para actualizar el ComboBox de sección
                // basándose en la sección extraída del ítem seleccionado y lo almacena
                UpdateSeccionComboBox(seccion);
            }


        }
        #endregion

        #region Metodo SECCION de llenado combobox y su llenado
        private void UpdateSeccionComboBox(string seccion)
        {

            // Primero, limpia los ítems actuales de 'secciontxt' para evitar duplicaciones.

            secciontxt.Items.Clear();

            //FOR estructura de control que establece la ejecucuion de un codigo determinada veces
            //aca se establece un icremento del 1 al 3 para crear sub secciones de la seccion establecida en categoria
            for (int i = 1; i <= 3; i++)
            {
                // Formatea y añade nuevos ítems. Por ejemplo, si sección es 'A', añade 'A-1', 'A-2', 'A-3'.

                secciontxt.Items.Add($"{seccion}-{i}");
            }
        }
        #endregion

        private void stocktxt_TextChanged(object sender, EventArgs e)
        {

        }

        #region evento combobox seccion
        private void secciontxt_TextChanged(object sender, EventArgs e)
        {
            if (secciontxt.SelectedIndex != 0)
            {
                string selectedseccion = secciontxt.SelectedItem.ToString();
                // Resto de tu código que depende de selectedSeccion
            }
        }
        #endregion

        #region  evento textbox idsuplidor
        private void idsuplidortxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idsuplidortxt.SelectedItem != null)
            {
                string selectedSuplidor = idsuplidortxt.SelectedItem.ToString();
                // El resto de tu código que depende de selectedSuplidor viene aquí...
            }
        }
        #endregion

        private void descripciontxt_TextChanged(object sender, EventArgs e)
        {

        }

        #region Evento y ejecucion de btn insertar

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

        #endregion

        #region Evento btn guardar y ejecucion
        private void guardarbtn_Click(object sender, EventArgs e)
        {
            // Asigna valores a los parámetros de la consulta SQL.
            //captura de error
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
        #endregion

        // Llamadas a métodos para llenar los ComboBoxes ('categoriabox', 'idsuplidortxt') con datos.

        private void agrproducto_Load_1(object sender, EventArgs e)
        {
            PopulateCategoriaComboBox();
            PopulateSuplidorComboBox();

        }

        // Implementación de otros métodos y eventos según sea necesario...
    }
}