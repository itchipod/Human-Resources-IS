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
    public partial class Form_Dependent : Form
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        public Form_Dependent()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void Form_Dependent_Load(object sender, EventArgs e)
        {
            gettempid();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Emp_Dependent(Dependent_Name, Relation, Age, Birthday, Emp_ID) VALUES (@spo, @rel, @age, @bir, @empid)";
                cmd.Parameters.AddWithValue("@spo", tb_depname.Text);
                cmd.Parameters.AddWithValue("@rel", tb_relation.Text);
                cmd.Parameters.AddWithValue("@age", tb_age.Text);
                cmd.Parameters.AddWithValue("@bir", date_birth.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@empid", empsystemid);
                audittrail("Added Dependent " + tb_depname.Text);
                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myconn.Close();
            this.Close();
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

        private void date_birth_ValueChanged(object sender, EventArgs e)
        {
            var datetoday = DateTime.UtcNow;

            var age = datetoday.Year - date_birth.Value.Year;
            tb_age.Text = age.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
        }
    }
}
