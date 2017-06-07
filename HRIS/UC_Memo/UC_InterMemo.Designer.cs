namespace HRIS.UC_Memo
{
    partial class UC_InterMemo
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
            this.btn_overview = new System.Windows.Forms.Button();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.date_received = new System.Windows.Forms.DateTimePicker();
            this.date_date = new System.Windows.Forms.DateTimePicker();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_memo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_memo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_overview);
            this.groupBox1.Controls.Add(this.cb_emp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.date_received);
            this.groupBox1.Controls.Add(this.date_date);
            this.groupBox1.Controls.Add(this.tb_subject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dg_memo);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memorandum";
            // 
            // btn_overview
            // 
            this.btn_overview.BackgroundImage = global::HRIS.Properties.Resources.Icons8_Windows_8_Editing_Overview_Pages_1;
            this.btn_overview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_overview.Location = new System.Drawing.Point(482, 25);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(25, 23);
            this.btn_overview.TabIndex = 24;
            this.btn_overview.UseVisualStyleBackColor = true;
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // cb_emp
            // 
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(332, 26);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(145, 21);
            this.cb_emp.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Employee:";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(188, 436);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(97, 436);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 436);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // date_received
            // 
            this.date_received.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_received.Location = new System.Drawing.Point(137, 83);
            this.date_received.Name = "date_received";
            this.date_received.Size = new System.Drawing.Size(100, 20);
            this.date_received.TabIndex = 6;
            // 
            // date_date
            // 
            this.date_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date.Location = new System.Drawing.Point(137, 55);
            this.date_date.Name = "date_date";
            this.date_date.Size = new System.Drawing.Size(100, 20);
            this.date_date.TabIndex = 5;
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(137, 28);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(100, 20);
            this.tb_subject.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Received:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // dg_memo
            // 
            this.dg_memo.AllowUserToAddRows = false;
            this.dg_memo.AllowUserToDeleteRows = false;
            this.dg_memo.AllowUserToResizeRows = false;
            this.dg_memo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_memo.Location = new System.Drawing.Point(6, 122);
            this.dg_memo.Name = "dg_memo";
            this.dg_memo.ReadOnly = true;
            this.dg_memo.RowHeadersVisible = false;
            this.dg_memo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_memo.Size = new System.Drawing.Size(540, 296);
            this.dg_memo.TabIndex = 0;
            this.dg_memo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_memo_CellClick);
            // 
            // UC_InterMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_InterMemo";
            this.Size = new System.Drawing.Size(571, 542);
            this.Load += new System.EventHandler(this.UC_InterMemo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_memo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_memo;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker date_received;
        private System.Windows.Forms.DateTimePicker date_date;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_overview;
        private System.Windows.Forms.ComboBox cb_emp;
        private System.Windows.Forms.Label label4;
    }
}
