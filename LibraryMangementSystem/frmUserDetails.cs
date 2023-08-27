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
    public partial class frmUserDetails : Form
    {

        SQLiteCommand cmd ;

        SQLiteDataReader dr;
           
        public frmUserDetails()
        {
         
         
            InitializeComponent();
            
        }
        
        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            pnlChangePass.Hide();

           cmd = new SQLiteCommand(MainForm.con);


       
        }

        private void picCloseAdd_Click(object sender, EventArgs e)
        {
            pnlChangePass.Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try{
           
            string curpass = txtCurPass.Text;
            string pass1 = txtPass1.Text;
            string pass2 = txtPass2.Text;
                string cmdstr = "select Password from UserDetails where UserName=@uname";
                cmd.CommandText = cmdstr;
                
                cmd.Parameters.Add("@uname", DbType.String);
                cmd.Parameters["@uname"].Value = MainForm.globalstrLoggedUser;
                string recpass = cmd.ExecuteScalar().ToString();
                string decryptedstring = StringCipher.Decrypt(recpass, StringCipher.enckey);

          
                if (string.Compare(decryptedstring,curpass) != 0)
                {
                 MessageBox.Show("Enter the correct Current Password");
                   
                    return;
                }
            
            if (String.IsNullOrEmpty(pass1.Trim()))
            {
                MessageBox.Show("Please Enter Password.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPass1.Clear();
                return;
            }
            if (pass1 != pass2)
            {
                MessageBox.Show("Passwords do not match.Please retype the password.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPass2.Clear();
                return;
            }
            string encryptedpass = StringCipher.Encrypt(pass1, StringCipher.enckey);

            cmd.CommandText = "update UserDetails set Password=@pass where UserName=@uname;";

            cmd.Parameters.Add("@uname", DbType.String).Value = MainForm.globalstrLoggedUser;
            cmd.Parameters.Add("@pass", DbType.String).Value = encryptedpass;
            cmd.ExecuteNonQuery();
            pnlChangePass.Hide();
            MessageBox.Show("Password changed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            pnlChangePass.Show();
            pnlChangePass.BringToFront();
            txtCurPass.Clear();
            txtPass1.Clear();
            txtPass2.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUserDetails_Shown(object sender, EventArgs e)
        {

           
            string cmdtext = String.Format("select * from UserDetails where UserName='{0}';", MainForm.globalstrLoggedUser);
            cmd.CommandText = cmdtext;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("User not found.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    this.Close();
                    return;

                }
                
                while (dr.Read())
                {
                    txtEditUname.Text = dr["UserName"].ToString();
                    txtEditName.Text = dr["Name"].ToString();
                    txtEditAddress.Text = dr["Address"].ToString();
                    txtEditEmail.Text = dr["Email"].ToString();
                    txtEditPhone.Text = dr["PhoneNumber"].ToString();

                }
                dr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }
        
    }
}
