namespace HRIS.User_Control
{
    partial class UC_Dashboard
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
            this.dg_contracts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_bday = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_sched = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_contracts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bday)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sched)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_contracts);
            this.groupBox1.Location = new System.Drawing.Point(504, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contracts Expiring this Month";
            // 
            // dg_contracts
            // 
            this.dg_contracts.AllowUserToAddRows = false;
            this.dg_contracts.AllowUserToDeleteRows = false;
            this.dg_contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_contracts.Location = new System.Drawing.Point(9, 29);
            this.dg_contracts.Name = "dg_contracts";
            this.dg_contracts.ReadOnly = true;
            this.dg_contracts.RowHeadersVisible = false;
            this.dg_contracts.Size = new System.Drawing.Size(355, 225);
            this.dg_contracts.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_bday);
            this.groupBox2.Location = new System.Drawing.Point(504, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 362);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Birthdays for the Month";
            // 
            // dg_bday
            // 
            this.dg_bday.AllowUserToAddRows = false;
            this.dg_bday.AllowUserToDeleteRows = false;
            this.dg_bday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_bday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bday.Location = new System.Drawing.Point(9, 22);
            this.dg_bday.Name = "dg_bday";
            this.dg_bday.ReadOnly = true;
            this.dg_bday.RowHeadersVisible = false;
            this.dg_bday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_bday.Size = new System.Drawing.Size(355, 334);
            this.dg_bday.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_note);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.date_date);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dg_sched);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 614);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SCHEDULE/REMINDERS";
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(202, 572);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(283, 20);
            this.tb_note.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOTE:";
            // 
            // date_date
            // 
            this.date_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date.Location = new System.Drawing.Point(52, 573);
            this.date_date.Name = "date_date";
            this.date_date.Size = new System.Drawing.Size(83, 20);
            this.date_date.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATE:";
            // 
            // dg_sched
            // 
            this.dg_sched.AllowUserToAddRows = false;
            this.dg_sched.AllowUserToDeleteRows = false;
            this.dg_sched.AllowUserToResizeRows = false;
            this.dg_sched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_sched.Location = new System.Drawing.Point(6, 29);
            this.dg_sched.Name = "dg_sched";
            this.dg_sched.ReadOnly = true;
            this.dg_sched.RowHeadersVisible = false;
            this.dg_sched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_sched.Size = new System.Drawing.Size(479, 537);
            this.dg_sched.TabIndex = 0;
            this.dg_sched.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_sched_CellClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(3, 623);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(102, 623);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "REMOVE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(897, 698);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_contracts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_bday)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sched)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_sched;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dg_contracts;
        private System.Windows.Forms.DataGridView dg_bday;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
    }
}
