namespace HRIS.User_Control_Employee
{
    partial class Form_RemoveEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.tb_mname = new System.Windows.Forms.TextBox();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_hired = new System.Windows.Forms.DateTimePicker();
            this.date_removed = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(118, 10);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 4;
            // 
            // tb_lname
            // 
            this.tb_lname.Location = new System.Drawing.Point(118, 34);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(202, 20);
            this.tb_lname.TabIndex = 5;
            // 
            // tb_mname
            // 
            this.tb_mname.Location = new System.Drawing.Point(118, 57);
            this.tb_mname.Name = "tb_mname";
            this.tb_mname.Size = new System.Drawing.Size(202, 20);
            this.tb_mname.TabIndex = 6;
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(118, 81);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(202, 20);
            this.tb_fname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Hired:";
            // 
            // date_hired
            // 
            this.date_hired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_hired.Location = new System.Drawing.Point(118, 108);
            this.date_hired.Name = "date_hired";
            this.date_hired.Size = new System.Drawing.Size(100, 20);
            this.date_hired.TabIndex = 9;
            // 
            // date_removed
            // 
            this.date_removed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_removed.Location = new System.Drawing.Point(118, 134);
            this.date_removed.Name = "date_removed";
            this.date_removed.Size = new System.Drawing.Size(100, 20);
            this.date_removed.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Removed:";
            // 
            // tb_position
            // 
            this.tb_position.Location = new System.Drawing.Point(119, 160);
            this.tb_position.Name = "tb_position";
            this.tb_position.Size = new System.Drawing.Size(201, 20);
            this.tb_position.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Last Position:";
            // 
            // tb_reason
            // 
            this.tb_reason.Location = new System.Drawing.Point(119, 186);
            this.tb_reason.Multiline = true;
            this.tb_reason.Name = "tb_reason";
            this.tb_reason.Size = new System.Drawing.Size(201, 69);
            this.tb_reason.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Reason:";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(62, 291);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 16;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(169, 291);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Form_RemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 350);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.tb_reason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_position);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_removed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_hired);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.tb_mname);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_RemoveEmployee";
            this.Text = "REMOVE EMPLOYEE";
            this.Load += new System.EventHandler(this.Form_RemoveEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.TextBox tb_mname;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_hired;
        private System.Windows.Forms.DateTimePicker date_removed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_cancel;
    }
}