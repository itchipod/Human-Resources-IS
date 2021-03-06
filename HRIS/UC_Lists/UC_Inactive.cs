﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRIS.UC_Lists
{
    public partial class UC_Inactive : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string selectedempid;
        public UC_Inactive()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Inactive_Load(object sender, EventArgs e)
        {
            loaddb();
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT SysEmp_ID, Emp_Overview.Emp_ID, Emp_Overview.Last_Name, Emp_Overview.First_Name, Emp_Overview.Suffix_Name, Emp_Overview.Mid_Name, Emp_Overview.Date_Hired, Date_Remove, Reason_Leaving, Emp_Overview.Emp_Dept, Emp_Overview.Emp_Position, Emp_Overview.Emp_Status  from List_InactiveEmp LEFT JOIN Emp_Overview ON List_InactiveEmp.SysEmp_ID=Emp_Overview.ID";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "ID No.";
                        dataGridView1.Columns[2].HeaderText = "Last Name";
                        dataGridView1.Columns[3].HeaderText = "First Name";
                        dataGridView1.Columns[4].HeaderText = "Suffix";
                        dataGridView1.Columns[5].HeaderText = "Middle Name";
                        dataGridView1.Columns[6].HeaderText = "Date Hired";
                        dataGridView1.Columns[7].HeaderText = "Date Resigned/Retired";
                        dataGridView1.Columns[8].HeaderText = "Reason";
                        dataGridView1.Columns[9].HeaderText = "Department";
                        dataGridView1.Columns[10].HeaderText = "Position";
                        dataGridView1.Columns[11].HeaderText = "Employment Status";


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete Record Completely", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from List_InactiveEmp where SysEmp_ID=@id";
                    cmd.Parameters.AddWithValue("@id", selectedempid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    
                    deleteoverview();
                    MessageBox.Show("Record deleted successfully");
                    loaddb();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                myconn.Close();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedempid = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
            //MessageBox.Show(selectedempid);
        }

        private void deleteoverview()
        {
           
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from Emp_Overview where ID=@id";
                    cmd.Parameters.AddWithValue("@id", selectedempid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    loaddb();
                    
                }
                catch (Exception)
                {

                }
                myconn.Close();
            
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            updatetempid();
            UC_Lists.Form_Restore f = new UC_Lists.Form_Restore();
            if (Application.OpenForms[f.Name] == null)
            {
                f.Show();
            }
            else
                Application.OpenForms[f.Name].Activate();
            
        }

        public void updatetempid()
        {
            
            
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE Temp_EmpID set TempEmpID=@empid where ID=1";
                cmd.Parameters.AddWithValue("@empid", selectedempid);
                //cmd.Parameters.AddWithValue("@id", 1);
                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myconn.Close();
            }
        }

    }
}
