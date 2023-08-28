using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourcePlanning
{
    public class Sql
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GIR3DQR\SQLEXPRESS; Initial Catalog= RepoDB; Integrated security=True;");

        public void insert(string a, string b, string c, string d) // To Insert Records behind Button click
        {
            try
            { 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Insert into [RMS](Pid, PName, Qty, Supplier) " +
                "values ('" + a+ "', '" + b + "', '" + c + "', '" + d + "')";
            cmd.ExecuteNonQuery();

            }
            catch { }
            con.Close();
        }
        public void update(string a, string b, string c, string d) // To update Records behind Button click
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " UPDATE RMS Set PName='" + b + "'," +
                    " Qty='" + c + "', Supplier='" + d + "' WHERE Pid= '" + a + "' ";
                cmd.ExecuteNonQuery();

 
            }
            catch { }
        }
        public void delete(string a)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM RMS WHERE Pid='" + a + "'";
                cmd.ExecuteNonQuery();
               
                con.Close();
            }
            catch
            { }

        }
       

    }
}
