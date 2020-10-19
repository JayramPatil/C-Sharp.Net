namespace Dynamic_And_Dependent_Combobox_Assignment
{
    partial class View_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.cmb_Brand = new System.Windows.Forms.ComboBox();
            this.cmb_Model = new System.Windows.Forms.ComboBox();
            this.lbl_Add_Customer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1501, 156);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(192, 39);
            this.btn_Search.TabIndex = 36;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.Location = new System.Drawing.Point(287, 155);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(235, 40);
            this.lbl_Brand.TabIndex = 32;
            this.lbl_Brand.Text = "Brand";
            this.lbl_Brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Model
            // 
            this.lbl_Model.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Location = new System.Drawing.Point(853, 154);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(235, 40);
            this.lbl_Model.TabIndex = 33;
            this.lbl_Model.Text = "Model";
            this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(528, 158);
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(267, 37);
            this.cmb_Brand.TabIndex = 34;
            this.cmb_Brand.SelectedIndexChanged += new System.EventHandler(this.cmb_Brand_SelectedIndexChanged);
            // 
            // cmb_Model
            // 
            this.cmb_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Model.FormattingEnabled = true;
            this.cmb_Model.Location = new System.Drawing.Point(1094, 158);
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.Size = new System.Drawing.Size(285, 37);
            this.cmb_Model.TabIndex = 35;
            // 
            // lbl_Add_Customer
            // 
            this.lbl_Add_Customer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Add_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Add_Customer.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Customer.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_Customer.Location = new System.Drawing.Point(0, 0);
            this.lbl_Add_Customer.Name = "lbl_Add_Customer";
            this.lbl_Add_Customer.Size = new System.Drawing.Size(1732, 100);
            this.lbl_Add_Customer.TabIndex = 31;
            this.lbl_Add_Customer.Text = "View Product";
            this.lbl_Add_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Add_Customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1732, 100);
            this.panel1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1732, 509);
            this.dataGridView1.TabIndex = 39;
            // 
            // View_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 750);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_Model);
            this.Controls.Add(this.cmb_Brand);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.btn_Search);
            this.Name = "View_Product";
            this.Text = "View Product";
            this.Load += new System.EventHandler(this.View_Product_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.ComboBox cmb_Brand;
        private System.Windows.Forms.Label lbl_Add_Customer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Model;
    }
}