namespace HRIS.User_Control_Employee
{
    partial class Form_AddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.tb_mname = new System.Windows.Forms.TextBox();
            this.date_hired = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_contract = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_suffix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(93, 10);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(56, 20);
            this.tb_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Middle Name:";
            // 
            // tb_lname
            // 
            this.tb_lname.Location = new System.Drawing.Point(93, 40);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(150, 20);
            this.tb_lname.TabIndex = 5;
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(93, 67);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(150, 20);
            this.tb_fname.TabIndex = 6;
            // 
            // tb_mname
            // 
            this.tb_mname.Location = new System.Drawing.Point(93, 95);
            this.tb_mname.Name = "tb_mname";
            this.tb_mname.Size = new System.Drawing.Size(150, 20);
            this.tb_mname.TabIndex = 7;
            // 
            // date_hired
            // 
            this.date_hired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_hired.Location = new System.Drawing.Point(115, 147);
            this.date_hired.Name = "date_hired";
            this.date_hired.Size = new System.Drawing.Size(82, 20);
            this.date_hired.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Date Hired:";
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Contractual",
            "Permanent",
            "Trainee"});
            this.cb_status.Location = new System.Drawing.Point(115, 174);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(98, 21);
            this.cb_status.TabIndex = 27;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Employment Status:";
            // 
            // date_contract
            // 
            this.date_contract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_contract.Location = new System.Drawing.Point(115, 203);
            this.date_contract.Name = "date_contract";
            this.date_contract.Size = new System.Drawing.Size(85, 20);
            this.date_contract.TabIndex = 29;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 208);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(99, 13);
            this.label28.TabIndex = 28;
            this.label28.Text = "Contract Expiration:";
            // 
            // cb_dept
            // 
            this.cb_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(90, 258);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(121, 21);
            this.cb_dept.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Department:";
            // 
            // tb_position
            // 
            this.tb_position.Location = new System.Drawing.Point(90, 230);
            this.tb_position.Name = "tb_position";
            this.tb_position.Size = new System.Drawing.Size(102, 20);
            this.tb_position.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Position:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 291);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 34;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_suffix
            // 
            this.tb_suffix.Location = new System.Drawing.Point(93, 121);
            this.tb_suffix.Name = "tb_suffix";
            this.tb_suffix.Size = new System.Drawing.Size(102, 20);
            this.tb_suffix.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Suffix:";
            // 
            // Form_AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 325);
            this.Controls.Add(this.tb_suffix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_dept);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_position);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.date_contract);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_hired);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_mname);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Name = "Form_AddEmployee";
            this.Text = "New Employee";
            this.Load += new System.EventHandler(this.Form_AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.TextBox tb_mname;
        private System.Windows.Forms.DateTimePicker date_hired;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_contract;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_suffix;
        private System.Windows.Forms.Label label5;
    }
}