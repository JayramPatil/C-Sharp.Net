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
    public partial class ViewAllProfessors : Form
    {
        public ViewAllProfessors()
        {
            InitializeComponent();
        }

        private void ViewAllProfessors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'practice_Assignment1_DBDataSet1.Professor_Info' table. You can move, or remove it, as needed.
            this.professor_InfoTableAdapter.Fill(this.practice_Assignment1_DBDataSet1.Professor_Info);

        }
    }
}
