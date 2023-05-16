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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public string VinCode
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Make
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public string Model
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string Year
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = value; }
        }

        public string BodyType
        {
            get { return comboBox3.Text; }
            set { comboBox3.Text = value; }
        }

        public string FuelType
        {
            get { return comboBox4.Text; }
            set { comboBox4.Text = value; }
        }

        public string Transmission
        {
            get { return comboBox5.Text; }
            set { comboBox5.Text = value; }
        }

        public string Price
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE vehicles SET make = @make, model = @model, year = @year, body_type = @body_type, fuel_type = @fuel_type, transmission = @transmission, value = @value WHERE vin_code = @vin_code", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@vin_code", VinCode);
                    cmd.Parameters.AddWithValue("@make", Make);
                    cmd.Parameters.AddWithValue("@model", Model);
                    cmd.Parameters.AddWithValue("@year", Year);
                    cmd.Parameters.AddWithValue("@body_type", BodyType);
                    cmd.Parameters.AddWithValue("@fuel_type", FuelType);
                    cmd.Parameters.AddWithValue("@transmission", Transmission);
                    cmd.Parameters.AddWithValue("@value", Price);

                    cmd.ExecuteNonQuery();
                }
            }

            this.DialogResult = DialogResult.OK;


            MessageBox.Show("Changes saved successfully!");

            this.Close();
        }
    }
}
