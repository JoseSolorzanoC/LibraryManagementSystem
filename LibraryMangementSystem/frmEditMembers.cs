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
    public partial class frmEditMembers : Form
    {
        byte[] byteArrayPhoto = null;
        object retval = null;
        byte[] img = null;
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        
        string cmdtext;
        public static string openwithmid;
        public frmEditMembers()
        {
            con = MainForm.con;
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Show();
            btnDelete.Show();
       

            string memid = txtMemberID.Text;
            if (String.IsNullOrEmpty(memid.Trim()))
            {
                MessageBox.Show("Please Enter Member ID.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberID.Clear();
                clearedit();
                return;
            }
            

            cmdtext = String.Format("select * from MemberDetails where MemberID='{0}';", memid);
            //  cmd.CommandText = cmdtext;
            cmd = new SQLiteCommand(cmdtext, con);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Member not found.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMemberID.Clear();
                    dr.Close();
                    clearedit();
                    return;
                }
                else
                {
                    showedit();
                }

                while (dr.Read())
                {
                    txtmemid2.Text = dr["MemberID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                   // DateTime dt=Convert.ToDateTime();

                    if (!string.IsNullOrEmpty(dr["Dob"].ToString().Trim()))
                    {
                        DateTime dt = Convert.ToDateTime(dr["Dob"].ToString(), System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);
                        dateDob.Value = dt;
                    }
                    else
                    {
                        dateDob.Hide();
                    }
                   

                    txtEmail.Text = dr["Email"].ToString();
                   
                    txtPhone.Text = dr["PhoneNumber"].ToString();
                    
                 cmbCourse.Text= dr["Course"].ToString();
                //  MessageBox.Show(dr["Course"].ToString());
                   // cmbCourse.SelectedIndex = 2;
                 // cmbCourse.Text = "bsc electronics";
                    txtAdmYear.Value =Convert.ToInt32( dr["AdmissionYear"].ToString());
                    txtRollNo.Text = dr["RollNo"].ToString();

                    retval = dr["Photo"];

                }


                if (!(retval is DBNull))
                {
                    img = (byte[])retval;
                    System.IO.MemoryStream myMemoryStream = new System.IO.MemoryStream(img);
                    System.Drawing.Image myImage = System.Drawing.Image.FromStream(myMemoryStream);
                    picPhoto.Image = myImage;
                    picPhoto.Show();
                }
               
                dr.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {

            try
            {

                long imageFileLength = 0;

                this.openFileDialog.ShowDialog();
                string strFn = this.openFileDialog.FileName;
                if (strFn == "")
                    return;
                this.picPhoto.Image = Image.FromFile(strFn);
                FileInfo fiImage = new FileInfo(strFn);
                imageFileLength = fiImage.Length;

                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                byteArrayPhoto = new byte[Convert.ToInt32(imageFileLength)];
                fs.Read(byteArrayPhoto, 0, Convert.ToInt32(imageFileLength));
                fs.Close();

                //  textMBimgurl.Text = strFn;
                // labelMBpicsize.Text ="Size : "+Convert.ToString(Math.Round(imageFileLength/1024.00,2))+ " KB ";

                openFileDialog.FileName = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with opening file :" + ex.Message);
            }
        }
        private void clearedit()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            txtMemberID.Enabled = true;
            btnEdit.Enabled = true;
            label3.Enabled = true;
            lblStatus.Enabled = true;
        }
        private void showedit()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
            if (MainForm.globalstrLoggedUserType == "User")
            {
                btnDelete.Enabled = false;


            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter Name");
                return;
            }
            

            try
            {




                string memid = txtmemid2.Text;



                cmdtext = "UPDATE MemberDetails SET Name=@name,Address=@address,PhoneNumber=@phno,Dob=@dob,Email=@email,Course=@course,AdmissionYear=@admyear,RollNo=@rollno WHERE MemberID=@memberid;";


                cmd.CommandText = cmdtext;
                cmd.Parameters.Add("@name", DbType.String).Value = txtName.Text;
                cmd.Parameters.Add("@address", DbType.String).Value = txtAddress.Text;
                cmd.Parameters.Add("@phno", DbType.String).Value = txtPhone.Text;
                cmd.Parameters.Add("@dob", DbType.String).Value = dateDob.Text;
                cmd.Parameters.Add("@email", DbType.String).Value = txtEmail.Text;

                cmd.Parameters.Add("@course", DbType.String).Value = cmbCourse.Text;
                cmd.Parameters.Add("@admyear", DbType.String).Value = txtAdmYear.Value;
                cmd.Parameters.Add("@rollno", DbType.String).Value = txtRollNo.Text;

                cmd.Parameters.Add("@memberid", DbType.String).Value = memid;
                cmd.ExecuteNonQuery();
                //Null values cannot be passed into binary type
                if (byteArrayPhoto != null)
                {

                    cmd.CommandText = string.Format("UPDATE MemberDetails SET Photo=@photo WHERE MemberID='{0}';", memid);
                    cmd.Connection = con;
                    cmd.Parameters.Add("@photo", System.Data.DbType.Binary);
                    cmd.Parameters["@photo"].Value = byteArrayPhoto;
                    cmd.ExecuteNonQuery();

                }

              

                lblStatus.Text = "The Member '" +txtName.Text + "' ID: " + memid + " was MODIFIED successfully. ";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
   


        
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delid = txtmemid2.Text;
            string memname = txtName.Text;
            DialogResult dres = MessageBox.Show("Do you want to DELETE this Member ?\nName: " + memname+"\nID: " + delid, "Confirm DELETE Operation", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {


                cmd.CommandText = string.Format("DELETE FROM MemberDetails WHERE MemberID={0}", delid);
                cmd.ExecuteNonQuery();
                string msg = "The Member'" + memname + "'  ID:" + delid + " was DELETED successfully.";
                lblStatus.Text = msg;


                cmd.CommandText = string.Format("INSERT INTO DeletedID(tablename,deletedid) VALUES('{0}',{1});", "MemberDetails", delid);
                cmd.ExecuteNonQuery();
                MainForm.dbsettings.hasDelMemberDetails = true;
                clearedit();
               
                

            }
            else
            {
                lblStatus.Text = "DELETE Action was Cancelled.";
            }
        }

        private void frmEditMembers_Load(object sender, EventArgs e)
        {
            string courses = MainForm.dbsettings.courseList;
            string[] coursearray = courses.Split(',');
            foreach (string item in coursearray)
            {
                cmbCourse.Items.Add(item);

            }

            if (cmbCourse.Items.Count > 0)
                cmbCourse.SelectedIndex = 0;

            if (String.IsNullOrEmpty(openwithmid))
            {
                clearedit();
            }
            else
            {
                txtMemberID.Text = openwithmid;
                btnEdit_Click(null, null);
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

      
    }
}
