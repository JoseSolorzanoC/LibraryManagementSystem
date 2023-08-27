using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace LibraryManagementSystem
{
    public partial class frmSummary : Form
    {
        string memid;
        public frmSummary(string name,string id)
        {
            InitializeComponent();
            txtmemid.Text = id;
            txtName.Text = name;
            memid = id;
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            
            SQLiteCommand cmd = new SQLiteCommand(MainForm.con);
            SQLiteDataReader dr;

            cmd.CommandText = string.Format("SELECT * from IssueDetails where MemberID={0} ORDER BY IssueDate ", memid);
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

               datagridPending.DataSource = dt;

           

            }
            else
            {
                

             datagridPending.DataSource = null;
            }
            dr.Close();

            cmd.CommandText = string.Format("SELECT * from SubmittedBooks where MemberID={0} ORDER BY IssueDate desc ", memid);
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

               datagridReturned.DataSource = dt;



            }
            else
            {


               datagridReturned.DataSource = null;
            }
            dr.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtmemid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmitbook_Click(object sender, EventArgs e)
        {
            
        }
    }
}
