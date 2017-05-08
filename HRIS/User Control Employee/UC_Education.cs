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

namespace HRIS.User_Control_Employee
{
    public partial class UC_Education : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        string commandtext;
        string imagepath;
        bool forinsert=false;
        public UC_Education()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void UC_Education_Load(object sender, EventArgs e)
        {
            gettempid();
            cb_level.SelectedIndex = 0;
        }

        private void cb_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleartb();
            forinsert = false;
            if (cb_level.SelectedIndex == 0)
            {
                loadelementary();
                if (forinsert == true)
                    commandtext = @"INSERT INTO Emp_Elem (Elem_Name, Elem_Degree, Elem_Honor, Elem_Address, Elem_Diploma, Emp_ID) VALUES (@name, @degree, @honor, @address, @diploma, @empid)";
                else
                    commandtext = @"UPDATE Emp_Elem SET Elem_Name=@name, Elem_Degree=@degree, Elem_Honor=@honor, Elem_Address=@address, Elem_Diploma=@diploma where Emp_ID= " + empsystemid; 

            }
            else if (cb_level.SelectedIndex == 1)
            {
                loadsecondary();
                if (forinsert == true)
                    commandtext = @"INSERT INTO Emp_Secondary (HS_Name, HS_Degree, HS_Honor, HS_Address, HS_Diploma, Emp_ID) VALUES (@name, @degree, @honor, @address, @diploma, @empid)";
                else
                    commandtext = @"UPDATE Emp_Secondary SET HS_Name=@name, HS_Degree=@degree, HS_Honor=@honor, HS_Address=@address, HS_Diploma=@diploma where Emp_ID= " + empsystemid;

            }
            else if (cb_level.SelectedIndex == 2)
            {
                loadvoc();
                if (forinsert == true)
                    commandtext = @"INSERT INTO Emp_Voc (Voc_Name, Voc_Degree, Voc_Honor, Voc_Address, Voc_Diploma, Emp_ID) VALUES (@name, @degree, @honor, @address, @diploma, @empid)";
                else
                    commandtext = @"UPDATE Emp_Voc SET Voc_Name=@name, Voc_Degree=@degree, Voc_Honor=@honor, Voc_Address=@address, Voc_Diploma=@diploma where Emp_ID= " + empsystemid;

            }
            else if (cb_level.SelectedIndex == 3)
            {
                loadcollege();
                if (forinsert == true)
                    commandtext = @"INSERT INTO Emp_College (Coll_Name, Coll_Degree, Coll_Honor, Coll_Address, Coll_Diploma, Emp_ID) VALUES (@name, @degree, @honor, @address, @diploma, @empid)";
                else
                    commandtext = @"UPDATE Emp_College SET Coll_Name=@name, Coll_Degree=@degree, Coll_Honor=@honor, Coll_Address=@address, Coll_Diploma=@diploma where Emp_ID= " + empsystemid;

            }
            else if (cb_level.SelectedIndex == 4)
            {
                loadgrad();
                if (forinsert == true)
                    commandtext = @"INSERT INTO Emp_Graduate (Grad_Name, Grad_Degree, Grad_Honor, Grad_Address, Grad_Diploma, Emp_ID) VALUES (@name, @degree, @honor, @address, @diploma, @empid)";
                else
                    commandtext = @"UPDATE Emp_Graduate SET Grad_Name=@name, Grad_Degree=@degree, Grad_Honor=@honor, Grad_Address=@address, Grad_Diploma=@diploma where Emp_ID= " + empsystemid;

            }
            else if (cb_level.SelectedIndex == 5)
            {
                loadpost();
                if (forinsert == true)
                    commandtext = @"INSERT INTO Emp_PostGrad (Post_Name, Post_Degree, Post_Honor, Post_Address, Post_Diploma, Emp_ID) VALUES (@name, @degree, @honor, @address, @diploma, @empid)";
                else
                    commandtext = @"UPDATE Emp_PostGrad SET Post_Name=@name, Post_Degree=@degree, Post_Honor=@honor, Post_Address=@address, Post_Diploma=@diploma where Emp_ID= " + empsystemid;

            }

            imagepath = tb_diploma.Text;
        }

        private void loadelementary()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Elem where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_address.Text = ds.Tables[0].Rows[0]["Elem_Address"].ToString();
                        tb_degree.Text = ds.Tables[0].Rows[0]["Elem_Degree"].ToString();
                        tb_honor.Text = ds.Tables[0].Rows[0]["Elem_Honor"].ToString();
                        tb_schoolname.Text = ds.Tables[0].Rows[0]["Elem_Name"].ToString();
                        tb_diploma.Text = ds.Tables[0].Rows[0]["Elem_Diploma"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                forinsert = true;
                //throw;
            }
        }

        private void loadsecondary()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Secondary where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_address.Text = ds.Tables[0].Rows[0]["HS_Address"].ToString();
                        tb_degree.Text = ds.Tables[0].Rows[0]["HS_Degree"].ToString();
                        tb_honor.Text = ds.Tables[0].Rows[0]["HS_Honor"].ToString();
                        tb_schoolname.Text = ds.Tables[0].Rows[0]["HS_Name"].ToString();
                        tb_diploma.Text = ds.Tables[0].Rows[0]["HS_Diploma"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                forinsert = true;
                //throw;
            }
        }

        private void loadvoc()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Voc where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_address.Text = ds.Tables[0].Rows[0]["Voc_Address"].ToString();
                        tb_degree.Text = ds.Tables[0].Rows[0]["Voc_Degree"].ToString();
                        tb_honor.Text = ds.Tables[0].Rows[0]["Voc_Honor"].ToString();
                        tb_schoolname.Text = ds.Tables[0].Rows[0]["Voc_Name"].ToString();
                        tb_diploma.Text = ds.Tables[0].Rows[0]["Voc_Diploma"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                forinsert = true;
                //throw;
            }
        }

        private void loadcollege()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_College where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_address.Text = ds.Tables[0].Rows[0]["Coll_Address"].ToString();
                        tb_degree.Text = ds.Tables[0].Rows[0]["Coll_Degree"].ToString();
                        tb_honor.Text = ds.Tables[0].Rows[0]["Coll_Honor"].ToString();
                        tb_schoolname.Text = ds.Tables[0].Rows[0]["Coll_Name"].ToString();
                        tb_diploma.Text = ds.Tables[0].Rows[0]["Coll_Diploma"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                forinsert = true;
                //throw;
            }
        }

        private void loadgrad()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Graduate where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_address.Text = ds.Tables[0].Rows[0]["Grad_Address"].ToString();
                        tb_degree.Text = ds.Tables[0].Rows[0]["Grad_Degree"].ToString();
                        tb_honor.Text = ds.Tables[0].Rows[0]["Grad_Honor"].ToString();
                        tb_schoolname.Text = ds.Tables[0].Rows[0]["Grad_Name"].ToString();
                        tb_diploma.Text = ds.Tables[0].Rows[0]["Grad_Diploma"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                forinsert = true;
                //throw;
            }
        }

        private void loadpost()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_PostGrad where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_address.Text = ds.Tables[0].Rows[0]["Post_Address"].ToString();
                        tb_degree.Text = ds.Tables[0].Rows[0]["Post_Degree"].ToString();
                        tb_honor.Text = ds.Tables[0].Rows[0]["Post_Honor"].ToString();
                        tb_schoolname.Text = ds.Tables[0].Rows[0]["Post_Name"].ToString();
                        tb_diploma.Text = ds.Tables[0].Rows[0]["Post_Diploma"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                forinsert = true;
                //throw;
            }
        }

        private void gettempid()
        {
            try
            {
                string sqlstring = "SELECT TempEmpID from Temp_EmpID where ID=1";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        empsystemid = ds.Tables[0].Rows[0]["TempEmpID"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Update records to database?", "UPDATE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = commandtext;
                    cmd.Parameters.AddWithValue("@name", tb_schoolname.Text);
                    cmd.Parameters.AddWithValue("@degree", tb_degree.Text);
                    cmd.Parameters.AddWithValue("@honor", tb_honor.Text);
                    cmd.Parameters.AddWithValue("@address", tb_address.Text);
                    cmd.Parameters.AddWithValue("@diploma", tb_diploma.Text);
                    cmd.Parameters.AddWithValue("@empid", empsystemid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    audittrail("Added Education Information");
                    cb_level_SelectedIndexChanged(this, new EventArgs());
                    MessageBox.Show("Record added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }


            }
        }

        private void cleartb()
        {
            tb_address.Clear(); tb_degree.Clear(); tb_honor.Clear(); tb_schoolname.Clear();
        }

        private void btn_uploaddiploma_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            //o.Filter = "JPG Files (*.jpg) | *.jpg | PNG Files(*.png) | *.png | JPEG Files(*.jpeg) | *.jpeg";
            o.ShowDialog();
            imagepath = o.FileName;
            if (imagepath != "")
            {
                DialogResult yesno = MessageBox.Show("Upload new file?", "UPLOAD", MessageBoxButtons.YesNoCancel);
                if (yesno == DialogResult.Yes)
                {
                    tb_diploma.Text = imagepath;
                }
            }
        }

        private void btn_viewdiploma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(imagepath);
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
        }
    }
}
