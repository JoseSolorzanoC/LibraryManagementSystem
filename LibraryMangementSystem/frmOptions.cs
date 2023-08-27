using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmFine_Load(object sender, EventArgs e)
        {
       
        
            txtFine.Value = MainForm.dbsettings.dailyFine;
            txtDaysToIssue.Value = MainForm.dbsettings.daysToIssue;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
          
            

           MainForm.dbsettings.dailyFine =Convert.ToInt32(txtFine.Value);
            MainForm.dbsettings.daysToIssue =Convert.ToInt32(txtDaysToIssue.Value);
           
            this.Close();
      

            //integer check
        }

        
    }
}
