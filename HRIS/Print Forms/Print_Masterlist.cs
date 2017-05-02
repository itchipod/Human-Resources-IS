using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;

namespace HRIS.Print_Forms
{
    public partial class Print_Masterlist : Form
    {
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public Print_Masterlist()
        {
            InitializeComponent();
        }

        private void Print_Masterlist_Load(object sender, EventArgs e)
        {
            loaddb();
            this.reportViewer1.RefreshReport();
        }

        private void loaddb()
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
                        ReportDataSource reportDataSource = new ReportDataSource();
                        reportDataSource.Name = "ReportData";
                        reportDataSource.Value = ds;
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        //portViewer1.DataBind();
                        
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
