namespace Assignment_5
{
    partial class Accept_Employee_Details
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_EmpID = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_wipro = new System.Windows.Forms.CheckBox();
            this.cb_isro = new System.Windows.Forms.CheckBox();
            this.cb_nasa = new System.Windows.Forms.CheckBox();
            this.cb_tcs = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.cmb_MentorName = new System.Windows.Forms.ComboBox();
            this.tb_MobileNo = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.rtb_OtherHobbies = new System.Windows.Forms.RichTextBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.mentorTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment_5DataSet = new Assignment_5.Assignment_5DataSet();
            this.mentor_TableTableAdapter = new Assignment_5.Assignment_5DataSetTableAdapters.Mentor_TableTableAdapter();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mentorTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 79);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1057, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accept Employee Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(231, 91);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(222, 34);
            this.tb_Name.TabIndex = 10;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(60, 93);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(165, 31);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Name";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(423, 723);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(194, 46);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_EmpID
            // 
            this.tb_EmpID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_EmpID.Enabled = false;
            this.tb_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EmpID.Location = new System.Drawing.Point(231, 15);
            this.tb_EmpID.Name = "tb_EmpID";
            this.tb_EmpID.Size = new System.Drawing.Size(222, 34);
            this.tb_EmpID.TabIndex = 7;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(60, 17);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(165, 31);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Employee ID";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.512439F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.53732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04976F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.53732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04976F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.512439F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Designation, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmb_MentorName, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_MobileNo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Salary, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_EmpID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtp_DOB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.clb_Hobbies, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.rtb_OtherHobbies, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Department, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.80496F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.46202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.96595F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.96595F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.96595F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.19382F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.641351F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1037, 607);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(459, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(116, 46);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cb_wipro);
            this.groupBox3.Controls.Add(this.cb_isro);
            this.groupBox3.Controls.Add(this.cb_nasa);
            this.groupBox3.Controls.Add(this.cb_tcs);
            this.groupBox3.Location = new System.Drawing.Point(752, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 152);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // cb_wipro
            // 
            this.cb_wipro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cb_wipro.AutoSize = true;
            this.cb_wipro.BackColor = System.Drawing.Color.Transparent;
            this.cb_wipro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_wipro.Location = new System.Drawing.Point(104, 82);
            this.cb_wipro.Name = "cb_wipro";
            this.cb_wipro.Size = new System.Drawing.Size(101, 29);
            this.cb_wipro.TabIndex = 3;
            this.cb_wipro.Text = "WIPRO";
            this.cb_wipro.UseVisualStyleBackColor = false;
            // 
            // cb_isro
            // 
            this.cb_isro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_isro.AutoSize = true;
            this.cb_isro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_isro.Location = new System.Drawing.Point(29, 82);
            this.cb_isro.Name = "cb_isro";
            this.cb_isro.Size = new System.Drawing.Size(82, 29);
            this.cb_isro.TabIndex = 2;
            this.cb_isro.Text = "ISRO";
            this.cb_isro.UseVisualStyleBackColor = true;
            // 
            // cb_nasa
            // 
            this.cb_nasa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cb_nasa.AutoSize = true;
            this.cb_nasa.BackColor = System.Drawing.Color.Transparent;
            this.cb_nasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nasa.Location = new System.Drawing.Point(104, 47);
            this.cb_nasa.Name = "cb_nasa";
            this.cb_nasa.Size = new System.Drawing.Size(90, 29);
            this.cb_nasa.TabIndex = 1;
            this.cb_nasa.Text = "NASA";
            this.cb_nasa.UseVisualStyleBackColor = false;
            // 
            // cb_tcs
            // 
            this.cb_tcs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_tcs.AutoSize = true;
            this.cb_tcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tcs.Location = new System.Drawing.Point(29, 47);
            this.cb_tcs.Name = "cb_tcs";
            this.cb_tcs.Size = new System.Drawing.Size(76, 29);
            this.cb_tcs.TabIndex = 0;
            this.cb_tcs.Text = "TCS";
            this.cb_tcs.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rb_Night);
            this.groupBox2.Controls.Add(this.rb_Evening);
            this.groupBox2.Controls.Add(this.rb_Morning);
            this.groupBox2.Location = new System.Drawing.Point(752, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 64);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // rb_Night
            // 
            this.rb_Night.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_Night.AutoSize = true;
            this.rb_Night.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Night.Location = new System.Drawing.Point(127, 25);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(78, 29);
            this.rb_Night.TabIndex = 4;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Evening
            // 
            this.rb_Evening.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Evening.Location = new System.Drawing.Point(65, 25);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(104, 29);
            this.rb_Evening.TabIndex = 3;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Morning
            // 
            this.rb_Morning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Morning.Location = new System.Drawing.Point(16, 25);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(104, 29);
            this.rb_Morning.TabIndex = 2;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Team Leader",
            "Jr Developer",
            "Sr Developer"});
            this.cmb_Designation.Location = new System.Drawing.Point(752, 250);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(222, 37);
            this.cmb_Designation.TabIndex = 19;
            // 
            // cmb_MentorName
            // 
            this.cmb_MentorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_MentorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MentorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MentorName.FormattingEnabled = true;
            this.cmb_MentorName.Items.AddRange(new object[] {
            "Sanket Patil",
            "Akash Mane",
            "Shubham More",
            "Pratik Patil"});
            this.cmb_MentorName.Location = new System.Drawing.Point(752, 90);
            this.cmb_MentorName.Name = "cmb_MentorName";
            this.cmb_MentorName.Size = new System.Drawing.Size(222, 37);
            this.cmb_MentorName.TabIndex = 20;
            // 
            // tb_MobileNo
            // 
            this.tb_MobileNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobileNo.Location = new System.Drawing.Point(231, 252);
            this.tb_MobileNo.Name = "tb_MobileNo";
            this.tb_MobileNo.Size = new System.Drawing.Size(222, 34);
            this.tb_MobileNo.TabIndex = 12;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(752, 330);
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(222, 34);
            this.tb_Salary.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Department";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date Of Birth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mobile Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hobbies";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Other Hobbies";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(581, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mentor Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "Shift Timing";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(581, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 31);
            this.label10.TabIndex = 15;
            this.label10.Text = "Designation";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(581, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 31);
            this.label11.TabIndex = 16;
            this.label11.Text = "Salary";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(581, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 31);
            this.label12.TabIndex = 17;
            this.label12.Text = "Projects";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(231, 174);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(222, 34);
            this.dtp_DOB.TabIndex = 21;
            this.dtp_DOB.Value = new System.DateTime(2020, 10, 17, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_Female);
            this.groupBox1.Controls.Add(this.rb_Male);
            this.groupBox1.Location = new System.Drawing.Point(231, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 62);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(109, 21);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(98, 29);
            this.rb_Female.TabIndex = 1;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(15, 21);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(76, 29);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.CheckOnClick = true;
            this.clb_Hobbies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Reading",
            "Drawing",
            "Playing Chess",
            "Travelling",
            "Cycling",
            "Other"});
            this.clb_Hobbies.Location = new System.Drawing.Point(231, 389);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(222, 152);
            this.clb_Hobbies.TabIndex = 24;
            this.clb_Hobbies.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Hobbies_ItemCheck);
            this.clb_Hobbies.SelectedIndexChanged += new System.EventHandler(this.clb_Hobbies_SelectedIndexChanged);
            // 
            // rtb_OtherHobbies
            // 
            this.rtb_OtherHobbies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_OtherHobbies.Enabled = false;
            this.rtb_OtherHobbies.Location = new System.Drawing.Point(231, 550);
            this.rtb_OtherHobbies.Name = "rtb_OtherHobbies";
            this.rtb_OtherHobbies.Size = new System.Drawing.Size(222, 50);
            this.rtb_OtherHobbies.TabIndex = 25;
            this.rtb_OtherHobbies.Text = "";
            // 
            // cmb_Department
            // 
            this.cmb_Department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Department.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mentorTableBindingSource, "Department", true));
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(752, 14);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(222, 37);
            this.cmb_Department.TabIndex = 18;
            this.cmb_Department.SelectedIndexChanged += new System.EventHandler(this.cmb_Department_SelectedIndexChanged);
            // 
            // mentorTableBindingSource
            // 
            this.mentorTableBindingSource.DataMember = "Mentor_Table";
            this.mentorTableBindingSource.DataSource = this.assignment_5DataSet;
            // 
            // assignment_5DataSet
            // 
            this.assignment_5DataSet.DataSetName = "Assignment_5DataSet";
            this.assignment_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mentor_TableTableAdapter
            // 
            this.mentor_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Accept_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 781);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.panel1);
            this.Name = "Accept_Employee_Details";
            this.Text = "Accept Employee Details";
            this.Load += new System.EventHandler(this.Accept_Employee_Details_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mentorTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_5DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_EmpID;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.ComboBox cmb_MentorName;
        private System.Windows.Forms.TextBox tb_MobileNo;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_wipro;
        private System.Windows.Forms.CheckBox cb_isro;
        private System.Windows.Forms.CheckBox cb_nasa;
        private System.Windows.Forms.CheckBox cb_tcs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.RichTextBox rtb_OtherHobbies;
        private Assignment_5DataSet assignment_5DataSet;
        private System.Windows.Forms.BindingSource mentorTableBindingSource;
        private Assignment_5DataSetTableAdapters.Mentor_TableTableAdapter mentor_TableTableAdapter;
        private System.Windows.Forms.Button btn_Search;
    }
}