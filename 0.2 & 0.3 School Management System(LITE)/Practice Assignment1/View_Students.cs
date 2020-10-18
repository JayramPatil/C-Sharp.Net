using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Assignment1
{
    public partial class View_Students : Form
    {
        public View_Students()
        {
            InitializeComponent();
        }

        private void View_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'practice_Assignment1_DBDataSet.Student_Info' table. You can move, or remove it, as needed.
            this.student_InfoTableAdapter.Fill(this.practice_Assignment1_DBDataSet.Student_Info);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();

            this.Hide();
            obj.Show();
        }
    }
}
