using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace LibraryManagementSystem
{
    public partial class frmExtendDueDate : Form
    {
        string bid,mid;
        DateTime ddinit;
        public string returndate {get;set;} 
        public frmExtendDueDate(DateTime dd,string b,string m)
        {
            InitializeComponent();
            datedd.Value = dd;
            ddinit = dd;
            bid = b;
            mid = m;
           // MessageBox.Show(dd.ToString());
        }

        private void frmExtendDueDate_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(numericUpDown1.Value);
            DateTime dt = ddinit;
            dt = dt.AddDays(d);
            datedd.Value = dt;

          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteCommand cmd = new SQLiteCommand(MainForm.con);
                string cmdtext = string.Format("UPDATE IssueDetails SET DueDate='{0}' WHERE BookID={1} AND MemberID='{2}' ;", datedd.Text,bid,mid);
                cmd.CommandText = cmdtext;
                cmd.ExecuteNonQuery();
                returndate = datedd.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        

        }

        private void dateIDdd_Enter(object sender, EventArgs e)
        {
        }

        private void datedd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
