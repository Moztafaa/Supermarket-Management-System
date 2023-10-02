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
    public partial class productForm : Form
    {
        DBConnect dBCon = new DBConnect();        
        public productForm()
        {
            InitializeComponent();
        }

        private void productForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }
        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
            comboBox_search.DataSource = table;
            comboBox_search.ValueMember = "CatName";
        }

        private void getTable()
        {//ProdId,ProdName,ProdPrice,ProdQty,ProdCat
            string selectQuerry = "SELECT * FROM [Product]";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_price.Clear();
            TextBox_qty.Clear();
            comboBox_category.SelectedIndex = 0;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_category_Click(object sender, EventArgs e)
        {
            categoryForm categoryForm = new categoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Login_form login_form = new Login_form();
            login_form.Show();
            this.Hide();
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES('"+TextBox_id.Text+"','"+TextBox_name.Text+"','"+TextBox_price.Text+"','"+TextBox_qty.Text+"','"+ TextBox_avail.Text+"','"+TextBox_prodDate.Text+"','"+TextBox_NoCustomer.Text+"','"+comboBox_category.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_price.Text == "" || TextBox_qty.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE Product SET ProdName='" + TextBox_name.Text + "', ProdPrice='" + TextBox_price.Text + "', ProdQty='" + TextBox_qty.Text + "' ,AVAILABILTY='" + TextBox_avail.Text + "' ,ProductionDate='" + TextBox_prodDate.Text + "' ,NoCustomers='" + TextBox_NoCustomer.Text + "' ,ProdCat='" + comboBox_category.Text +  "'WHERE ProdId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void dataGridView_product_Click_1(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_price.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_qty.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_avail.Text = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
            TextBox_prodDate.Text = dataGridView_product.SelectedRows[0].Cells[5].Value.ToString();
            TextBox_NoCustomer.Text = dataGridView_product.SelectedRows[0].Cells[6].Value.ToString();
            comboBox_category.Text = dataGridView_product.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProdId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Product WHERE ProdCat='" + comboBox_search.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;

        }

        private void button_users_Click(object sender, EventArgs e)
        {
            userForm userForm = new userForm();
            userForm.Show();
            this.Hide();
           
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            sellingForm sellingForm = new sellingForm();
            sellingForm.Show();
            this.Hide();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            searchForm searchForm = new searchForm();
            searchForm.Show();
            this.Hide();
        }
    }
}
