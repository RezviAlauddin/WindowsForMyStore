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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\WindowsFor\WindowsFor\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Login(UserName,Password,Email,Phone) VALUES('" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Welcome!! You Become New User.");

        }
    }
}
