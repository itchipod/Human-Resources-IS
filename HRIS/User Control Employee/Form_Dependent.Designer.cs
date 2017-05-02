namespace HRIS.User_Control_Employee
{
    partial class Form_Dependent
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
            this.tb_depname = new System.Windows.Forms.TextBox();
            this.tb_relation = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dependent Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // tb_depname
            // 
            this.tb_depname.Location = new System.Drawing.Point(104, 10);
            this.tb_depname.Name = "tb_depname";
            this.tb_depname.Size = new System.Drawing.Size(158, 20);
            this.tb_depname.TabIndex = 4;
            // 
            // tb_relation
            // 
            this.tb_relation.Location = new System.Drawing.Point(104, 39);
            this.tb_relation.Name = "tb_relation";
            this.tb_relation.Size = new System.Drawing.Size(158, 20);
            this.tb_relation.TabIndex = 5;
            // 
            // tb_age
            // 
            this.tb_age.Enabled = false;
            this.tb_age.Location = new System.Drawing.Point(104, 97);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(46, 20);
            this.tb_age.TabIndex = 6;
            // 
            // date_birth
            // 
            this.date_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_birth.Location = new System.Drawing.Point(104, 69);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(105, 20);
            this.date_birth.TabIndex = 7;
            this.date_birth.ValueChanged += new System.EventHandler(this.date_birth_ValueChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(89, 141);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(7, 141);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form_Dependent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 200);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_relation);
            this.Controls.Add(this.tb_depname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Dependent";
            this.Text = "Add Dependent";
            this.Load += new System.EventHandler(this.Form_Dependent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_depname;
        private System.Windows.Forms.TextBox tb_relation;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
    }
}