using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public partial class searchForm : Form
    {
        DBConnect dBCon = new DBConnect();
        DataTable table = new DataTable();
        public searchForm()
        {
            InitializeComponent();
        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            getTable();
        }
        private DataTable getTable()
        {
            string selectQuerry = "SELECT * FROM [Product]";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);          
            adapter.Fill(table);
            dataGridView_User.DataSource = table;
            return table;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            DataView dvUser = table.DefaultView;
            dvUser.RowFilter = "ProdName LIKE '%" + textBox_name.Text + "%'";
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            DataView dvUser = table.DefaultView;
            dvUser.RowFilter = "ProdId LIKE '%" + textBox_id.Text + "%'";
        }

        private void textBox_category_TextChanged(object sender, EventArgs e)
        {
            DataView dvUser = table.DefaultView;
            dvUser.RowFilter = "ProdCat LIKE '%" + textBox_category.Text + "%'";
        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {
            DataView dvUser = table.DefaultView;
            dvUser.RowFilter = "ProdPrice LIKE '%" + textBox_price.Text + "%'";
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Login_form login = new Login_form();
            login.Show();
            this.Hide();
        }
    }
}
