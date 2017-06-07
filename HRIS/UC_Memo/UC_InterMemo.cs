using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRIS.UC_Memo
{
    public partial class UC_InterMemo : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string id;
        string empid;
        public UC_InterMemo()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_InterMemo_Load(object sender, EventArgs e)
        {
            loaddb();
            loademployees();
        }

        private void loademployees()
        {
            try
            {
                string sqlstring = "SELECT ID, (Last_Name + ', ' + First_Name) AS name from Emp_Overview";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        cb_emp.DisplayMember = "name";
                        cb_emp.ValueMember = "ID";
                        cb_emp.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            string empid2 = cb_emp.SelectedValue.ToString();
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE Temp_EmpID set TempEmpID=@empid where ID=@id";
                cmd.Parameters.AddWithValue("@empid", empid2);
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myconn.Close();
            }
            Form_Overview f = new Form_Overview();
            f.Show();
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT Emp_Memo.ID, Memo_Subject, Memo_Date, Memo_DateReceived, Emp_Memo.Emp_ID, (Emp_Overview.First_Name + ' ' + Emp_Overview.Last_Name + ' ' + Emp_Overview.Suffix_Name) AS Name, Emp_Overview.Emp_Dept from Emp_Memo LEFT JOIN Emp_Overview ON Emp_Memo.Emp_ID=Emp_Overview.ID";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_memo.DataSource = ds.Tables[0];
                        dg_memo.Columns[0].Visible = false;

                        dg_memo.Columns[1].HeaderText = "Subject";
                        dg_memo.Columns[2].HeaderText = "Date";
                        dg_memo.Columns[3].HeaderText = "Date Received";
                        dg_memo.Columns[4].HeaderText = "Employee ID";
                        dg_memo.Columns[5].HeaderText = "Employee Name";
                        dg_memo.Columns[6].HeaderText = "Department";
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Add new records to database?", "ADD", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Emp_Memo (Memo_Subject, Memo_Date, Memo_DateReceived, Emp_ID) VALUES (@subj, @date, @datr, @empid)";
                    cmd.Parameters.AddWithValue("@subj", tb_subject.Text);
                    cmd.Parameters.AddWithValue("@date", date_date.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@datr", date_received.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@empid", cb_emp.SelectedValue.ToString());
                    

                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    audittrail("Added Memo Report for " + cb_emp.Text);
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Update records to database?", "ADD", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE Emp_Memo SET Memo_Subject=@subj, Memo_Date=@date, Memo_DateReceived=@datr, Emp_ID=@empid where ID=@id";
                    cmd.Parameters.AddWithValue("@subj", tb_subject.Text);
                    cmd.Parameters.AddWithValue("@date", date_date.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@datr", date_received.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@empid", cb_emp.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@id", id);


                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    audittrail("Updated Memo Report for " + cb_emp.Text);
                    MessageBox.Show("Record updated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void dg_memo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dg_memo.SelectedRows[0].Cells[0].Value.ToString() + string.Empty;
            tb_subject.Text = dg_memo.SelectedRows[0].Cells[1].Value.ToString() + string.Empty;
            date_date.Text = dg_memo.SelectedRows[0].Cells[2].Value.ToString() + string.Empty;
            date_received.Text = dg_memo.SelectedRows[0].Cells[3].Value.ToString() + string.Empty;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

            DialogResult yesno = MessageBox.Show("Delete records from database?", "ADD", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE FROM Emp_Memo where ID=@id";
                    
                    cmd.Parameters.AddWithValue("@id", id);


                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    audittrail("Deleted Memo Report for " + cb_emp.Text);
                    MessageBox.Show("Record deleted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
        }
    }
}
