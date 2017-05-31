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
    public partial class UC_Family : UserControl
    {
        private OleDbConnection myconn;
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        string empsystemid;
        string updateoradd;
        string selecteddepid;
        public UC_Family()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Dependent f = new Form_Dependent();
            if (Application.OpenForms[f.Name] == null)
                f.Show();
            else
               Application.OpenForms[f.Name].Activate();
            
            

        }

        private void UC_Family_Load(object sender, EventArgs e)
        {
            cb_isdependent.SelectedIndex = 1;
            gettempid();
            setspouse();
            getdependents();
            
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

        private void setspouse()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Spouse where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        tb_address.Text = ds.Tables[0].Rows[0]["Spouse_Address"].ToString();
                        tb_age.Text = ds.Tables[0].Rows[0]["Age"].ToString();
                        tb_degree.Text = ds.Tables[0].Rows[0]["Degree"].ToString();
                        tb_educational.Text = ds.Tables[0].Rows[0]["Educ_Att"].ToString();
                        tb_employer.Text = ds.Tables[0].Rows[0]["Employer"].ToString();
                        tb_occupation.Text = ds.Tables[0].Rows[0]["Occupation"].ToString();
                        tb_position.Text = ds.Tables[0].Rows[0]["Spouse_Position"].ToString();
                        tb_spousename.Text = ds.Tables[0].Rows[0]["Spouse_Name"].ToString();
                        tb_tel.Text = ds.Tables[0].Rows[0]["Telno"].ToString();
                        cb_isdependent.Text = ds.Tables[0].Rows[0]["Is_Dependent"].ToString();
                        date_birth.Text = ds.Tables[0].Rows[0]["Birthdate"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                updateoradd = "A";
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(updateoradd == "A")
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Emp_Spouse(Spouse_Name, Age, Birthdate, Educ_Att, Degree, Occupation, Spouse_Position, Employer, Spouse_Address, Telno, Is_Dependent, Emp_ID) VALUES (@spo, @age, @bir, @edu, @deg, @occ, @pos, @emp, @add, @tel, @isd, @empid)";
                    cmd.Parameters.AddWithValue("@spo", tb_spousename.Text);
                    cmd.Parameters.AddWithValue("@age", tb_age.Text);
                    cmd.Parameters.AddWithValue("@bir", date_birth.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@edu", tb_educational.Text);
                    cmd.Parameters.AddWithValue("@deg", tb_degree.Text);
                    cmd.Parameters.AddWithValue("@occ", tb_occupation.Text);
                    cmd.Parameters.AddWithValue("@pos", tb_position.Text);
                    cmd.Parameters.AddWithValue("@emp", tb_employer.Text);
                    cmd.Parameters.AddWithValue("@add", tb_address.Text);
                    cmd.Parameters.AddWithValue("@tel", tb_tel.Text);
                    cmd.Parameters.AddWithValue("@isd", cb_isdependent.Text);
                    cmd.Parameters.AddWithValue("@empid", empsystemid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    //if (cb_isdependent.SelectedIndex == 0)
                    //    addspousetodependent();
                    
                        
                    MessageBox.Show("Record Added Successfully");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                myconn.Close();
            }

            else
            {
                DialogResult yesno = MessageBox.Show("Update Record?", "UPDATE", MessageBoxButtons.YesNoCancel);
                if(yesno == DialogResult.Yes)
                {
                    try
                    {
                        myconn.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"UPDATE Emp_Spouse SET Spouse_Name=@spo, Age=@age, Birthdate=@bir, Educ_Att=@edu, Degree=@deg, Occupation=@occ, Spouse_Position=@pos, Employer=@emp, Spouse_Address=@add, Telno=@tel, Is_Dependent=@isd where Emp_ID=@id";
                        cmd.Parameters.AddWithValue("@spo", tb_spousename.Text);
                        cmd.Parameters.AddWithValue("@age", tb_age.Text);
                        cmd.Parameters.AddWithValue("@bir", date_birth.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@edu", tb_educational.Text);
                        cmd.Parameters.AddWithValue("@deg", tb_degree.Text);
                        cmd.Parameters.AddWithValue("@occ", tb_occupation.Text);
                        cmd.Parameters.AddWithValue("@pos", tb_position.Text);
                        cmd.Parameters.AddWithValue("@emp", tb_employer.Text);
                        cmd.Parameters.AddWithValue("@add", tb_address.Text);
                        cmd.Parameters.AddWithValue("@tel", tb_tel.Text);
                        cmd.Parameters.AddWithValue("@isd", cb_isdependent.Text);
                        cmd.Parameters.AddWithValue("@id", empsystemid);
                        cmd.Connection = myconn;
                        cmd.ExecuteNonQuery();
                        //if (cb_isdependent.SelectedIndex == 0)
                        //    addspousetodependent();
                        //else if (cb_isdependent.SelectedIndex == 1)
                        //    removespousefromdependent();
                        MessageBox.Show("Record Updated Successfully");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    myconn.Close();
                }
            }
            audittrail("Updated Spouse Information for " + empsystemid);

        }

        private void getdependents()
        {
            try
            {
                string sqlstring = "SELECT * from Emp_Dependent where Emp_ID = " + empsystemid;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dg_dependent.DataSource = ds.Tables[0];
                        dg_dependent.Columns[0].Visible = false;
                        dg_dependent.Columns[1].HeaderText = "Dependent Name";
                        dg_dependent.Columns[5].Visible = false;

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                
            }
        }

        private void date_birth_ValueChanged(object sender, EventArgs e)
        {
            var datetoday = DateTime.UtcNow;

            var age = datetoday.Year - date_birth.Value.Year;
            tb_age.Text = age.ToString();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Delete records from database?", "DELETE", MessageBoxButtons.YesNoCancel);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    myconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from Emp_Dependent where ID=@id";
                    cmd.Parameters.AddWithValue("@id", selecteddepid);
                    cmd.Connection = myconn;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                    audittrail("Deleted Dependent from Employee No." + empsystemid);
                    MessageBox.Show("Record deleted successfully");
                    getdependents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myconn.Close();
                }
            }
        }

        private void addspousetodependent()
        {
            try
            {
                
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Emp_Dependent(Dependent_Name, Relation, Age, Birthday, Emp_ID) VALUES (@spo, @rel, @age, @bir, @empid)";
                cmd.Parameters.AddWithValue("@spo", tb_spousename.Text);
                cmd.Parameters.AddWithValue("@rel", "Spouse");
                cmd.Parameters.AddWithValue("@age", tb_age.Text);
                cmd.Parameters.AddWithValue("@bir", date_birth.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@empid", empsystemid);

                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void removespousefromdependent()
        {
            try
            {
                myconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"DELETE from Emp_Dependent where Relation = 'Spouse' AND Emp_ID = " + empsystemid;
                
                cmd.Connection = myconn;
                cmd.ExecuteNonQuery();
                myconn.Close();

               
            }
            catch (Exception)
            {
                
            }
        }

        private void dg_dependent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selecteddepid = dg_dependent.SelectedRows[0].Cells[0].Value + string.Empty;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            getdependents();
        }

        private void audittrail(string _activity)
        {
            Audit_Trail.Add_AuditTrail a = new Audit_Trail.Add_AuditTrail();
            a.add_log(_activity);
        }
    }
}
