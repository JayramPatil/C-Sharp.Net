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

namespace Practice_Assignment1
{
    public partial class Update : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Practice_Assignment1_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        public Update()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("update Student_Info set Name = '" + tb_Name.Text + "',Father_Name = '" + tb_Father.Text + "', Mother_Name = '" + tb_Mother.Text + "', Date_Of_Birth = '" + dtp_DOB.Text + "', Class = '" + tb_Addin.Text + "' where Name = '" + tb_Name.Text + "'", Con);

            cmd.ExecuteReader();

            Con_Close();

            tb_Father.Text = "";
            tb_Mother.Text = "";
            tb_Addin.Text = "";
            tb_Name.Text = "";
            tb_Father.Enabled = false;
            tb_Mother.Enabled = false;
            tb_Addin.Enabled = false;
            dtp_DOB.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("select * from Student_Info where Name = '" + tb_Name.Text + "' ", Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Mother.Text = obj.GetString(obj.GetOrdinal("Mother_Name"));
                tb_Father.Text = obj.GetString(obj.GetOrdinal("Father_Name"));
                dtp_DOB.Text = (obj["Date_Of_Birth"].ToString());
                tb_Addin.Text = (obj["Class"].ToString());
            }
            else
            {
                MessageBox.Show("NO SUCH STUDENT EXIST !", "Error");
                tb_Name.Clear();
                tb_Name.Focus();
            }

            tb_Father.Enabled = true;
            tb_Mother.Enabled = true;
            tb_Addin.Enabled = true;
            dtp_DOB.Enabled = true;

            Con_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Father.Text = "";
            tb_Mother.Text = "";
            tb_Addin.Text = "";
            tb_Name.Text = "";
            tb_Father.Enabled = false;
            tb_Mother.Enabled = false;
            tb_Addin.Enabled = false;
        }
    }
}
