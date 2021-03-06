﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Novacode;
using System.Diagnostics;

namespace HRIS.UC_Lists
{
    public partial class UC_Masterlist : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public UC_Masterlist()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Masterlist_Load(object sender, EventArgs e)
        {
            loadmasterlist();
            loadcbcolumns();
            loaddepartment();
            cb_dept.Text = "ALL";
            cb_Column.SelectedIndex = 0;
            
        }

        private void loadmasterlist()
        {
         
            try
            {
                string sqlstring = "SELECT * from Emp_Overview where Emp_Status <> 'Inactive'";
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
                        dataGridView1.Columns[3].DisplayIndex = 5;
                        dataGridView1.Columns[4].HeaderText = "Suffix";
                        dataGridView1.Columns[5].HeaderText = "First Name";
                        dataGridView1.Columns[5].DisplayIndex = 3;
                        dataGridView1.Columns[6].HeaderText = "Employee Status";
                        dataGridView1.Columns[7].HeaderText = "Date Hired";
                        dataGridView1.Columns[8].Visible = false; //contract expiration
                        dataGridView1.Columns[9].HeaderText = "Position";
                        dataGridView1.Columns[10].HeaderText = "Department";
                        dataGridView1.Columns[11].Visible = false; //supervisor
                        dataGridView1.Columns[12].HeaderText = "Zipcode";
                        dataGridView1.Columns[13].HeaderText = "Current Address";
                        dataGridView1.Columns[14].HeaderText = "Gender";
                        dataGridView1.Columns[15].HeaderText = "Civil Status";
                        dataGridView1.Columns[16].HeaderText = "Citizenship";
                        dataGridView1.Columns[17].Visible = false; //religion
                        dataGridView1.Columns[18].HeaderText = "Age";
                        dataGridView1.Columns[19].HeaderText = "Birthdate";
                        dataGridView1.Columns[20].HeaderText = "Telephone";
                        dataGridView1.Columns[21].HeaderText = "Cellphone";
                        dataGridView1.Columns[22].HeaderText = "Email";
                        dataGridView1.Columns[23].Visible = false; //contact name
                        dataGridView1.Columns[24].Visible = false; //contact relationship
                        dataGridView1.Columns[25].Visible = false; //contact number
                        dataGridView1.Columns[26].Visible = false; //contact number
                        dataGridView1.Columns[27].HeaderText = "TIN";
                        dataGridView1.Columns[28].HeaderText = "SSS";
                        dataGridView1.Columns[29].HeaderText = "Valucare";
                        dataGridView1.Columns[30].HeaderText = "Pagibig";
                        dataGridView1.Columns[31].HeaderText = "Philhealth";  
                        dataGridView1.Columns[32].Visible = false; //id path
                        dataGridView1.Columns[33].HeaderText = "Payroll Type";
                        dataGridView1.Columns[34].Visible = false; //id path
                       
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void loadcbcolumns()
        {
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Visible != false)
                {
                    cb_column2.Items.Add(dataGridView1.Columns[i].Name.ToString());
                    cb_Column.Items.Add(dataGridView1.Columns[i].HeaderText.ToString());
                }
            }
        }


        private void loadmasterlistdept()
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Emp_Dept LIKE '%{0}%'", cb_dept.Text);
        }

        private void loaddepartment()
        {
            try
            {
                string sqlstring = "SELECT * from Maint_Dept";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        cb_dept.DisplayMember = "department";
                        cb_dept.ValueMember = "department";
                        cb_dept.DataSource = ds.Tables[0];
                        
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cb_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_dept.Text != "ALL")
                loadmasterlistdept();
            else
                loadmasterlist();
            int a = dataGridView1.RowCount;
            countRows();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //printDocument1.Print();
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
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            this.dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void countRows()
        {
            int a = dataGridView1.RowCount;
            lbl_total.Text = a.ToString();
        }

        private void tb_Value_TextChanged(object sender, EventArgs e)
        {
            cb_column2.SelectedIndex = cb_Column.SelectedIndex;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("" + cb_column2.Text + " LIKE '%{0}%'",  tb_Value.Text);
            countRows();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string empid2 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + string.Empty;
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE Temp_EmpID set TempEmpID=@empid where ID=@id";
                cmd.Parameters.AddWithValue("@empid", empid2);
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myconn.Close();
            }
            Form_Overview f = new Form_Overview();
            f.Show();
        }

        private void btn_numemployee_Click(object sender, EventArgs e)
        {
            string departmentName;

            string[] numberperdep;
            int count;
            try
            {
                string sqlstring = "SELECT department from Maint_Dept where department <> 'ALL'";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        numberperdep = new string[ds.Tables[0].Rows.Count];
                        for(int i=0;i<ds.Tables[0].Rows.Count;i++)
                        {

                            departmentName = ds.Tables[0].Rows[i][0].ToString();
                            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Emp_Dept LIKE '%{0}%'", departmentName);
                            count = dataGridView1.Rows.Count;

                            numberperdep[i] = departmentName + ": " + count.ToString();

                        }

                    }
                }
                
                loadmasterlist();
            }
            catch (Exception)
            {
                throw;
            }

            CreateDocument(string.Join(" \n", numberperdep));
        }

        public void CreateDocument(string count)
        {            
            string fileName = @"C:\Documents and Settings\HR\Employees per Department.docx";            
            var doc = DocX.Create(fileName);           
            doc.InsertParagraph(count);           
            doc.Save();            
            Process.Start("WINWORD.EXE", fileName);
        }
    }
    
}
