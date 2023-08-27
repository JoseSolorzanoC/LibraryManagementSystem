using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Office;
using System.IO;
using System.Diagnostics;
namespace LibraryManagementSystem
{
    public partial class frmExport : Form
    {
        
        string cur;
        
        public frmExport()
        {
            InitializeComponent();
            cur = MainForm.datafolder + @"\Excel";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
        SQLiteConnection sqlCon=MainForm.con;
            string tabname=comboTablename.Text;
        string qry = "SELECT * from " +tabname ;
 SQLiteDataAdapter da = new SQLiteDataAdapter(qry, sqlCon);
 System.Data.DataTable dtMainSQLData = new System.Data.DataTable();
 da.Fill(dtMainSQLData);
 DataColumnCollection dcCollection = dtMainSQLData.Columns;
    // Export Data into EXCEL Sheet
// Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new                                            
 //Microsoft.Office.Interop.Excel.ApplicationClass();

 Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application() ;


    ExcelApp.Application.Workbooks.Add(Type.Missing);
    // ExcelApp.Cells.CopyFromRecordset(objRS);
    for (int i = 1; i < dtMainSQLData.Rows.Count + 2; i++)
    {
        for (int j = 1; j < dtMainSQLData.Columns.Count + 1; j++)
        {
            if (i == 1)
            {
                ExcelApp.Cells[i, j] = dcCollection[j - 1].ToString();
            }
            else
                ExcelApp.Cells[i, j] = dtMainSQLData.Rows[i - 2][j - 1].ToString();
            
        }
    }

    
    //ExcelApp.ActiveWorkbook.SaveCopyAs("C:\\Users\\arun\\Desktop\\test.xls");

    
     
            string fileName=tabname+".xlsx";
    string destination = Path.Combine(cur, fileName);

   ExcelApp.ActiveWorkbook.SaveCopyAs(destination);
    ExcelApp.ActiveWorkbook.Saved = true;
  
    lblStatus.Text = "File Saved as " + destination;
    ExcelApp.Quit();}

        private void frmExport_Load(object sender, EventArgs e)
        {
            comboTablename.SelectedIndex = 0;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(cur);
        }
        }

    }

