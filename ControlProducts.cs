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
    public partial class ControlProducts : Form
    {
        public ControlProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ad = new AdminPanel();
            ad.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            if(textBox1.Text!=" " && textBox2.Text != " " && textBox3.Text != " ")
            {

          
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Products(Code,Name,Prce,amount) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + numericUpDown1.Value+ "') ", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Product Added successfully!!.");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void all_data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Products", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            // sda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            all_data();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Update Products SET Name='"+textBox2.Text+"',Prce='"+textBox3.Text+"',amount='"+ numericUpDown1.Value+ "' Where Code='" + textBox1.Text + "'", con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Update Done!!");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Delete From Products WHERE Code='" + textBox1.Text + "'", con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Delete Done!!");
            con.Close();
        }

        private void ControlProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataDataSet1.Products);

        }

        private void productsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
