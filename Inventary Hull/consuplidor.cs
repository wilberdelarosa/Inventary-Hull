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
    public partial class consuplidor : Form
    {
        private DatabaseManager databaseManager;
        public consuplidor()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
        }

        private void consuplidor_Load(object sender, EventArgs e)
        {
            // Assuming you have a table named "producto" in your database
            string query = "SELECT * FROM suplidor";

            using (DataTable dataTable = new DataTable())
            {
                using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                {
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

    }
}