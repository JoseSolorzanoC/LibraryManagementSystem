using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using LibraryManagementSystem;
namespace LibraryManagementSystem
{
    public partial class frmManageDatabase : Form
    {
        public string strFn;
        public frmManageDatabase()
        {
            InitializeComponent();
        }

        private void frmManageDatabase_Load(object sender, EventArgs e)
        {
            pnlDbName.Hide();
            loaddb();
            listAvailDBs.SelectedIndex = 0;           
            
            lbldefault.Text = "Default Database :\n" + MainForm.dbname;  
        }

        private void loaddb()
        {

            DirectoryInfo d = new DirectoryInfo(MainForm.datafolder);
            FileInfo[] Files = d.GetFiles("*.db");
            listAvailDBs.Items.Clear();
            foreach (FileInfo file in Files)
            {
                listAvailDBs.Items.Add(file.Name);
            }
           
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
        
        openFileDialog1.ShowDialog();
        strFn = openFileDialog1.FileName;
        if (!String.IsNullOrEmpty(strFn))
        {
           
          pnlDbName.Show();
          pnlDbName.BringToFront(); 
        }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dbname = txtDBname.Text;
            if(dbname.Contains('.'))
            {
                MessageBox.Show("Database name cannot contain dots");
                txtDBname.Clear();
                return;
            }

            string source = strFn;
         //   static string dbname=Properties.Settings.Default.defaultdb;
            string currentFolder =MainForm.datafolder ;
            string fileName = txtDBname.Text + ".db";
            string destination = Path.Combine(currentFolder, fileName);

            if (File.Exists(destination))
            {
                MessageBox.Show("The Database name already exists.Please choose a different name");
                return;
            }
        
            File.Copy(source, destination);
            
          string connstr = "Data Source="+destination+";Version=3";
        SQLiteConnection con = new SQLiteConnection(connstr);
        con.Open();
        SQLiteCommand cmd = new SQLiteCommand(con);

        double version;
        cmd.CommandText = "SELECT count(*) FROM sqlite_master WHERE type='table' AND name='Settings'";
            int setexist=Convert.ToInt32(cmd.ExecuteScalar());
           // MessageBox.Show("exists="+setexist.ToString());
            if (setexist == 0)
                version = 1.0;
            else
            {
                cmd.CommandText = "select Value from Settings where Name='version'";
                object ob = cmd.ExecuteScalar();

                string ver = Convert.ToString(ob);
                version = Convert.ToDouble(ver);
                
            }
            // MessageBox.Show("version="+version.ToString());
             if (version == 1.0)
             {
                 cmd.CommandText = @"CREATE TABLE Settings (Name TEXT PRIMARY KEY, Value TEXT);
        INSERT INTO Settings (Name, Value) VALUES ('lastView', '0');
        INSERT INTO Settings (Name, Value) VALUES ('defaultCateg', '');
        INSERT INTO Settings (Name, Value) VALUES ('usePackages', 'False');
        INSERT INTO Settings (Name, Value) VALUES ('maxBooks', '3');
        INSERT INTO Settings (Name, Value) VALUES ('defaultPkg', '');
        INSERT INTO Settings (Name, Value) VALUES ('userEnabled', 'False');
        INSERT INTO Settings (Name, Value) VALUES ('defaultUser', '');
        INSERT INTO Settings (Name, Value) VALUES ('adminFirstUse', 'True');
        INSERT INTO Settings (Name, Value) VALUES ('dailyFine', '1');
        INSERT INTO Settings (Name, Value) VALUES ('daysToIssue', '10');
        INSERT INTO Settings (Name, Value) VALUES ('languageList', 'English');
        INSERT INTO Settings (Name, Value) VALUES ('courseList', 'Unspecified');
        INSERT INTO Settings (Name, Value) VALUES ('hasDelBookDetails', 'False');
        INSERT INTO Settings (Name, Value) VALUES ('hasDelMemberDetails', 'False');
        INSERT INTO Settings (Name, Value) VALUES ('hasDelCategories', 'False');
        INSERT INTO Settings (Name, Value) VALUES ('hasDelPackages', 'False');
        INSERT INTO Settings (Name, Value) VALUES ('version', '1.1');
        ALTER TABLE BookDetails ADD Ebook BLOB";
                 cmd.ExecuteNonQuery();
             }
             else
             { 
                  cmd.CommandText = "UPDATE Settings SET Value='True' WHERE Name='adminFirstUse'";
                  cmd.ExecuteNonQuery();
             }
             loaddb();
             pnlDbName.Hide();
             MessageBox.Show("Database Imported successfully");
        }

        private void picCloseDbName_Click(object sender, EventArgs e)
        {
            pnlDbName.Hide();
        }

        private void btnMakeDefault_Click(object sender, EventArgs e)
        {
            string db = listAvailDBs.SelectedItem.ToString();
            Properties.Settings.Default.defaultdb = db;
            Properties.Settings.Default.Save();
            MessageBox.Show("Default Database changed.The changes will take effect when the application is launched again.");
            lbldefault.Text ="Default Database :\n" + db;            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

             //   MessageBox.Show(saveFileDialog1.FileName);
                string currentFolder = MainForm.datafolder;
                string fileName = listAvailDBs.SelectedItem.ToString();
                string source= Path.Combine(currentFolder, fileName);
                string destination = saveFileDialog1.FileName;
                File.Copy(source, destination,true);
                

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listAvailDBs.SelectedItem.ToString() == "librarydb.db")
                {
                    MessageBox.Show("The main database cannot be deleted");
                    return;
                }
                if (listAvailDBs.SelectedItem.ToString() == Properties.Settings.Default.defaultdb)
                {
                    MessageBox.Show("The default database cannot be deleted");
                    return;
                }
                string msg = "Do you want to delete database " + listAvailDBs.SelectedItem.ToString();
                DialogResult res = MessageBox.Show(msg, "Delete Database", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                    return;
                else
                {
                    string currentFolder = MainForm.datafolder;
                    string fileName = listAvailDBs.SelectedItem.ToString();
                    string source = Path.Combine(currentFolder, fileName);
                  //  MessageBox.Show(source);
                    File.Delete(source);
                }
                loaddb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
