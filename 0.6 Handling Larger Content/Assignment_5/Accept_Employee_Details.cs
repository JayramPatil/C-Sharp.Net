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
    public partial class Accept_Employee_Details : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=MY-PC;Initial Catalog=Assignment_5;Integrated Security=True");
        int i = 0;

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
        public Accept_Employee_Details()
        {
            InitializeComponent();
        }
        public Accept_Employee_Details(int iNo)
        {
            InitializeComponent();
            i = iNo;
            if (i == 1)
            {
                label1.Text = "Search Employee";
                btn_Submit.Text = "Refresh";
                foreach (Control cnt1 in this.Controls)
                {
                    foreach (Control cnt2 in cnt1.Controls)
                    {
                        cnt2.Enabled = false;
                    }
                }
                tb_EmpID.Enabled = true;
                btn_Search.Visible = true;
                btn_Search.Enabled = true;
                rtb_OtherHobbies.Visible = false;
                label6.Visible = false;
                clb_Hobbies.Items.Clear();
            }
            else if(i == 2)
            {
                label1.Text = "Update Employee Details";
                btn_Submit.Text = "Update";
                foreach (Control cnt1 in this.Controls)
                {
                    foreach (Control cnt2 in cnt1.Controls)
                    {
                        cnt2.Enabled = false;
                    }
                }
                tb_EmpID.Enabled = true;
                btn_Search.Visible = true;
                btn_Search.Enabled = true;
                clb_Hobbies.Items.Clear();
                rtb_OtherHobbies.Enabled = true;
            }
            if (i == 3)
            {
                label1.Text = "Delete Employee";
                btn_Submit.Text = "Delete";
                foreach (Control cnt1 in this.Controls)
                {
                    foreach (Control cnt2 in cnt1.Controls)
                    {
                        cnt2.Enabled = false;
                    }
                }
                tb_EmpID.Enabled = true;
                btn_Search.Visible = true;
                btn_Search.Enabled = true;
                rtb_OtherHobbies.Visible = false;
                label6.Visible = false;
                clb_Hobbies.Items.Clear();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(i == 0 || i == 2)
            { 
                Con_Open();

                String rb = (rb_Male.Checked) ? "Male" : "Female";
                string Shift = (rb_Morning.Checked) ? "Morning" : (rb_Evening.Checked) ? "Evening" : "Night";
                string Projects = "";
                string Hobbies = "";

                foreach (CheckBox Cb in groupBox3.Controls)
                {
                    if(Cb.Checked)
                    {
                        if(Projects == "")
                        {
                            Projects = Cb.Text;
                        }
                        else
                        {
                            Projects += " ," + Cb.Text;
                        }
                    }
                }
                for (int i = 0 ; i <= clb_Hobbies.Items.Count - 1; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (i == 5 && rtb_OtherHobbies.Text != "")
                        {
                            Hobbies += " ," + rtb_OtherHobbies.Text;
                        }
                        else if (Hobbies == "")
                        {
                            Hobbies = clb_Hobbies.Items[i].ToString();
                        }
                        else
                        {
                            Hobbies += " ," + clb_Hobbies.Items[i].ToString();
                        }
                    
                    }
                }
                if(i == 0)
                {
                    SqlCommand cmd = new SqlCommand("insert into Assignment_5(Name,Mobile_No,Gender,DOB,Hobbies,Department,Mentor_Name,Shift_Time,Project_Name,Designation,Salary) values ('" + tb_Name.Text + "'," + tb_MobileNo.Text + ",'" + rb + "','" + dtp_DOB.Text + "','" + Hobbies + "','" + cmb_Department.Text + "','" + cmb_MentorName.Text + "','" + Shift + "','" + Projects + "','" + cmb_Designation.Text + "'," + tb_Salary.Text + ")", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Successfully");
                }
                else if(i == 2)
                {
                    SqlCommand cmd = new SqlCommand("update Assignment_5 set Name ='" + tb_Name.Text + "',Mobile_No = " + tb_MobileNo.Text + ",Gender = '" + rb + "',DOB = '" + dtp_DOB.Text + "',Hobbies = '" + Hobbies + "',Department = '" + cmb_Department.Text + "',Mentor_Name = '" + cmb_MentorName.Text + "',Shift_Time = '" + Shift + "',Project_Name = '" + Projects + "',Designation = '" + cmb_Designation.Text + "',Salary = " + tb_Salary.Text + " where ID = " + tb_EmpID.Text + "", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                }

                Con_Close();
            }
            if(i == 3)
            {
                Con_Open();
                SqlCommand cmd = new SqlCommand("Delete from Assignment_5 where ID = " + tb_EmpID.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully");
                Con_Close();
            }

            foreach (Control Control1 in this.Controls)
            {
                foreach (Control Control2 in Control1.Controls)
                {
                    if (Control2.GetType() == typeof(GroupBox))
                    {
                        foreach (Control cb in Control2.Controls)
                        {
                            if (cb.GetType() == typeof(CheckBox))
                            {
                                CheckBox chk = (CheckBox)cb;
                                chk.Checked = false;
                            }
                            else if (cb.GetType() == typeof(RadioButton))
                            {
                                RadioButton rb = (RadioButton)cb;
                                rb.Checked = false;
                            }

                        }
                    }
                    else if (Control2.GetType() == typeof(TextBox) || Control2.GetType() == typeof(RichTextBox))
                    {
                        Control2.Text = "";
                    }
                    else if(Control2.GetType() == typeof(CheckedListBox))
                    {
                        CheckedListBox clb = (CheckedListBox)Control2;
                        for (int i = 0; i < clb.Items.Count; i++)
                        {
                            clb.SetItemChecked(i, false);
                        }
                    }
                }
            }

            cmb_Department.SelectedIndex = -1;
            cmb_Designation.SelectedIndex = -1;
            cmb_MentorName.SelectedIndex = -1;
            cmb_Department.Text = "";
            cmb_Designation.Text = "";
            cmb_MentorName.Text = "";
            clb_Hobbies.Items.Clear();
            
        }

        private void clb_Hobbies_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void clb_Hobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clb_Hobbies.GetItemChecked(5))
            {
                rtb_OtherHobbies.Enabled = true;
            }
            else if (!clb_Hobbies.GetItemChecked(5))
            {
                rtb_OtherHobbies.Enabled = false;
            }
        }

        private void Accept_Employee_Details_Load(object sender, EventArgs e)
        {
            Con_Open();
            cmb_MentorName.Items.Clear();
            cmb_MentorName.Text = "";

            if (i == 0)
            {
                SqlCommand cmd = new SqlCommand("select MAX(ID) from Assignment_5", Con);

                tb_EmpID.Text = (((int)cmd.ExecuteScalar()) + 1).ToString();

                cmd.Dispose();

                cmd = new SqlCommand("Select Distinct Department From Mentor_Table", Con);

                var obj = cmd.ExecuteReader();

                while (obj.Read())
                {
                    cmb_Department.Items.Add(obj.GetString(obj.GetOrdinal("Department")));
                }
            }
            Con_Close();
        }

        private void cmb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (i != 1)
            {
                Con_Open();
                cmb_MentorName.Items.Clear();
                cmb_MentorName.Text = "";

                SqlCommand cmd = new SqlCommand("select Name from Mentor_Table where Department = '" + cmb_Department.Text + "'", Con);

                var obj = cmd.ExecuteReader();

                while (obj.Read())
                {
                    cmb_MentorName.Items.Add(obj.GetString(obj.GetOrdinal("Name")));
                }
                Con_Close();
            }
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * from Assignment_5 where ID = " + tb_EmpID.Text + "",Con);

            var obj = cmd.ExecuteReader();

            cmd.Dispose();

            if (obj.Read())
            {
                tb_MobileNo.Text = (obj["Mobile_No"].ToString());
                tb_Name.Text = obj["Name"].ToString();
                if(obj["Gender"].ToString() == "Male")
                {
                    rb_Male.Checked = true;
                }
                else
                {
                    rb_Female.Checked = true;
                }
                dtp_DOB.Text = obj["DOB"].ToString();
                tb_Salary.Text = obj["Salary"].ToString();


                clb_Hobbies.Items.Clear();
                string str = obj["Hobbies"].ToString();
                string[] Hobbie = str.Split(',');
                foreach (string Hobbies in Hobbie)
                {
                    clb_Hobbies.Items.Add(Hobbies, true);
                }
                cmb_Department.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_Department.Text = obj["Department"].ToString();
                cmb_MentorName.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_MentorName.Text = obj["Mentor_Name"].ToString();
                cmb_Designation.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_Designation.Text = obj["Designation"].ToString();

                if (obj["Shift_Time"].ToString() == "Morning")
                {
                    rb_Morning.Checked = true;
                }
                else if (obj["Shift_Time"].ToString() == "Evening")
                {
                    rb_Evening.Checked = true;
                }
                else
                {
                    rb_Night.Checked = true;
                }

                foreach (CheckBox chk in groupBox3.Controls)
                {
                    chk.Checked = false;
                }
                string Project = obj["Project_Name"].ToString();
                string[] Project_Names = Project.Split(',');
                foreach (string Pj in Project_Names)
                {
                    foreach (CheckBox chk in groupBox3.Controls)
                    {
                        if(Pj.Contains(chk.Text))
                        {
                            chk.Checked = true;
                        }
                    }
                }

                /*for (int i = 0; str[i] != '\0';)
                {
                    if(str[i] == ',')
                    {
                        i++;
                        Hobbie = "";
                        continue;
                    }
                    while(str[i] != ',' && str[i] != '\0')
                    {
                        Hobbie += str[i];
                        i++;
                        continue;
                    }
                    clb_Hobbies.Items.Add(Hobbie, true);
                }*/
            }
            else
            {
                MessageBox.Show("Enter Valid ID");

                foreach (Control Control1 in this.Controls)
                {
                    foreach (Control Control2 in Control1.Controls)
                    {
                        if (Control2.GetType() == typeof(GroupBox))
                        {
                            foreach (Control cb in Control2.Controls)
                            {
                                if (cb.GetType() == typeof(CheckBox))
                                {
                                    CheckBox chk = (CheckBox)cb;
                                    chk.Checked = false;
                                }
                                else if (cb.GetType() == typeof(RadioButton))
                                {
                                    RadioButton rb = (RadioButton)cb;
                                    rb.Checked = false;
                                }

                            }
                        }
                        else if (Control2.GetType() == typeof(TextBox) || Control2.GetType() == typeof(RichTextBox))
                        {
                            Control2.Text = "";
                        }
                        else if (Control2.GetType() == typeof(CheckedListBox))
                        {
                            CheckedListBox clb = (CheckedListBox)Control2;
                            for (int i = 0; i < clb.Items.Count; i++)
                            {
                                clb.SetItemChecked(i, false);
                            }
                        }
                    }
                }

                cmb_Department.SelectedIndex = -1;
                cmb_Designation.SelectedIndex = -1;
                cmb_MentorName.Text = "";
                clb_Hobbies.Items.Clear();

            }
            if(i == 2)
            {
                foreach (Control cnt1 in this.Controls)
                {
                    foreach (Control cnt2 in cnt1.Controls)
                    {
                        cnt2.Enabled = true;
                    }
                }
            }
            Con_Close();
        }
    }
}
