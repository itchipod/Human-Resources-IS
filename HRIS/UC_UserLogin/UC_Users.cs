using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRIS.UC_UserLogin
{
    public partial class UC_Users : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string isexists="0";
        string id;
        public UC_Users()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            loaddb();
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT * from Users_Log where Username";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns["ID"].Visible = false;                        
                        dataGridView1.Columns[1].HeaderText = "Username";
                        dataGridView1.Columns[2].HeaderText = "Password";               
                        dataGridView1.Columns[3].HeaderText = "User Type";
                       
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void checkifexist()
        {
            CheckUser c = new CheckUser();
            isexists = c.checkuser_add(tb_username.Text);
            MessageBox.Show(isexists);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //checkifexist();
            if(isexists == "0")
            { 
            DialogResult yesno = MessageBox.Show("Add new user to database?", "ADD", MessageBoxButtons.YesNoCancel);
                if (yesno == DialogResult.Yes)
                {
                    try
                    {
                        myconn.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"INSERT INTO Users_Log (Username, User_Password, User_Type) VALUES (@name, @password, @type)";
                        cmd.Parameters.AddWithValue("@name", tb_username.Text);
                        cmd.Parameters.AddWithValue("@password", tb_password.Text);
                        cmd.Parameters.AddWithValue("@type", cb_type.Text);
                        cmd.Connection = myconn;
                        cmd.ExecuteNonQuery();
                        myconn.Close();
                        loaddb();
                        MessageBox.Show("Record added successfully");
                        audittrail("Added new user");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Check if username already exist", "ERROR");
                        myconn.Close();
                    }
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isexists == "0")
            {
                DialogResult yesno = MessageBox.Show("Update user to database?", "UPDATE", MessageBoxButtons.YesNoCancel);
                if (yesno == DialogResult.Yes)
                {
                    try
                    {
                        myconn.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"UPDATE Users_Log SET Username=@name, User_Password=@password, User_Type=@type where ID=@id";
                        cmd.Parameters.AddWithValue("@name", tb_username.Text);
                        cmd.Parameters.AddWithValue("@password", tb_password.Text);
                        cmd.Parameters.AddWithValue("@type", cb_type.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Connection = myconn;
                        cmd.ExecuteNonQuery();
                        myconn.Close();
                        loaddb();
                        MessageBox.Show("Record updated successfully");
                        audittrail("Updated user");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Check if username already exist", "ERROR");
                        myconn.Close();
                    }
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tb_username.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tb_password.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cb_type.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete user?", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"Delete from Users_Log where ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);              
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    loaddb();
                    MessageBox.Show("Record deleted successfully");
                    audittrail("Deleted user");
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
            if (checkBox1.Checked == true)
            {
                tb_password.PasswordChar = '\0';
            }
            else
                tb_password.PasswordChar = '•';
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
        }
    }
}
