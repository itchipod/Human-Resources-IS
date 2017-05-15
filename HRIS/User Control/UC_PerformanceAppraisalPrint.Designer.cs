namespace HRIS.User_Control
{
    partial class UC_PerformanceAppraisalPrint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_emp = new System.Windows.Forms.DateTimePicker();
            this.btn_printall = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_supervisor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_designation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_period = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_dep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_emp);
            this.groupBox1.Controls.Add(this.btn_printall);
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.tb_status);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_supervisor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_designation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_period);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_dep);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Performance Appraisal";
            // 
            // date_emp
            // 
            this.date_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_emp.Location = new System.Drawing.Point(94, 124);
            this.date_emp.Name = "date_emp";
            this.date_emp.Size = new System.Drawing.Size(121, 20);
            this.date_emp.TabIndex = 17;
            // 
            // btn_printall
            // 
            this.btn_printall.Location = new System.Drawing.Point(290, 187);
            this.btn_printall.Name = "btn_printall";
            this.btn_printall.Size = new System.Drawing.Size(75, 23);
            this.btn_printall.TabIndex = 16;
            this.btn_printall.Text = "PRINT ALL";
            this.btn_printall.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(175, 187);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 15;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(431, 124);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(121, 20);
            this.tb_status.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Status:";
            // 
            // tb_supervisor
            // 
            this.tb_supervisor.Location = new System.Drawing.Point(431, 92);
            this.tb_supervisor.Name = "tb_supervisor";
            this.tb_supervisor.Size = new System.Drawing.Size(121, 20);
            this.tb_supervisor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Supervisor:";
            // 
            // tb_designation
            // 
            this.tb_designation.Location = new System.Drawing.Point(431, 60);
            this.tb_designation.Name = "tb_designation";
            this.tb_designation.Size = new System.Drawing.Size(121, 20);
            this.tb_designation.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Designation:";
            // 
            // tb_period
            // 
            this.tb_period.Location = new System.Drawing.Point(431, 27);
            this.tb_period.Name = "tb_period";
            this.tb_period.Size = new System.Drawing.Size(121, 20);
            this.tb_period.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Employed:";
            // 
            // tb_dep
            // 
            this.tb_dep.Location = new System.Drawing.Point(94, 92);
            this.tb_dep.Name = "tb_dep";
            this.tb_dep.Size = new System.Drawing.Size(121, 20);
            this.tb_dep.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // cb_name
            // 
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(94, 59);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(121, 21);
            this.cb_name.TabIndex = 1;
            this.cb_name.SelectedIndexChanged += new System.EventHandler(this.cb_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // UC_PerformanceAppraisalPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_PerformanceAppraisalPrint";
            this.Size = new System.Drawing.Size(611, 512);
            this.Load += new System.EventHandler(this.UC_PerformanceAppraisal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_printall;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_supervisor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_designation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_period;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_dep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_emp;
    }
}
