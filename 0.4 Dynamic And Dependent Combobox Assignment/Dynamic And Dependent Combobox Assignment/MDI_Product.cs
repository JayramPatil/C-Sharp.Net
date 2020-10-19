using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_And_Dependent_Combobox_Assignment
{
    public partial class MDI_Product : Form
    {
        public MDI_Product()
        {
            InitializeComponent();
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Add_Customer obj = new frm_Add_Customer();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product obj = new Add_Product();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void vIEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Product obj = new View_Product();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
    }
}
