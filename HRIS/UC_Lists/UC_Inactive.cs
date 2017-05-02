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
    public partial class UC_Inactive : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string selectedempid;
        public UC_Inactive()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Inactive_Load(object sender, EventArgs e)
        {
            loaddb();
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT * from List_InactiveEmp";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "ID";
                        dataGridView1.Columns[2].HeaderText = "Last Name";
                        dataGridView1.Columns[3].HeaderText = "Middle Name";
                        dataGridView1.Columns[4].HeaderText = "Suffix";
                        dataGridView1.Columns[5].HeaderText = "First Name";
                        dataGridView1.Columns[6].HeaderText = "Date Hired";
                        dataGridView1.Columns[7].HeaderText = "Date Remove";
                        dataGridView1.Columns[8].HeaderText = "Position";
                        dataGridView1.Columns[9].HeaderText = "Reason for Leaving";
                        dataGridView1.Columns[10].Visible = false; //system id

                    }
                }
            }
            catch (Exception)
            {


            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete Record Completely", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from List_InactiveEmp where SysEmp_ID=@id";
                    cmd.Parameters.AddWithValue("@id", selectedempid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    
                    deleteoverview();
                    MessageBox.Show("Record deleted successfully");
                    loaddb();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                myconn.Close();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedempid = dataGridView1.SelectedRows[0].Cells[10].Value + string.Empty;
            //MessageBox.Show(selectedempid);
        }

        private void deleteoverview()
        {
           
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from Emp_Overview where ID=@id";
                    cmd.Parameters.AddWithValue("@id", selectedempid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    loaddb();
                    
                }
                catch (Exception)
                {

                }
                myconn.Close();
            
        }
    }
}
