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
    public partial class agrempleado : Form
    {

        private DatabaseManager databaseManager;
        public agrempleado()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
        }



        private void nuevobtn_Click(object sender, EventArgs e)
        {
           
        }

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
        }
        private string GetUnmaskedText(MaskedTextBox maskedTextBox)
        {
            string unmaskedText = maskedTextBox.Text;
            foreach (char maskChar in maskedTextBox.Mask)
            {
                unmaskedText = unmaskedText.Replace(maskChar.ToString(), "");
            }
            return unmaskedText;
        }

        private void agrempleado_Load(object sender, EventArgs e)
        {

        }

        private void nuevobtn_Click_1(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            apellidotxt.Enabled = true;
            direcciontxt.Enabled = true;
            maskeddni.Enabled = true;
            emailtxt.Enabled = true;
            maskedtel.Enabled = true;
            maskedcel.Enabled = true;
            cargotxt.Enabled = true;

            nombretxt.BackColor = Color.White;
            apellidotxt.BackColor = Color.White;
            direcciontxt.BackColor = Color.White;
            maskeddni.BackColor = Color.White;
            emailtxt.BackColor = Color.White;
            maskedtel.BackColor = Color.White;
            maskedcel.BackColor = Color.White;
            cargotxt.BackColor = Color.White;
        }

        private void guardarbtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(nombretxt.Text) || string.IsNullOrWhiteSpace(apellidotxt.Text) ||
                    string.IsNullOrWhiteSpace(direcciontxt.Text) || string.IsNullOrWhiteSpace(GetUnmaskedText(maskeddni)) ||
                    string.IsNullOrWhiteSpace(emailtxt.Text) || string.IsNullOrWhiteSpace(GetUnmaskedText(maskedtel)) ||
                    string.IsNullOrWhiteSpace(GetUnmaskedText(maskedcel)) || string.IsNullOrWhiteSpace(cargotxt.Text))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                    return; // Exit the method without proceeding to database insertion
                }

                string insertQuery = "INSERT INTO empleado (nombre, apellido, direccion, dni, email, telefono, celular, cargo) " +
                   "VALUES (@nombre, @apellido, @direccion, @dni, @email, @telefono, @celular, @cargo)";

                using (SqlCommand command = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    // Add parameters using AddWithValue
                    command.Parameters.AddWithValue("@nombre", nombretxt.Text);
                    command.Parameters.AddWithValue("@apellido", apellidotxt.Text);
                    command.Parameters.AddWithValue("@direccion", direcciontxt.Text);

                    string dni = maskeddni.Text.Replace("-", " "); // Remove spaces or any other formatting
                    command.Parameters.AddWithValue("@dni", dni);

                    command.Parameters.AddWithValue("@email", emailtxt.Text);

                    string phoneNumber = maskedtel.Text.Replace("-", ""); // Remove hyphens or any other formatting
                    command.Parameters.AddWithValue("@telefono", phoneNumber);

                    string cellphoneNumber = maskedcel.Text.Replace("-", ""); // Remove hyphens or any other formatting
                    command.Parameters.AddWithValue("@celular", cellphoneNumber);

                    command.Parameters.AddWithValue("@cargo", cargotxt.Text);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Data insertada correctamente.");

                nombretxt.Clear();
                apellidotxt.Clear();
                direcciontxt.Clear();
                maskeddni.Clear();
                emailtxt.Clear();
                maskedtel.Clear();
                maskedcel.Clear();
                cargotxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR HAS INSERTADO UN DATO MAL: " + ex.Message);
            }
        }
    }
}