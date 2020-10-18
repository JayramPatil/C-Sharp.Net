namespace Assignment_1
{
    partial class frm_Add_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Customer));
            this.lbl_Add_Cust = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_All_Employee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_Cust
            // 
            this.lbl_Add_Cust.BackColor = System.Drawing.Color.White;
            this.lbl_Add_Cust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Add_Cust.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Cust.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_Cust.Location = new System.Drawing.Point(0, 0);
            this.lbl_Add_Cust.Name = "lbl_Add_Cust";
            this.lbl_Add_Cust.Size = new System.Drawing.Size(1836, 98);
            this.lbl_Add_Cust.TabIndex = 1;
            this.lbl_Add_Cust.Text = "ADD EMPLOYEE";
            this.lbl_Add_Cust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Add_Cust);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1836, 98);
            this.panel1.TabIndex = 2;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(1116, 193);
            this.tb_ID.MaxLength = 10;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(505, 38);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // lbl_ID
            // 
            this.lbl_ID.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(422, 190);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(468, 47);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(1116, 439);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(505, 38);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Mob_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.Location = new System.Drawing.Point(422, 436);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(468, 47);
            this.lbl_Mob_No.TabIndex = 6;
            this.lbl_Mob_No.Text = "MOBILE NUMBER";
            this.lbl_Mob_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(1116, 318);
            this.tb_Name.MaxLength = 10;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(505, 38);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Name
            // 
            this.lbl_Name.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(422, 315);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(468, 47);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "NAME";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_DOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(422, 561);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(468, 47);
            this.lbl_DOB.TabIndex = 9;
            this.lbl_DOB.Text = "DATE OF BIRTH";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_City
            // 
            this.lbl_City.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_City.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(422, 682);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(468, 47);
            this.lbl_City.TabIndex = 10;
            this.lbl_City.Text = "CITY";
            this.lbl_City.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(1116, 561);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(505, 38);
            this.dtp_DOB.TabIndex = 4;
            // 
            // cmb_City
            // 
            this.cmb_City.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Items.AddRange(new object[] {
            "Karad",
            "Mumbai",
            "Pune",
            "Sangli",
            "Satara"});
            this.cmb_City.Location = new System.Drawing.Point(1116, 685);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(505, 39);
            this.cmb_City.Sorted = true;
            this.cmb_City.TabIndex = 5;
            this.cmb_City.Text = "Karad";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MintCream;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Save.Location = new System.Drawing.Point(594, 793);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(364, 73);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_All_Employee
            // 
            this.btn_View_All_Employee.BackColor = System.Drawing.Color.MintCream;
            this.btn_View_All_Employee.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_View_All_Employee.Location = new System.Drawing.Point(1072, 793);
            this.btn_View_All_Employee.Name = "btn_View_All_Employee";
            this.btn_View_All_Employee.Size = new System.Drawing.Size(364, 73);
            this.btn_View_All_Employee.TabIndex = 7;
            this.btn_View_All_Employee.Text = "VIEW ALL EMPLOYEE\'S";
            this.btn_View_All_Employee.UseVisualStyleBackColor = false;
            this.btn_View_All_Employee.Click += new System.EventHandler(this.btn_View_All_Employee_Click);
            // 
            // frm_Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1836, 877);
            this.Controls.Add(this.btn_View_All_Employee);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Add_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Cust;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_All_Employee;
    }
}