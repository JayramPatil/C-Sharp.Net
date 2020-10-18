namespace Practice_Assignment1
{
    partial class frm_Add
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Father = new System.Windows.Forms.TextBox();
            this.lbl_Father_Name = new System.Windows.Forms.Label();
            this.tb_Mother = new System.Windows.Forms.TextBox();
            this.lbl_Mother_Name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Add_In = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Add_In = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Add
            // 
            this.lbl_Add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Add.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add.Location = new System.Drawing.Point(0, 0);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(1902, 100);
            this.lbl_Add.TabIndex = 0;
            this.lbl_Add.Text = "ADD STUDENT";
            this.lbl_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(435, 194);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(263, 39);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.tb_Name.Location = new System.Drawing.Point(1212, 197);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(353, 36);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(1020, 831);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(326, 48);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Father
            // 
            this.tb_Father.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.tb_Father.Location = new System.Drawing.Point(1212, 322);
            this.tb_Father.Name = "tb_Father";
            this.tb_Father.Size = new System.Drawing.Size(353, 36);
            this.tb_Father.TabIndex = 2;
            this.tb_Father.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Father_KeyPress);
            // 
            // lbl_Father_Name
            // 
            this.lbl_Father_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Father_Name.Location = new System.Drawing.Point(435, 319);
            this.lbl_Father_Name.Name = "lbl_Father_Name";
            this.lbl_Father_Name.Size = new System.Drawing.Size(263, 39);
            this.lbl_Father_Name.TabIndex = 6;
            this.lbl_Father_Name.Text = "Father Name";
            this.lbl_Father_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mother
            // 
            this.tb_Mother.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.tb_Mother.Location = new System.Drawing.Point(1212, 443);
            this.tb_Mother.Name = "tb_Mother";
            this.tb_Mother.Size = new System.Drawing.Size(353, 36);
            this.tb_Mother.TabIndex = 3;
            this.tb_Mother.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mother_KeyPress);
            // 
            // lbl_Mother_Name
            // 
            this.lbl_Mother_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mother_Name.Location = new System.Drawing.Point(435, 440);
            this.lbl_Mother_Name.Name = "lbl_Mother_Name";
            this.lbl_Mother_Name.Size = new System.Drawing.Size(263, 39);
            this.lbl_Mother_Name.TabIndex = 8;
            this.lbl_Mother_Name.Text = "Mother Name";
            this.lbl_Mother_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(435, 559);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(263, 39);
            this.lbl_DOB.TabIndex = 10;
            this.lbl_DOB.Text = "Date Of Birth";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Add_In
            // 
            this.lbl_Add_In.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_In.Location = new System.Drawing.Point(435, 678);
            this.lbl_Add_In.Name = "lbl_Add_In";
            this.lbl_Add_In.Size = new System.Drawing.Size(263, 39);
            this.lbl_Add_In.TabIndex = 12;
            this.lbl_Add_In.Text = "Addmission In";
            this.lbl_Add_In.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.dtp_DOB.Location = new System.Drawing.Point(1212, 562);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(353, 36);
            this.dtp_DOB.TabIndex = 4;
            this.dtp_DOB.Value = new System.DateTime(2020, 7, 16, 0, 0, 0, 0);
            // 
            // cmb_Add_In
            // 
            this.cmb_Add_In.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Add_In.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.cmb_Add_In.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_Add_In.Location = new System.Drawing.Point(1212, 681);
            this.cmb_Add_In.Name = "cmb_Add_In";
            this.cmb_Add_In.Size = new System.Drawing.Size(353, 37);
            this.cmb_Add_In.TabIndex = 5;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(550, 831);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(326, 48);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "REFRESH";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Add_In);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.lbl_Add_In);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.tb_Mother);
            this.Controls.Add(this.lbl_Mother_Name);
            this.Controls.Add(this.tb_Father);
            this.Controls.Add(this.lbl_Father_Name);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add";
            this.Text = "Add Student";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Father;
        private System.Windows.Forms.Label lbl_Father_Name;
        private System.Windows.Forms.TextBox tb_Mother;
        private System.Windows.Forms.Label lbl_Mother_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Add_In;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Add_In;
        private System.Windows.Forms.Button btn_Refresh;
    }
}