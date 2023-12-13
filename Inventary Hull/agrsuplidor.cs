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
    public partial class agrsuplidor : Form
    {
        private DatabaseManager databaseManager;
        public agrsuplidor()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();

        }

        private void agrsuplidor_Load(object sender, EventArgs e)
        {

        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            rnctxt.Enabled = true;
            direcciontxt.Enabled = true;
            emailtxt.Enabled = true;
            telefonotxt.Enabled = true;
            descripciontxt.Enabled = true;

            nombretxt.BackColor = Color.White;
            rnctxt.BackColor = Color.White;
            direcciontxt.BackColor = Color.White;
            emailtxt.BackColor = Color.White;
            telefonotxt.BackColor = Color.White;
            descripciontxt.BackColor = Color.White;
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any of the required fields is empty
                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(nombretxt.Text) ||
                    string.IsNullOrWhiteSpace(rnctxt.Text) ||
                    string.IsNullOrWhiteSpace(direcciontxt.Text) ||
                    string.IsNullOrWhiteSpace(emailtxt.Text) ||
                    string.IsNullOrWhiteSpace(telefonotxt.Text) ||
                    string.IsNullOrWhiteSpace(descripciontxt.Text))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                    return; // Exit the method without proceeding to database insertion
                }


                string insertQuery = "insert into suplidor (nombre, rnc, direccion, email, telefono, descripcion) " +
                    "VALUES (@nombre, @rnc, @direccion, @email, @telefono, @descripcion)";

                using (SqlCommand command = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    // Add parameters using AddWithValue
                    command.Parameters.AddWithValue("@nombre", nombretxt.Text);
                    command.Parameters.AddWithValue("@direccion", direcciontxt.Text);
                    command.Parameters.AddWithValue("@email", emailtxt.Text);

                    string rnc = rnctxt.Text.Replace(" ", ""); // Remove spaces or any other formatting
                    command.Parameters.AddWithValue("@rnc", rnc);

                    string phoneNumber = telefonotxt.Text.Replace("-", ""); // Remove hyphens or any other formatting
                    command.Parameters.AddWithValue("@telefono", phoneNumber);

                    command.Parameters.AddWithValue("@descripcion", descripciontxt.Text);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data insertada correctamente.");

                nombretxt.Text = "";
                rnctxt.Text = "";
                direcciontxt.Text = "";
                emailtxt.Text = "";
                telefonotxt.Text = "";
                descripciontxt.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR HAS INSERTADO UN DATO MAL: " + ex.Message);
            }
        }

        private void telefonotxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rnctxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
