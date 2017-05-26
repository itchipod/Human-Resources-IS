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
    public partial class UC_Violation : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string id;
        string empid;
        public UC_Violation()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Violation_Load(object sender, EventArgs e)
        {
            loademployees();
            loaddb();
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT Emp_Violation.ID, Emp_Violation.Emp_ID, (Emp_Overview.First_Name + ' ' + Emp_Overview.Last_Name + ' ' + Emp_Overview.Suffix_Name) AS Name, Emp_Overview.Emp_Dept, Offense, Violation_Date, Violation_Place, Violation_Time, Offense_Time, Penalty, Date_Effective from Emp_Violation LEFT JOIN Emp_Overview ON Emp_Violation.Emp_ID=Emp_Overview.ID";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_violation.DataSource = ds.Tables[0];
                        dg_violation.Columns[0].Visible = false;
                       
                        dg_violation.Columns[1].HeaderText = "ID";
                        dg_violation.Columns[3].HeaderText = "Department";
                        dg_violation.Columns[4].HeaderText = "Offense";
                        dg_violation.Columns[5].HeaderText = "Violation Date";
                        dg_violation.Columns[6].HeaderText = "Violation Place";
                        dg_violation.Columns[7].HeaderText = "Violation Time";
                        dg_violation.Columns[8].HeaderText = "Times offense is made";
                        dg_violation.Columns[9].HeaderText = "Penalty";
                        dg_violation.Columns[10].HeaderText = "Date Effective";
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
                    cmd.CommandText = @"INSERT INTO Emp_Violation (Emp_ID, Offense, Violation_Date, Violation_Place, Violation_Time, Offense_Time, Penalty, Date_Effective) VALUES (@id, @off, @dat, @pla, @tim, @offtim, @pen, @dateff)";
                    cmd.Parameters.AddWithValue("@id", empid);
                    cmd.Parameters.AddWithValue("@off", tb_offense.Text);
                    cmd.Parameters.AddWithValue("@dat", date_violation.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@pla", tb_place.Text);
                    cmd.Parameters.AddWithValue("@tim", time_violation.Value.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@offtim", tb_offensewas.Text);
                    cmd.Parameters.AddWithValue("@pen", tb_penalty.Text);
                    cmd.Parameters.AddWithValue("@dateff", tb_effectivedate.Text);
                    
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    audittrail("Added Violation Report for " + cb_emp.Text);
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
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

        private void cb_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            empid = cb_emp.SelectedValue.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Update records to database?", "UPDATE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE Emp_Violation SET Emp_ID=@empid, Offense=@off, Violation_Date=@dat, Violation_Place=@pla, Violation_Time=@tim, Offense_Time=@offtim, Penalty=@pen, Date_Effective=@dateff where ID=@id";
                    cmd.Parameters.AddWithValue("@empid", empid);
                    cmd.Parameters.AddWithValue("@off", tb_offense.Text);
                    cmd.Parameters.AddWithValue("@dat", date_violation.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@pla", tb_place.Text);
                    cmd.Parameters.AddWithValue("@tim", time_violation.Value.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@offtim", tb_offensewas.Text);
                    cmd.Parameters.AddWithValue("@pen", tb_penalty.Text);
                    cmd.Parameters.AddWithValue("@dateff", tb_effectivedate.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    audittrail("Updated Violation Report History for " + cb_emp.Text);
                    MessageBox.Show("Record updated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void dg_violation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dg_violation.SelectedRows[0].Cells[0].Value.ToString() + string.Empty;
            empid = dg_violation.SelectedRows[0].Cells[1].Value.ToString() + string.Empty;
            tb_offense.Text = dg_violation.SelectedRows[0].Cells[4].Value.ToString() + string.Empty;
            date_violation.Text = dg_violation.SelectedRows[0].Cells[5].Value.ToString() + string.Empty;
            tb_place.Text = dg_violation.SelectedRows[0].Cells[6].Value.ToString() + string.Empty;
            time_violation.Text = dg_violation.SelectedRows[0].Cells[7].Value.ToString() + string.Empty;
            tb_offensewas.Text = dg_violation.SelectedRows[0].Cells[8].Value.ToString() + string.Empty;
            tb_penalty.Text = dg_violation.SelectedRows[0].Cells[9].Value.ToString() + string.Empty;
            tb_effectivedate.Text = dg_violation.SelectedRows[0].Cells[10].Value.ToString() + string.Empty;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete records from database?", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from Emp_Violation where ID=@id";
                    
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    MessageBox.Show("Record deleted successfully");
                    audittrail("Deleted Violation Report for " + cb_emp.Text);
                    
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
    }
}
