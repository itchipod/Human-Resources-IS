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

namespace HRIS.User_Control_Employee
{
    public partial class UC_Medical : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        string id;
        public UC_Medical()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Medical_Load(object sender, EventArgs e)
        {
            gettempid();
            loaddbmedical();
            loadailment();
        }

        private void gettempid()
        {
            try
            {
                string sqlstring = "SELECT TempEmpID from Temp_EmpID where ID=1";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        empsystemid = ds.Tables[0].Rows[0]["TempEmpID"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void loaddbmedical()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Medical where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_medical.DataSource = ds.Tables[0];
                        dg_medical.Columns["ID"].Visible = false;
                        dg_medical.Columns["Emp_ID"].Visible = false;
                        dg_medical.Columns[2].HeaderText = "Date of Contingency";
                        dg_medical.Columns[3].HeaderText = "Place of Contingency";
                        dg_medical.Columns[4].HeaderText = "Nature of Contingency";
                        dg_medical.Columns[5].HeaderText = "Days Absent";
                        dg_medical.Columns[6].HeaderText = "Remarks";

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void loadailment()
        {
            list_ailment.Items.Clear();
            try
            {
                string sqlstring = "SELECT Ailment from Emp_Ailment where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        for(int i = 0;i < ds.Tables[0].Rows.Count; i++)
                        {
                            list_ailment.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                        }
                        //dg_medical.Columns[2].HeaderText = "Date of Contingency";

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_addmedical_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Add new records to database?", "ADD", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Emp_Medical (Emp_ID, Date_Contingency, Place_Contingency, Nature_Contingency, Days_Absent, Remarks) VALUES (@id, @date, @place, @nature, @days, @remarks) ";
                    cmd.Parameters.AddWithValue("@id", empsystemid);
                    cmd.Parameters.AddWithValue("@date", date_contingency.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@place", tb_place.Text);
                    cmd.Parameters.AddWithValue("@nature", tb_nature.Text);
                    cmd.Parameters.AddWithValue("@days", tb_days.Text);
                    cmd.Parameters.AddWithValue("@remarks", tb_remarks.Text);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddbmedical();
                    MessageBox.Show("Record added successfully");
                    audittrail("Added medical record");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void dg_medical_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dg_medical.SelectedRows[0].Cells[0].Value + string.Empty;
            //date_contingency.Text = dg_medical.SelectedRows[0].Cells[2].Value + string.Empty;
            //tb_place.Text = dg_medical.SelectedRows[0].Cells[0].Value + string.Empty;
            //tb_nature.Text = dg_medical.SelectedRows[0].Cells[0].Value + string.Empty;
            //tb_days.Text = dg_medical.SelectedRows[0].Cells[0].Value + string.Empty;
            //tb_remarks.Text = dg_medical.SelectedRows[0].Cells[0].Value + string.Empty;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete record from database?", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE FROM Emp_Medical where ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddbmedical();
                    MessageBox.Show("Record deleted successfully");
                    audittrail("Deleted medical record");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void btn_AddAilment_Click(object sender, EventArgs e)
        {
            tb_ailment.Enabled = true; btn_OK.Enabled = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Add new records to database?", "ADD", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Emp_Ailment (Emp_ID, Ailment) VALUES (@id, @ail) ";
                    cmd.Parameters.AddWithValue("@id", empsystemid);
                    cmd.Parameters.AddWithValue("@ail", tb_ailment.Text);
                    
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loadailment();
                    MessageBox.Show("Record added successfully");
                    tb_ailment.Enabled = false; btn_OK.Enabled = true;
                    audittrail("Added ailment");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void list_ailment_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q="+list_ailment.SelectedItem.ToString());
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
        }
    }
}
