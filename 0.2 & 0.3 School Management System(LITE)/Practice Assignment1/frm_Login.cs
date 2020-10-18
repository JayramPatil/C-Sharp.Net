using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Assignment1
{
    public partial class frm_Login : Form
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
        public frm_Login()
        {
            InitializeComponent();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("select count(*) from Login where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "'", Con);

            if (Convert.ToInt32(Cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login Successful !", "Login");

                MDI_Form obj = new MDI_Form();
                //frm_Add obj = new frm_Add();

                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password !", "Login");
            }

            tb_Password.Clear();
            tb_Username.Clear();
            tb_Password.Enabled = false;
            btn_Login.Enabled = false;
            tb_Username.Focus();

            Con_Close();
        }
    }
}
