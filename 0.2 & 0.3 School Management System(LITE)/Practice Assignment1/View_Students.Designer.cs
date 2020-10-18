namespace Practice_Assignment1
{
    partial class View_Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_View_Stud = new System.Windows.Forms.Label();
            this.dgv_View_Stud = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practice_Assignment1_DBDataSet = new Practice_Assignment1.Practice_Assignment1_DBDataSet();
            this.student_InfoTableAdapter = new Practice_Assignment1.Practice_Assignment1_DBDataSetTableAdapters.Student_InfoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practice_Assignment1_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_View_Stud);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 100);
            this.panel1.TabIndex = 1;
            // 
            // lbl_View_Stud
            // 
            this.lbl_View_Stud.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_View_Stud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_View_Stud.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Stud.Location = new System.Drawing.Point(0, 0);
            this.lbl_View_Stud.Name = "lbl_View_Stud";
            this.lbl_View_Stud.Size = new System.Drawing.Size(1902, 100);
            this.lbl_View_Stud.TabIndex = 0;
            this.lbl_View_Stud.Text = "VIEW STUDENTS";
            this.lbl_View_Stud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_View_Stud
            // 
            this.dgv_View_Stud.AllowUserToAddRows = false;
            this.dgv_View_Stud.AllowUserToDeleteRows = false;
            this.dgv_View_Stud.AutoGenerateColumns = false;
            this.dgv_View_Stud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Stud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Stud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Stud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.motherNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dgv_View_Stud.DataSource = this.studentInfoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Stud.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Stud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_View_Stud.Location = new System.Drawing.Point(0, 100);
            this.dgv_View_Stud.Name = "dgv_View_Stud";
            this.dgv_View_Stud.ReadOnly = true;
            this.dgv_View_Stud.RowHeadersVisible = false;
            this.dgv_View_Stud.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_View_Stud.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_View_Stud.RowTemplate.Height = 24;
            this.dgv_View_Stud.Size = new System.Drawing.Size(1902, 853);
            this.dgv_View_Stud.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "Father_Name";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "Father_Name";
            this.fatherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motherNameDataGridViewTextBoxColumn
            // 
            this.motherNameDataGridViewTextBoxColumn.DataPropertyName = "Mother_Name";
            this.motherNameDataGridViewTextBoxColumn.HeaderText = "Mother_Name";
            this.motherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motherNameDataGridViewTextBoxColumn.Name = "motherNameDataGridViewTextBoxColumn";
            this.motherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "Student_Info";
            this.studentInfoBindingSource.DataSource = this.practice_Assignment1_DBDataSet;
            // 
            // practice_Assignment1_DBDataSet
            // 
            this.practice_Assignment1_DBDataSet.DataSetName = "Practice_Assignment1_DBDataSet";
            this.practice_Assignment1_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_InfoTableAdapter
            // 
            this.student_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // View_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_Stud);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Students";
            this.Load += new System.EventHandler(this.View_Students_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practice_Assignment1_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_View_Stud;
        private System.Windows.Forms.DataGridView dgv_View_Stud;
        private Practice_Assignment1_DBDataSet practice_Assignment1_DBDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private Practice_Assignment1_DBDataSetTableAdapters.Student_InfoTableAdapter student_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
    }
}