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
    public partial class Add_Professor : Form
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
        public Add_Professor()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Father.Clear();
            tb_Surname.Clear();
            tb_Mobile.Clear();
            tb_Address.Clear();
            tb_Adhaar.Clear();
            dtp_DOB.ResetText();
            cmb_Qualification.SelectedIndex = -1;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            cb_1.Checked = false;
            cb_2.Checked = false;
            cb_3.Checked = false;
            cb_4.Checked = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            string CheckBox = "";
            int Cb = 0;
            string Experience;

            if (cb_1.Checked)
            {
                CheckBox = CheckBox + cb_1.Text + ", ";
                Cb = (Cb * 10) + 1;
            }
            if (cb_2.Checked)
            {
                CheckBox = CheckBox + cb_2.Text + ", ";
                Cb = (Cb * 10) + 2;
            }
            if (cb_3.Checked)
            {
                CheckBox = CheckBox + cb_3.Text + ", ";
                Cb = (Cb * 10) + 3;
            }
            if (cb_4.Checked)
            {
                CheckBox = CheckBox + cb_4.Text + ", ";
                Cb = (Cb * 10) + 4;
            }

            CheckBox = CheckBox.Remove(CheckBox.Length -2,2);

            if (rb_Male.Checked)
            {
                Experience = "Male";
            }
            else
            {
                Experience = "Female";
            }


            SqlDataAdapter sda = new SqlDataAdapter("insert into Professor_Info values ('" + tb_Name.Text + "','" + tb_Father.Text + "','" + tb_Surname.Text + "','" + dtp_DOB.Text + "','" + cmb_Qualification.Text + "'," + tb_Mobile.Text + ",'" + tb_Address.Text + "'," + tb_Adhaar.Text + ",'" + Experience + "','" + CheckBox + "'," + Cb + ")", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            Con_Close();

            MessageBox.Show("Saved Successfully", "Success");

            tb_Name.Clear();
            tb_Father.Clear();
            tb_Surname.Clear();
            tb_Mobile.Clear();
            tb_Address.Clear();
            tb_Adhaar.Clear();
            dtp_DOB.ResetText();
            cmb_Qualification.SelectedIndex = -1;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            cb_1.Checked = false;
            cb_2.Checked = false;
            cb_3.Checked = false;
            cb_4.Checked = false;
        }
    }
}
