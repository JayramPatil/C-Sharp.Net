using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successfully", "Welcome");
                frm_Add_Customer obj = new frm_Add_Customer();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please, Fill The Required Fields First !", "Warning");
                lbl_Error.Text = "PLEASE ENTER VALID USERNAME & PASSWORD";
            }
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
            lbl_Error.Text = "Login To Continue";
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
        }
    }
}
