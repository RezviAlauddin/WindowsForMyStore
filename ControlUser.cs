using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFor
{
    public partial class ControlUser : Form
    {
        public ControlUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ad = new AdminPanel();
            ad.Show();
        }

        private void ControlUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet8.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dataDataSet8.Login);

        }
    }
}
