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
    public partial class Search_Professor : Form
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

        public Search_Professor()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("select * from Professor_Info where Name = '" + tb_Name.Text + "'", Con);

            var obj = cmd.ExecuteReader();

            if(obj.Read())
            {
                tb_Father.Text = obj.GetString(obj.GetOrdinal("Father_Name"));
                tb_Surname.Text = obj.GetString(obj.GetOrdinal("Surname"));
                dtp_DOB.Text = (obj["DOB"].ToString());
                cmb_Qualification.Text = obj.GetString(obj.GetOrdinal("Qualification"));
                tb_Mobile.Text = (obj["Mobile_Number"].ToString());
                tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                tb_Adhaar.Text = (obj["Adhaar"].ToString());

                string RadioButton = obj.GetString(obj.GetOrdinal("Gender"));

                if(RadioButton == rb_Male.Text)
                {
                    rb_Male.Checked = true;
                }
                else
                {
                    rb_Female.Checked = true;
                }

                int Selected_CB = Int32.Parse(obj["Selected_Checkboxs"].ToString());


                while(Selected_CB > 0)
                {
                    if(Selected_CB % 10 == 1)
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
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            tb_Father.Text = "";
            tb_Surname.Text = "";
            dtp_DOB.Text = "";
            cmb_Qualification.SelectedIndex = -1;
            tb_Mobile.Text = "";
            tb_Address.Text = "";
            tb_Adhaar.Text = "";
            rb_Male.Checked = false;
            rb_Female.Checked = false;

            tb_Name.Text = "";
            tb_Name.Focus();
        }
    }
}
