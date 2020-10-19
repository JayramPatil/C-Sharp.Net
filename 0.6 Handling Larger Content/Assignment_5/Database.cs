using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment_5
{
    public class Database
    {
        public SqlConnection Con = new SqlConnection(@"Data Source=MY-PC;Initial Catalog=Assignment_5;Integrated Security=True");

        public void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
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
    }
}
