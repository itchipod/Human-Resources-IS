using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace HRIS.UC_UserLogin
{
    class CheckUser
    {
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();

        public string checkuser_add(string username)
        {
                string sqlstring = "SELECT * from Users_Log where Username="+username;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        try
                        {
                            adapter.Fill(ds);
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                               return "1";
                            }
                            else
                            return "0";
                    }
                        catch (Exception) {
                        throw;
                            }
                    }
                }
           
        }
    }
}
