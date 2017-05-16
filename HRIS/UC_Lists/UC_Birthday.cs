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
using Novacode;
using System.Diagnostics;

namespace HRIS.UC_Lists
{
    public partial class UC_Birthday : UserControl
    {
        //private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string datetoday;
        string[] birthdays;
        //string month;   
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
            //MessageBox.Show(dataGridView1.Rows[0].Cells[2].Value.ToString());

        }

        private void loaddb()
        {
            try
            {
                string sqlstring = "SELECT Emp_ID, (First_Name + ' ' + Last_Name) AS NAME, Birthdate from Emp_Overview where Emp_Status <> 'Inactive' AND MONTH(Birthdate) = " +datetoday + " ORDER BY DAY(Birthdate)";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        
                        dataGridView1.Columns[2].DefaultCellStyle.Format = "dd";
                        dataGridView1.Columns[2].ValueType = typeof(DateTime);
                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Name";
                        dataGridView1.Columns[2].HeaderText = "Birthday";
                        
                        //month = dataGridView1.Columns[2].ToString();
                       // this.dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Ascending);


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
            birthdays = new string[dataGridView1.Rows.Count];
            string birth; string name;
            for(int o=0;o<dataGridView1.Rows.Count;o++)
            {
                name = dataGridView1.Rows[o].Cells[1].Value.ToString();
                birth = dataGridView1.Rows[o].Cells[2].Value.ToString();
                
                birthdays[o] = name + "- " + birth;
            }
            CreateSampleDocument();
        }

       

        public void CreateSampleDocument()
        {
            // Modify to suit your machine:
            string fileName = @"C:\Users\Public\Documents\Birthdays.docx";

            // Create a document in memory:
            var doc = DocX.Create(fileName);

            // Insert a paragrpah:
            doc.InsertParagraph(string.Join(" \n", birthdays));

            // Save to the output directory:
            doc.Save();

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
