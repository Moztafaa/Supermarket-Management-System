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
    public partial class Login_form : Form
    {
        DBConnect dBCon  = new DBConnect();
        public Login_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_role.SelectedIndex ==0)
                {
                    
                    
                    
                        string selectQuery = "SELECT * FROM [User] WHERE UserType ='ADMIN' AND UserName='" + TextBox_username.Text + "' AND UserPass='" + TextBox_password.Text + "'";

                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0){
                            productForm product = new productForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    
                }
                

                if (comboBox_role.SelectedIndex == 1)
                {



                    string selectQuery = "SELECT * FROM [User] WHERE UserType ='CUSTOMER' AND UserName='" + TextBox_username.Text + "' AND UserPass='" + TextBox_password.Text + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        customerUser customer = new customerUser();
                        customer.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        
    }
}
