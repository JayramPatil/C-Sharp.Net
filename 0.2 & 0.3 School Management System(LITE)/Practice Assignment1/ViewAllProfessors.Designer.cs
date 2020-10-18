namespace Practice_Assignment1
{
    partial class ViewAllProfessors
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
            this.lbl_View_Prof = new System.Windows.Forms.Label();
            this.dgv_Professor = new System.Windows.Forms.DataGridView();
            this.practice_Assignment1_DBDataSet1 = new Practice_Assignment1.Practice_Assignment1_DBDataSet1();
            this.professorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professor_InfoTableAdapter = new Practice_Assignment1.Practice_Assignment1_DBDataSet1TableAdapters.Professor_InfoTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adhaarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Professor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practice_Assignment1_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Prof
            // 
            this.lbl_View_Prof.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_View_Prof.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_View_Prof.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Prof.Location = new System.Drawing.Point(0, 0);
            this.lbl_View_Prof.Name = "lbl_View_Prof";
            this.lbl_View_Prof.Size = new System.Drawing.Size(1902, 100);
            this.lbl_View_Prof.TabIndex = 1;
            this.lbl_View_Prof.Text = "VIEW PROFESSOR";
            this.lbl_View_Prof.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Professor
            // 
            this.dgv_Professor.AllowUserToAddRows = false;
            this.dgv_Professor.AllowUserToDeleteRows = false;
            this.dgv_Professor.AllowUserToResizeColumns = false;
            this.dgv_Professor.AutoGenerateColumns = false;
            this.dgv_Professor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Professor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Professor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Professor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.adhaarDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn});
            this.dgv_Professor.DataSource = this.professorInfoBindingSource;
            this.dgv_Professor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Professor.Location = new System.Drawing.Point(0, 100);
            this.dgv_Professor.Name = "dgv_Professor";
            this.dgv_Professor.RowHeadersVisible = false;
            this.dgv_Professor.RowHeadersWidth = 51;
            this.dgv_Professor.RowTemplate.Height = 24;
            this.dgv_Professor.Size = new System.Drawing.Size(1902, 853);
            this.dgv_Professor.TabIndex = 2;
            // 
            // practice_Assignment1_DBDataSet1
            // 
            this.practice_Assignment1_DBDataSet1.DataSetName = "Practice_Assignment1_DBDataSet1";
            this.practice_Assignment1_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professorInfoBindingSource
            // 
            this.professorInfoBindingSource.DataMember = "Professor_Info";
            this.professorInfoBindingSource.DataSource = this.practice_Assignment1_DBDataSet1;
            // 
            // professor_InfoTableAdapter
            // 
            this.professor_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "Father_Name";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "Father_Name";
            this.fatherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "Mobile_Number";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile_Number";
            this.mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // adhaarDataGridViewTextBoxColumn
            // 
            this.adhaarDataGridViewTextBoxColumn.DataPropertyName = "Adhaar";
            this.adhaarDataGridViewTextBoxColumn.HeaderText = "Adhaar";
            this.adhaarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adhaarDataGridViewTextBoxColumn.Name = "adhaarDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // ViewAllProfessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Professor);
            this.Controls.Add(this.lbl_View_Prof);
            this.Name = "ViewAllProfessors";
            this.Text = "View All Professors";
            this.Load += new System.EventHandler(this.ViewAllProfessors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Professor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practice_Assignment1_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Prof;
        private System.Windows.Forms.DataGridView dgv_Professor;
        private Practice_Assignment1_DBDataSet1 practice_Assignment1_DBDataSet1;
        private System.Windows.Forms.BindingSource professorInfoBindingSource;
        private Practice_Assignment1_DBDataSet1TableAdapters.Professor_InfoTableAdapter professor_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adhaarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
    }
}