namespace HRIS.UC_Lists
{
    partial class UC_Masterlist
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Column = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_numemployee = new System.Windows.Forms.Button();
            this.print_master = new System.Windows.Forms.Button();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cb_column2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_column2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_numemployee);
            this.groupBox1.Controls.Add(this.print_master);
            this.groupBox1.Controls.Add(this.cb_dept);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 609);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMPLOYEE MASTERLIST";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Value);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_Column);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(269, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // tb_Value
            // 
            this.tb_Value.Location = new System.Drawing.Point(178, 33);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.Size = new System.Drawing.Size(168, 20);
            this.tb_Value.TabIndex = 12;
            this.tb_Value.TextChanged += new System.EventHandler(this.tb_Value_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Value:";
            // 
            // cb_Column
            // 
            this.cb_Column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Column.FormattingEnabled = true;
            this.cb_Column.Location = new System.Drawing.Point(9, 32);
            this.cb_Column.Name = "cb_Column";
            this.cb_Column.Size = new System.Drawing.Size(135, 21);
            this.cb_Column.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Column:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(897, 67);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(25, 13);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(751, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Number of Employees:";
            // 
            // btn_numemployee
            // 
            this.btn_numemployee.Location = new System.Drawing.Point(601, 580);
            this.btn_numemployee.Name = "btn_numemployee";
            this.btn_numemployee.Size = new System.Drawing.Size(191, 23);
            this.btn_numemployee.TabIndex = 5;
            this.btn_numemployee.Text = "PRINT NUMBER OF EMPLOYEES";
            this.btn_numemployee.UseVisualStyleBackColor = true;
            this.btn_numemployee.Click += new System.EventHandler(this.btn_numemployee_Click);
            // 
            // print_master
            // 
            this.print_master.Location = new System.Drawing.Point(798, 580);
            this.print_master.Name = "print_master";
            this.print_master.Size = new System.Drawing.Size(124, 23);
            this.print_master.TabIndex = 4;
            this.print_master.Text = "PRINT DISPLAYED";
            this.print_master.UseVisualStyleBackColor = true;
            this.print_master.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_dept
            // 
            this.cb_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(99, 44);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(128, 21);
            this.cb_dept.TabIndex = 3;
            this.cb_dept.SelectedIndexChanged += new System.EventHandler(this.cb_dept_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DEPARTMENT:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(916, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // cb_column2
            // 
            this.cb_column2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_column2.FormattingEnabled = true;
            this.cb_column2.Location = new System.Drawing.Point(657, 19);
            this.cb_column2.Name = "cb_column2";
            this.cb_column2.Size = new System.Drawing.Size(135, 21);
            this.cb_column2.TabIndex = 13;
            this.cb_column2.Visible = false;
            // 
            // UC_Masterlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Masterlist";
            this.Size = new System.Drawing.Size(946, 651);
            this.Load += new System.EventHandler(this.UC_Masterlist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button print_master;
        private System.Windows.Forms.Button btn_numemployee;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Column;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_column2;
    }
}
