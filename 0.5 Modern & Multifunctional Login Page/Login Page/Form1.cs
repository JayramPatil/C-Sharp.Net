using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class frm_Login : Form
    {
        Database DB = new Database();
        public frm_Login()
        {
            InitializeComponent();
            btn_SignUp.Enabled = false;
            btn_ChangePassword.Enabled = false;
        }
        public void EnableBtn(Label lbl, Label lbl_panel_P, Label lbl_panel_CP, Button btn)
        {
            if (lbl.Visible == true || lbl_panel_P.Text != "STRONG" || lbl_panel_CP.Text != "MATCHED")
            {
                btn.Enabled = false;
            }
            else
            {
                btn.Enabled = true;
            }
        }
        public void ClearTextBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {
                foreach (Control control1 in control.Controls)
                {
                    foreach (Control control2 in control1.Controls)
                    {
                        if (control2.GetType() == typeof(TextBox))
                        {
                            control2.Text = "";
                        }
                    }
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (DB.Login(tb_Username.Text, tb_Password.Text))
            {
                MessageBox.Show("Login Successfull");
            }
            else
            {
                MessageBox.Show("Login Failed ");
            }

            ClearTextBoxes(this);
            /*tb_Username.Text = "";
            tb_Password.Text = "";*/
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (DB.CheckKey("Admin", tb_AdminKey.Text))
            {
                lbl_WAK.Visible = true;
            }
            else
            {
                string Year = DateTime.Now.Year.ToString();

                string UserKey = tb_NewUsername.Text + "_" + Year;

                string Query = "Insert into LoginAdminKey values('" + tb_NewUsername.Text + "','" + tb_NewPassword.Text + "','" + UserKey + "')";

                DB.Insert(Query);

                MessageBox.Show("New User Added Successfully !");

                tb_NewUsername.Text = "";
                tb_NewPassword.Text = "";
                tb_ConfirmPassword.Text = "";
                tb_AdminKey.Text = "";

            }

        }

        private void Password(TextBox tb, Panel panel , Label lbl)
        {
            if (tb.TextLength == 0)
            {
                panel.Visible = false;
                lbl.Visible = false;
            }
            else if (tb.TextLength <= 4)
            {
                panel.Visible = true;
                panel.BackColor = Color.DarkRed;
                panel.Width = 60;
                lbl.Visible = true;
                lbl.Text = "WEAK";
                lbl.Width = 65;
            }
            else if (tb.TextLength <= 9)
            {
                panel.BackColor = Color.DarkOrange;
                panel.Width = 150;
                lbl.Width = 165;
                lbl.Text = "AVERAGE";
            }
            else
            {
                panel.BackColor = Color.DarkGreen;
                panel.Width = 230;
                lbl.Text = "STRONG";
                lbl.Width = 240;
            }
        }
        public void ConfirmPassword(TextBox tb, Panel panel, Label lbl, TextBox tb_New)
        {
            if (tb.Text == tb_New.Text)
            {
                panel.Width = 225;
                panel.BackColor = Color.DarkGreen;
                lbl.Text = "MATCHED";
            }
            else
            {

                panel.Width = 190;
                panel.BackColor = Color.DarkRed;
                lbl.Text = " NOT MATCHED";
            }
        }

        private void tb_NewPassword_TextChanged(object sender, EventArgs e)
        {

            Password(tb_NewPassword, panel_Password, lbl_panel_Password);
        }

        
        private void tb_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tb_ConfirmPassword.TextLength == 0)
            {
                panel_ConfirmPassword.Visible = false;
                lbl_panel_ConfirmPassword.Visible = false;
            }
            panel_ConfirmPassword.Visible = true;
            lbl_panel_ConfirmPassword.Visible = true;
            ConfirmPassword(tb_ConfirmPassword,panel_ConfirmPassword,lbl_panel_ConfirmPassword,tb_NewPassword);
        }

        private void tb_NewUsername_TextChanged(object sender, EventArgs e)
        {
            if (DB.CheckUsername(tb_NewUsername.Text))
            {
                lbl_UAE.Visible = true;
            }
            else
            {
                lbl_UAE.Visible = false;
            }
        }

        private void tb_AdminKey_TextChanged(object sender, EventArgs e)
        {
            lbl_WAK.Visible = false;
        }

        private void lbl_UAE_TextChanged(object sender, EventArgs e)
        {

            EnableBtn(lbl_UAE, lbl_panel_Password,lbl_panel_ConfirmPassword,btn_SignUp);
        }

        private void lbl_panel_Password_TextChanged(object sender, EventArgs e)
        {
            EnableBtn(lbl_UAE, lbl_panel_Password, lbl_panel_ConfirmPassword, btn_SignUp);
            ConfirmPassword(tb_ConfirmPassword, panel_ConfirmPassword, lbl_panel_ConfirmPassword, tb_NewPassword);
        }

        private void lbl_panel_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            EnableBtn(lbl_UAE, lbl_panel_Password, lbl_panel_ConfirmPassword, btn_SignUp);
        }

        private void lbl_panel_FNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void tb_FNewPassword_TextChanged(object sender, EventArgs e)
        {
            Password(tb_FNewPassword, panel_FNewPassword,lbl_panel_FNewPassword);
        }

        private void tb_FConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            panel_NewConfirmPassword.Visible = true;
            lbl_panel_FNewConfirmPassword.Visible = true;
            ConfirmPassword(tb_FConfirmPassword, panel_NewConfirmPassword, lbl_panel_FNewConfirmPassword,tb_FNewPassword);
        }

        private void tb_FUsername_TextChanged(object sender, EventArgs e)
        {
            lbl_FUAE.Visible = false;
        }

        private void tb_FUserKey_TextChanged(object sender, EventArgs e)
        {
            lbl_WUK.Visible = false;
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if (!DB.CheckUsername(tb_FUsername.Text))
            {
                lbl_FUAE.Visible = true;
            }

            if (DB.CheckKey(tb_FUsername.Text, tb_FUserKey.Text))
            {
                lbl_WUK.Visible = true;
            }

            else
            {

                string Query = "Update LoginAdminKey set Password = '" + tb_FNewPassword.Text + "' where Username = '" + tb_FUsername.Text + "'";

                DB.Update(Query);

                MessageBox.Show("Password Updated Successfully !");

                tb_FUsername.Text = "";
                tb_FNewPassword.Text = "";
                tb_FConfirmPassword.Text = "";
                tb_FUserKey.Text = "";

            }
        }

        private void lbl_UAE_VisibleChanged(object sender, EventArgs e)
        {
            EnableBtn(lbl_FUAE, lbl_panel_FNewPassword, lbl_panel_FNewConfirmPassword, btn_ChangePassword);
        }

        private void lbl_panel_FNewPassword_TextChanged(object sender, EventArgs e)
        {
            EnableBtn(lbl_FUAE, lbl_panel_FNewPassword, lbl_panel_FNewConfirmPassword, btn_ChangePassword);
        }

        private void lbl_panel_FNewConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            EnableBtn(lbl_FUAE, lbl_panel_FNewPassword, lbl_panel_FNewConfirmPassword, btn_ChangePassword);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                tb_Password.PasswordChar = '\0';
            }
            else
            {
                tb_Password.PasswordChar = '*';
            }
        }
    }
}
