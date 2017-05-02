namespace HRIS.User_Control_Employee
{
    partial class UC_Training
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
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dg_training = new System.Windows.Forms.DataGridView();
            this.date_date = new System.Windows.Forms.DateTimePicker();
            this.tb_provider = new System.Windows.Forms.TextBox();
            this.tb_license = new System.Windows.Forms.TextBox();
            this.tb_rating = new System.Windows.Forms.TextBox();
            this.tb_place = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_training)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_date);
            this.groupBox1.Controls.Add(this.tb_provider);
            this.groupBox1.Controls.Add(this.tb_license);
            this.groupBox1.Controls.Add(this.tb_rating);
            this.groupBox1.Controls.Add(this.tb_place);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_type);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.dg_training);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROFESSIONAL TRAINING AND DEVELOPMENT";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(98, 463);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 463);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dg_training
            // 
            this.dg_training.AllowUserToAddRows = false;
            this.dg_training.AllowUserToDeleteRows = false;
            this.dg_training.AllowUserToResizeRows = false;
            this.dg_training.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_training.Location = new System.Drawing.Point(6, 155);
            this.dg_training.Name = "dg_training";
            this.dg_training.ReadOnly = true;
            this.dg_training.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_training.Size = new System.Drawing.Size(631, 296);
            this.dg_training.TabIndex = 0;
            this.dg_training.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_training_CellClick);
            // 
            // date_date
            // 
            this.date_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date.Location = new System.Drawing.Point(102, 84);
            this.date_date.Name = "date_date";
            this.date_date.Size = new System.Drawing.Size(129, 20);
            this.date_date.TabIndex = 27;
            // 
            // tb_provider
            // 
            this.tb_provider.Location = new System.Drawing.Point(436, 84);
            this.tb_provider.Name = "tb_provider";
            this.tb_provider.Size = new System.Drawing.Size(177, 20);
            this.tb_provider.TabIndex = 26;
            // 
            // tb_license
            // 
            this.tb_license.Location = new System.Drawing.Point(436, 59);
            this.tb_license.Name = "tb_license";
            this.tb_license.Size = new System.Drawing.Size(177, 20);
            this.tb_license.TabIndex = 25;
            // 
            // tb_rating
            // 
            this.tb_rating.Location = new System.Drawing.Point(436, 36);
            this.tb_rating.Name = "tb_rating";
            this.tb_rating.Size = new System.Drawing.Size(177, 20);
            this.tb_rating.TabIndex = 24;
            // 
            // tb_place
            // 
            this.tb_place.Location = new System.Drawing.Point(102, 109);
            this.tb_place.Name = "tb_place";
            this.tb_place.Size = new System.Drawing.Size(178, 20);
            this.tb_place.TabIndex = 23;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(102, 59);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(178, 20);
            this.tb_name.TabIndex = 22;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(102, 36);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(178, 20);
            this.tb_type.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Provided by:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "License No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Rating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Place:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type:";
            // 
            // UC_Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Training";
            this.Size = new System.Drawing.Size(665, 543);
            this.Load += new System.EventHandler(this.UC_Training_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_training)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dg_training;
        private System.Windows.Forms.DateTimePicker date_date;
        private System.Windows.Forms.TextBox tb_provider;
        private System.Windows.Forms.TextBox tb_license;
        private System.Windows.Forms.TextBox tb_rating;
        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
