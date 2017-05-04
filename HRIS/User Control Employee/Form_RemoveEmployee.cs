using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRIS.User_Control_Employee
{
    public partial class Form_RemoveEmployee : Form
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        public Form_RemoveEmployee()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void Form_RemoveEmployee_Load(object sender, EventArgs e)
        {
            gettempid();
            setTextboxes();
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

        private void setTextboxes()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Overview where ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_id.Text = ds.Tables[0].Rows[0]["Emp_ID"].ToString();
                        
                        tb_fname.Text = ds.Tables[0].Rows[0]["First_Name"].ToString() + ds.Tables[0].Rows[0]["Suffix_Name"].ToString(); 
                        tb_lname.Text = ds.Tables[0].Rows[0]["Last_Name"].ToString();
                        tb_mname.Text = ds.Tables[0].Rows[0]["Mid_Name"].ToString();
                        
                        tb_position.Text = ds.Tables[0].Rows[0]["Emp_Position"].ToString();
                        
                        date_hired.Text = ds.Tables[0].Rows[0]["Date_Hired"].ToString();
                       

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_reason.Text))
            {
                addtoinactive();
                setstatus();
                Form_Main m = new Form_Main();
                m.employeeToolStripMenuItem_Click(this, new EventArgs());
            }
            else
                MessageBox.Show("Must Provide Reason for Removing");
        }

        private void addtoinactive()
        {
            DialogResult yesno = MessageBox.Show("Remove employee?", "REMOVE", MessageBoxButtons.YesNo);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO List_InactiveEmp(Emp_ID, Last_Name, Mid_Name, First_Name, Date_Hired, Date_Remove, Emp_Position, Reason_Leaving, SysEmp_ID) VALUES (@id, @lname, @mname, @fname, @datehired, @dateremoved, @pos, @reason, @sysid)";
                    cmd.Parameters.AddWithValue("@id", tb_id.Text);
                    cmd.Parameters.AddWithValue("@lname", tb_lname.Text);
                    cmd.Parameters.AddWithValue("@mname", tb_mname.Text);
                    cmd.Parameters.AddWithValue("@fname", tb_fname.Text);
                    
                    cmd.Parameters.AddWithValue("@datehired", date_hired.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@dateremoved", date_removed.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@pos", tb_position.Text);
                    cmd.Parameters.AddWithValue("@reason", tb_reason.Text);
                    cmd.Parameters.AddWithValue("@sysid", empsystemid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();

                    
                    //ue.loademployees();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                myconn.Close();
            }
        }

        private void setstatus()
        {
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE Emp_Overview set Emp_Status = @status where ID=@id";
                cmd.Parameters.AddWithValue("@status", "Inactive");
                cmd.Parameters.AddWithValue("@id", empsystemid);
                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Removed Successfully");
                User_Control.UC_Employee ue = new User_Control.UC_Employee();
                ue.loademployees();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myconn.Close();
        }
    }
}
