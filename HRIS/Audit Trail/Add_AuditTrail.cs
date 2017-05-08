using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace HRIS.Audit_Trail
{
    class Add_AuditTrail
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        DateTime datetoday;
        string username;
        public Add_AuditTrail()
        {
            //myconn = new OleDbConnection(connstring);
        }
        public void add_log(string activity_log)
        {
            
            myconn = new OleDbConnection(connstring);
            getusername();
            myconn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO Audit_Trail (Date_Log, Username, Activity) VALUES (@date, @username, @activity)";
            cmd.Parameters.AddWithValue("@date", DateTime.UtcNow.ToString());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@activity", activity_log);
            cmd.Connection = myconn;
            cmd.ExecuteNonQuery();
            myconn.Close();
            
            
        }

        private void getusername()
        {
            string sqlstring = "SELECT username from Users_UserLogged";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    username = ds.Tables[0].Rows[0]["username"].ToString();

                }
            }
        }
    }
}
