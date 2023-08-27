using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        string userName;
        string passWord;
        string lookupPassword;
        public string conString;

        SQLiteConnection con;
        SQLiteCommand cmd;

        
       
        public LoginForm()
        {
            try
            {
               
                InitializeComponent();
               // SplashForm sp = new SplashForm();
                //sp.ShowDialog();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("splash screen error:" + ex.Message);
            }

        }
        private void showsplash()
        {
            SplashForm spf = new SplashForm();
            spf.ShowDialog();
            spf.Dispose();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
          //  con.Open();
            con = MainForm.con;
            con.Open();
            
        }        
        

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (authenticateLogin() == true)
            {
                
                DialogResult = DialogResult.OK;
            }           

        }

        private bool authenticateLogin()
        {
            
            
                 userName = txtUname.Text;
                 passWord = txtPass.Text;

                 //Validation
                 // Check for invalid userName.           
                 if ((null == userName) || (0 == userName.Length))
                 {
                     txtUname.Focus();
                     lblStatus.Text = "Enter User Name";

                     return false;

                 }

                 // Check for invalid passWord.            
                 if ((null == passWord) || (0 == passWord.Length))
                 {
                     txtPass.Focus();
                     lblStatus.Text = "Enter Password";
                     return false;
                 }
                 //Connection Opened.Checking password..
                 string cmdstr = "select Type,Password from UserDetails where UserName=@uname";
                 cmd = new SQLiteCommand(cmdstr, con);
                 cmd.Parameters.Add("@uname", DbType.String);
                 cmd.Parameters["@uname"].Value = userName;

                 SQLiteDataReader dataReader;
                 dataReader = cmd.ExecuteReader();
                 bool d = dataReader.Read();
                 if (d == false)
                 {

                     lblStatus.Text = "User does not exist !";
                     txtUname.Clear();
                     txtUname.Focus();
                   
                     return false;
                 }
                 string usertype = dataReader["Type"].ToString();
                 lookupPassword = dataReader["Password"].ToString();
                 string decryptedstring = StringCipher.Decrypt(lookupPassword, StringCipher.enckey);
                 

                 if (string.Compare(decryptedstring, passWord) == 0)
                 {
                     MainForm.globalstrLoggedUser = userName;
                     MainForm.globalstrLoggedUserType = usertype;
                     
                     return true;
                 }
                 else
                 {
                     lblStatus.Text = "Enter the correct Password";
                     txtPass.Clear();
                     txtPass.Clear();
                     
                     return false;
                 }
             
                
            
            
         
                        
            
           
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (MainForm.dbsettings.defaultUser != null)
            {
                txtUname.Text = MainForm.dbsettings.defaultUser;
                txtPass.Focus();
            }
            
        }

        private void btnTestLogin_Click(object sender, EventArgs e)
        {
            txtUname.Text = "admin";
            txtPass.Text = "admin";
            cmdLogin_Click(null, null);
            
        }

        
        
    }
}