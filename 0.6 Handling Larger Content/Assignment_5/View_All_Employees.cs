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

namespace Assignment_5
{
    public partial class View_All_Employees : Form
    {
        public View_All_Employees()
        {
            InitializeComponent();
        }

        private void View_All_Employees_Load(object sender, EventArgs e)
        {
            Database obj = new Database();

            obj.Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * From Assignment_5", obj.Con);

            DataTable Dt = new DataTable();

            sda.Fill(Dt);

            dataGridView1.DataSource = Dt;

        }
    }
}
