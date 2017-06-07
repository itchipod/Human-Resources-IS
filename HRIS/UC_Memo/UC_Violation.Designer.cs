namespace HRIS.UC_Memo
{
    partial class UC_Violation
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
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.dg_violation = new System.Windows.Forms.DataGridView();
            this.tb_effectivedate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_penalty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_offensewas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.time_violation = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_offense = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_violation = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_place = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_violation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.btn_remove);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_overview);
            this.groupBox1.Controls.Add(this.dg_violation);
            this.groupBox1.Controls.Add(this.tb_effectivedate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_penalty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_offensewas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.time_violation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_offense);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date_violation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_place);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_emp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VIOLATION REPORT";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(611, 118);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(118, 23);
            this.btn_print.TabIndex = 25;
            this.btn_print.Text = "PRINT DISPLAYED";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(174, 118);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 24;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(92, 118);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(9, 118);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_overview
            // 
            this.btn_overview.BackgroundImage = global::HRIS.Properties.Resources.Icons8_Windows_8_Editing_Overview_Pages_1;
            this.btn_overview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_overview.Location = new System.Drawing.Point(213, 19);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(25, 23);
            this.btn_overview.TabIndex = 21;
            this.btn_overview.UseVisualStyleBackColor = true;
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // dg_violation
            // 
            this.dg_violation.AllowUserToAddRows = false;
            this.dg_violation.AllowUserToDeleteRows = false;
            this.dg_violation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_violation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_violation.Location = new System.Drawing.Point(9, 147);
            this.dg_violation.Name = "dg_violation";
            this.dg_violation.ReadOnly = true;
            this.dg_violation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_violation.Size = new System.Drawing.Size(720, 418);
            this.dg_violation.TabIndex = 17;
            this.dg_violation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_violation_CellClick);
            // 
            // tb_effectivedate
            // 
            this.tb_effectivedate.Location = new System.Drawing.Point(580, 80);
            this.tb_effectivedate.Name = "tb_effectivedate";
            this.tb_effectivedate.Size = new System.Drawing.Size(104, 20);
            this.tb_effectivedate.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Effective Dates:";
            // 
            // tb_penalty
            // 
            this.tb_penalty.Location = new System.Drawing.Point(58, 81);
            this.tb_penalty.Name = "tb_penalty";
            this.tb_penalty.Size = new System.Drawing.Size(271, 20);
            this.tb_penalty.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Penalty:";
            // 
            // tb_offensewas
            // 
            this.tb_offensewas.Location = new System.Drawing.Point(409, 80);
            this.tb_offensewas.Name = "tb_offensewas";
            this.tb_offensewas.Size = new System.Drawing.Size(69, 20);
            this.tb_offensewas.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Offense Was:";
            // 
            // time_violation
            // 
            this.time_violation.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_violation.Location = new System.Drawing.Point(561, 49);
            this.time_violation.Name = "time_violation";
            this.time_violation.Size = new System.Drawing.Size(91, 20);
            this.time_violation.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Violation Time:";
            // 
            // tb_offense
            // 
            this.tb_offense.Location = new System.Drawing.Point(94, 49);
            this.tb_offense.Name = "tb_offense";
            this.tb_offense.Size = new System.Drawing.Size(135, 20);
            this.tb_offense.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Offense Against:";
            // 
            // date_violation
            // 
            this.date_violation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_violation.Location = new System.Drawing.Point(329, 49);
            this.date_violation.Name = "date_violation";
            this.date_violation.Size = new System.Drawing.Size(91, 20);
            this.date_violation.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Violation Date:";
            // 
            // tb_place
            // 
            this.tb_place.Location = new System.Drawing.Point(383, 21);
            this.tb_place.Name = "tb_place";
            this.tb_place.Size = new System.Drawing.Size(135, 20);
            this.tb_place.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Place of Violation:";
            // 
            // cb_emp
            // 
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(63, 20);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(145, 21);
            this.cb_emp.TabIndex = 2;
            this.cb_emp.SelectedIndexChanged += new System.EventHandler(this.cb_emp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UC_Violation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Violation";
            this.Size = new System.Drawing.Size(756, 590);
            this.Load += new System.EventHandler(this.UC_Violation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_violation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_violation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_violation;
        private System.Windows.Forms.TextBox tb_effectivedate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_penalty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_offensewas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker time_violation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_offense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_overview;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
    }
}
