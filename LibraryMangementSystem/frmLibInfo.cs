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
    public partial class frmLibInfo : Form
    {
        SQLiteConnection con = MainForm.con;

        public frmLibInfo()
        {
            InitializeComponent();
        }

        private void frmLibInfo_Load(object sender, EventArgs e)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = "select count(BookID) from BookDetails ";
            txtTotalBooks.Text= com.ExecuteScalar().ToString();

         
           com.CommandText = "select count(BookID) from IssueDetails ";
           txtIssuedBooks.Text = com.ExecuteScalar().ToString();

          
           com.CommandText = "select count(BookID) from BookDetails where Available='True' ";
           txtAvailableBooks.Text = com.ExecuteScalar().ToString();

           com.CommandText = "select count(MemberID) from MemberDetails ";
          txtTotalMembers.Text = com.ExecuteScalar().ToString();

          com.CommandText = "select sum(Price) from BookDetails ";
          txtCostBooks.Text = com.ExecuteScalar().ToString();

          com.CommandText = "select sum(Fine) from SubmittedBooks ";
          txtTotalFine.Text = com.ExecuteScalar().ToString();

          com.CommandText = "select sum(TotalFee) from PackageAccounting ";
         txtPackageFees.Text = com.ExecuteScalar().ToString();
        }
    }
}
