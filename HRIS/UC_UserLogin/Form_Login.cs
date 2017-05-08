using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRIS.UC_UserLogin
{
    public partial class Form_Login : Form
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string type;
        public Form_Login()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            matchData();
        }

        private void Form_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                matchData();
            }
        }

        private void matchData()
        {
            string sqlstring = "SELECT * from Users_Log where Username LIKE '" + tb_username.Text + "' AND User_Password LIKE '" + tb_password.Text + "'";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();

                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        type = ds.Tables[0].Rows[0]["User_Type"].ToString();
                        User_Logged();
                        this.Hide();
                        Form_Main f = new Form_Main();
                        f.Show();

                    }
                    else
                    {
                        MessageBox.Show("Username or Password not found");
                    }

                }
            }
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                matchData();
            }
        }

        private void User_Logged()
        {

            myconn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE Users_UserLogged set username=@name, user_type=@type where ID=1";
            cmd.Parameters.AddWithValue("@name", tb_username.Text);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Connection = myconn;
            cmd.ExecuteNonQuery();
            myconn.Close();
        }
    }
}
