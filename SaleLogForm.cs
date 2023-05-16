using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace paper3
{
    public partial class SaleLogForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";

        public SaleLogForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                // Retrieve sales data from the database
                string query = "SELECT vin_code AS 'VIN Code', make AS 'Make', model AS 'Model', quantity_sold AS 'Quantity Sold', date_sold AS 'Date', price AS 'Price' FROM sales";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtSales = new DataTable();
                adapter.Fill(dtSales);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dtSales;
                //fdgdfgfdg
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Width = 150;
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            this.Hide();
        }


    }
}
