namespace HRIS.User_Control
{
    partial class UC_Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_employee = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationAttainmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingAndDevelopmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_searchemp = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.dg_emp = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_employee
            // 
            this.panel_employee.Location = new System.Drawing.Point(235, 40);
            this.panel_employee.Name = "panel_employee";
            this.panel_employee.Size = new System.Drawing.Size(861, 589);
            this.panel_employee.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewToolStripMenuItem,
            this.familyInformationToolStripMenuItem,
            this.educationAttainmentToolStripMenuItem,
            this.employmentHistoryToolStripMenuItem,
            this.trainingAndDevelopmentToolStripMenuItem,
            this.medicalHistoryToolStripMenuItem,
            this.performanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(235, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.CheckOnClick = true;
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.overviewToolStripMenuItem.Text = "Employee Details";
            this.overviewToolStripMenuItem.Click += new System.EventHandler(this.overviewToolStripMenuItem_Click);
            // 
            // familyInformationToolStripMenuItem
            // 
            this.familyInformationToolStripMenuItem.Name = "familyInformationToolStripMenuItem";
            this.familyInformationToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.familyInformationToolStripMenuItem.Text = "Family Information";
            this.familyInformationToolStripMenuItem.Click += new System.EventHandler(this.familyInformationToolStripMenuItem_Click);
            // 
            // educationAttainmentToolStripMenuItem
            // 
            this.educationAttainmentToolStripMenuItem.Name = "educationAttainmentToolStripMenuItem";
            this.educationAttainmentToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.educationAttainmentToolStripMenuItem.Text = "Educational Attainment";
            this.educationAttainmentToolStripMenuItem.Click += new System.EventHandler(this.educationAttainmentToolStripMenuItem_Click);
            // 
            // employmentHistoryToolStripMenuItem
            // 
            this.employmentHistoryToolStripMenuItem.Name = "employmentHistoryToolStripMenuItem";
            this.employmentHistoryToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.employmentHistoryToolStripMenuItem.Text = "Employment History";
            this.employmentHistoryToolStripMenuItem.Click += new System.EventHandler(this.employmentHistoryToolStripMenuItem_Click);
            // 
            // trainingAndDevelopmentToolStripMenuItem
            // 
            this.trainingAndDevelopmentToolStripMenuItem.Name = "trainingAndDevelopmentToolStripMenuItem";
            this.trainingAndDevelopmentToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.trainingAndDevelopmentToolStripMenuItem.Text = "Training and Development";
            this.trainingAndDevelopmentToolStripMenuItem.Click += new System.EventHandler(this.trainingAndDevelopmentToolStripMenuItem_Click);
            // 
            // medicalHistoryToolStripMenuItem
            // 
            this.medicalHistoryToolStripMenuItem.Name = "medicalHistoryToolStripMenuItem";
            this.medicalHistoryToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.medicalHistoryToolStripMenuItem.Text = "Medical History";
            this.medicalHistoryToolStripMenuItem.Click += new System.EventHandler(this.medicalHistoryToolStripMenuItem_Click);
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.performanceToolStripMenuItem.Text = "Performance";
            this.performanceToolStripMenuItem.Click += new System.EventHandler(this.performanceToolStripMenuItem_Click);
            // 
            // tb_searchemp
            // 
            this.tb_searchemp.Location = new System.Drawing.Point(4, 13);
            this.tb_searchemp.Name = "tb_searchemp";
            this.tb_searchemp.Size = new System.Drawing.Size(225, 20);
            this.tb_searchemp.TabIndex = 4;
            this.tb_searchemp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(4, 604);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 36);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "NEW";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(154, 604);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 36);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // dg_emp
            // 
            this.dg_emp.AllowUserToAddRows = false;
            this.dg_emp.AllowUserToDeleteRows = false;
            this.dg_emp.AllowUserToResizeRows = false;
            this.dg_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_emp.Location = new System.Drawing.Point(4, 40);
            this.dg_emp.MultiSelect = false;
            this.dg_emp.Name = "dg_emp";
            this.dg_emp.ReadOnly = true;
            this.dg_emp.RowHeadersVisible = false;
            this.dg_emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_emp.ShowEditingIcon = false;
            this.dg_emp.Size = new System.Drawing.Size(225, 558);
            this.dg_emp.TabIndex = 7;
            this.dg_emp.SelectionChanged += new System.EventHandler(this.dg_emp_SelectionChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImage = global::HRIS.Properties.Resources.refresh;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Refresh.Location = new System.Drawing.Point(95, 604);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(40, 36);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dg_emp);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.tb_searchemp);
            this.Controls.Add(this.panel_employee);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(1292, 677);
            this.Load += new System.EventHandler(this.UC_Employee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_employee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem educationAttainmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employmentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingAndDevelopmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ToolStripMenuItem familyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceToolStripMenuItem;
        public System.Windows.Forms.TextBox tb_searchemp;
        public System.Windows.Forms.DataGridView dg_emp;
        private System.Windows.Forms.Button btn_Refresh;
    }
}
