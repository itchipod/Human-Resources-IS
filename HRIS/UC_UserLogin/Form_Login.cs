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
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public Form_Login()
        {
            InitializeComponent();
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
            string sqlstring = "SELECT Username, User_Password from Users_Log where Username LIKE '" + tb_username.Text + "' AND User_Password LIKE '" + tb_password.Text + "'";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();

                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
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
    }
}
