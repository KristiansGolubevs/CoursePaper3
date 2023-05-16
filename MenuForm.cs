using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace paper3
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CarForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new PartForm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SaleLogForm().Show();
            this.Hide();
        }

    }
}
