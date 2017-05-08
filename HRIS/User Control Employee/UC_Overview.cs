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
    public partial class UC_Overview : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        public UC_Overview()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }
        

        private void UC_Overview_Load(object sender, EventArgs e)
        {
            gettempid();
            loaddepartment();
            setTextboxes();
            
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

                throw;
            }
        }

        private void setTextboxes()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Overview where ID = " +empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_empid.Text = ds.Tables[0].Rows[0]["Emp_ID"].ToString();
                        tb_address.Text = ds.Tables[0].Rows[0]["Current_Address"].ToString();
                        tb_age.Text = ds.Tables[0].Rows[0]["Emp_Age"].ToString();
                        tb_cell.Text = ds.Tables[0].Rows[0]["Cellphone"].ToString();
                        tb_citizenship.Text = ds.Tables[0].Rows[0]["Citizenship"].ToString();
                        tb_contactaddress.Text = ds.Tables[0].Rows[0]["Contact_Address"].ToString();
                        tb_contactname.Text = ds.Tables[0].Rows[0]["Contact_Name"].ToString();
                        tb_contactnumber.Text = ds.Tables[0].Rows[0]["Contact_Number"].ToString();
                        tb_dept.Text = ds.Tables[0].Rows[0]["Emp_Dept"].ToString();
                        tb_email.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                        tb_fname.Text = ds.Tables[0].Rows[0]["First_Name"].ToString();
                        tb_lname.Text = ds.Tables[0].Rows[0]["Last_Name"].ToString();
                        tb_mname.Text = ds.Tables[0].Rows[0]["Mid_Name"].ToString();
                        tb_pagibig.Text = ds.Tables[0].Rows[0]["Pagibig"].ToString();
                        tb_Philhealth.Text = ds.Tables[0].Rows[0]["Philhealth"].ToString();
                        tb_position.Text = ds.Tables[0].Rows[0]["Emp_Position"].ToString();
                        tb_religion.Text = ds.Tables[0].Rows[0]["Religion"].ToString();
                        tb_civil.Text = ds.Tables[0].Rows[0]["Civil_Status"].ToString();
                        tb_sname.Text = ds.Tables[0].Rows[0]["Suffix_Name"].ToString();
                        tb_SSS.Text = ds.Tables[0].Rows[0]["SSS"].ToString();
                        tb_supervisor.Text = ds.Tables[0].Rows[0]["Supervisor"].ToString();
                        tb_telephone.Text = ds.Tables[0].Rows[0]["Telephone"].ToString();
                        tb_TIN.Text = ds.Tables[0].Rows[0]["TIN"].ToString();
                        tb_valucare.Text = ds.Tables[0].Rows[0]["Valucare"].ToString();
                        tb_zipcode.Text = ds.Tables[0].Rows[0]["Zipcode"].ToString();
                        cb_empstatus.Text = ds.Tables[0].Rows[0]["Emp_Status"].ToString();
                        cb_gender.Text = ds.Tables[0].Rows[0]["Gender"].ToString();
                        date_birth.Text = ds.Tables[0].Rows[0]["Birthdate"].ToString();
                        date_contract.Text = ds.Tables[0].Rows[0]["Contract_Exp"].ToString();
                        date_hired.Text = ds.Tables[0].Rows[0]["Date_Hired"].ToString();
                        pic_id.ImageLocation = ds.Tables[0].Rows[0]["ID_path"].ToString();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Update records to database?", "ADD", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE Emp_Overview set Emp_ID=@empid, Last_Name= StrConv([@lastname], 3), Mid_Name=StrConv([@midname], 3), Suffix_Name=@suffixname, First_Name=StrConv([@firstname], 3), Emp_Status=@empstatus, Date_Hired=@datehired, Contract_Exp=@contractexp, Emp_Position=@empposition, Emp_Dept=@empdept, Supervisor=@supervisor, Zipcode=@zipcode, Current_Address=@currentaddress, Gender=@gender, Civil_Status=@civilstatus, Citizenship=@citizenship, Religion=@religion, Emp_Age=@empage, Birthdate=@birthdate, Telephone=@telephone, Cellphone=@cellphone, Email=@email, Contact_Name=@contactname, Contact_Number=@contactnumber, Contact_Address=@contactaddress, TIN=@tin, SSS=@sss, Valucare=@valucare, Pagibig=@pagibig, Philhealth=@philhealth where ID=@id";
                    cmd.Parameters.AddWithValue("@empid", tb_empid.Text);
                    cmd.Parameters.AddWithValue("@lastname", tb_lname.Text);
                    cmd.Parameters.AddWithValue("@midname", tb_mname.Text);
                    cmd.Parameters.AddWithValue("@suffixname", tb_sname.Text);
                    cmd.Parameters.AddWithValue("@firstname", tb_fname.Text);
                    cmd.Parameters.AddWithValue("@empstatus", cb_empstatus.Text);
                    cmd.Parameters.AddWithValue("@datehired", date_hired.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@contractexp", date_contract.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@empposition", tb_position.Text);
                    cmd.Parameters.AddWithValue("@empdept", tb_dept.Text);
                    cmd.Parameters.AddWithValue("@supervisor", tb_supervisor.Text);
                    cmd.Parameters.AddWithValue("@zipcode", tb_zipcode.Text);
                    cmd.Parameters.AddWithValue("@currentaddress", tb_address.Text);
                    cmd.Parameters.AddWithValue("@gender", cb_gender.Text);
                    cmd.Parameters.AddWithValue("@civilstatus", tb_civil.Text);
                    cmd.Parameters.AddWithValue("@citizenship", tb_citizenship.Text);
                    cmd.Parameters.AddWithValue("@religion", tb_religion.Text);
                    cmd.Parameters.AddWithValue("@empage", tb_age.Text);
                    cmd.Parameters.AddWithValue("@birthdate", date_birth.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@telephone", tb_telephone.Text);
                    cmd.Parameters.AddWithValue("@cellphone", tb_cell.Text);
                    cmd.Parameters.AddWithValue("@email", tb_email.Text);
                    cmd.Parameters.AddWithValue("@contactname", tb_contactname.Text);
                    cmd.Parameters.AddWithValue("@contactnumber", tb_contactnumber.Text);
                    cmd.Parameters.AddWithValue("@contactaddress", tb_contactaddress.Text);
                    cmd.Parameters.AddWithValue("@tin", tb_TIN.Text);
                    cmd.Parameters.AddWithValue("@sss", tb_SSS.Text);
                    cmd.Parameters.AddWithValue("@valucare", tb_valucare.Text);
                    cmd.Parameters.AddWithValue("@pagibig",  tb_pagibig.Text);
                    cmd.Parameters.AddWithValue("@philhealth", tb_Philhealth.Text);
                    cmd.Parameters.AddWithValue("@id", empsystemid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    setTextboxes();
                    MessageBox.Show("Record updated successfully");
                    audittrail("Updated Employee Information No. " + tb_empid.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }
            }
        }


        private void date_birth_ValueChanged(object sender, EventArgs e)
        {
            var datetoday = DateTime.UtcNow;
            
            var age = datetoday.Year - date_birth.Value.Year;
            tb_age.Text = age.ToString();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            o.ShowDialog();
            string imagepath = o.FileName;
            if (imagepath != "")
            {
                DialogResult yesno = MessageBox.Show("Upload new image?", "UPLOAD", MessageBoxButtons.YesNoCancel);
                if (yesno == DialogResult.Yes)
                {
                    try
                    {
                        myconn.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"UPDATE Emp_Overview set ID_path=@idpath where ID=@id";
                        cmd.Parameters.AddWithValue("@idpath", imagepath);
                        cmd.Parameters.AddWithValue("@id", empsystemid);
                        cmd.Connection = myconn;
                        cmd.ExecuteNonQuery();
                        myconn.Close();
                        setTextboxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        myconn.Close();
                    }
                }
            }
        }

        private void loaddepartment()
        {
            try
            {
                string sqlstring = "SELECT department from Maint_Dept";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        tb_dept.DisplayMember = "department";
                        tb_dept.ValueMember = "department";
                        tb_dept.DataSource = ds.Tables[0];

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tb_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlstring = "SELECT supervisor from Maint_Dept where department = '" + tb_dept.Text + "'";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_supervisor.Text = ds.Tables[0].Rows[0]["supervisor"].ToString();
                        
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cb_empstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_empstatus.SelectedIndex == 1)
                date_contract.Enabled = false;
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
        }
    }
}
