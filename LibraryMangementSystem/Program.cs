using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace LibraryManagementSystem
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///
         
        
        [STAThread]
        
        static void Main()
        {
            //Uncomment the below line for resetting all settings to default.Perform it before building setup project.
            //Properties.Settings.Default.Reset();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm frmMain = new MainForm();

            SQLiteConnection con;
            con = MainForm.con;
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select Value from Settings where Name='userEnabled'", con);
            string userenabled= cmd.ExecuteScalar().ToString();
            bool user = Convert.ToBoolean(userenabled);
           // MessageBox.Show(user.ToString());
           
           if (user)
           {
               LoginForm frmLogin = new LoginForm();
             
               if (frmLogin.ShowDialog() == DialogResult.OK)
               {
                   
                   Application.Run(frmMain);


               }
               else
               {

                   Application.Exit();
               }
           }
           else
           {
               //MessageBox.Show("else part");
               MainForm.globalstrLoggedUserType = "Administrator";
              string cmdtext = String.Format("select UserName from UserDetails where Type='{0}';","Administrator");
              // string cmdtext = String.Format("select Name from abc where id={0};","1");

              
               
                cmd = new SQLiteCommand(cmdtext, con);
             //  MessageBox.Show(con.ConnectionString);
               object res = cmd.ExecuteScalar();
               if(res!=null)
               {
     string uname = res.ToString();
   
   //  con.Close();
     MainForm.globalstrLoggedUser = uname;
               }
               Application.Run(frmMain);
           }
         
           
           
            
      

        }
    }
}