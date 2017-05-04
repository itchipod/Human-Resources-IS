namespace HRIS.UC_Lists
{
    partial class Form_Restore
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.date_contract = new System.Windows.Forms.DateTimePicker();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.date_hired = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employment Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contract Expiration:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(131, 19);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(131, 50);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(138, 20);
            this.tb_name.TabIndex = 5;
            // 
            // date_contract
            // 
            this.date_contract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_contract.Location = new System.Drawing.Point(131, 149);
            this.date_contract.Name = "date_contract";
            this.date_contract.Size = new System.Drawing.Size(100, 20);
            this.date_contract.TabIndex = 7;
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Contractual",
            "Permanent",
            "Trainee"});
            this.cb_status.Location = new System.Drawing.Point(131, 82);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(112, 21);
            this.cb_status.TabIndex = 26;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(15, 241);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(75, 23);
            this.btn_restore.TabIndex = 27;
            this.btn_restore.Text = "RESTORE";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(121, 241);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // date_hired
            // 
            this.date_hired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_hired.Location = new System.Drawing.Point(131, 116);
            this.date_hired.Name = "date_hired";
            this.date_hired.Size = new System.Drawing.Size(100, 20);
            this.date_hired.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date Re-hired:";
            // 
            // Form_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 346);
            this.Controls.Add(this.date_hired);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.date_contract);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Restore";
            this.Text = "RESTORE EMPLOYEE";
            this.Load += new System.EventHandler(this.Form_Restore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DateTimePicker date_contract;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker date_hired;
        private System.Windows.Forms.Label label5;
    }
}