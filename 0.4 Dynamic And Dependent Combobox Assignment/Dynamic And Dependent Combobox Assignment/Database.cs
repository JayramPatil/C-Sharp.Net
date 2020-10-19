using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dynamic_And_Dependent_Combobox_Assignment
{
    public class Database
    {
        public SqlConnection con = new SqlConnection(@"Data Source=My-PC;Initial Catalog=Product_Assignment_DB;Integrated Security=True");

        public Database()
        {

        }
        public void Con_Open()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void Con_Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void Insert(string cmd)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd,con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            Con_Close();
        }
        public SqlDataReader Load_ComboBox(string cmd)
        {

            Con_Open();

            SqlCommand Cmd = new SqlCommand(cmd, con);

            var obj = Cmd.ExecuteReader();

            Cmd.Dispose();

            return obj;
        }
        public DataTable Fill_DGV(string cmd)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd,con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            Con_Close();

            return dt;
        }
    }
}
