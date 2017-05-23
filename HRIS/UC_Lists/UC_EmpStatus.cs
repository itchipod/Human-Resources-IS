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
    public partial class UC_EmpStatus : UserControl
    {
        private OleDbConnection myconn;
        string status = "Contractual";
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public UC_EmpStatus()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_EmpStatus_Load(object sender, EventArgs e)
        {
            
            loaddb();
            cb_status.SelectedIndex = 0;
        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT Emp_ID, Last_Name, Mid_Name, Suffix_Name, First_Name, Emp_Status, Date_Hired, Contract_Exp, Emp_Position, Emp_Dept, Supervisor from Emp_Overview";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        
                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Last Name";
                        dataGridView1.Columns[2].HeaderText = "Middle Name";
                        dataGridView1.Columns[3].HeaderText = "Suffix";
                        dataGridView1.Columns[4].HeaderText = "First Name";
                        dataGridView1.Columns[5].HeaderText = "Employee Status";
                        dataGridView1.Columns[6].HeaderText = "Date Hired";
                        dataGridView1.Columns[7].HeaderText = "Contract Expiration"; //contract expiration
                        dataGridView1.Columns[8].HeaderText = "Position";
                        dataGridView1.Columns[9].HeaderText = "Department";
                        
                       

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.SelectedIndex == 0)
                status = "Contractual";
            else if (cb_status.SelectedIndex == 1)
                status = "Trainee";
            else if (cb_status.SelectedIndex == 2)
                status = "Permanent";
            //MessageBox.Show(status);
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Emp_Status LIKE '%{0}%'", status);
            int count = dataGridView1.Rows.Count;
            lbl_total.Text = count.ToString();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
    }
}
