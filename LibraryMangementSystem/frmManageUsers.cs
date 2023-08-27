using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;



namespace LibraryManagementSystem
{
    public partial class frmManageUsers : Form
    {
        SQLiteCommand cmd = new SQLiteCommand(MainForm.con);
        SQLiteDataReader dr;
  
        string cmdtext;
        SQLiteConnection con;
        string edituname;
        bool adminFirstUse;
        public frmManageUsers()
        {
            con = MainForm.con;
            InitializeComponent();
        }
        public static string RandomStr()
        {
            string rStr = Path.GetRandomFileName();
            rStr = rStr.Replace(".", ""); // For Removing the .
            return rStr;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            pnlAddUser.Show();
            pnlAddUser.BringToFront();
        }

        private void picCloseAdd_Click(object sender, EventArgs e)
        {
            pnlAddUser.Hide();
            fillgrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                
                string pass1, pass2,uname;
                uname = txtAddUname.Text;

                if (String.IsNullOrEmpty(uname.Trim()))
                {
                    MessageBox.Show("Please Enter User Name.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddUname.Clear();
                    return;
                }

                cmd.CommandText =string.Format("SELECT COUNT(*) FROM UserDetails WHERE UserName='{0}';",uname);
                string c = cmd.ExecuteScalar().ToString();
                if (c != "0")
                {
                    MessageBox.Show("User Name already exists.Please Enter another User Name.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddUname.Clear();
                    return;
                }

                pass1 = txtAddPass1.Text;
                pass2 = txtAddPass2.Text;

                if (String.IsNullOrEmpty(pass1.Trim()))
                {
                    MessageBox.Show("Please Enter Password.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddPass1.Clear();
                    return;
                }
                if (pass1!=pass2)
                {
                    MessageBox.Show("Passwords do not match.Please retype the password.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddPass2.Clear();
                    return;
                }
                //pass hashing
                string encryptedpass = StringCipher.Encrypt(pass1,StringCipher.enckey);


                if (string.IsNullOrEmpty(txtAddName.Text))
                {
                    MessageBox.Show("Enter Name");
                    return;
                }
               
                cmd.CommandText = "INSERT INTO UserDetails(UserName,Password,Name,Address,PhoneNumber,Email,Type) VALUES(@uname,@pass,@name,@addr,@phno,@email,@type);";

                cmd.Parameters.Add("@uname", DbType.String).Value = uname;
                cmd.Parameters.Add("@pass", DbType.String).Value =encryptedpass;
                cmd.Parameters.Add("@name", DbType.String).Value = txtAddName.Text;
                cmd.Parameters.Add("@addr", DbType.String).Value = txtAddAddress.Text;
                    cmd.Parameters.Add("@phno", DbType.String).Value =txtAddPhone.Text;
                    cmd.Parameters.Add("@email", DbType.String).Value = txtAddEmail.Text;
                    string msg;
                    if (btnAdd.Text != "Add Administrator")
                    {
                        cmd.Parameters.Add("@type", DbType.String).Value = "User";
                        msg = "User " + uname + " was added.";
                    }
                    else
                    {
                        cmd.Parameters.Add("@type", DbType.String).Value = "Administrator";
                        msg = "Administrator " + uname + " was added.";
                    }
                
                cmd.ExecuteNonQuery();
                if (btnAdd.Text == "Add Administrator")
                {
                    MainForm.dbsettings.adminFirstUse = false;

                    
                    btnAdd.Text = "Add User";
                  
                }
                lblStatus.Text = msg;

                txtAddUname.Clear();
                txtAddPass1.Clear();
                txtAddPass2.Clear();
                txtAddName.Clear();
                txtAddPhone.Clear();
                txtAddAddress.Clear();
                txtAddEmail.Clear();

                fillgrid();
                pnlAddUser.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            pnlAddUser.Hide();
            pnlEditUsers.Hide();
            fillgrid();
            if (MainForm.dbsettings.userEnabled)
            {
                btnEnable.Text = "Disable Users";
                grpUsers.Enabled = true;
            }
            else
            {
                btnEnable.Text = "Enable Users";
                grpUsers.Enabled = false;
            }
        }
        private void fillgrid()
        {
            SQLiteDataReader dtr ;
            cmd.CommandText = "SELECT UserName,Name,PhoneNumber,Email,Type from UserDetails";
            dtr = cmd.ExecuteReader();
         
            if (dtr.HasRows == true)
            {
                
                DataTable dt = new DataTable();
                dt.Clear();
               
                dt.Load(dtr);
             datagridUsers.DataSource = dt;
                
            }
            else
            {
              //  MessageBox.Show("No Users in the list ! ");
                datagridUsers.DataSource = null;
            }
            dtr.Close();
        }

        private void picCloseEdit_Click(object sender, EventArgs e)
        {
            pnlEditUsers.Hide();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {

            string uname;
            uname = txtEditUname.Text;

            if (String.IsNullOrEmpty(uname.Trim()))
            {
                MessageBox.Show("Please Enter User Name.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEditUname.Clear();
                return;
            }

            if (uname != edituname)
            {
                cmd.CommandText = string.Format("SELECT COUNT(*) FROM UserDetails WHERE UserName='{0}';", uname);
                string c = cmd.ExecuteScalar().ToString();
                if (c != "0")
                {
                    MessageBox.Show("User Name already exists.Please Enter another User Name.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEditUname.Clear();
                    return;
                }
            }
            if (string.IsNullOrEmpty(txtEditName.Text))
            {
                MessageBox.Show("Enter Name");
                return;
            }


            try
            {
         



                cmdtext = "UPDATE UserDetails SET UserName=@uname,Name=@name,Address=@addr,PhoneNumber=@phno,Email=@email WHERE UserName=@olduname;";


                cmd.CommandText = cmdtext;
                cmd.Parameters.Add("@uname", DbType.String).Value = uname;
                cmd.Parameters.Add("@name", DbType.String).Value = txtEditName.Text;
                cmd.Parameters.Add("@addr", DbType.String).Value =txtEditAddress.Text;
                cmd.Parameters.Add("@phno", DbType.String).Value =txtEditPhone.Text;
                cmd.Parameters.Add("@email", DbType.String).Value = txtEditEmail.Text;
                cmd.Parameters.Add("@olduname", DbType.String).Value =edituname;
           
                cmd.ExecuteNonQuery();
                //Null values cannot be passed into binary type
               



                lblStatus.Text = "The Member '" + edituname  + " was MODIFIED successfully. ";
                pnlEditUsers.Hide();
                fillgrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
   
        }

        private void txtResetPass_Click(object sender, EventArgs e)
        {
            /*var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 4)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());*/
            string result = RandomStr();
            result = result.Substring(0, 5);
            string encryptedpass = StringCipher.Encrypt(result, StringCipher.enckey);

            cmdtext = string.Format("UPDATE UserDetails SET Password='{0}' WHERE UserName='{1}';",encryptedpass,edituname);


            cmd.CommandText = cmdtext;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password was reset to "+result);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (datagridUsers.RowCount != 0)
                edituname = datagridUsers.SelectedRows[0].Cells["UserName"].Value.ToString();
            else
                return;

            pnlEditUsers.Show();
            pnlEditUsers.BringToFront();

         
            if (String.IsNullOrEmpty(edituname.Trim()))
            {
                MessageBox.Show("Please Select a User to Edit.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            cmdtext = String.Format("select * from UserDetails where UserName='{0}';",edituname);
            cmd = new SQLiteCommand(cmdtext, con);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("User not found.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dr.Close();
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

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            string deluname=datagridUsers.SelectedRows[0].Cells["UserName"].Value.ToString();
            string type = datagridUsers.SelectedRows[0].Cells["Type"].Value.ToString();
            if (type == "Administrator")
            {
                MessageBox.Show("Administrator account cannot be deleted.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogResult dres = MessageBox.Show("Do you want to DELETE this User ?\nName: " + deluname, "Confirm DELETE Operation", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {


                cmd.CommandText = string.Format("DELETE FROM UserDetails WHERE UserName='{0}'", deluname);
                cmd.ExecuteNonQuery();
                string msg = "The User '" + deluname + " was DELETED successfully.";
                lblStatus.Text = msg;


                fillgrid();

            }
            else
            {
                lblStatus.Text = "DELETE Action was Cancelled.";
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (btnEnable.Text == "Enable Users")
            {
                MainForm.dbsettings.userEnabled = true;
                lblStatus.Text = "Users Enabled";
                btnEnable.Text = "Disable Users";
                grpUsers.Enabled = true;
                adminFirstUse = MainForm.dbsettings.adminFirstUse;
                if (adminFirstUse == true)
                {
                    btnAdd.Text = "Add Administrator";
                    pnlAddUser.Show();
                }

            }
            else
            { 
                
              MainForm.dbsettings.userEnabled = false;
                lblStatus.Text = "Users Disabled";
                btnEnable.Text = "Enable Users";
                grpUsers.Enabled = false;

            }
            

        
            
        }

        private void btnMakeDefault_Click(object sender, EventArgs e)
        {
             string uname;
            if (datagridUsers.RowCount != 0)
            uname= datagridUsers.SelectedRows[0].Cells["UserName"].Value.ToString();
            else
                return;

            MainForm.dbsettings.defaultUser = uname;
          
            lblStatus.Text = "Default user is " + uname;
        }

        private void pnlEditUsers_Leave(object sender, EventArgs e)
        {
            pnlEditUsers.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmManageUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
             cmd.CommandText = "SELECT COUNT(*) FROM UserDetails";
             string c = cmd.ExecuteScalar().ToString();
             if (c == "0")
             {
            MainForm.dbsettings.userEnabled = false;          
          
             }
        }
       
    }
}
