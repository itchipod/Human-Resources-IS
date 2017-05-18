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

namespace HRIS
{
    public partial class  Form_Main : Form
    {
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public Form_Main()
        {
            InitializeComponent();
        }       

        public void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Control.UC_Employee ue = new User_Control.UC_Employee();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(ue);
            removecolors();
            employeeToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Control.UC_MaintDepartment um = new User_Control.UC_MaintDepartment();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(um);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            setadmin();
            User_Control.UC_Dashboard um = new User_Control.UC_Dashboard();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(um);
        }

        private void allEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Lists.UC_Masterlist um = new UC_Lists.UC_Masterlist();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(um);
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removecolors();
            maintenanceToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
        }

        private void removecolors()
        {
            maintenanceToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            memorandumToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            listOfReportsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            employeeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            performanceAppraisalToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            usersToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            auditTrailToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void performanceAppraisalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removecolors();
            performanceAppraisalToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
        }

        private void memorandumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removecolors();
            memorandumToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
        }

        private void listOfReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removecolors();
            listOfReportsToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
        }

        private void inactiveEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Lists.UC_Inactive uc = new UC_Lists.UC_Inactive();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(uc);

        }

        private void employmentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Lists.UC_EmpStatus uc = new UC_Lists.UC_EmpStatus();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(uc);
        }

        private void birthdaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Lists.UC_Birthday uc = new UC_Lists.UC_Birthday();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(uc);

        }

        private void backToDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Control.UC_Dashboard uc = new User_Control.UC_Dashboard();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(uc);
            removecolors();
            backToDashboardToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_UserLogin.UC_Users u = new UC_UserLogin.UC_Users();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(u);
            removecolors();
            usersToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
        }

        private void auditTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Audit_Trail.UC_Audit u = new Audit_Trail.UC_Audit();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(u);
            removecolors();
            auditTrailToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
        }

        private void setadmin()
        {
            string sqlstring = "SELECT user_type from Users_UserLogged where ID=1";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    string a = ds.Tables[0].Rows[0]["user_type"].ToString();
                    if (a != "Administrator")
                    {
                        maintenanceToolStripMenuItem.Visible = false;
                        usersToolStripMenuItem.Visible = false;

                    }
                }
            }
        }

        private void printPerformanceAppraisalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Control.UC_PerformanceAppraisalPrint uc = new User_Control.UC_PerformanceAppraisalPrint();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(uc);
            
        }

        private void medicalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Lists.UC_MedicalRecords uc = new UC_Lists.UC_MedicalRecords();
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(uc);
        }
    }
}
