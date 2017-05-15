using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Word;

namespace HRIS.User_Control
{
    public partial class UC_PerformanceAppraisalPrint : UserControl
    {
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        ApplicationClass oWordApplic = new Microsoft.Office.Interop.Word.ApplicationClass();
        private Microsoft.Office.Interop.Word.Document oDoc = new Document();
        public UC_PerformanceAppraisalPrint()
        {
            InitializeComponent();
        }

        private void UC_PerformanceAppraisal_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }

        private void loadcombobox()
        {
            string sqlstring = "SELECT ID, (Emp_ID + ' - ' + Last_Name + ', ' + First_Name + ' ' + LEFT(Mid_Name, 1) + '.') AS name from Emp_Overview where Emp_Status <> 'Inactive'";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cb_name.ValueMember = "ID";
                    cb_name.DisplayMember = "name";
                    
                    //tb_period.Text = ds.Tables[0].Rows[0][0].ToString();
                    cb_name.DataSource = ds.Tables[0];

                }
            }
        }

        private void loaddetails()
        {
            string sqlstring = "SELECT Emp_Dept, Date_Hired, Emp_Position, Supervisor, Emp_Status from Emp_Overview where ID = " + cb_name.SelectedValue.ToString();
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    tb_dep.Text = ds.Tables[0].Rows[0][0].ToString();
                    date_emp.Text = ds.Tables[0].Rows[0][1].ToString();
                    tb_designation.Text = ds.Tables[0].Rows[0][2].ToString();
                    tb_supervisor.Text = ds.Tables[0].Rows[0][3].ToString();
                    tb_status.Text = ds.Tables[0].Rows[0][4].ToString();
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //string filename = @"C:\Users\JGalve\Documents\Test.docx";

            //Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            //Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();

            //doc = word.Documents.Add(filename);
            //doc.Activate();

            //foreach (Microsoft.Office.Interop.Word.FormField field in doc.FormFields)
            //{
            //    //switch (field.Name)
            //    //{
            //    //    case "Text2":
            //    //        field.Range.Text = "1";
            //    //        break;

            //    //    default:
            //    //        break;
            //    //}
            //    field.Range.Text = "1";
            //}

            //doc.SaveAs2(@"C:\Users\JGalve\Documents\Test.docx");
            //doc.Close();
            //word.Quit();
            //System.Diagnostics.Process.Start(@"C:\Users\JGalve\Documents\Test.docx");

            Open(@"C:\Users\JGalve\Documents\Test.docx");
            foreach (Field myMergeField in oDoc.Fields)
            {
                //iTotalFields++;
                Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;

                
               
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLength = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    fieldName = fieldName.Trim();
                    
                        myMergeField.Select();
                        oWordApplic.Selection.TypeText("This Text Replaces the Field in the Template");
                    
                
            }
            SaveAs(@"C:\Users\JGalve\Documents\Test.docx"); Quit();
            MessageBox.Show("The file is successfully saved!");
        }

        private void cb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddetails();
        }

       

        public void Open(string strFileName)
        {
            object fileName = strFileName;
            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;

            oDoc = oWordApplic.Documents.Open(ref fileName, ref missing, ref readOnly,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);

            oDoc.Activate();
        }

        public void SaveAs(string strFileName)
        {
            object missing = System.Reflection.Missing.Value;
            object fileName = strFileName;

            oDoc.SaveAs(ref fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
        }

        public void Quit()
        {
            object missing = System.Reflection.Missing.Value;
            oWordApplic.Application.Quit(ref missing, ref missing, ref missing);
        }
    }
}
