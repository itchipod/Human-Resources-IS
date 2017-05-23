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
    public partial class UC_Performance : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        string vio_id;
        public UC_Performance()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Performance_Load(object sender, EventArgs e)
        {
            gettempid();
            getviolation();
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

        private void getviolation()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Violation where Emp_ID=" + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_violation.DataSource = ds.Tables[0];
                        dg_violation.Columns[0].Visible = false;
                        dg_violation.Columns[1].Visible = false;
                        dg_violation.Columns[2].HeaderText = "Offense";
                        dg_violation.Columns[3].HeaderText = "Date";
                        dg_violation.Columns[4].HeaderText = "Place";
                        dg_violation.Columns[5].HeaderText = "Time";
                        dg_violation.Columns[6].HeaderText = "Penalty";
                        dg_violation.Columns[7].HeaderText = "Date Effective";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dg_violation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vio_id = dg_violation.SelectedRows[0].Cells[0].Value.ToString() + string.Empty;
        }

        private void btn_Del_Click(object sender, EventArgs e)
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
                    getviolation();
                    cmd.Parameters.AddWithValue("@id", vio_id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    
                    audittrail("Deleted Violation Report for");
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
