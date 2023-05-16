

using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace paper3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HIEUD0V\SQLEXPRESS;Initial Catalog=paper3;Integrated Security=True");
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
      

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            String username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {                 
                    new AdminForm().Show();
                    this.Hide();
                }
                else
                {
                    String query = "SELECT * FROM users WHERE username = '" + txtUsername.Text +
                        "' AND password = '" + txtPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = txtUsername.Text;
                        password = txtPassword.Text;
                        new MenuForm().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                conn.Close();
            }


        }
    }
}