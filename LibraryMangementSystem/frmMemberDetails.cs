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
    public partial class frmMemberDetails : Form
    {
        public static string openwithmid;

       // string pkgid;
        object retval = null;
        byte[] img = null;
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
       // string txt;
        string memid;
        string cmdtext;
        public frmMemberDetails()
        {
             con = MainForm.con;
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
           memid =txtMemberID.Text;
            if (String.IsNullOrEmpty(memid.Trim()))
            {
                MessageBox.Show("Please Enter Member ID.","Alert !",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
             txtMemberID.Clear();
                return;
            }

            cmdtext = String.Format("select * from MemberDetails where MemberID='{0}';",memid);
           //  cmd.CommandText = cmdtext;
            cmd = new SQLiteCommand(cmdtext, con);

           
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Member not found.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMemberID.Clear();
                    dr.Close();
                    return;
                }
                
                while (dr.Read())
                {
                    txtmemid2.Text = dr["MemberID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtAddress.Text = dr["Address"].ToString(); 
                    txtdob.Text= dr["Dob"].ToString(); 
                    txtEmail.Text      = dr["Email"].ToString();
                    txtCourse.Text = dr["Course"].ToString();
                    txtAdmYear.Text = dr["AdmissionYear"].ToString();
                    txtRollNo.Text = dr["RollNo"].ToString();


                 
                    txtPhone.Text     = dr["PhoneNumber"].ToString(); 

                    retval = dr["Photo"];
                                     
                }

                
                  if (!(retval is DBNull))
                  {
                     img = (byte[])retval;
                      System.IO.MemoryStream myMemoryStream = new System.IO.MemoryStream(img);
                      System.Drawing.Image myImage = System.Drawing.Image.FromStream(myMemoryStream);
                      picPhoto.Image = myImage;
                     MainForm.MBpicboxsetsizemode(picPhoto);
                      if (picPhoto.SizeMode == PictureBoxSizeMode.Zoom)
                          labelenlarge.Text = "Click to Enlarge";
                      else
                          labelenlarge.Text = "";
                  }
                  dr.Close();
                  fillgrid();
                  txtMemberID.Clear();
                

        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }
        private void fillgrid()
        {

            cmd.CommandText = string.Format("SELECT * from SetPackages where MemberID={0} ORDER BY ID ", memid);
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                
                datagridPackages.DataSource = dt;

                btnCancelPkg.Enabled = true;

            }
            else
            {
                btnCancelPkg.Enabled = false;

                datagridPackages.DataSource = null;
            }
            dr.Close();
        }
       
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            labelenlarge.Text = "";
            if (!String.IsNullOrEmpty(openwithmid))
            {
           
                txtMemberID.Text= openwithmid;
                btnok_Click(null, null);



            }
        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
        {
            string id;
             cmd.CommandText = string.Format("SELECT ID,max(EndDate),PackageTitle FROM SetPackages WHERE MemberID={0}", memid);
            dr=cmd.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                id=dr["ID"].ToString();
                string title = dr["PackageTitle"].ToString();
                dr.Close();
                cmd.CommandText = string.Format("DELETE FROM SetPackages WHERE ID={0}", id);
              cmd.ExecuteNonQuery();
            string  msg = "The Package  '"  +title+ "'  ID: " + id + " was Cancelled successfully.";
            MessageBox.Show(msg);
            }

            fillgrid();


        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsummary_Click(object sender, EventArgs e)
        {
            frmSummary sm = new frmSummary(txtName.Text, txtmemid2.Text);
            sm.ShowDialog();
        }

        private void btnBooksToSubmit_Click(object sender, EventArgs e)
        {

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelenlarge.Text))
                return;

            if (picPhoto.Dock == DockStyle.None)
            {
                picPhoto.Dock = DockStyle.Fill;
              MainForm.MBpicboxsetsizemode(picPhoto);
            }
            else
            {
                picPhoto.Dock = DockStyle.None;
                MainForm.MBpicboxsetsizemode(picPhoto);

            }

        }
    }
}
