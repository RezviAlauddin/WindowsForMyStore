using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFor
{
   public class database
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public bool Checkdb(string UserName,string Password)
        {
            if(UserName==" "|| Password==" ")
            {
                throw new NullReferenceException("field can not be empty");
            }
            string query = "Select * from Login where UserName='"+UserName.Trim()+"' and Password='"+Password.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
