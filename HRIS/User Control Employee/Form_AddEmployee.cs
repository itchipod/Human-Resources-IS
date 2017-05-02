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
    public partial class Form_AddEmployee : Form
    {
        private OleDbConnection myconn;
        string datecontract="";
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public Form_AddEmployee()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cb_status.SelectedIndex == 1)
            {
                datecontract = "";
                date_contract.Enabled = false;
            }
            else
            {
                datecontract = date_contract.Value.ToShortDateString();
                date_contract.Enabled = true;
            }
        }

        private void Form_AddEmployee_Load(object sender, EventArgs e)
        {
            cb_status.SelectedIndex = 0;
            loaddepartment();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Add new employee?", "ADD", MessageBoxButtons.YesNo);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Emp_Overview(Emp_ID, Last_Name, Mid_Name, Suffix_Name, First_Name, Emp_Status, Date_Hired, Contract_Exp, Emp_Position, Emp_Dept) VALUES (@id, @lname, @mname, @suffix, @fname, @empstatus, @datehired, @contract, @pos, @dept)";
                    cmd.Parameters.AddWithValue("@id", tb_id.Text);
                    cmd.Parameters.AddWithValue("@lname", tb_lname.Text);
                    cmd.Parameters.AddWithValue("@mname", tb_mname.Text);
                    cmd.Parameters.AddWithValue("@suffix", tb_suffix.Text);
                    cmd.Parameters.AddWithValue("@fname", tb_fname.Text);
                    cmd.Parameters.AddWithValue("@empstatus", cb_status.Text);
                    cmd.Parameters.AddWithValue("@datehired", date_hired.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@contract", datecontract);
                    cmd.Parameters.AddWithValue("@pos", tb_position.Text);
                    cmd.Parameters.AddWithValue("@dept", cb_dept.Text);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully");
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

        private void loaddepartment()
        {
            try
            {
                string sqlstring = "SELECT department from Maint_Dept";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        cb_dept.DisplayMember = "department";
                        cb_dept.ValueMember = "department";
                        cb_dept.DataSource = ds.Tables[0];

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
