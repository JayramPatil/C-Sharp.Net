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
    public partial class Delete : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Practice_Assignment1_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
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
        public Delete()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Father.Text = "";
            tb_Mother.Text = "";
            tb_Addin.Text = "";
            tb_Name.Text = "";
            tb_DOB.Text = "";
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
                tb_DOB.Text = (obj["Date_Of_Birth"].ToString());
                tb_Addin.Text = (obj["Class"].ToString());
            }
            else
            {
                MessageBox.Show("NO SUCH STUDENT EXIST !", "Error");
                tb_Name.Clear();
                tb_Name.Focus();
            }
            Con_Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("delete from Student_Info where Name = '" + tb_Name.Text + "'", Con);

            Cmd.ExecuteReader();

            tb_Father.Text = "";
            tb_Mother.Text = "";
            tb_Addin.Text = "";
            tb_Name.Text = "";
            tb_DOB.Text = "";

            tb_Name.Focus();

            Con_Close();
        }
    }
}
