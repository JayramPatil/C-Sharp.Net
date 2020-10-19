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
    public partial class Add_Product : Form
    {
        Database DB = new Database();
        public Add_Product()
        {
            InitializeComponent();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string cmd = "insert into Product_Info values ('" + tb_Brand.Text + "','" + tb_Model.Text + "'," + tb_Quantity.Text + "," + tb_P_Price.Text + "," + tb_S_Price.Text + ")";

            DB.Insert(cmd);
        }
    }
}
