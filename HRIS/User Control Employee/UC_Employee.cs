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
    public partial class UC_Employee : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        string id;
        public UC_Employee()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dg_history.SelectedRows[0].Cells[0].Value + string.Empty;
            tb_address.Text = dg_history.SelectedRows[0].Cells[2].Value + string.Empty;
            tb_companyname.Text = dg_history.SelectedRows[0].Cells[1].Value + string.Empty;
            tb_jobdescr.Text = dg_history.SelectedRows[0].Cells[4].Value + string.Empty;
            tb_lastsalary.Text = dg_history.SelectedRows[0].Cells[9].Value + string.Empty;
            tb_period.Text = dg_history.SelectedRows[0].Cells[5].Value + string.Empty;
            tb_position.Text = dg_history.SelectedRows[0].Cells[3].Value + string.Empty;
            tb_reason.Text = dg_history.SelectedRows[0].Cells[8].Value + string.Empty;
            tb_supervisor.Text = dg_history.SelectedRows[0].Cells[7].Value + string.Empty;
            tb_telno.Text = dg_history.SelectedRows[0].Cells[6].Value + string.Empty;
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            gettempid();
            loademployer();
        }

        private void loademployer()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_History where Emp_ID = " +empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_history.DataSource = ds.Tables[0];
                        dg_history.Columns["ID"].Visible = false;
                        dg_history.Columns["Emp_ID"].Visible = false;
                        dg_history.Columns[1].HeaderText = "Company Name";
                        dg_history.Columns[2].HeaderText = "Address";
                        dg_history.Columns[3].HeaderText = "Position";
                        dg_history.Columns[4].HeaderText = "Job Description";
                        dg_history.Columns[5].HeaderText = "Job Period";
                        dg_history.Columns[6].HeaderText = "Telephone No";
                        dg_history.Columns[7].HeaderText = "Reason for Leaving";
                        dg_history.Columns[8].HeaderText = "Last Salary";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
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
                    cmd.CommandText = @"INSERT INTO Emp_History (Company_Name, Company_Address, Company_Position, Job_Descr, Job_Period, Tel_no, Supervisor, Reason_Leaving, Last_Salary, Emp_ID) VALUES (@nam, @add, @pos, @des, @per, @tel, @sup, @rea, @las, @emp)";
                    cmd.Parameters.AddWithValue("@nam", tb_companyname.Text);
                    cmd.Parameters.AddWithValue("@add", tb_address.Text);
                    cmd.Parameters.AddWithValue("@pos", tb_position.Text);
                    cmd.Parameters.AddWithValue("@des", tb_jobdescr.Text);
                    cmd.Parameters.AddWithValue("@per", tb_period.Text);
                    cmd.Parameters.AddWithValue("@tel", tb_telno.Text);
                    cmd.Parameters.AddWithValue("@sup", tb_supervisor.Text);
                    cmd.Parameters.AddWithValue("@rea", tb_reason.Text);
                    cmd.Parameters.AddWithValue("@las", tb_lastsalary.Text);
                    cmd.Parameters.AddWithValue("@emp", empsystemid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loademployer();
                    audittrail("Added Employment History for "+empsystemid);
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete records from database?", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from Emp_History where ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loademployer();
                    audittrail("Deleted Employment History for " + empsystemid);
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
