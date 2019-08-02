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
    public partial class UpdateSelfInfo : Form
    {
        public UpdateSelfInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm f = new UserForm();
            f.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\WindowsFor\WindowsFor\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Update Login SET UserName='" + textBox1.Text + "',Password='" + textBox2.Text + "',Email='" + textBox3.Text + "' where Phone='" + textBox4.Text + "' ", con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Update Done!!");
            con.Close();
        }
    }
}
