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

namespace HRIS.User_Control
{
    public partial class UC_Employee : UserControl
    {
        private OleDbConnection myconn;
        public string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public string id;
        public string empid;

        User_Control_Employee.UC_Overview uo = new User_Control_Employee.UC_Overview();
        User_Control_Employee.UC_Education ue = new User_Control_Employee.UC_Education();
        User_Control_Employee.UC_Family uf = new User_Control_Employee.UC_Family();
        User_Control_Employee.UC_Employee uh = new User_Control_Employee.UC_Employee();
        User_Control_Employee.UC_Training ut = new User_Control_Employee.UC_Training();
        User_Control_Employee.UC_Medical um = new User_Control_Employee.UC_Medical();
        User_Control_Employee.UC_Performance up = new User_Control_Employee.UC_Performance();

        public UC_Employee()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }
        //private User_Control_Employee.UC_Overview uo = new User_Control_Employee.UC_Overview();
        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changecolor();
            
            panel_employee.Controls.Clear();
            //applytocontents();
            panel_employee.Controls.Add(uo);
            overviewToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            toolstripuncheck();
            overviewToolStripMenuItem.Checked = true;
            //uo.testtry();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {

            loademployees();
            dg_emp.Rows[0].Cells[0].Selected = false;
            //applytocontents();
            overviewToolStripMenuItem_Click(this, new EventArgs());
            dg_emp.Focus();
           
            //dg_emp_CellClick(this, new EventArgs());
            
            
            
        }

        private void changecolor()
        {
            overviewToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            educationAttainmentToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            familyInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            medicalHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            employmentHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            trainingAndDevelopmentToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            performanceToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void educationAttainmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changecolor();
            
            panel_employee.Controls.Clear();
            panel_employee.Controls.Add(ue);
            educationAttainmentToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            toolstripuncheck();
            educationAttainmentToolStripMenuItem.Checked = true;
        }

        private void familyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changecolor();
            
            panel_employee.Controls.Clear();
            panel_employee.Controls.Add(uf);
            familyInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            toolstripuncheck();
            familyInformationToolStripMenuItem.Checked = true;
        }

        private void employmentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changecolor();
            
            panel_employee.Controls.Clear();
            panel_employee.Controls.Add(uh);
            employmentHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            toolstripuncheck();
            employmentHistoryToolStripMenuItem.Checked = true;
        }

        private void trainingAndDevelopmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changecolor();
            
            panel_employee.Controls.Clear();
            panel_employee.Controls.Add(ut);
            trainingAndDevelopmentToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            toolstripuncheck();
            trainingAndDevelopmentToolStripMenuItem.Checked = true;
        }

        private void medicalHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changecolor();
            
            panel_employee.Controls.Clear();
            panel_employee.Controls.Add(um);
            medicalHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            toolstripuncheck();
            medicalHistoryToolStripMenuItem.Checked = true;
        }

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changecolor();
            
            panel_employee.Controls.Clear();
            panel_employee.Controls.Add(up);
            performanceToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            toolstripuncheck();
            performanceToolStripMenuItem.Checked = true;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            User_Control_Employee.Form_AddEmployee f = new User_Control_Employee.Form_AddEmployee();
            if (Application.OpenForms[f.Name] == null)
            {
                f.Show();
            }
            else
                Application.OpenForms[f.Name].Activate();
            
        }

        public void loademployees()
        {
            
                try
                {
                    string sqlstring = "SELECT ID, Emp_ID,(Emp_ID + ' - ' + Last_Name + ', ' + First_Name + ' ' + Mid_Name) AS NAME from Emp_Overview where Emp_Status <> 'Inactive'";
                    using (OleDbConnection conn = new OleDbConnection(connstring))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            dg_emp.DataSource = ds.Tables[0];
                            dg_emp.Columns["Emp_ID"].Visible = false;
                            dg_emp.Columns["ID"].Visible = false;
                            dg_emp.Columns["NAME"].HeaderText = "EMPLOYEE";
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dg_emp.DataSource as DataTable).DefaultView.RowFilter = string.Format("NAME LIKE '%{0}%'", tb_searchemp.Text);
        }
   

        public void applytocontents()
        {
             id = dg_emp.SelectedRows[0].Cells[0].Value + string.Empty;
             //empid = dg_emp.SelectedRows[0].Cells[1].Value + string.Empty;
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE Temp_EmpID set TempEmpID=@empid where ID=@id";
                cmd.Parameters.AddWithValue("@empid", id);
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

            if (overviewToolStripMenuItem.Checked == true)
            {

                uo.gettempid();
                uo.setTextboxes();
            }
            //overviewToolStripMenuItem_Click(this, new EventArgs());
            else if (educationAttainmentToolStripMenuItem.Checked == true)
            {
                educationAttainmentToolStripMenuItem_Click(this, new EventArgs());
            }
            else if (familyInformationToolStripMenuItem.Checked == true)
            {
                uf.gettempid();
                uf.setspouse();
                uf.getdependents();
                //familyInformationToolStripMenuItem_Click(this, new EventArgs());
            }

            else if (performanceToolStripMenuItem.Checked == true)
            {
                up.gettempid();
                up.getviolation();
                up.getperformance();
                //performanceToolStripMenuItem_Click(this, new EventArgs());
            }
            else if (employmentHistoryToolStripMenuItem.Checked == true)
            {
                uh.gettempid();
                uh.loademployer();
                //employmentHistoryToolStripMenuItem_Click(this, new EventArgs());
            }
            else if (medicalHistoryToolStripMenuItem.Checked == true)
            {
                um.gettempid();
                um.loaddbmedical();
                um.loadailment();
                //medicalHistoryToolStripMenuItem_Click(this, new EventArgs());
            }
            else if (trainingAndDevelopmentToolStripMenuItem.Checked == true)
            {
                ut.gettempid();
                ut.loadtraining();
                //trainingAndDevelopmentToolStripMenuItem_Click(this, new EventArgs());
            }
        }

        private void dg_emp_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dg_emp.SelectedRows.Count > 0)
                applytocontents();
        }

        private void tb_searchemp_Click(object sender, EventArgs e)
        {

        }

        private void tb_searchemp_Leave(object sender, EventArgs e)
        {

        }

        private void toolstripuncheck()
        {
            overviewToolStripMenuItem.Checked = false;
            familyInformationToolStripMenuItem.Checked = false;
            medicalHistoryToolStripMenuItem.Checked = false;
            educationAttainmentToolStripMenuItem.Checked = false;
            employmentHistoryToolStripMenuItem.Checked = false;
            trainingAndDevelopmentToolStripMenuItem.Checked = false;
            performanceToolStripMenuItem.Checked = false;
        }

        private void tb_searchemp_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            User_Control_Employee.Form_RemoveEmployee f = new User_Control_Employee.Form_RemoveEmployee();
            if (Application.OpenForms[f.Name] == null)
            {
                f.Show();
            }
            else
                Application.OpenForms[f.Name].Activate();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            loademployees();
        }

        private void dg_emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_emp.SelectedRows.Count > 0)
                applytocontents();
        }
    }
}
