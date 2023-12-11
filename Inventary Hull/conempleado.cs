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
    public partial class conempleado : Form
    {
        private DatabaseManager databaseManager;
        public conempleado()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();

        }

        private void conempleado_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM empleado";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
