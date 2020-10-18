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

namespace Assignment_1
{
    public partial class frm_Add_Customer : Form
    {
        //@"Data Source=.\SQLEXPRESS;Initial Catalog=Assignment_1_DB;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Assignment1_DB;Integrated Security=True");
        
        void Con_Open()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public frm_Add_Customer()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(tb_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "")
            {
                Con_Open();

                SqlDataAdapter sda = new SqlDataAdapter("insert into abc values (" + tb_ID.Text + ",'" + tb_Name.Text + "'," + tb_Mob_No.Text + ",'" + dtp_DOB.Text + "','" + cmb_City.Text + "')",con);

                DataTable dt = new DataTable();

                sda.Fill(dt);
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!", "Warning");
            }
            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_Mob_No.Text = "";
            dtp_DOB.Text = "";
            cmb_City.Text = "";
            tb_ID.Focus();
        }

        private void btn_View_All_Employee_Click(object sender, EventArgs e)
        {
            frm_View_Employee obj = new frm_View_Employee();
            obj.Show();
            this.Hide();
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
