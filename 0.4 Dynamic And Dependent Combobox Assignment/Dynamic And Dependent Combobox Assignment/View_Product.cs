using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_And_Dependent_Combobox_Assignment
{
    public partial class View_Product : Form
    {
        Database DB = new Database();
        public View_Product()
        {
            InitializeComponent();
        }

        private void View_Product_Load(object sender, EventArgs e)
        {
            string cmd = "select Distinct(Brand) From Product_Info";

            var Obj = DB.Load_ComboBox(cmd);

            while(Obj.Read())
            {
                cmb_Brand.Items.Add(Obj.GetString(Obj.GetOrdinal("Brand")));
            }
            Obj.Dispose();

            cmd = "Select * From Product_Info";

            DataTable dt = DB.Fill_DGV(cmd);

            dataGridView1.DataSource = dt;


        }

        private void cmb_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Model.Items.Clear();
            cmb_Model.Text = "";
            string cmd = "select Distinct(Model) from Product_Info where Brand = '" + cmb_Brand.Text + "'";

            var Obj = DB.Load_ComboBox(cmd);

            while (Obj.Read())
            {
                cmb_Model.Items.Add(Obj.GetString(Obj.GetOrdinal("Model")));
            }
            Obj.Dispose();

            cmd = "Select * From Product_Info where Brand = '" + cmb_Brand.Text + "'";

            DataTable dt = DB.Fill_DGV(cmd);

            dataGridView1.DataSource = dt;

        }
    }
}
