using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFor
{
    class CheckDatabase
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\WindowsFor\WindowsFor\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public bool Checkdb(string UserName, string Password)
        {
            string query = "Select * from Login where UserName='" + UserName.Trim() + "' and Password='" + Password.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (UserName == " " || Password == " ")
            {
                throw new NullReferenceException("field can not be empty");
            }
            if (dtbl.Rows.Count == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool ChSignUp(string UserName, string Password, string Email, string Phone)
        {
            if (UserName == " " || Password == " " || Phone == " ")
            {
                throw new NullReferenceException("fiELD CAN NO BE NULL");
            }
            else if (UserName !=" " && Password != " " && Phone != " ")
            {
                con.Open();
                string query = "insert into Login values('" + UserName.Trim() + "','" + Password.Trim() + "','" + Email.Trim() + "','" + Phone.Trim()+ "') ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ChUpdate(string UserName, string Password, string Email, string Phone)
        {
            if (UserName == " " || Password == " " || Phone == " ")
            {
                throw new NullReferenceException("fiELD CAN NO BE NULL");
            }
            else if (UserName != " " && Password != " " && Phone != " ")
            {
                con.Open();
                string query = "Update Login SET Password ='" + Password.Trim() + "',Email='" + Email.Trim() + "',Phone='" + Phone.Trim() + "' where  UserName ='" + UserName.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ChDelete(string UserName, string Password, string Email, string Phone)
        {
            if (UserName == " " || Password == " " || Phone == " ")
            {
                throw new NullReferenceException("fiELD CAN NO BE NULL");
            }
            else if (UserName != " " && Password != " " && Phone != " ")
            {
                con.Open();
                string query = "Delete Login  where  UserName ='" + UserName.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
