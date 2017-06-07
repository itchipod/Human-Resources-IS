using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using Microsoft.Office.Interop.Word;

namespace HRIS.User_Control
{
    public partial class UC_PerformanceAppraisal : UserControl
    {
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        private OleDbConnection myconn;
        string empid; string id;
        public UC_PerformanceAppraisal()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_PerformanceAppraisal_Load(object sender, EventArgs e)
        {
            loaddb();
            loadcombobox();
            loaddepartment();
            loadperiod();
           
            cb_period.Text = "PERIOD";
            cb_department.Text = "DEPARTMENT";
           
        }

        private void loaddb()
        {
            try {
                string sqlstring = "SELECT Emp_Evaluation.ID, Emp_Evaluation.Emp_ID, Emp_Overview.Emp_ID, (Emp_Overview.First_Name + ' ' + Emp_Overview.Last_Name + ' ' + Emp_Overview.Mid_Name) AS Name, Eval_Period, Eval_Grade, Eval_By, Emp_Overview.Emp_Dept FROM Emp_Evaluation LEFT JOIN Emp_Overview ON Emp_Evaluation.Emp_ID=Emp_Overview.ID";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].Visible = false;
                        dataGridView1.Columns[2].HeaderText = "Employee ID";
                        dataGridView1.Columns[3].HeaderText = "Employee Name";
                        dataGridView1.Columns[4].HeaderText = "Period";
                        dataGridView1.Columns[5].HeaderText = "Grade(%)";
                        dataGridView1.Columns[6].HeaderText = "Evaluated by";
                        dataGridView1.Columns[7].HeaderText = "Department";
                        

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadcombobox()
        {
            string sqlstring = "SELECT ID, Emp_ID, (Emp_ID + ' - ' + Last_Name + ', ' + First_Name + ' ' + LEFT(Mid_Name, 1) + '.') AS name from Emp_Overview where Emp_Status <> 'Inactive'";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cb_name.ValueMember = "ID";
                    cb_name.DisplayMember = "name";
                    
                    //tb_period.Text = ds.Tables[0].Rows[0][0].ToString();
                    cb_name.DataSource = ds.Tables[0];

                }
            }
        }

        

        private void btn_overview_Click(object sender, EventArgs e)
        {
            string empid2 = cb_name.SelectedValue.ToString();
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

        private void loadperiod()
        {
            string sqlstring = "SELECT DISTINCT Eval_Period from Emp_Evaluation";
           using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cb_period.ValueMember = "Eval_Period";
                    cb_period.DisplayMember = "Eval_Period";
                    //tb_period.Text = ds.Tables[0].Rows[0][0].ToString();
                    cb_period.DataSource = ds.Tables[0];

                }
            }
        }

        private void loaddepartment()
        {
            string sqlstring = "SELECT department from Maint_Dept where department <> 'ALL'";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cb_department.ValueMember = "department";
                    cb_department.DisplayMember = "department";
                    //tb_period.Text = ds.Tables[0].Rows[0][0].ToString();
                    cb_department.DataSource = ds.Tables[0];

                }
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
                    cmd.CommandText = @"INSERT INTO Emp_Evaluation (Emp_ID, Eval_Period, Eval_Grade, Eval_By) VALUES (@id, @per, @gra, @by)";
                    cmd.Parameters.AddWithValue("@id", empid);
                    cmd.Parameters.AddWithValue("@per", tb_period.Text);
                    cmd.Parameters.AddWithValue("@gra", tb_grade.Text);
                    cmd.Parameters.AddWithValue("@by", tb_evaluated.Text);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    audittrail("Added Violation Report for " + cb_name.Text);
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void cb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            empid = cb_name.SelectedValue.ToString();
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
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
                    cmd.CommandText = @"UPDATE Emp_Evaluation SET Emp_ID=@empid, Eval_Period=@per, Eval_Grade=@gra, Eval_By=@by where ID=@id";
                    cmd.Parameters.AddWithValue("@empid", empid);
                    cmd.Parameters.AddWithValue("@per", tb_period.Text);
                    cmd.Parameters.AddWithValue("@gra", tb_grade.Text);
                    cmd.Parameters.AddWithValue("@by", tb_evaluated.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    audittrail("Added Violation Report for " + cb_name.Text);
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
            tb_period.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + string.Empty;
            tb_grade.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString() + string.Empty;
            tb_evaluated.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + string.Empty;
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
                    cmd.CommandText = @"DELETE FROM Emp_Evaluation where ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    audittrail("Added Violation Report for " + cb_name.Text);
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                //cb_department.Enabled = true;
                cb_period.Enabled = true;
            }
            else
            {
                //cb_department.Enabled = false;
                cb_period.Enabled = false;
                loaddb();
            }
        }

        private void cb_period_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChange();
        }

        private void cbChange()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("Eval_Period LIKE '%{0}%' AND Emp_Dept LIKE '%{1}%'", cb_period.Text, cb_department.Text);
            else if (checkBox1.Checked == true)
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("Eval_Period LIKE '%{0}%'", cb_period.Text);
            else if (checkBox2.Checked == true)
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("Emp_Dept LIKE '%{0}%'", cb_department.Text);

            averagegrade();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                cb_department.Enabled = true;
                //cb_period.Enabled = true;
            }
            else
            {
                cb_department.Enabled = false;
                loaddb();
                //cb_period.Enabled = false;
            }
        }

        private void cb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChange();

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        

        private void copyAlltoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_period_DisplayMemberChanged(object sender, EventArgs e)
        {
            //int grades1 = 0;
            averagegrade();
        }

        private void averagegrade()
        {
            int rowcount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Visible);
            
            float[] grades = new float[rowcount];
            for (int i = 0; i < rowcount; i++)
            {
                grades[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }

            float average = grades.Sum() / rowcount;
            lbl_average.Text = average.ToString() + "%";
        }
    }


}
