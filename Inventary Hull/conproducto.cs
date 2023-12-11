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
    public partial class conproducto : Form
    {
        private const string InstructionalText = "Puedes presionar Enter para buscar";

        private DatabaseManager databaseManager;

        public conproducto()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();

            //THIS IS SO THAT THE FORM ADJUST ITSELF WHEN SIZEING THE WINDOW
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SetInstructionalText();

            // THIS IS FOR THE TEXTBOX AND THE MASSAGE I WANTED TO DISPLAY BEFORE THE USER ENTERS SOMETINHG 
            txtID.GotFocus += TxtID_GotFocus;
            txtID.LostFocus += TxtID_LostFocus;
            txtID.KeyPress += TxtID_KeyPress;
        }
        private void SetInstructionalText()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = InstructionalText;
                txtID.ForeColor = SystemColors.GrayText; // Change the text color to gray
            }

        }
        private void ClearInstructionalText()
        {
            if (txtID.Text == InstructionalText)
            {
                txtID.Text = string.Empty;
                txtID.ForeColor = SystemColors.WindowText; // Change the text color to the default
            }
        }
        private void TxtID_GotFocus(object sender, EventArgs e)
        {
            ClearInstructionalText();
        }

        private void TxtID_LostFocus(object sender, EventArgs e)
        {
            SetInstructionalText();
        }

        //esta parte es un eventhandler para que al presionar enter se pueda hacer la busqueda sin necesidad de presionar el boton de busqueda 
        private void TxtID_KeyPress(object sender, KeyPressEventArgs funcion)
        {
            // Check if the pressed key is Enter (ASCII value 13)
            if (funcion.KeyChar == (char)Keys.Enter)
            {
                // Call the buscarbtn_Click event handler logic
                buscarbtn_Click(sender, funcion);

                // Suppress the key press to prevent the default behavior
                funcion.Handled = true;
            }
        }

        private void conproducto_Load(object sender, EventArgs e)
        {
            // Assuming you have a table named "producto" in your database
            LoadData();

            txtID.KeyPress += TxtID_KeyPress;
        }
        private void LoadData()
        {
            string query = "SELECT * FROM producto";

            using (DataTable dataTable = new DataTable())
            {
                using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                {
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }

            // Close the connection when done
            databaseManager.CloseConnection();
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            // Get the ID from the TextBox
            if (int.TryParse(txtID.Text, out int id))
            {
                // Modify the query to include the ID filter
                string query = $"SELECT * FROM producto WHERE ID = {id}";

                using (DataTable dataTable = new DataTable())
                {
                    using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                    {
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Este producto no está ingresado.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                // Close the connection when done
                databaseManager.CloseConnection();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido para la búsqueda.", "ID no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {


            string query = "SELECT * FROM producto";

            using (DataTable dataTable = new DataTable())
            {
                using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                {
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }

            // Close the connection when done
            databaseManager.CloseConnection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

