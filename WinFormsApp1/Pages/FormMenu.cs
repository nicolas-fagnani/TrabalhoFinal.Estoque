using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Cursor;

namespace Estoque.Forms.Pages
{
    public partial class FormMenu : Form
    {
        public FormMenu(string userName)
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!");
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!");
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!");
        }
    }
}
