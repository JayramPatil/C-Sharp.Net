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
    public partial class MDI_Form : Form
    {
        public MDI_Form()
        {
            InitializeComponent();
        }

        private void tsm_Add_Click(object sender, EventArgs e)
        {
            frm_Add obj = new frm_Add();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();

            this.Hide();
            obj.Show();
        }

        private void tsm_View_Click(object sender, EventArgs e)
        {
            View_Students obj = new View_Students();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search obj = new Search();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update obj = new Update();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete obj = new Delete();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Professor obj = new Add_Professor();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewAllProfessorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllProfessors obj = new ViewAllProfessors();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Professor obj = new Search_Professor();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateProfessorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Professor obj = new Update_Professor();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void deleteProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Professor obj = new Delete_Professor();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();

            this.Hide();
            obj.Show();
        }
    }
}
