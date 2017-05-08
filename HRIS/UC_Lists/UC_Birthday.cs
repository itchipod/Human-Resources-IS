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
                        dataGridView1.Columns[2].DefaultCellStyle.Format = "MM/dd";
                        dataGridView1.Columns[2].ValueType = typeof(DateTime);
                        
                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Name";
                        dataGridView1.Columns[2].HeaderText = "Birthday";
                        //month = dataGridView1.Columns[2].ToString();
                        this.dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Ascending);


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

        private void button1_Click(object sender, EventArgs e)
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
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
    }
}
