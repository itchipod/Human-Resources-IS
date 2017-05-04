using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRIS.UC_Lists
{
    public partial class Form_Restore : Form
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        public Form_Restore()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void Form_Restore_Load(object sender, EventArgs e)
        {
            cb_status.SelectedIndex = 0;
            gettempid();
            loaddb();
        }

        private void loaddb()
        {
            string sqlstring = "SELECT Emp_ID, (Last_Name + ', ' + First_Name + ' ' + Mid_Name) AS Empname FROM Emp_Overview where ID=" +empsystemid;
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    tb_id.Text = ds.Tables[0].Rows[0]["Emp_ID"].ToString();
                    tb_name.Text = ds.Tables[0].Rows[0]["Empname"].ToString();
                }
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

        private void btn_restore_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Update records to database?", "RESTORE", MessageBoxButtons.YesNoCancel);
            if(yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE Emp_Overview set Emp_Status=@status, Date_Hired=@datehired, Contract_Exp=@contract where ID=@id";
                    cmd.Parameters.AddWithValue("@status", cb_status.Text);
                    cmd.Parameters.AddWithValue("@datehired", date_hired.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@contract", date_contract.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@id", empsystemid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully. Check Employee Module.");
                    myconn.Close();
                    deletedb();
                    
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }
                
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.SelectedIndex == 1)
            {
                date_contract.Enabled = false;
            }
            else
                date_contract.Enabled = true;
        }

        private void deletedb()
        {
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"DELETE from List_InactiveEmp where SysEmp_ID=@id";
                cmd.Parameters.AddWithValue("@id", empsystemid);
                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                
                myconn.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myconn.Close();
            }
        }
    }
}
