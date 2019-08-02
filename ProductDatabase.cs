using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFor
{
    class ProductDatabase
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        public bool CheckProDbins(string Code, string Name, int Prce, int amount)
        {
            if (Code == " " || Name == " " || Prce == 0 || amount == 0)
            {
                throw new NullReferenceException("Field can not be empty ");
            }
         else if (Code!=" "&& Name!=" "&& Prce!=0 && amount!=0)
            {
                con.Open();
                string query = "insert into Products values('" + Code.Trim() + "','" + Name.Trim() + "','" + Prce + "','" + amount + "') ";
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
        public bool CheckProDbUp(string Code, string Name, int Prce, int amount)
        {

            if (Code == " " || Name == " " || Prce == 0 || amount == 0)
            {
                throw new NullReferenceException("Field can not be empty ");
            }
            else if (Code != " " && Name != " " && Prce != 0 && amount != 0)
            {
                con.Open();
                string query = "Update Products SET Name ='" + Name.Trim() + "',Prce='" + Prce + "',amount ='" + amount + "' where Code ='" + Code.Trim() + "'";
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

        public bool CheckProDbDe(string Code, string Name, int Prce, int amount)
        {

            if (Code == " " || Name == " " || Prce == 0 || amount == 0)
            {
                throw new NullReferenceException("Field can not be empty ");
            }
            else if (Code != " " && Name != " " && Prce != 0 && amount != 0)
            {
                con.Open();
                string query = "Delete Products where Code ='" + Code.Trim() + "' ";
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
        public bool ChSearch(String Name)
        {
            if (Name == " ")
            {
                throw new NullReferenceException("Search By Name please");
            }
            else if (Name != " ")
            {

                con.Open();

                string query = "Select * FROM Products where Name like  '" + Name.Trim() + "%' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
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
