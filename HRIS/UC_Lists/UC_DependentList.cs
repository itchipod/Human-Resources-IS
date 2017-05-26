using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRIS.UC_Lists
{
    public partial class UC_DependentList : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public UC_DependentList()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_DependentList_Load(object sender, EventArgs e)
        {
            loaddb();
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT Emp_Dependent.ID, Dependent_Name, Relation, Age, Birthday, Emp_Dependent.Emp_ID, (Emp_Overview.First_Name + ' ' + Emp_Overview.Last_Name + ' ' + Emp_Overview.Suffix_Name) AS Name FROM Emp_Dependent LEFT JOIN Emp_Overview ON Emp_Dependent.Emp_ID=Emp_Overview.ID";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].Visible = false;

                        dataGridView1.Columns[1].HeaderText = "Dependent Name";
                        dataGridView1.Columns[2].HeaderText = "Relation";
                        dataGridView1.Columns[3].HeaderText = "Age";
                        
                        dataGridView1.Columns[4].HeaderText = "Birthday";
                        dataGridView1.Columns[5].Visible = false;
                        dataGridView1.Columns[6].HeaderText = "Employee Name";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
