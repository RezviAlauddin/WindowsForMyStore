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

namespace WindowsFor
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet7.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.dataDataSet7.Products);
            // TODO: This line of code loads data into the 'dataDataSet6.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dataDataSet6.Login);
            // TODO: This line of code loads data into the 'dataDataSet5.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this.dataDataSet5.Users);
            // TODO: This line of code loads data into the 'dataDataSet4.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.dataDataSet4.Users);
            // TODO: This line of code loads data into the 'dataDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataDataSet3.Users);
            // TODO: This line of code loads data into the 'dataDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataDataSet2.Products);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UpdateSelfInfo us = new UpdateSelfInfo();
            us.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM Products where Name like  '" + textBox1.Text + "%' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
