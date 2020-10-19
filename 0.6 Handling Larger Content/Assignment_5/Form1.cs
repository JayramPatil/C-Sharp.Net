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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Database DB = new Database();

            DB.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(*) From Login where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "'",DB.Con);

            //int i = cmd.ExecuteNonQuery();

            if(Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login Successfully");

                MDIParent1 obj = new MDIParent1();

                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Details");
            }

            tb_Password.Text = "";
            tb_Username.Text = "";
            DB.Con_Close();
 
        }
    }
}
