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
    public partial class Search : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Practice_Assignment1_DB;Integrated Security=True");

        void Con_Open()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void Con_Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Search()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("select * from Student_Info where Name = '" + tb_Name.Text + "' ", con);

            var obj = cmd.ExecuteReader();

            if(obj.Read())
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

        private void btn_ViewAll_Click(object sender, EventArgs e)
        {
            View_Students obj = new View_Students();

            this.Hide();
            obj.Show();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Mother.Clear();
            tb_Father.Clear();
            tb_DOB.Clear();
            tb_Addin.Clear();
            tb_Name.Focus();
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void tb_DOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Addin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Add_In_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DOB_Click(object sender, EventArgs e)
        {

        }

        private void tb_Mother_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Mother_Name_Click(object sender, EventArgs e)
        {

        }

        private void tb_Father_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Father_Name_Click(object sender, EventArgs e)
        {

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
