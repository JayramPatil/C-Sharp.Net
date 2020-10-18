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
    public partial class Update_Professor : Form
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
        public Update_Professor()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("select * from Professor_Info where Name = '" + tb_Name.Text + "'", Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Father.Text = obj.GetString(obj.GetOrdinal("Father_Name"));
                tb_Surname.Text = obj.GetString(obj.GetOrdinal("Surname"));
                dtp_DOB.Text = (obj["DOB"].ToString());
                cmb_Qualification.Text = obj.GetString(obj.GetOrdinal("Qualification"));
                tb_Mobile.Text = (obj["Mobile_Number"].ToString());
                tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                tb_Adhaar.Text = (obj["Adhaar"].ToString());

                string RadioButton = obj.GetString(obj.GetOrdinal("Gender"));

                if (RadioButton == rb_Male.Text)
                {
                    rb_Male.Checked = true;
                }
                else
                {
                    rb_Female.Checked = true;
                }

                int Selected_CB = Int32.Parse(obj["Selected_Checkboxs"].ToString());


                while (Selected_CB > 0)
                {
                    if (Selected_CB % 10 == 1)
                    {
                        cb_1.Checked = true;
                    }
                    else if (Selected_CB % 10 == 2)
                    {
                        cb_2.Checked = true;
                    }
                    else if (Selected_CB % 10 == 3)
                    {
                        cb_3.Checked = true;
                    }
                    else if (Selected_CB % 10 == 4)
                    {
                        cb_4.Checked = true;
                    }
                    Selected_CB /= 10;
                }


            }

            Con_Close();

            tb_Name.Enabled = true;
            tb_Father.Enabled = true;
            tb_Surname.Enabled = true;
            tb_Mobile.Enabled = true;
            tb_Address.Enabled = true;
            tb_Adhaar.Enabled = true;
            dtp_DOB.Enabled = true;
            cmb_Qualification.Enabled = true;
            groupBox1.Enabled = true;
            rb_Male.Enabled = true;
            rb_Female.Enabled = true;
            cb_1.Enabled = true;
            cb_2.Enabled = true;
            cb_3.Enabled = true;
            cb_4.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
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

            CheckBox = CheckBox.Remove(CheckBox.Length - 2, 2);

            if (rb_Male.Checked)
            {
                Experience = "Male";
            }
            else
            {
                Experience = "Female";
            }


            SqlDataAdapter sda = new SqlDataAdapter("update Professor_Info set Name = '" + tb_Name.Text + "',Father_Name = '" + tb_Father.Text + "',Surname = '" + tb_Surname.Text + "',DOB = '" + dtp_DOB.Text + "',Qualification = '" + cmb_Qualification.Text + "',Mobile_Number = " + tb_Mobile.Text + ",Address = '" + tb_Address.Text + "',Adhaar = " + tb_Adhaar.Text + ",Gender = '" + Experience + "',Experience = '" + CheckBox + "',Selected_Checkboxs = " + Cb + " where Name = '" + tb_Name.Text + "'", Con);

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
            groupBox1.Enabled = false;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            cb_1.Checked = false;
            cb_2.Checked = false;
            cb_3.Checked = false;
            cb_4.Checked = false;
            tb_Name.Focus();

            tb_Father.Enabled = false;
            tb_Surname.Enabled = false;
            tb_Mobile.Enabled = false;
            tb_Address.Enabled = false;
            tb_Adhaar.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Qualification.Enabled = false;
            groupBox1.Enabled = false;
            cb_1.Enabled = false;
            cb_2.Enabled = false;
            cb_3.Enabled = false;
            cb_4.Enabled = false;
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
            groupBox1.Enabled = false;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            cb_1.Checked = false;
            cb_2.Checked = false;
            cb_3.Checked = false;
            cb_4.Checked = false;
            tb_Name.Focus();

            tb_Father.Enabled = false;
            tb_Surname.Enabled = false;
            tb_Mobile.Enabled = false;
            tb_Address.Enabled = false;
            tb_Adhaar.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Qualification.Enabled = false;
            groupBox1.Enabled = false;
            cb_1.Enabled = false;
            cb_2.Enabled = false;
            cb_3.Enabled = false;
            cb_4.Enabled = false;
        }
    }
}
