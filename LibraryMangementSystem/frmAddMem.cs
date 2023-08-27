using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace LibraryManagementSystem
{
    
    public partial class frmAddMem : Form
    {
        //class variables
        byte[] byteArrayPhoto = null;
        SQLiteConnection con;
        SQLiteCommand cmd;
        //SQLiteDataReader dr;
        public frmAddMem()
        {
            con = MainForm.con;
            cmd = new SQLiteCommand(con);
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void frmAddMem_Load(object sender, EventArgs e)
        {
            string courses = MainForm.dbsettings.courseList;
            string[] coursearray =courses.Split(',');
            foreach (string item in coursearray)
            {
                cmbCourse.Items.Add(item);
                
            }
            
            if (cmbCourse.Items.Count > 0)
               cmbCourse.SelectedIndex = 0;

            txtAdmYear.Value = DateTime.Today.Year;
            
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
             try
            {
                
                long imageFileLength=0;
		        
                this.openFileDialog.ShowDialog();
                string strFn = this.openFileDialog.FileName;
                if (strFn == "")
                    return;
                this.picPhoto.Image = Image.FromFile(strFn);
                FileInfo fiImage = new FileInfo(strFn);
                imageFileLength = fiImage.Length;
               
                FileStream fs = new FileStream(strFn, FileMode.Open,FileAccess.Read, FileShare.Read);
                byteArrayPhoto = new byte[Convert.ToInt32(imageFileLength)];
                fs.Read(byteArrayPhoto, 0,Convert.ToInt32(imageFileLength));
                fs.Close();
                
              //  textMBimgurl.Text = strFn;
               // labelMBpicsize.Text ="Size : "+Convert.ToString(Math.Round(imageFileLength/1024.00,2))+ " KB ";

                openFileDialog.FileName = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with opening Image :"+ex.Message);
            }
        

        }

        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show((cmbPackage.SelectedItem as ComboboxItem).Value.ToString());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Enter Member name");
               return;
            }
 

            int id;
            bool hasdel = MainForm.dbsettings.hasDelMemberDetails;
            id = MainForm.getNextID(hasdel, "MemberDetails");
           // MessageBox.Show(id.ToString());
          


                string msg;
             
                cmd.CommandText = "INSERT INTO MemberDetails(MemberID,Name,Address,PhoneNumber,Dob,Email,Course,AdmissionYear,RollNo) VALUES(@id,@name,@address,@phone,@dob,@email,@course,@admyr,@rollno)";
                
                cmd.Parameters.Add(new SQLiteParameter("@id",id));
                cmd.Parameters.Add(new SQLiteParameter("@name",txtName.Text));
                cmd.Parameters.Add(new SQLiteParameter("@address",txtAddress.Text));
                cmd.Parameters.Add(new SQLiteParameter("@phone",txtPhone.Text));
                cmd.Parameters.Add(new SQLiteParameter("@dob",dateDob.Text));
                cmd.Parameters.Add(new SQLiteParameter("@email",txtEmail.Text));
                cmd.Parameters.Add(new SQLiteParameter("@course",cmbCourse.Text));
                cmd.Parameters.Add(new SQLiteParameter("@admyr",txtAdmYear.Value));
                cmd.Parameters.Add(new SQLiteParameter("@rollno",txtRollNo.Text));

               
                //MessageBox.Show(id.ToString());
                cmd.ExecuteNonQuery();


               if (byteArrayPhoto!= null)
               {

                   cmd.CommandText = string.Format("UPDATE MemberDetails SET Photo=@Picture WHERE MemberID={0};",id);
                   cmd.Connection = con;
                   cmd.Parameters.Add("@Picture", System.Data.DbType.Binary);
                   cmd.Parameters["@Picture"].Value = byteArrayPhoto;
                   cmd.ExecuteNonQuery();

               }

                              
                               msg = "New Member Added.Member ID: "+id;
                               lblStatus.Text = msg;

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {

                        c.Text = "";

                    }
                }
                byteArrayPhoto = null;
                picPhoto.Image = null;
                MainForm.newmid = id.ToString();

               // this.DialogResult = DialogResult.OK;
        }

       
    }
}
