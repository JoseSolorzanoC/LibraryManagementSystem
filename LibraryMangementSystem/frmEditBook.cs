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
    public partial class frmEditBook : Form
    {
        bool pdfselected = false;
        SQLiteConnection con;


        public static string bid;

        byte[] byteArrayMBimage = null;

        public frmEditBook()
        {
            con = MainForm.con;

            InitializeComponent();
        }
        private void clearedit()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            btnMBeditdel.Enabled = true;
            txtMBenterid.Enabled = true;
            label1.Enabled = true;
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
                btnMBdelete.Enabled = false;


            }


        }
        private void btnMBeditdel_Click(object sender, EventArgs e)
        {

            labelMBpdfsize.Hide();
            textMBpdfurl.Hide();

            // byte[] bytearrayRead = new byte[0];
            object Imageretval = null;
            string haspdf = "False";
            // panelMBtop.Hide();                 

            //Fill Details
            string bookid = txtMBenterid.Text;

            string price = "";

            if (String.IsNullOrEmpty(bookid.Trim()))
            {
                // MessageBox.Show("Please Enter Book ID.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblStatus.Text = "Please Enter Book ID.";
                txtMBenterid.Clear();
                clearedit();



                return;
            }
            string cmdtext = String.Format("select * from BookDetails where BookID='{0}';", bookid);
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = cmdtext;

            //clear
            MBclear();




            try
            {
                SQLiteDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Book not found.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //  lblStatus.Text = "Book not found.";
                    txtMBenterid.Clear();
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

                    textMBbid.Text = bookid;
                    // textMBbid.Text= dr["BookID"].ToString();
                    textMBisbn.Text = dr["ISBN"].ToString();
                    textMBtitle.Text = dr["Title"].ToString();
                    textMBauthor.Text = dr["Author"].ToString();
                    comboMBcateg.Text = dr["Category"].ToString();
                    textMBdesc.Text = dr["Description"].ToString();
                    textMByear.Text = dr["Year"].ToString();
                    textMBpub.Text = dr["Publisher"].ToString();
                    comboMBlang.Text = dr["Language"].ToString();

                    price = dr["Price"].ToString();

                    textMBpage.Text = dr["Pages"].ToString();
                    textMBshelf.Text = dr["Shelf"].ToString();

                    textMBdateadd.Text = dr["DateAdded"].ToString();


                    MBcombobtype.Text = dr["Type"].ToString();
                    Imageretval = dr["Image"];
                    haspdf = dr["HasPdf"].ToString();

                    //MessageBox.Show(Imageretval.ToString());





                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message From DataReader  :" + ex.Message + "\n Source :" + ex.Source);
            }




            //Read Image
            if (!(Imageretval is DBNull))
            {
                byteArrayMBimage = (byte[])Imageretval;
                System.IO.MemoryStream myMemoryStream = new System.IO.MemoryStream(byteArrayMBimage);
                System.Drawing.Image myImage = System.Drawing.Image.FromStream(myMemoryStream);
                pictureMB.Image = myImage;
                MBpicboxsetsizemode(pictureMB);
                if (pictureMB.SizeMode == PictureBoxSizeMode.Zoom)
                    BDlabelenlarge.Text = "Click to Enlarge";
                else
                    BDlabelenlarge.Text = "";
                pictureMB.Show();

            }


            //Read Pdf

        }
        private void MBclear()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                }
            }
            byteArrayMBimage = null;

            pictureMB.Image = null;
        }
        private void MBpicboxsetsizemode(PictureBox pic)
        {

            if (pic.Image == null)
                return;
            if (pic.Image.Size.Height < pic.Size.Height && pic.Image.Size.Width < pic.Size.Width)
            {
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pic.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnMBdelete_Click(object sender, EventArgs e)
        {
            SQLiteCommand comm = new SQLiteCommand(con);
            comm.CommandText = String.Format("select count(BookID) from IssueDetails where BookID={0};", textMBbid.Text);
            int c = Convert.ToInt32(comm.ExecuteScalar());
            if (c != 0)
            {
                MessageBox.Show("This Book is already issued.Delete after submission.");
                return;
            }

            SQLiteCommand cmd = new SQLiteCommand(con);
            DialogResult dres = MessageBox.Show("Do you want to DELETE this Book ?\nTitle: " + textMBtitle.Text + "\nBook ID : " + textMBbid.Text, "Confirm DELETE Operation", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {


                cmd.CommandText = string.Format("DELETE FROM BookDetails WHERE BookID='{0}'", textMBbid.Text);
                cmd.ExecuteNonQuery();
                lblStatus.Text = "The Book '" + textMBtitle.Text + "' ID: " + textMBbid.Text + " was DELETED successfully.";

                SQLiteCommand cm = new SQLiteCommand(con);
                cm.CommandText = "INSERT INTO DeletedID(tablename,deletedID) VALUES(@tabname,@delid);";

                cm.Parameters.Add(new SQLiteParameter("@tabname", "BookDetails"));
                cm.Parameters.Add(new SQLiteParameter("@delid", textMBbid.Text));

                cm.ExecuteNonQuery();
                clearedit();
                MainForm.dbsettings.hasDelBookDetails = true;

                string fileName = textMBbid.Text + ".pdf";

                //string cur = Environment.CurrentDirectory + @"\Ebooks";
                string cur = MainForm.datafolder + @"\Ebooks";

                string destination = Path.Combine(cur, fileName);


                if (File.Exists(destination))
                {
                    File.Delete(destination);
                }
                MessageBox.Show("Libro eliminado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                lblStatus.Text = "DELETE Action was Cancelled.";
            }

        }

        private void btnMBeditsave_Click(object sender, EventArgs e)
        {
            try
            {

                string haspdf;
                if (String.IsNullOrEmpty(textMBpdfurl.Text))
                {
                    haspdf = "False";
                }
                else
                {
                    haspdf = "True";
                }

                if (string.IsNullOrEmpty(textMBtitle.Text))
                {
                    MessageBox.Show("Enter Title");
                    return;
                }



                string price = null;

                price = textMBprice.Text.Trim();



                string bookid = textMBbid.Text;



                string cmdtext = @"UPDATE BookDetails SET BookNo=@bookno,ISBN=@isbn,Title=@title,Author=@author,Description=@desc,
Publisher=@pub,Category=@categ,Year=@year,Language=@lang,HasPdf=@haspdf,
Price=@price,Pages=@pages,Shelf=@shelf,DateAdded=@date,Type=@type WHERE BookID=@bid;";


                SQLiteCommand comm = new SQLiteCommand(con);




                comm.CommandText = cmdtext;
                comm.Parameters.Add(new SQLiteParameter("@bid", bookid));
                comm.Parameters.Add(new SQLiteParameter("@bookno", textMBbookno.Text));
                comm.Parameters.Add(new SQLiteParameter("@isbn", textMBisbn.Text));
                comm.Parameters.Add(new SQLiteParameter("@title", textMBtitle.Text));
                comm.Parameters.Add(new SQLiteParameter("@author", textMBauthor.Text));

                comm.Parameters.Add(new SQLiteParameter("@desc", textMBdesc.Text));
                comm.Parameters.Add(new SQLiteParameter("@categ", comboMBcateg.Text));
                comm.Parameters.Add(new SQLiteParameter("@pub", textMBpub.Text));
                comm.Parameters.Add(new SQLiteParameter("@lang", comboMBlang.Text));

                comm.Parameters.Add(new SQLiteParameter("@year", textMByear.Text));
                comm.Parameters.Add(new SQLiteParameter("@pages", textMBpage.Text));
                comm.Parameters.Add(new SQLiteParameter("@shelf", textMBshelf.Text));
                comm.Parameters.Add(new SQLiteParameter("@date", textMBdateadd.Text));

                comm.Parameters.Add(new SQLiteParameter("@type", MBcombobtype.Text));
                comm.Parameters.Add(new SQLiteParameter("@avail", "True"));
                comm.Parameters.Add(new SQLiteParameter("@price", price));
                comm.Parameters.Add(new SQLiteParameter("@haspdf", haspdf));







                comm.ExecuteNonQuery();
                //Null values cannot be passed into binary type

                if (pdfselected && !String.IsNullOrEmpty(textMBpdfurl.Text))
                {
                    try
                    {
                        /*
                        string fileName = bookid.ToString() + ".pdf"; ;
                        string source = textMBpdfurl.Text;
                        string cur = MainForm.datafolder+ @"\Ebooks";

                        string destination = Path.Combine(cur, fileName);

                        File.Copy(source, destination, true);*/

                        string strFn = textMBpdfurl.Text;
                        byte[] byteArrayMBpdf = null;
                        long pdfFileLength = 0;
                        FileInfo fipdf = new FileInfo(strFn);
                        pdfFileLength = fipdf.Length;

                        FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                        byteArrayMBpdf = new byte[Convert.ToInt32(pdfFileLength)];
                        fs.Read(byteArrayMBpdf, 0, Convert.ToInt32(pdfFileLength));
                        fs.Close();

                        comm.CommandText = string.Format("UPDATE BookDetails SET Ebook=@pdf WHERE BookID={0};", bookid);
                        comm.Connection = con;
                        comm.Parameters.Add("@pdf", System.Data.DbType.Binary);
                        comm.Parameters["@pdf"].Value = byteArrayMBpdf;
                        comm.ExecuteNonQuery();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message From DataReader  :" + ex.Message + "\n Source :" + ex.Source);
                    }


                }

                if (byteArrayMBimage != null)
                {
                    SQLiteCommand command = new SQLiteCommand(con);
                    command.CommandText = string.Format("UPDATE BookDetails SET Image=@Picture WHERE BookID='{0}';", bookid);
                    command.Connection = con;
                    command.Parameters.Add("@Picture", System.Data.DbType.Binary);
                    command.Parameters["@Picture"].Value = byteArrayMBimage;
                    command.ExecuteNonQuery();

                }


                lblStatus.Text = "The Book '" + textMBtitle.Text + "' ID: " + textMBbid.Text + " was MODIFIED successfully. ";
                MessageBox.Show("Libro actualizado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);



                //UPDATE Persons SET Address='Nissestien 67', City='Sandnes'WHERE LastName='Tjessem' AND FirstName='Jakob'


                //    textMBenterbid.Text = textMBbid.Text;

                txtMBenterid.Clear();
                clearedit();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message From DataReader  :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void btnMBgbooksapi_Click(object sender, EventArgs e)
        {

            /* if (MainForm.bform == null)
             {
                 MainForm.bform = new BooksAPIForm();

             }*/
            MainForm.bform = new BooksAPIForm();
            MainForm.bform.ShowDialog();
            textMBtitle.Text = MainForm.gtitle;
            textMBauthor.Text = MainForm.gauthor;
            textMBdesc.Text = MainForm.gdesc;
            textMBpub.Text = MainForm.gpublisher;
            textMBpage.Text = MainForm.gpages;
            textMByear.Text = MainForm.gpubyear;
            textMBisbn.Text = MainForm.gisbn;
            if (MainForm.gimg != null)
            {
                pictureMB.Image = MainForm.gimg;

                MemoryStream ms = new MemoryStream();
                MainForm.gimg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byteArrayMBimage = ms.ToArray();

                MBpicboxsetsizemode(pictureMB);
            }
            if (pictureMB.SizeMode != PictureBoxSizeMode.CenterImage)
                BDlabelenlarge.Text = "Click to Enlarge";
            else
                BDlabelenlarge.Text = "";
        }

        private void frmEditBook_Load(object sender, EventArgs e)
        {

            SQLiteCommand cmd = new SQLiteCommand("select Category from Categories", con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            comboMBcateg.Items.Clear();
            while (dr.Read())
            {
                comboMBcateg.Items.Add(dr[0].ToString());
            }

            dr.Close();


            if (String.IsNullOrEmpty(bid))
            {
                clearedit();
            }
            else
            {
                txtMBenterid.Text = bid;
                btnMBeditdel_Click(null, null);

            }


            labelMBpdfsize.Hide();
            textMBpdfurl.Hide();
            labelMBpicsize.Hide();

            if (MainForm.globalstrLoggedUserType == "User")
            {
                btnMBdelete.Enabled = false;


            }

        }

        private void pictureMB_Click(object sender, EventArgs e)
        {
            if (pictureMB.Image == null)
                return;
            if (pictureMB.Dock == DockStyle.Fill)
            {
                pictureMB.Dock = DockStyle.None;

                MBpicboxsetsizemode(pictureMB);
                return;
            }
            if (pictureMB.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pictureMB.Dock = DockStyle.Fill;

                MBpicboxsetsizemode(pictureMB);

            }
        }

        private void MBcombobtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MBcombobtype.Text == "Hardcopy Only")
            {

                btnMBopenpdf.Hide();
                pdfselected = false;

            }
            else
            {

                btnMBopenpdf.Show();
            }
        }

        private void btnMBopenfile_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(pictureMB.Visible.ToString());
                long imageFileLength = 0;

                this.openFileDialogMBpic.ShowDialog();
                string strFn = this.openFileDialogMBpic.FileName;
                if (strFn == "")
                    return;
                this.pictureMB.Image = Image.FromFile(strFn);
                FileInfo fiImage = new FileInfo(strFn);
                imageFileLength = fiImage.Length;

                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                byteArrayMBimage = new byte[Convert.ToInt32(imageFileLength)];
                fs.Read(byteArrayMBimage, 0, Convert.ToInt32(imageFileLength));
                fs.Close();

                textMBimgurl.Text = strFn;
                labelMBpicsize.Text = "Size : " + Convert.ToString(Math.Round(imageFileLength / 1024.00, 2)) + " KB ";
                labelMBpicsize.Show();
                openFileDialogMBpic.FileName = "";

                MBpicboxsetsizemode(pictureMB);

            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error with opening file :" + ex.Message);
            }
        }

        private void btnMBopenpdf_Click(object sender, EventArgs e)
        {
            try
            {

                long imageFileLength = 0;
                openFileDialogMBpic.Filter = "Pdf Files|*.pdf|All Files|*.*";
                this.openFileDialogMBpic.ShowDialog();
                string strFn = this.openFileDialogMBpic.FileName;

                if (strFn == "")
                {
                    labelMBpdfsize.Hide();
                    textMBpdfurl.Hide();
                    return;
                }


                FileInfo fiImage = new FileInfo(strFn);
                imageFileLength = fiImage.Length;



                textMBpdfurl.Text = strFn;
                labelMBpdfsize.Text = "Size : " + Convert.ToString(Math.Round(imageFileLength / 1024.00, 2)) + " KB ";

                openFileDialogMBpic.Filter = "";
                openFileDialogMBpic.FileName = "";
                pdfselected = true;
                labelMBpdfsize.Show();
                textMBpdfurl.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnMBViewpdf_Click(object sender, EventArgs e)
        {

        }

        private void comboMBcateg_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (MBcombobtype.Text == "Hardcopy Only")
            {
                textMBpdfurl.Hide();
                labelMBpdfsize.Hide();
                btnMBopenpdf.Hide();

                textMBpdfurl.Clear();
            }
            else
            {
                textMBpdfurl.Show();
                labelMBpdfsize.Show();
                btnMBopenpdf.Show();
            }
        }


    }
}
