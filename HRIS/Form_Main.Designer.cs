namespace HRIS
{
    partial class Form_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceAppraisalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPerformanceAppraisalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memorandumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthdaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToDashboardToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.performanceAppraisalToolStripMenuItem,
            this.memorandumToolStripMenuItem,
            this.listOfReportsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.auditTrailToolStripMenuItem,
            this.backupRestoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1212, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToDashboardToolStripMenuItem
            // 
            this.backToDashboardToolStripMenuItem.Name = "backToDashboardToolStripMenuItem";
            this.backToDashboardToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.backToDashboardToolStripMenuItem.Text = "Home";
            this.backToDashboardToolStripMenuItem.Click += new System.EventHandler(this.backToDashboardToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.positionToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.positionToolStripMenuItem.Text = "Backup/Restore";
            this.positionToolStripMenuItem.Visible = false;
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.employeeToolStripMenuItem.Text = "Employee ";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // performanceAppraisalToolStripMenuItem
            // 
            this.performanceAppraisalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPerformanceAppraisalToolStripMenuItem});
            this.performanceAppraisalToolStripMenuItem.Name = "performanceAppraisalToolStripMenuItem";
            this.performanceAppraisalToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.performanceAppraisalToolStripMenuItem.Text = "Performance Appraisal";
            this.performanceAppraisalToolStripMenuItem.Click += new System.EventHandler(this.performanceAppraisalToolStripMenuItem_Click);
            // 
            // printPerformanceAppraisalToolStripMenuItem
            // 
            this.printPerformanceAppraisalToolStripMenuItem.Name = "printPerformanceAppraisalToolStripMenuItem";
            this.printPerformanceAppraisalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.printPerformanceAppraisalToolStripMenuItem.Text = "Performance Appraisal";
            this.printPerformanceAppraisalToolStripMenuItem.Click += new System.EventHandler(this.printPerformanceAppraisalToolStripMenuItem_Click);
            // 
            // memorandumToolStripMenuItem
            // 
            this.memorandumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoToolStripMenuItem,
            this.violationsToolStripMenuItem});
            this.memorandumToolStripMenuItem.Name = "memorandumToolStripMenuItem";
            this.memorandumToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.memorandumToolStripMenuItem.Text = "Memos/Reports";
            this.memorandumToolStripMenuItem.Click += new System.EventHandler(this.memorandumToolStripMenuItem_Click);
            // 
            // memoToolStripMenuItem
            // 
            this.memoToolStripMenuItem.Name = "memoToolStripMenuItem";
            this.memoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.memoToolStripMenuItem.Text = "Memo";
            this.memoToolStripMenuItem.Click += new System.EventHandler(this.memoToolStripMenuItem_Click);
            // 
            // violationsToolStripMenuItem
            // 
            this.violationsToolStripMenuItem.Name = "violationsToolStripMenuItem";
            this.violationsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.violationsToolStripMenuItem.Text = "Violations";
            this.violationsToolStripMenuItem.Click += new System.EventHandler(this.violationsToolStripMenuItem_Click);
            // 
            // listOfReportsToolStripMenuItem
            // 
            this.listOfReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.medicalReportToolStripMenuItem,
            this.birthdaysToolStripMenuItem,
            this.dependentsToolStripMenuItem});
            this.listOfReportsToolStripMenuItem.Name = "listOfReportsToolStripMenuItem";
            this.listOfReportsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.listOfReportsToolStripMenuItem.Text = "Lists/Print";
            this.listOfReportsToolStripMenuItem.Click += new System.EventHandler(this.listOfReportsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allEmployeesToolStripMenuItem,
            this.employmentStatusToolStripMenuItem,
            this.inactiveEmployeesToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // allEmployeesToolStripMenuItem
            // 
            this.allEmployeesToolStripMenuItem.Name = "allEmployeesToolStripMenuItem";
            this.allEmployeesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.allEmployeesToolStripMenuItem.Text = "Employees Masterlist";
            this.allEmployeesToolStripMenuItem.Click += new System.EventHandler(this.allEmployeesToolStripMenuItem_Click);
            // 
            // employmentStatusToolStripMenuItem
            // 
            this.employmentStatusToolStripMenuItem.Name = "employmentStatusToolStripMenuItem";
            this.employmentStatusToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.employmentStatusToolStripMenuItem.Text = "Employment Status";
            this.employmentStatusToolStripMenuItem.Click += new System.EventHandler(this.employmentStatusToolStripMenuItem_Click);
            // 
            // inactiveEmployeesToolStripMenuItem
            // 
            this.inactiveEmployeesToolStripMenuItem.Name = "inactiveEmployeesToolStripMenuItem";
            this.inactiveEmployeesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.inactiveEmployeesToolStripMenuItem.Text = "Inactive Employees";
            this.inactiveEmployeesToolStripMenuItem.Click += new System.EventHandler(this.inactiveEmployeesToolStripMenuItem_Click);
            // 
            // medicalReportToolStripMenuItem
            // 
            this.medicalReportToolStripMenuItem.Name = "medicalReportToolStripMenuItem";
            this.medicalReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.medicalReportToolStripMenuItem.Text = "Medical Reports";
            this.medicalReportToolStripMenuItem.Click += new System.EventHandler(this.medicalReportToolStripMenuItem_Click);
            // 
            // birthdaysToolStripMenuItem
            // 
            this.birthdaysToolStripMenuItem.Name = "birthdaysToolStripMenuItem";
            this.birthdaysToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.birthdaysToolStripMenuItem.Text = "Birthdays";
            this.birthdaysToolStripMenuItem.Click += new System.EventHandler(this.birthdaysToolStripMenuItem_Click);
            // 
            // dependentsToolStripMenuItem
            // 
            this.dependentsToolStripMenuItem.Name = "dependentsToolStripMenuItem";
            this.dependentsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dependentsToolStripMenuItem.Text = "Dependents";
            this.dependentsToolStripMenuItem.Click += new System.EventHandler(this.dependentsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // auditTrailToolStripMenuItem
            // 
            this.auditTrailToolStripMenuItem.Name = "auditTrailToolStripMenuItem";
            this.auditTrailToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.auditTrailToolStripMenuItem.Text = "Audit Trail";
            this.auditTrailToolStripMenuItem.Click += new System.EventHandler(this.auditTrailToolStripMenuItem_Click);
            // 
            // backupRestoreToolStripMenuItem
            // 
            this.backupRestoreToolStripMenuItem.Name = "backupRestoreToolStripMenuItem";
            this.backupRestoreToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.backupRestoreToolStripMenuItem.Text = "Backup/Restore";
            this.backupRestoreToolStripMenuItem.Click += new System.EventHandler(this.backupRestoreToolStripMenuItem_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(13, 28);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1187, 689);
            this.mainpanel.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 729);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Human Resource Information System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memorandumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birthdaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employmentStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactiveEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem violationsToolStripMenuItem;
        public System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.ToolStripMenuItem backToDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceAppraisalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPerformanceAppraisalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupRestoreToolStripMenuItem;
    }
}

