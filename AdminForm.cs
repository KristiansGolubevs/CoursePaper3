using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paper3
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Username, Password FROM users", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Username", "Username");
                dataGridView1.Columns.Add("Password", "Password");

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);

                dataGridView1.Columns["Username"].DataPropertyName = "username";
                dataGridView1.Columns["Password"].DataPropertyName = "password";

                dataGridView1.Columns["Username"].Width = 200;
                dataGridView1.Columns["Password"].Width = 200;

                dataGridView1.DataSource = dtbl;
            }

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }



        private void label2_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string username = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString();

                    string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE username = @username", sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    MessageBox.Show("Record deleted for username: " + username);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();
                }

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Username, Password FROM users", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }

            MessageBox.Show("Record added successfully!");

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

        }

    }
}
