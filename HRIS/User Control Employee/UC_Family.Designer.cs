namespace HRIS.User_Control_Employee
{
    partial class UC_Family
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
            this.cb_isdependent = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_employer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_occupation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_degree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_educational = new System.Windows.Forms.ComboBox();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_spousename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_adddep = new System.Windows.Forms.Button();
            this.dg_dependent = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dependent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_isdependent);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.tb_tel);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_employer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_position);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_occupation);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_degree);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_educational);
            this.groupBox1.Controls.Add(this.date_birth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_age);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_spousename);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPOUSE INFORMATION";
            // 
            // cb_isdependent
            // 
            this.cb_isdependent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_isdependent.FormattingEnabled = true;
            this.cb_isdependent.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_isdependent.Location = new System.Drawing.Point(90, 164);
            this.cb_isdependent.Name = "cb_isdependent";
            this.cb_isdependent.Size = new System.Drawing.Size(66, 21);
            this.cb_isdependent.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Is dependent?";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(441, 163);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(110, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(315, 131);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(158, 20);
            this.tb_tel.TabIndex = 9;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(60, 131);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(158, 20);
            this.tb_address.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Telephone No.";
            // 
            // tb_employer
            // 
            this.tb_employer.Location = new System.Drawing.Point(65, 104);
            this.tb_employer.Name = "tb_employer";
            this.tb_employer.Size = new System.Drawing.Size(260, 20);
            this.tb_employer.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address:";
            // 
            // tb_position
            // 
            this.tb_position.Location = new System.Drawing.Point(289, 79);
            this.tb_position.Name = "tb_position";
            this.tb_position.Size = new System.Drawing.Size(158, 20);
            this.tb_position.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Employer:";
            // 
            // tb_occupation
            // 
            this.tb_occupation.Location = new System.Drawing.Point(75, 78);
            this.tb_occupation.Name = "tb_occupation";
            this.tb_occupation.Size = new System.Drawing.Size(141, 20);
            this.tb_occupation.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Occupation:";
            // 
            // tb_degree
            // 
            this.tb_degree.Location = new System.Drawing.Point(315, 49);
            this.tb_degree.Name = "tb_degree";
            this.tb_degree.Size = new System.Drawing.Size(158, 20);
            this.tb_degree.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Degree:";
            // 
            // tb_educational
            // 
            this.tb_educational.FormattingEnabled = true;
            this.tb_educational.Items.AddRange(new object[] {
            "Elementary",
            "High School",
            "Senior High School",
            "College",
            "Graduate School",
            "Others"});
            this.tb_educational.Location = new System.Drawing.Point(127, 47);
            this.tb_educational.Name = "tb_educational";
            this.tb_educational.Size = new System.Drawing.Size(121, 21);
            this.tb_educational.TabIndex = 5;
            // 
            // date_birth
            // 
            this.date_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_birth.Location = new System.Drawing.Point(441, 17);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(85, 20);
            this.date_birth.TabIndex = 4;
            this.date_birth.ValueChanged += new System.EventHandler(this.date_birth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Educational Attainment:";
            // 
            // tb_age
            // 
            this.tb_age.Enabled = false;
            this.tb_age.Location = new System.Drawing.Point(322, 17);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(40, 20);
            this.tb_age.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // tb_spousename
            // 
            this.tb_spousename.Location = new System.Drawing.Point(109, 17);
            this.tb_spousename.Name = "tb_spousename";
            this.tb_spousename.Size = new System.Drawing.Size(158, 20);
            this.tb_spousename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spouse Full Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Controls.Add(this.btn_remove);
            this.groupBox2.Controls.Add(this.btn_adddep);
            this.groupBox2.Controls.Add(this.dg_dependent);
            this.groupBox2.Location = new System.Drawing.Point(4, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OTHER DEPENDENTS";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(152, 178);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(137, 23);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "REMOVE DEPENDENT";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_adddep
            // 
            this.btn_adddep.Location = new System.Drawing.Point(7, 178);
            this.btn_adddep.Name = "btn_adddep";
            this.btn_adddep.Size = new System.Drawing.Size(137, 23);
            this.btn_adddep.TabIndex = 1;
            this.btn_adddep.Text = "ADD DEPENDENT";
            this.btn_adddep.UseVisualStyleBackColor = true;
            this.btn_adddep.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_dependent
            // 
            this.dg_dependent.AllowUserToAddRows = false;
            this.dg_dependent.AllowUserToDeleteRows = false;
            this.dg_dependent.AllowUserToResizeRows = false;
            this.dg_dependent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dependent.Location = new System.Drawing.Point(7, 20);
            this.dg_dependent.Name = "dg_dependent";
            this.dg_dependent.ReadOnly = true;
            this.dg_dependent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dependent.Size = new System.Drawing.Size(519, 147);
            this.dg_dependent.TabIndex = 0;
            this.dg_dependent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dependent_CellClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(431, 173);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(95, 23);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // UC_Family
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Family";
            this.Size = new System.Drawing.Size(731, 601);
            this.Load += new System.EventHandler(this.UC_Family_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dependent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_employer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_occupation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_degree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tb_educational;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_spousename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_dependent;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_adddep;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cb_isdependent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_refresh;
    }
}
