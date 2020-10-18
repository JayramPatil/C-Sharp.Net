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
using System.Data.Common;

//Data Source=.\SQLEXPRESS;Initial Catalog=Practice_Assignment1_DB;Integrated Security=True

namespace Practice_Assignment1
{
    public partial class frm_Add : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Practice_Assignment1_DB;Integrated Security=True");

        void Con_Open()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public frm_Add()
        {
            InitializeComponent();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(tb_Name.Text != "" && tb_Father.Text != "" && tb_Mother.Text != "")
            {
                MessageBox.Show("Saved SuccessFully");

                Con_Open();

                SqlDataAdapter sda = new SqlDataAdapter("insert into Student_Info values ('" + tb_Name.Text + "','" + tb_Father.Text + "','" + tb_Mother.Text + "'," + dtp_DOB.Text + ",'" + cmb_Add_In.Text + "')", con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

            }
            else
            {
                MessageBox.Show("Please Fill All Required Fields !");
            }
            tb_Name.Text = "";
            tb_Father.Text = "";
            tb_Mother.Text = "";
            dtp_DOB.ResetText();
            tb_Name.Focus();
            cmb_Add_In.SelectedIndex = -1;
        }

        private void btn_ViewAll_Click(object sender, EventArgs e)
        {
            View_Students obj = new View_Students();

            obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
            tb_Father.Text = "";
            tb_Mother.Text = "";
            dtp_DOB.ResetText();
            tb_Name.Focus();
            cmb_Add_In.SelectedIndex = -1;
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Father_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Mother_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();

            this.Hide();
            obj.Show();
        }
    }
}
