namespace HRIS.User_Control_Employee
{
    partial class UC_Education
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
            this.btn_update = new System.Windows.Forms.Button();
            this.cb_level = new System.Windows.Forms.ComboBox();
            this.btn_uploaddiploma = new System.Windows.Forms.Button();
            this.btn_viewdiploma = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_honor = new System.Windows.Forms.TextBox();
            this.tb_degree = new System.Windows.Forms.TextBox();
            this.tb_schoolname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_diploma = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_diploma);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.cb_level);
            this.groupBox1.Controls.Add(this.btn_uploaddiploma);
            this.groupBox1.Controls.Add(this.btn_viewdiploma);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.tb_honor);
            this.groupBox1.Controls.Add(this.tb_degree);
            this.groupBox1.Controls.Add(this.tb_schoolname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EDUCATIONAL ATTAINMENT";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(221, 212);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cb_level
            // 
            this.cb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_level.FormattingEnabled = true;
            this.cb_level.Items.AddRange(new object[] {
            "ELEMENTARY",
            "SECONDARY",
            "VOCATIONAL",
            "COLLEGE",
            "GRADUATE",
            "POST-GRADUATE"});
            this.cb_level.Location = new System.Drawing.Point(221, 20);
            this.cb_level.Name = "cb_level";
            this.cb_level.Size = new System.Drawing.Size(195, 21);
            this.cb_level.TabIndex = 36;
            this.cb_level.SelectedIndexChanged += new System.EventHandler(this.cb_level_SelectedIndexChanged);
            // 
            // btn_uploaddiploma
            // 
            this.btn_uploaddiploma.Location = new System.Drawing.Point(278, 158);
            this.btn_uploaddiploma.Name = "btn_uploaddiploma";
            this.btn_uploaddiploma.Size = new System.Drawing.Size(67, 19);
            this.btn_uploaddiploma.TabIndex = 35;
            this.btn_uploaddiploma.Text = "UPLOAD";
            this.btn_uploaddiploma.UseVisualStyleBackColor = true;
            this.btn_uploaddiploma.Click += new System.EventHandler(this.btn_uploaddiploma_Click);
            // 
            // btn_viewdiploma
            // 
            this.btn_viewdiploma.Location = new System.Drawing.Point(221, 158);
            this.btn_viewdiploma.Name = "btn_viewdiploma";
            this.btn_viewdiploma.Size = new System.Drawing.Size(51, 19);
            this.btn_viewdiploma.TabIndex = 2;
            this.btn_viewdiploma.Text = "VIEW";
            this.btn_viewdiploma.UseVisualStyleBackColor = true;
            this.btn_viewdiploma.Click += new System.EventHandler(this.btn_viewdiploma_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "DIPLOMA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "ADDRESS";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(221, 130);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(300, 20);
            this.tb_address.TabIndex = 14;
            // 
            // tb_honor
            // 
            this.tb_honor.Location = new System.Drawing.Point(221, 106);
            this.tb_honor.Name = "tb_honor";
            this.tb_honor.Size = new System.Drawing.Size(300, 20);
            this.tb_honor.TabIndex = 14;
            // 
            // tb_degree
            // 
            this.tb_degree.Location = new System.Drawing.Point(221, 82);
            this.tb_degree.Name = "tb_degree";
            this.tb_degree.Size = new System.Drawing.Size(300, 20);
            this.tb_degree.TabIndex = 13;
            // 
            // tb_schoolname
            // 
            this.tb_schoolname.Location = new System.Drawing.Point(221, 58);
            this.tb_schoolname.Name = "tb_schoolname";
            this.tb_schoolname.Size = new System.Drawing.Size(300, 20);
            this.tb_schoolname.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "HONOR/SCHOLARSHIP RECEIVED";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "DEGREE/UNITS EARNED";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NAME OF SCHOOL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LEVEL";
            // 
            // tb_diploma
            // 
            this.tb_diploma.Enabled = false;
            this.tb_diploma.Location = new System.Drawing.Point(351, 158);
            this.tb_diploma.Name = "tb_diploma";
            this.tb_diploma.Size = new System.Drawing.Size(170, 20);
            this.tb_diploma.TabIndex = 37;
            // 
            // UC_Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Education";
            this.Size = new System.Drawing.Size(919, 413);
            this.Load += new System.EventHandler(this.UC_Education_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_honor;
        private System.Windows.Forms.TextBox tb_degree;
        private System.Windows.Forms.TextBox tb_schoolname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_uploaddiploma;
        private System.Windows.Forms.Button btn_viewdiploma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_level;
        private System.Windows.Forms.TextBox tb_diploma;
    }
}
