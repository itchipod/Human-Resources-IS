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

namespace HRIS.UC_Lists
{
    public partial class UC_Birthday : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string datetoday; 
        string month;   
        public UC_Birthday()
        {
            InitializeComponent();
        }

        private void UC_Birthday_Load(object sender, EventArgs e)
        {
            datetoday = DateTime.UtcNow.Month.ToString();
            loaddb();
            string month = DateTime.Now.ToString("MMMM");
            //MessageBox.Show(datetoday);
            label2.Text = month;
            
            
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT Emp_ID, (First_Name + ' ' + Last_Name) AS NAME, Birthdate from Emp_Overview where MONTH(Birthdate) = "+datetoday;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];

                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Name";
                        dataGridView1.Columns[2].HeaderText = "Birthday";
                        month = dataGridView1.Columns[2].ToString();



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void getmonth()
        {
            

        }

        private void cb_birth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("");
        }
    }
}
