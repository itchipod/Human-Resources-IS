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
    public partial class UC_Dashboard : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string datetoday;
        string month;
        string id;
        public UC_Dashboard()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            datetoday = DateTime.UtcNow.Month.ToString();
            loadnote();
            loadbday();
            loadcontract();
        }

        private void loadbday()
        {
            try
            {
                string sqlstring = "SELECT Emp_ID, (First_Name + ' ' + Last_Name) AS NAME, Birthdate from Emp_Overview where MONTH(Birthdate) = " + datetoday;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_bday.DataSource = ds.Tables[0];

                        dg_bday.Columns[0].Visible = false;
                        dg_bday.Columns[1].HeaderText = "Name";
                        dg_bday.Columns[2].HeaderText = "Birthday";
                        month = dg_bday.Columns[2].ToString();



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadcontract()
        {
            try
            {
                string sqlstring = "SELECT Emp_ID, (First_Name + ' ' + Last_Name) AS NAME, Date_Hired, Contract_Exp from Emp_Overview where Emp_Status = 'Contractual' AND MONTH(Birthdate) = " + datetoday;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_contracts.DataSource = ds.Tables[0];

                        dg_contracts.Columns[0].HeaderText = "ID";
                        dg_contracts.Columns[1].HeaderText = "Name";
                        dg_contracts.Columns[2].HeaderText = "Date Hired";
                        dg_contracts.Columns[3].HeaderText = "Contract Expiration";
                        month = dg_bday.Columns[2].ToString();



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadnote()
        {
            try
            {
                string sqlstring = "SELECT * from Dash_Reminder";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_sched.DataSource = ds.Tables[0];
                        dg_sched.Columns[0].Visible = false;
                        dg_sched.Columns[1].HeaderText = "Date";
                        dg_sched.Columns[2].HeaderText = "Reminder";
                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Dash_Reminder (Note_Date, Note_Note) VALUES (@date, @note)";
                cmd.Parameters.AddWithValue("@date", date_date.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@note", tb_note.Text);
                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                loadnote();
                myconn.Close();
            }
            catch (Exception)
            {

                
            }
        }

        private void dg_sched_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dg_sched.SelectedRows[0].Cells[0].Value.ToString();
            date_date.Text = dg_sched.SelectedRows[0].Cells[1].Value.ToString();
            tb_note.Text = dg_sched.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete Record", "DELETE", MessageBoxButtons.YesNoCancel);
            if(yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from Dash_Reminder where ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loadnote();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }
            }
        }
    }
}
