using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRIS.Audit_Trail
{
    public partial class UC_Audit : UserControl
    {
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public UC_Audit()
        {
            InitializeComponent();
        }

        private void UC_Audit_Load(object sender, EventArgs e)
        {
            loaddb();
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT * from Audit_Trail";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns["ID"].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "Date";
                        dataGridView1.Columns[2].HeaderText = "User Logged";
                        dataGridView1.Columns[3].HeaderText = "Activity";

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date_Log = '{0}'", date_sort.Value);
        }
    }
}
