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
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Check if username already exist", "ERROR");
                        myconn.Close();
                    }
                }

            }
        }
    }
}
