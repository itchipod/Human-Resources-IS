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
    public partial class UC_MaintDepartment : UserControl
    {
        private OleDbConnection myconn;
        string id;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public UC_MaintDepartment()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_MaintDepartment_Load(object sender, EventArgs e)
        {
            loadsupervisor();
            loaddepartment();
        }

        private void loaddepartment()
        {
            try
            {
                string sqlstring = "SELECT * from Maint_Dept";
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

        private void loadsupervisor()
        {
            try
            {
                string sqlstring = "SELECT (Last_Name + ', ' + First_Name) AS name from Emp_Overview";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        cb_supervisor.DataSource = ds.Tables[0];
                        cb_supervisor.DisplayMember = "name";
                        cb_supervisor.ValueMember = "name";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cb_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlstring = "SELECT ID, supervisor from Maint_Dept where department = '" + cb_dept.Text + "'";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        cb_supervisor.Text = ds.Tables[0].Rows[0]["supervisor"].ToString();
                        id = ds.Tables[0].Rows[0]["ID"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
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
                    cmd.CommandText = @"INSERT INTO Maint_Dept (department, supervisor) VALUES (@dept, @super)";
                    cmd.Parameters.AddWithValue("@dept", cb_dept.Text);
                    cmd.Parameters.AddWithValue("@super", cb_supervisor.Text);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddepartment();
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Update records to database?", "ADD", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE Maint_Dept set department=@dept, supervisor=@super where ID=@id";
                    cmd.Parameters.AddWithValue("@dept", cb_dept.Text);
                    cmd.Parameters.AddWithValue("@super", cb_supervisor.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddepartment();
                    MessageBox.Show("Record updated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete records from database?", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from Maint_Dept where ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddepartment();
                    MessageBox.Show("Record deleted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }
            }
        }
    }
}
