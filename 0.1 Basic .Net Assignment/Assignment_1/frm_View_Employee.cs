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
    public partial class frm_View_Employee : Form
    {
        public frm_View_Employee()
        {
            InitializeComponent();
        }

        private void frm_View_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment1_DBDataSet1.abc' table. You can move, or remove it, as needed.
            this.abcTableAdapter.Fill(this.assignment1_DBDataSet1.abc);
            // TODO: This line of code loads data into the 'assignment1_DBDataSet.Table' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'assignment_1_DBDataSet5.Emp1' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'assignment_1_DBDataSet4.Emp1' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'assignment_1_DBDataSet3.Emp1' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'assignment_1_DBDataSet2.Employee' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'assignment_1_DBDataSet1.Emp' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'assignment_1_DBDataSet.Table' table. You can move, or remove it, as needed.

        }
    }
}
