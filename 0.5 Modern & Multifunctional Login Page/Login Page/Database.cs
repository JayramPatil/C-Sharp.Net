using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login_Page
{
    public class Database
    {
        public SqlConnection Con = new SqlConnection(@"Data Source=MY-PC;Initial Catalog=JayramP;Integrated Security=True");

        public void Con_Open()
        {
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        public void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        public void Insert(string Query)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            Con_Close();
        }

        public bool Login(string UN, string PW)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("select count(*) from LoginAdminKey where Username = '" + UN + "' AND Password = '" + PW + "'", Con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                Con_Close();
                return true;
            }

            Con_Close();

            return false;
        }
        public bool CheckUsername(string Username)
        {
            Con_Open();
            
            SqlCommand cmd = new SqlCommand("select Count(*) from LoginAdminKey where Username = '" + Username + "' ", Con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                Con_Close();
                return true;
            }

            Con_Close();

            return false;
        }
        public bool CheckKey(string Username ,string key)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("select Count(*) from LoginAdminKey where Username = '" + Username + "' And AdminKey = '" + key + "'", Con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                Con_Close();
                return false;
            }

            Con_Close();

            return true;
        }
        public void Update(string Query)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand(Query, Con);

            cmd.ExecuteNonQuery();

            Con_Close();
        }
    }
}
