using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRIS
{
    public partial class Form_Overview : Form
    {
        public Form_Overview()
        {
            InitializeComponent();
        }

        private void Form_Overview_Load(object sender, EventArgs e)
        {
            User_Control_Employee.UC_Overview uo = new User_Control_Employee.UC_Overview();
            main_panel.Controls.Clear();
            //applytocontents();
            main_panel.Controls.Add(uo);
        }

       
    }
}
