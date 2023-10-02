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

    public partial class showingList : Form
    {
        DBConnect dBCon = new DBConnect();

        SqlDataAdapter da;
        DataSet ds;
        public showingList()
        {
            InitializeComponent();
        }

        private void button_query1_Click(object sender, EventArgs e)
        {
            string query = textBox_query.Text;
            da = new SqlDataAdapter(query, dBCon.GetCon());
            ds = new DataSet();
            da.Fill(ds);
            dBCon.CloseCon();
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }
    }
}
