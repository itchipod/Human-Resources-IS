namespace HRIS.User_Control_Employee
{
    partial class UC_Medical
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
            this.tb_remarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_days = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_place = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_contingency = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_addmedical = new System.Windows.Forms.Button();
            this.dg_medical = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ailment = new System.Windows.Forms.TextBox();
            this.btn_DeleteAilment = new System.Windows.Forms.Button();
            this.btn_AddAilment = new System.Windows.Forms.Button();
            this.list_ailment = new System.Windows.Forms.ListBox();
            this.date_timeof = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_medical)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_timeof);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_remarks);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_days);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_nature);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_place);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_contingency);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_addmedical);
            this.groupBox1.Controls.Add(this.dg_medical);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEDICAL HISTORY";
            // 
            // tb_remarks
            // 
            this.tb_remarks.Location = new System.Drawing.Point(399, 86);
            this.tb_remarks.Name = "tb_remarks";
            this.tb_remarks.Size = new System.Drawing.Size(136, 20);
            this.tb_remarks.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remarks:";
            // 
            // tb_days
            // 
            this.tb_days.Location = new System.Drawing.Point(459, 56);
            this.tb_days.Name = "tb_days";
            this.tb_days.Size = new System.Drawing.Size(76, 20);
            this.tb_days.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "No. of days approved by SSS:";
            // 
            // tb_nature
            // 
            this.tb_nature.Location = new System.Drawing.Point(123, 86);
            this.tb_nature.Name = "tb_nature";
            this.tb_nature.Size = new System.Drawing.Size(136, 20);
            this.tb_nature.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nature of Contingency:";
            // 
            // tb_place
            // 
            this.tb_place.Location = new System.Drawing.Point(123, 56);
            this.tb_place.Name = "tb_place";
            this.tb_place.Size = new System.Drawing.Size(136, 20);
            this.tb_place.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Place of Contingency:";
            // 
            // date_contingency
            // 
            this.date_contingency.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_contingency.Location = new System.Drawing.Point(123, 27);
            this.date_contingency.Name = "date_contingency";
            this.date_contingency.Size = new System.Drawing.Size(136, 20);
            this.date_contingency.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date of Contingency:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(166, 514);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "DELETE RECORD";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_addmedical
            // 
            this.btn_addmedical.Location = new System.Drawing.Point(6, 514);
            this.btn_addmedical.Name = "btn_addmedical";
            this.btn_addmedical.Size = new System.Drawing.Size(154, 23);
            this.btn_addmedical.TabIndex = 1;
            this.btn_addmedical.Text = "ADD MEDICAL RECORD";
            this.btn_addmedical.UseVisualStyleBackColor = true;
            this.btn_addmedical.Click += new System.EventHandler(this.btn_addmedical_Click);
            // 
            // dg_medical
            // 
            this.dg_medical.AllowUserToAddRows = false;
            this.dg_medical.AllowUserToDeleteRows = false;
            this.dg_medical.AllowUserToResizeRows = false;
            this.dg_medical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_medical.Location = new System.Drawing.Point(6, 113);
            this.dg_medical.Name = "dg_medical";
            this.dg_medical.ReadOnly = true;
            this.dg_medical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_medical.Size = new System.Drawing.Size(571, 389);
            this.dg_medical.TabIndex = 0;
            this.dg_medical.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_medical_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_OK);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_ailment);
            this.groupBox2.Controls.Add(this.btn_DeleteAilment);
            this.groupBox2.Controls.Add(this.btn_AddAilment);
            this.groupBox2.Controls.Add(this.list_ailment);
            this.groupBox2.Location = new System.Drawing.Point(592, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 472);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AILMENTS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "*Double-click item to search on the net.";
            // 
            // btn_OK
            // 
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(172, 346);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(32, 23);
            this.btn_OK.TabIndex = 15;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ailment:";
            // 
            // tb_ailment
            // 
            this.tb_ailment.Enabled = false;
            this.tb_ailment.Location = new System.Drawing.Point(54, 348);
            this.tb_ailment.Name = "tb_ailment";
            this.tb_ailment.Size = new System.Drawing.Size(114, 20);
            this.tb_ailment.TabIndex = 13;
            // 
            // btn_DeleteAilment
            // 
            this.btn_DeleteAilment.Location = new System.Drawing.Point(115, 388);
            this.btn_DeleteAilment.Name = "btn_DeleteAilment";
            this.btn_DeleteAilment.Size = new System.Drawing.Size(85, 23);
            this.btn_DeleteAilment.TabIndex = 14;
            this.btn_DeleteAilment.Text = "DELETE";
            this.btn_DeleteAilment.UseVisualStyleBackColor = true;
            // 
            // btn_AddAilment
            // 
            this.btn_AddAilment.Location = new System.Drawing.Point(13, 388);
            this.btn_AddAilment.Name = "btn_AddAilment";
            this.btn_AddAilment.Size = new System.Drawing.Size(96, 23);
            this.btn_AddAilment.TabIndex = 13;
            this.btn_AddAilment.Text = "ADD AILMENT";
            this.btn_AddAilment.UseVisualStyleBackColor = true;
            this.btn_AddAilment.Click += new System.EventHandler(this.btn_AddAilment_Click);
            // 
            // list_ailment
            // 
            this.list_ailment.FormattingEnabled = true;
            this.list_ailment.Location = new System.Drawing.Point(13, 29);
            this.list_ailment.Name = "list_ailment";
            this.list_ailment.Size = new System.Drawing.Size(187, 303);
            this.list_ailment.TabIndex = 0;
            this.list_ailment.DoubleClick += new System.EventHandler(this.list_ailment_DoubleClick);
            // 
            // date_timeof
            // 
            this.date_timeof.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_timeof.Location = new System.Drawing.Point(459, 26);
            this.date_timeof.Name = "date_timeof";
            this.date_timeof.Size = new System.Drawing.Size(80, 20);
            this.date_timeof.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Time of Contingency:";
            // 
            // UC_Medical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Medical";
            this.Size = new System.Drawing.Size(833, 567);
            this.Load += new System.EventHandler(this.UC_Medical_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_medical)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_medical;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_addmedical;
        private System.Windows.Forms.TextBox tb_remarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_days;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_contingency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DeleteAilment;
        private System.Windows.Forms.Button btn_AddAilment;
        private System.Windows.Forms.ListBox list_ailment;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ailment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_timeof;
        private System.Windows.Forms.Label label8;
    }
}
