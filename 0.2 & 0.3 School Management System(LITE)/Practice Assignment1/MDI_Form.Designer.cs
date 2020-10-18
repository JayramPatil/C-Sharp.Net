namespace Practice_Assignment1
{
    partial class MDI_Form
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsm_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_View = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllProfessorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfessorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Logout = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Add,
            this.tsm_View,
            this.searchStudentToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.addProfessorToolStripMenuItem,
            this.viewAllProfessorsToolStripMenuItem,
            this.searchProfessorToolStripMenuItem,
            this.updateProfessorDetailsToolStripMenuItem,
            this.deleteProfessorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1902, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsm_Add
            // 
            this.tsm_Add.Name = "tsm_Add";
            this.tsm_Add.Size = new System.Drawing.Size(110, 26);
            this.tsm_Add.Text = "Add Student";
            this.tsm_Add.Click += new System.EventHandler(this.tsm_Add_Click);
            // 
            // tsm_View
            // 
            this.tsm_View.Name = "tsm_View";
            this.tsm_View.Size = new System.Drawing.Size(144, 26);
            this.tsm_View.Text = "View All Students";
            this.tsm_View.Click += new System.EventHandler(this.tsm_View_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.updateToolStripMenuItem.Text = "Update Student Details";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // addProfessorToolStripMenuItem
            // 
            this.addProfessorToolStripMenuItem.Name = "addProfessorToolStripMenuItem";
            this.addProfessorToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.addProfessorToolStripMenuItem.Text = "Add Professor";
            this.addProfessorToolStripMenuItem.Click += new System.EventHandler(this.addProfessorToolStripMenuItem_Click);
            // 
            // viewAllProfessorsToolStripMenuItem
            // 
            this.viewAllProfessorsToolStripMenuItem.Name = "viewAllProfessorsToolStripMenuItem";
            this.viewAllProfessorsToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.viewAllProfessorsToolStripMenuItem.Text = "View All Professors";
            this.viewAllProfessorsToolStripMenuItem.Click += new System.EventHandler(this.viewAllProfessorsToolStripMenuItem_Click);
            // 
            // searchProfessorToolStripMenuItem
            // 
            this.searchProfessorToolStripMenuItem.Name = "searchProfessorToolStripMenuItem";
            this.searchProfessorToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.searchProfessorToolStripMenuItem.Text = "Search Professor";
            this.searchProfessorToolStripMenuItem.Click += new System.EventHandler(this.searchProfessorToolStripMenuItem_Click);
            // 
            // updateProfessorDetailsToolStripMenuItem
            // 
            this.updateProfessorDetailsToolStripMenuItem.Name = "updateProfessorDetailsToolStripMenuItem";
            this.updateProfessorDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.updateProfessorDetailsToolStripMenuItem.Text = "Update Professor Details";
            this.updateProfessorDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateProfessorDetailsToolStripMenuItem_Click);
            // 
            // deleteProfessorToolStripMenuItem
            // 
            this.deleteProfessorToolStripMenuItem.Name = "deleteProfessorToolStripMenuItem";
            this.deleteProfessorToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.deleteProfessorToolStripMenuItem.Text = "Delete Professor";
            this.deleteProfessorToolStripMenuItem.Click += new System.EventHandler(this.deleteProfessorToolStripMenuItem_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.AutoSize = true;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(2441, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(89, 30);
            this.btn_Logout.TabIndex = 31;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(1788, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(114, 34);
            this.Logout.TabIndex = 33;
            this.Logout.Text = "LOGOUT";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // MDI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MDI_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsm_Add;
        private System.Windows.Forms.ToolStripMenuItem tsm_View;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllProfessorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfessorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProfessorToolStripMenuItem;
        private System.Windows.Forms.Button Logout;
    }
}



