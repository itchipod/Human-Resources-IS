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

namespace HRIS.User_Control_Employee
{
    public partial class UC_Training : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        string id;
        public UC_Training()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Training_Load(object sender, EventArgs e)
        {
            gettempid();
            loadtraining();
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

        private void loadtraining()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Training where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_training.DataSource = ds.Tables[0];
                        dg_training.Columns["ID"].Visible = false;
                        dg_training.Columns["Emp_ID"].Visible = false;
                        dg_training.Columns[1].HeaderText = "Type";
                        dg_training.Columns[2].HeaderText = "Training/Exam Name";
                        dg_training.Columns[3].HeaderText = "Date Attended";
                        dg_training.Columns[4].HeaderText = "Training Place";
                        dg_training.Columns[5].HeaderText = "Rating";
                        dg_training.Columns[6].HeaderText = "License Number";
                        dg_training.Columns[7].HeaderText = "Provider";
                        
                    }
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void dg_training_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dg_training.SelectedRows[0].Cells[0].Value + string.Empty;
            tb_type.Text = dg_training.SelectedRows[0].Cells[1].Value + string.Empty;
            tb_name.Text = dg_training.SelectedRows[0].Cells[2].Value + string.Empty;
            date_date.Text = dg_training.SelectedRows[0].Cells[3].Value + string.Empty;
            tb_place.Text = dg_training.SelectedRows[0].Cells[4].Value + string.Empty;
            tb_rating.Text = dg_training.SelectedRows[0].Cells[5].Value + string.Empty;
            tb_license.Text = dg_training.SelectedRows[0].Cells[6].Value + string.Empty;
            tb_provider.Text = dg_training.SelectedRows[0].Cells[7].Value + string.Empty;

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
                    cmd.CommandText = @"INSERT INTO Emp_Training (Training_Type, Training_Name, Date_Attended, Training_Place, Rating, License_no, Provider, Emp_ID) VALUES (@type, @name, @date, @place, @rating, @license, @provider, @emp)";
                    cmd.Parameters.AddWithValue("@type", tb_type.Text);
                    cmd.Parameters.AddWithValue("@name", tb_name.Text);
                    cmd.Parameters.AddWithValue("@date", date_date.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@place", tb_place.Text);
                    cmd.Parameters.AddWithValue("@rating", tb_rating.Text);
                    cmd.Parameters.AddWithValue("@license", tb_license.Text);
                    cmd.Parameters.AddWithValue("@provider", tb_provider.Text);
                    cmd.Parameters.AddWithValue("@emp", empsystemid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loadtraining();
                    audittrail("Training Added");
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete records from database?", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from Emp_Training where ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loadtraining();
                    audittrail("Training deleted");
                    MessageBox.Show("Record deleted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }
            }
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
        }
    }
}
