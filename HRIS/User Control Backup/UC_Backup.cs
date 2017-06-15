using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HRIS.User_Control_Backup
{
    public partial class UC_Backup : UserControl
    {
        public UC_Backup()
        {
            InitializeComponent();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            DialogResult v = MessageBox.Show("Restoring will overwrite all current database. Proceed?", "Prompt", MessageBoxButtons.YesNoCancel);
            if (v == DialogResult.Yes)
            {
                OpenFileDialog o = new OpenFileDialog();
                o.ShowDialog();
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            string dbFileName = "HRIS.accdb";
            string CurrentDatabasePath = Path.Combine(Environment.CurrentDirectory, dbFileName);
            string backTimeStamp = Path.GetFileNameWithoutExtension(dbFileName) + "_" + DateTime.Now.Year.ToString("yyyy-MM-dd") + Path.GetExtension(dbFileName);
            string destFileName = backTimeStamp + dbFileName;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string PathtobackUp = fbd.SelectedPath.ToString();
                destFileName = Path.Combine(PathtobackUp, destFileName);
                File.Copy(CurrentDatabasePath, destFileName, true);
                MessageBox.Show("successful Backup! ");
                //SaveFileDialog s = new SaveFileDialog();
                //s.ShowDialog();
            }
        }
    }
}
