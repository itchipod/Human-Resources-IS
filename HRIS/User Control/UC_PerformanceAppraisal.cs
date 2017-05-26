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
        public UC_PerformanceAppraisal()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_PerformanceAppraisal_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }

        private void loaddb()
        {

        }

        private void loadcombobox()
        {
            string sqlstring = "SELECT ID, (Emp_ID + ' - ' + Last_Name + ', ' + First_Name + ' ' + LEFT(Mid_Name, 1) + '.') AS name from Emp_Overview where Emp_Status <> 'Inactive'";
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

        private void loaddetails()
        {
            string sqlstring = "SELECT Emp_Dept, Date_Hired, Emp_Position, Supervisor, Emp_Status from Emp_Overview where ID = " + cb_name.SelectedValue.ToString();
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    
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
    }
}
