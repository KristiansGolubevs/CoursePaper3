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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT vin_code, make, model, year, body_type, fuel_type, transmission, value, date_added FROM vehicles", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("VIN Code", "VIN");
                dataGridView1.Columns.Add("Make", "Make");
                dataGridView1.Columns.Add("Model", "Model");
                dataGridView1.Columns.Add("Year", "Year");
                dataGridView1.Columns.Add("Body Type", "Body Type");
                dataGridView1.Columns.Add("Fuel Type", "Fuel Type");
                dataGridView1.Columns.Add("Transmission", "Transmission");
                dataGridView1.Columns.Add("Price", "Price");
                dataGridView1.Columns.Add("Date Purchased", "Date Purchased");
                //dataGridView1.Columns.Add("Delete", "Delete");
                //dataGridView1.Columns.Add("Edit", "Edit");

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);

                // Create and configure the Edit button column
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editButtonColumn);


                dataGridView1.Columns["VIN Code"].DataPropertyName = "vin_code";
                dataGridView1.Columns["Make"].DataPropertyName = "make";
                dataGridView1.Columns["Model"].DataPropertyName = "model";
                dataGridView1.Columns["Year"].DataPropertyName = "year";
                dataGridView1.Columns["Body Type"].DataPropertyName = "body_type";
                dataGridView1.Columns["Fuel Type"].DataPropertyName = "fuel_type";
                dataGridView1.Columns["Transmission"].DataPropertyName = "transmission";
                dataGridView1.Columns["Price"].DataPropertyName = "value";
                dataGridView1.Columns["Date Purchased"].DataPropertyName = "date_added";

                dataGridView1.Columns["VIN Code"].Width = 150;
                dataGridView1.Columns["Date Purchased"].Width = 130;

                dataGridView1.DataSource = dtbl;

                dataGridView1.CellClick += DataGridView1_CellClick;

            }
        }

        private void RefreshDataGridView()
        {
            string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT vin_code, make, model, year, body_type, fuel_type, transmission, value, date_added FROM vehicles", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" || dataGridView1.Columns[e.ColumnIndex].Name == "Edit"))
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string vinCode = dataGridView1.Rows[e.RowIndex].Cells["VIN Code"].Value.ToString();

                        string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM vehicles WHERE vin_code = @vinCode", sqlCon))
                            {
                                cmd.Parameters.AddWithValue("@vinCode", vinCode);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        MessageBox.Show("Record deleted for VIN Code: " + vinCode);
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditForm editForm = new EditForm();

                    editForm.VinCode = dataGridView1.Rows[e.RowIndex].Cells["VIN Code"].Value.ToString();
                    editForm.Make = dataGridView1.Rows[e.RowIndex].Cells["Make"].Value.ToString();
                    editForm.Model = dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString();
                    editForm.Year = dataGridView1.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                    editForm.BodyType = dataGridView1.Rows[e.RowIndex].Cells["Body Type"].Value.ToString();
                    editForm.FuelType = dataGridView1.Rows[e.RowIndex].Cells["Fuel Type"].Value.ToString();
                    editForm.Transmission = dataGridView1.Rows[e.RowIndex].Cells["Transmission"].Value.ToString();
                    editForm.Price = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();

                    DialogResult result = editForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        RefreshDataGridView();
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            textBox3.ResetText();
        }


    }


}
