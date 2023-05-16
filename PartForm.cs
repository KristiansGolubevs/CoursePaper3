using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace paper3
{
    public partial class PartForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";

        public PartForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;


            // Populate the VIN ComboBox with data from the database
            PopulateVinComboBox();

            // Attach the SelectedIndexChanged event handler to the VIN ComboBox
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT id, vin_code, make, model, part, quantity, price_per_item FROM parts", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Vin_code", "VIN Code");
                dataGridView1.Columns.Add("Make", "Make");
                dataGridView1.Columns.Add("Model", "Model");
                dataGridView1.Columns.Add("Part", "Part");
                dataGridView1.Columns.Add("Quantity", "Quantity");
                dataGridView1.Columns.Add("Price_per_item", "Price per Item");

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);

                // Create and configure the Edit button column
                DataGridViewButtonColumn soldButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Sold",
                    HeaderText = "Sold",
                    Text = "Sold",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(soldButtonColumn);

                dataGridView1.Columns["ID"].DataPropertyName = "ID";
                dataGridView1.Columns["Vin_code"].DataPropertyName = "vin_code";
                dataGridView1.Columns["Make"].DataPropertyName = "make";
                dataGridView1.Columns["Model"].DataPropertyName = "model";
                dataGridView1.Columns["Part"].DataPropertyName = "part";
                dataGridView1.Columns["Quantity"].DataPropertyName = "quantity";
                dataGridView1.Columns["Price_per_item"].DataPropertyName = "price_per_item";

                dataGridView1.Columns["Vin_code"].Width = 150;
                dataGridView1.Columns["Make"].Width = 150;
                dataGridView1.Columns["Model"].Width = 150;
                dataGridView1.Columns["Part"].Width = 150;
                dataGridView1.Columns["Quantity"].Width = 150;
                dataGridView1.Columns["Price_per_item"].Width = 150;



                dataGridView1.DataSource = dtbl;

                dataGridView1.Columns["ID"].DataPropertyName = "id";

                dataGridView1.CellClick += DataGridView1_CellClick;


            }

        }


        private void PopulateVinComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                // Execute a query to retrieve the VIN codes from the database
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT vin_code FROM vehicles", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();

                // Create a list to hold the VIN codes
                List<string> vinCodes = new List<string>();

                // Add an empty field as the first item
                vinCodes.Add("");

                // Read the VIN codes and add them to the list
                while (reader.Read())
                {
                    vinCodes.Add(reader["vin_code"].ToString());
                }

                // Bind the VIN codes to the ComboBox
                comboBox1.DataSource = vinCodes;
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVinCode = comboBox1.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedVinCode))
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    // Execute a query to retrieve the data for the selected VIN code
                    SqlCommand cmd = new SqlCommand("SELECT id, vin_code, make, model, part, quantity, price_per_item FROM parts WHERE vin_code = @vinCode", sqlCon);
                    cmd.Parameters.AddWithValue("@vinCode", selectedVinCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Create a new DataTable to store the filtered data
                    DataTable filteredTable = new DataTable();
                    filteredTable.Load(reader);

                    // Set the filtered DataTable as the DataGridView's data source
                    dataGridView1.DataSource = filteredTable;

                    // Display the make and model in the TextBox controls (if any rows are returned)
                    if (filteredTable.Rows.Count > 0)
                    {
                        textBox1.Text = filteredTable.Rows[0]["make"].ToString();
                        textBox2.Text = filteredTable.Rows[0]["model"].ToString();
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
            }
            else
            {
                // Reset the DataGridView and TextBox controls when no VIN code is selected
                dataGridView1.DataSource = null;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" || dataGridView1.Columns[e.ColumnIndex].Name == "Sold"))
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string vinCode = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM parts WHERE ID = @id", sqlCon))
                            {
                                cmd.Parameters.AddWithValue("@id", vinCode);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        MessageBox.Show("Record deleted for ID Code: " + vinCode);
                    }
                }
                else if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Sold")
                {
                    int selectedPartId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                    int currentQuantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);

                    // Prompt the user to enter the quantity sold
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the quantity sold:", "Sold Quantity", "");

                    if (int.TryParse(input, out int soldQuantity))
                    {
                        if (soldQuantity > 0 && soldQuantity <= currentQuantity)
                        {
                            int newQuantity = currentQuantity - soldQuantity;

                            // Update the quantity in the DataGridView
                            dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = newQuantity;

                            // Update the quantity in the database
                            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                            {
                                sqlCon.Open();

                                using (SqlCommand cmd = new SqlCommand("UPDATE parts SET quantity = @quantity WHERE id = @id", sqlCon))
                                {
                                    cmd.Parameters.AddWithValue("@quantity", newQuantity);
                                    cmd.Parameters.AddWithValue("@id", selectedPartId);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Quantity updated successfully!");

                            // Retrieve the price per item from the database
                            decimal pricePerItem = 0;
                            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                            {
                                sqlCon.Open();

                                using (SqlCommand cmd = new SqlCommand("SELECT price_per_item FROM parts WHERE id = @id", sqlCon))
                                {
                                    cmd.Parameters.AddWithValue("@id", selectedPartId);
                                    pricePerItem = Convert.ToDecimal(cmd.ExecuteScalar());
                                }
                            }

                            // Retrieve VIN code, make, and model from the DataGridView
                            string vinCode = dataGridView1.Rows[e.RowIndex].Cells["Vin_code"].Value.ToString();
                            string make = dataGridView1.Rows[e.RowIndex].Cells["Make"].Value.ToString();
                            string model = dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString();

                            // Insert a new sales record
                            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                            {
                                sqlCon.Open();

                                using (SqlCommand cmd = new SqlCommand("INSERT INTO sales (part_id, quantity_sold, date_sold, price, vin_code, make, model) VALUES (@partId, @quantitySold, @dateSold, @price, @vinCode, @make, @model)", sqlCon))
                                {
                                    cmd.Parameters.AddWithValue("@partId", selectedPartId);
                                    cmd.Parameters.AddWithValue("@quantitySold", soldQuantity);
                                    cmd.Parameters.AddWithValue("@dateSold", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@price", pricePerItem);
                                    cmd.Parameters.AddWithValue("@vinCode", vinCode);
                                    cmd.Parameters.AddWithValue("@make", make);
                                    cmd.Parameters.AddWithValue("@model", model);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Sale recorded successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid quantity entered or insufficient quantity available.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter a valid number.");
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
            textBox3.ResetText();
            textBox4.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO parts (vin_code, make, model, part, quantity, price_per_item) VALUES (@vin_code, @make, @model, @part, @quantity, @price_per_item)", sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@vin_code", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@make", textBox1.Text);
                        cmd.Parameters.AddWithValue("@model", textBox2.Text);
                        cmd.Parameters.AddWithValue("@part", comboBox2.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@quantity", textBox3.Text);
                        cmd.Parameters.AddWithValue("@price_per_item", textBox4.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView with the updated data
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM parts", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }

                // Clear the input fields
                comboBox1.ResetText();
                comboBox2.ResetText();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                MessageBox.Show("Part added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            new MenuForm().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Refresh the DataGridView with the full data from the "parts" table
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT id, vin_code, make, model, part, quantity, price_per_item FROM parts", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                comboBox1.ResetText();
                comboBox2.ResetText();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Vin_code", "VIN Code");
                dataGridView1.Columns.Add("Make", "Make");
                dataGridView1.Columns.Add("Model", "Model");
                dataGridView1.Columns.Add("Part", "Part");
                dataGridView1.Columns.Add("Quantity", "Quantity");
                dataGridView1.Columns.Add("Price_per_item", "Price per Item");

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);

                // Create and configure the Edit button column
                DataGridViewButtonColumn soldButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Sold",
                    HeaderText = "Sold",
                    Text = "Sold",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(soldButtonColumn);

                dataGridView1.Columns["ID"].DataPropertyName = "ID";
                dataGridView1.Columns["Vin_code"].DataPropertyName = "vin_code";
                dataGridView1.Columns["Make"].DataPropertyName = "make";
                dataGridView1.Columns["Model"].DataPropertyName = "model";
                dataGridView1.Columns["Part"].DataPropertyName = "part";
                dataGridView1.Columns["Quantity"].DataPropertyName = "quantity";
                dataGridView1.Columns["Price_per_item"].DataPropertyName = "price_per_item";

                dataGridView1.Columns["Vin_code"].Width = 150;
                dataGridView1.Columns["Make"].Width = 150;
                dataGridView1.Columns["Model"].Width = 150;
                dataGridView1.Columns["Part"].Width = 150;
                dataGridView1.Columns["Quantity"].Width = 150;
                dataGridView1.Columns["Price_per_item"].Width = 150;



                dataGridView1.DataSource = dtbl;

                dataGridView1.Columns["ID"].DataPropertyName = "id";


                dataGridView1.CellClick += DataGridView1_CellClick;

            }

        }
    }
}



