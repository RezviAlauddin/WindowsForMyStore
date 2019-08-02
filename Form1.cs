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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM Login where UserName='" + textBox1.Text+"' and Password='"+textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (textBox1.Text== "Rezvi" && textBox2.Text== "store_@dmin")
            {
                this.Hide();
                AdminPanel ad = new AdminPanel();
                ad.Show();
            }
              else if(textBox1.Text !=" "&& textBox2.Text !=" ")
            {
                this.Hide();
                UserForm ss = new UserForm();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Check username and password");

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin ss = new Signin();
            ss.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
