using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.IO;


using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using Glass;
using System.Collections;


using System.Data.SQLite;
using System.Security.Cryptography;
/*
 *This Project Uses Multiple panels.Click view->other windows->document outline.
 *Then right click on panel and select BringToFront for a viewing a panel. 
  */
namespace LibraryManagementSystem
{
    



    public partial class MainForm : Form
    {
        public static class dbsettings
        {
            
            
            public static string lastView;
             public static string defaultCateg;
            public static bool usePackages;
            public static int maxBooks;
            public static string defaultPkg;
            public static bool userEnabled;
           public static  string defaultUser;
           public static  bool adminFirstUse;
           public static  int dailyFine;
           public static  int daysToIssue;
           public static  string languageList;
            public static string courseList;
            public static bool hasDelBookDetails;
            public static bool hasDelMemberDetails;
           public static  bool hasDelCategories;
           public static  bool hasDelPackages;
            
            public static void readSettings()
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Settings", con);
                SQLiteDataReader dr = cmd.ExecuteReader();
                dr.Read(); lastView= dr["Value"].ToString();
                dr.Read(); defaultCateg = dr["Value"].ToString();
                dr.Read(); usePackages =Convert.ToBoolean( dr["Value"].ToString());
                dr.Read(); maxBooks =Convert.ToInt32( dr["Value"].ToString());
                dr.Read(); defaultPkg = dr["Value"].ToString();
                dr.Read(); userEnabled =Convert.ToBoolean(dr["Value"].ToString());
                dr.Read(); defaultUser = dr["Value"].ToString();
                dr.Read(); adminFirstUse =Convert.ToBoolean( dr["Value"].ToString());
                dr.Read(); dailyFine =Convert.ToInt32( dr["Value"].ToString());
                dr.Read(); daysToIssue = Convert.ToInt32(dr["Value"].ToString());
                dr.Read(); languageList = dr["Value"].ToString();
                dr.Read(); courseList = dr["Value"].ToString();
                dr.Read(); hasDelBookDetails =Convert.ToBoolean( dr["Value"].ToString());
                dr.Read(); hasDelMemberDetails =Convert.ToBoolean( dr["Value"].ToString());
                dr.Read(); hasDelCategories =Convert.ToBoolean( dr["Value"].ToString());
                dr.Read(); hasDelPackages = Convert.ToBoolean(dr["Value"].ToString());
                               
            }
            public static void writeSettings()
            {
                SQLiteCommand cmd = new SQLiteCommand(con);
              string   cmdtext;
                cmdtext =String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",lastView,"lastView");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",defaultCateg,"defaultCateg");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';", usePackages, "usePackages");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",maxBooks,"maxBooks");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",defaultPkg,"defaultPkg");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",userEnabled,"userEnabled");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",defaultUser,"defaultUser");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",adminFirstUse,"adminFirstUse");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",dailyFine,"dailyFine");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",daysToIssue,"daysToIssue");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",languageList,"languageList");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",courseList,"courseList");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",hasDelBookDetails,"hasDelBookDetails");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",hasDelMemberDetails,"hasDelMemberDetails");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",hasDelCategories,"hasDelCategories");
                cmdtext+=String.Format("UPDATE Settings SET Value='{0}' WHERE Name='{1}';",hasDelPackages,"hasDelPackages");


                cmd.CommandText = cmdtext;
                cmd.ExecuteNonQuery();
            }
        }

        object retvalpdf = null;

        public static DataGridViewCellStyle ds;
        public static DataGridViewCellStyle al;
        public Panel prevpanel;
        public static string newmid;
        public static string msg;
        public static string globalstrLoggedUser;
        public static string globalstrLoggedUserType;
        public static string gtitle, gauthor, gpages, gpublisher, glang, gisbn, gdesc, gpubyear = "";
        public static Image gimg = null;
      public static  BooksAPIForm bform = null;
        Color init = Color.DarkBlue;
        // Color clkd = Color.DarkSeaGreen;
        Color clkd = Color.DarkGreen;
        Glass.GlassButton clickedButton = new GlassButton();

        //static string cur = Environment.CurrentDirectory;
        //old- gives-warning- Environment.SpecialFolder.ApplicationData 
        //c:\programdata folder.gives readonly file error- Environment.SpecialFolder.CommonApplicationData
      //  public static string datafolder =Environment.ExpandEnvironmentVariables(@"%systemdrive%\ProgramData\LibraryManagementSystem");
        public static string datafolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LibraryManagementSystem");
     public static string dbname=Properties.Settings.Default.defaultdb;
        static string connstr = "Data Source="+datafolder+@"\"+dbname+";Version=3";
        public static SQLiteConnection con = new SQLiteConnection(connstr);
        public static SQLiteCommand cmd = new SQLiteCommand(MainForm.con);


        //Global variables



        byte[] byteArrayMBimage = null;


        string selectallbooks = "SELECT BookID,Title,Author,Category,Publisher,Language,Year,Price,Pages,Shelf,DateAdded,Type,Available FROM BookDetails ";
        public MainForm()
        {
            InitializeComponent();
           // MessageBox.Show(connstr);

           // MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));

        }
        private void loadlang()
        {
            string langs = dbsettings.languageList;
            if (string.IsNullOrEmpty(langs.Trim()))
                return;

            string[] langarray = langs.Split(',');
            comboMBlang.Items.Clear();
            foreach (string item in langarray)
            {
                comboMBlang.Items.Add(item);
            }

            if (comboMBlang.Items.Count > 0)
                comboMBlang.SelectedIndex = 0;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlAddCateg.Hide();
            ds = gridviewExplore.DefaultCellStyle;
            al = gridviewExplore.AlternatingRowsDefaultCellStyle;

        dataGridID.DefaultCellStyle= ds;
        dataGridID.AlternatingRowsDefaultCellStyle =al;
      

            prevpanel = panelExplore;
            panelExplore.Hide();
            panelExtraMenu.Hide();
            panelIssueDetails.Hide();
            panelIssueSubmit.Hide();
            panelManageBooks.Hide();
            panelManageMembers.Hide();
            panelBookDetails.Hide();

            dbsettings.readSettings();
            
            loadlang();
            treeViewExplore.Nodes.Add("nodeCateg", "Categories");
          
            bool BDhasdel = dbsettings.hasDelBookDetails;
            int bookid =readonlyNextID(BDhasdel, "BookDetails");
            textMBbid.Text = bookid.ToString();

            if (globalstrLoggedUserType == "User")
            {
                btnMenuPackages.Enabled = false;
                btnMenuUsers.Enabled = false;
                btnMenuExport.Enabled = false;


            }
          //  if (dbsettings.userEnabled == false)
            //    btnMenuUserDetails.Enabled = false;
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT COUNT(*) FROM UserDetails";
            string c = cmd.ExecuteScalar().ToString();
            if (c == "0")
            {
                btnMenuUserDetails.Enabled = false;

            }

            pnlISshow.Hide();
            BDlabelenlarge.Text = "";
            this.Activate();

            //Form Load-Connection Open
            //   con.Open();

            //Make treeViewExplore
          //  treeViewExplore.Nodes.Add("nodeAll", "All");
          //  treeViewExplore.Nodes.Add("nodeCateg", "Categories");
         //   treeViewExplore.Nodes["nodeCateg"].Tag = "noContentNode";



            //load category and fill grid
            loadCategory();

            // int r=fillGrid(selectallbooks+" ORDER BY Title");


            //load ExploreBooks search combobox
            comboSearchFields.SelectedIndex = 0;
            panelIScontainer.Hide();
            MBcombobtype.SelectedIndex = 0;
            
            if(comboMBlang.Items.Count!=0)
            comboMBlang.SelectedIndex = 0;


            //Issuedetails click 
            btnIDisudet_Click(null, null);

            //Managemembers 
            viewall(10);

            comboMMfields.SelectedIndex = 0;

            comboMBcateg.SelectedItem = dbsettings.defaultCateg;
       
            comboIDfield.SelectedIndex = 0;

            
            textMBdateadd.Text = DateTime.Today.ToString("dd/MM/yyyy");
            labelBDavail.Text = "";

            comboBDid.SelectedIndex = 0;
           
        }
        private void UserValidate()
        {
            /*  if (globalstrLoggedUserType != "a")
          {
              btnMBdelete.Enabled = false;
          }
          else 
          {
              btnMBdelete.Enabled = true;
          }*/
        }
        private int fillGrid(string cmdtext)
        {
            SQLiteCommand com = new SQLiteCommand(cmdtext, con);
            SQLiteDataReader dtr;
            dtr = com.ExecuteReader();
            DataTable tableExplore = new DataTable();

            tableExplore.Load(dtr);
            dtr.Close();

            gridviewExplore.DataSource = tableExplore;

            return tableExplore.Rows.Count;
        }

        private void loadCategory()
        {
            

            SQLiteCommand cmd = new SQLiteCommand("select Category from Categories", con);
            SQLiteDataReader dr = cmd.ExecuteReader();
          treeViewExplore.Nodes["nodeCateg"].Nodes.Clear();
            

            comboMBcateg.Items.Clear();
            while (dr.Read())
            {
                treeViewExplore.Nodes["nodeCateg"].Nodes.Add(dr[0].ToString());
               
                comboMBcateg.Items.Add(dr[0].ToString());
            }
            treeViewExplore.ExpandAll();
            dr.Close();
        }

        private void treeViewExplore_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewExplore.SelectedNode == null)
            {
                return;
            }
            if (treeViewExplore.SelectedNode.Text=="Categories")
            {
                return;
            }
            TreeNode selnode = treeViewExplore.SelectedNode;
            int res = 0;
    
                    res = fillGrid(string.Format(selectallbooks + " where Category='{0}' ORDER BY BookID", selnode.Text));
                if (res == 0)
                {
                    lblStatus.Text = "No Books to Display in the Category " + selnode.Text;
                }
                else
                {
                    lblStatus.Text = "Displaying " + res + " Books in the Category " + selnode.Text;
                }
           
            

        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchterm;
            string selectcmd;
            searchterm = textSearchTerm.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(searchterm))
            {
                lblStatus.Text = "Enter a Search Term for Searching Books.";
                return;
            }

            selectcmd = string.Format(selectallbooks + " where REPLACE({0}, ' ', '') LIKE('%{1}%')", comboSearchFields.Text, searchterm);
            SQLiteCommand cmd = new SQLiteCommand(selectcmd, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridviewExplore.DataSource = dt;


                lblStatus.Text = string.Format("Displaying {2} Search Results for ' {0} ' in {1} of Books.", searchterm, comboSearchFields.Text, dt.Rows.Count);
            }
            else
            {

                gridviewExplore.DataSource = null;
                lblStatus.Text = lblStatus.Text = string.Format("No Search Results for ' {0} ' in {1} of Books.", searchterm, comboSearchFields.Text);

            }
            dr.Close();

        }

        private void btnBDok_Click(object sender, EventArgs e)
        {
            bookdetailsFill(textBDbookidok.Text);
        }

        private void bookdetailsFill(string bookid)
        {
            string available = "False";

            object retval = null;
           

            byte[] img = null;
            string haspdf = "false";
            string price = "";
            if (String.IsNullOrEmpty(bookid.Trim()))
            {
                MessageBox.Show("Please Enter Book ID or Book No.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBDbookidok.Clear();
                return;
            }
            string cmdtext;
            if(comboBDid.Text=="Book ID")
            cmdtext = String.Format("select * from BookDetails where BookID='{0}';", bookid);
            else
            cmdtext = String.Format("select * from BookDetails where BookNo='{0}';", bookid);

            SQLiteCommand cmd = new SQLiteCommand(cmdtext, con);
          
            SQLiteDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                MessageBox.Show("Book not found.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBDbookidok.Clear();
                dr.Close();
                return;
            }

            while (dr.Read())
            {

                textBDbookid.Text = dr["BookID"].ToString();
                textBDbookno.Text = dr["BookNo"].ToString();
                textBDisbn.Text = dr["ISBN"].ToString();
                textBDtitle.Text = dr["Title"].ToString();
                textBDauthor.Text = dr["Author"].ToString();
                textBDcateg.Text = dr["Category"].ToString();
                textBDdescription.Text = dr["Description"].ToString();
                textBDyear.Text = dr["Year"].ToString();
                textBDpublisher.Text = dr["Publisher"].ToString();
                textBDlang.Text = dr["Language"].ToString();
                price = dr["Price"].ToString();
                textBDpages.Text = dr["Pages"].ToString();
                textBDshelf.Text = dr["Shelf"].ToString();
                textBDtype.Text = dr["Type"].ToString();
                textBDdateadded.Text = dr["DateAdded"].ToString();
                retval = dr["Image"];
                retvalpdf = dr["Ebook"];
                haspdf = dr["HasPdf"].ToString();
                available = dr["Available"].ToString();

            }



            if (available == "True")
            {
                labelBDavail.Text = "This Book is Available";
                labelBDavail.ForeColor = Color.Green;
                btnBDissuedet.Hide();


            }
            else
            {

                labelBDavail.Text = "This Book is not Available";
                labelBDavail.ForeColor = Color.Red;
                btnBDissuedet.Show();

            }





            textBDbookidok.Clear();
            if (!(retval is DBNull))
            {
                picBookCover.Show();
                img = (byte[])retval;
       
                System.IO.MemoryStream myMemoryStream = new System.IO.MemoryStream(img);
                System.Drawing.Image myImage = System.Drawing.Image.FromStream(myMemoryStream);
                picBookCover.Image = myImage;
                MBpicboxsetsizemode(picBookCover);
                if (picBookCover.SizeMode == PictureBoxSizeMode.Zoom)
                    BDlabelenlarge.Text = "Click to Enlarge";
                else
                    BDlabelenlarge.Text = "";

            }
            else
            {
             
                picBookCover.Hide();
                BDlabelenlarge.Text = "";
            }
            //Read Pdf
           // MessageBox.Show(haspdf);
            if (haspdf == "True")
            {
                btnBDviewebook.Show();
                btnBDebookfolder.Show();


            }
            else
            {
                btnBDviewebook.Hide();
                btnBDebookfolder.Hide();
            }

            textBDprice.Text = price;




        }

        private void gridviewExplore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBDid.SelectedIndex = 0;
            cmdBookDetails_Click(null, null);
            bookdetailsFill(gridviewExplore.SelectedRows[0].Cells["BookID"].Value.ToString());


        }

        //Glass button color change function
        private bool navigate(GlassButton newclickedbutton)
        {
            if (clickedButton == newclickedbutton)
                return false;
            clickedButton.BackColor = init;
            clickedButton.GlowColor = Color.Cyan;
            clickedButton = newclickedbutton;
            clickedButton.BackColor = clkd;
            clickedButton.GlowColor = Color.YellowGreen;
            return true;

        }


        //things to do when clicking a specific glassbutton:
        private void cmdBookDetails_Click(object sender, EventArgs e)
        {
             
            if(!navigate(cmdBookDetails))
            return;

            prevpanel.Hide();
            this.AcceptButton = btnBDok;
            panelBookDetails.Show();
            textBDbookidok.Focus();      
            prevpanel = panelBookDetails;
        
          
        }
        private void cmdExplore_Click(object sender, EventArgs e)
        {
            
            if (!navigate(cmdExplore))
                return;
          
            prevpanel.Hide();
            panelExplore.Show();
            textSearchTerm.Focus();
            prevpanel = panelExplore;
           
        }
        private void cmdIssueSubmitBook_Click(object sender, EventArgs e)
        {
            
            if (!navigate(cmdIssueSubmitBook))
                return;

            prevpanel.Hide();
            this.AcceptButton = btnISok;
            panelIssueSubmit.Show();
            textISbid.Focus();
            prevpanel = panelIssueSubmit;
          
        }
        private void cmdIssueDetails_Click(object sender, EventArgs e)
        {
          
            if (!navigate(cmdIssueDetails))
                return;

            prevpanel.Hide();
            panelIssueDetails.Show();
            textIDsearch.Focus();
            prevpanel = panelIssueDetails;
        }
        private void cmdManageBooks_Click(object sender, EventArgs e)
        {
                    
            if (!navigate(cmdManageBooks))
                return;

            prevpanel.Hide();
            panelManageBooks.Show();
            textMBisbn.Focus();    
            prevpanel = panelManageBooks;
            this.AcceptButton = btnMBadd2;

        }
        private void cmdManageMembers_Click(object sender, EventArgs e)
        {
           
            if (!navigate(cmdManageMembers))
                return;

            prevpanel.Hide();
            panelManageMembers.Show();
            textMMsearchterm.Focus();
            prevpanel = panelManageMembers;
        }



        private void MainForm_Shown(object sender, EventArgs e)
        {
            

            lblUsersStatus.Text = globalstrLoggedUser ;
            lblUserType.Text = globalstrLoggedUserType;

            string lastview = dbsettings.lastView;
            switch (lastview)
            {
                case "0": cmdExplore_Click(null, null);
                    break;
                case "1": cmdBookDetails_Click(null, null);
                    break;
                case "2": cmdIssueSubmitBook_Click(null, null);
                    break;
                case "3": cmdIssueDetails_Click(null, null);
                    break;
                case "4": cmdManageBooks_Click(null, null);
                    break;
                case "5": cmdManageMembers_Click(null, null);
                    break;
                case "6": cmdMenu_Click(null, null);
                    break;
            }
            fillGrid(selectallbooks + " ORDER BY BookID LIMIT 10 ");

        }


        private bool checksubmit(string bookid, string memid)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(BookID) from IssueDetails where BookID={0} AND MemberID={1};", bookid, memid);
            int c = Convert.ToInt32(com.ExecuteScalar());
            if (c == 0)
                return false;
            else
                return true;
        }
        private void prepareIssue()
        {
            panelIScontainer.Show();
            groupSubmit.Hide();
            groupIssue.Show();

           // textISIBissuedate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dpISIBissuedate.Value = DateTime.Today;
            int dti = dbsettings.daysToIssue;
            textISIBduedate.Text = DateTime.Today.AddDays(dti).ToString("dd/MM/yyyy");
            textISIBdays.Text = dti.ToString();
            btnISissue.Focus();

        }

        private void prepareSubmit(string bookid, string memid)
        {
            panelIScontainer.Show();
            groupIssue.Hide();
            groupSubmit.Show();
            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            com.CommandText = String.Format("select IssueDate,DueDate from IssueDetails where BookID={0} AND MemberID={1};", bookid, memid);
            dtr = com.ExecuteReader();
            dtr.Read();
            string id = dtr["IssueDate"].ToString();
            string dd = dtr["DueDate"].ToString();
            textISSBissuedate.Text = id;
            textISSBduedate.Text = dd;

            //textISSBsubmitdate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dpISSBsubmitdate.Value = DateTime.Today;
            DateTime duedate = DateTime.ParseExact(dd, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan ts = DateTime.Today - duedate;
            if (ts.Days > 0)
            {
                int dailyFine = dbsettings.dailyFine;
                int fine = ts.Days * dailyFine;
                textISSBfine.Text = fine.ToString();
                
               // MessageBox.Show("Days:" + ts.Days + "  dailyfine:" + dailyFine + "  FineTotal:" + fine);
            }
            else
            {
                textISSBfine.Text = "0";
            }
            btnISsubmitbook.Focus();
        }

        private void getMemBookDetails(string bookid, string memid)
        {

            pnlISshow.Show();



            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            com.CommandText = String.Format("select Name from MemberDetails where MemberID={0};", memid);
            string name = com.ExecuteScalar().ToString();
            textIsName.Text = name;

            com.CommandText = String.Format("select Title,Author from BookDetails where BookID={0};", bookid);
            dtr = com.ExecuteReader();
            dtr.Read();
            textIStitle.Text = dtr["Title"].ToString();
            textISauthor.Text = dtr["Author"].ToString();


        }

        private bool ISvalidate()
        {
            string bookid = textISbid.Text;
            string memid = textISmid.Text;
            string msg;

            //bookid validate
            if (String.IsNullOrEmpty(bookid.Trim()))
            {
                msg = "Please Enter Book ID.";
                MessageBox.Show(msg);
                textISbid.Clear();
                textISbid.Focus();
                return false;

            }

            //member id validate
            if (String.IsNullOrEmpty(memid.Trim()))
            {
                msg = "Please Enter Member ID.";
                MessageBox.Show(msg);
                textISmid.Clear();
                textISmid.Focus();
                return false;
            }

            //check whether book exists
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(BookID) from BookDetails where BookID={0};", bookid);
            int c = Convert.ToInt32(com.ExecuteScalar());
            if (c == 0)
            {
                MessageBox.Show("Book not found ! ID:" + bookid);
                return false;
            }

            //check whether member exists
            com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(MemberID) from MemberDetails where MemberID='{0}'", memid);
            int c1 = Convert.ToInt32(com.ExecuteScalar());
            if (c1 == 0)
            {
                MessageBox.Show("Member not found ! ID:" + memid);
                return false;
            }
            return true;

        }

        private bool bookavail(string bid)
        {
            //check for book availability.
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select Available from BookDetails where BookID={0};", bid);
            string avail = com.ExecuteScalar().ToString();
            if (avail == "False")
            {
                MessageBox.Show("The Book is not Available for Issuing.");
                return false;

            }
            return true;
        }

        private bool checkPackageLimit(string memid)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(MemberID) from SetPackages where MemberID={0} ;", memid);
            int c = Convert.ToInt32(com.ExecuteScalar());

            if (c == 0)
            {
                MessageBox.Show("This Member has not activated any Packages.\nDisable Packages for just setting a Maximum Books limit.");
                return false;
            }


            DateTime pkgst; string pkgst_txt = ""; bool foundmatchingpkg = false;
            while (true)
            {
                com.CommandText = String.Format("select count(MemberID) from SetPackages where MemberID={0} ;", memid);
                int c1 = Convert.ToInt32(com.ExecuteScalar());
                if (c1 == 0)
                    break;
                com.CommandText = String.Format("select min(StartDate) from SetPackages where MemberID={0} ;", memid);
                string stdate = com.ExecuteScalar().ToString();
                com.CommandText = String.Format("select EndDate from SetPackages where MemberID={0} AND StartDate='{1}' ;", memid, stdate);
                string endate = com.ExecuteScalar().ToString();
                DateTime end = DateTime.ParseExact(endate, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime start = DateTime.ParseExact(stdate, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime tod = DateTime.Today;
                if (tod >= start && tod <= end)
                {
                    pkgst = start;
                    pkgst_txt = stdate;
                    foundmatchingpkg = true;
                    break;

                }
                else
                {
                    com.CommandText = String.Format("DELETE from SetPackages where MemberID={0} AND StartDate='{1}'  ;", memid, stdate);
                    com.ExecuteNonQuery();

                }
            }
            if (foundmatchingpkg == false)
            {
                MessageBox.Show("The current Package has expired for this member.");
                return false;
            }
            else
            {
                com.CommandText = String.Format("select MaxBooks from SetPackages where MemberID={0} AND StartDate='{1}' ;", memid, pkgst_txt);
                int maxb = Convert.ToInt32(com.ExecuteScalar());

                com.CommandText = String.Format("select count(BookID) from IssueDetails where MemberID={0};", memid);
                int pendingbook = Convert.ToInt32(com.ExecuteScalar());

                if (pendingbook >= maxb)
                {
                    MessageBox.Show("Member has reached the maximum limit on books specified in the package");
                    return false;
                }
                else
                {
                    return true;
                }

            }




        }

        private bool checkMaxBookLimit(string mid)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(BookID) from IssueDetails where MemberID={0};", mid);
            int pendingbook = Convert.ToInt32(com.ExecuteScalar());

            if (pendingbook >= dbsettings.maxBooks)
            {
                MessageBox.Show("Member has reached the maximum limit on books.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnISok_Click(object sender, EventArgs e)
        {
            panelIScontainer.Hide();
            textISauthor.Clear(); textISbid2.Clear(); textISmid2.Clear(); textIsName.Clear();
            textIStitle.Clear();

            if (!ISvalidate())
                return;

            string bid = textISbid.Text;
            string mid = textISmid.Text;
            textISbid2.Text = bid;
            textISmid2.Text = mid;

            textISbid.Clear(); textISmid.Clear();

            if (checksubmit(bid, mid))
            {
                //code for submitting book
                getMemBookDetails(bid, mid);
                prepareSubmit(bid, mid);
            }
            else
            {
                //code for issuing book
                if (!bookavail(bid))
                {
                    
                    textISbid.Focus();
                    return;
                }

                if (dbsettings.usePackages)
                {
                    if (!checkPackageLimit(mid))
                        return;
                }
                else
                {
                    if (!checkMaxBookLimit(mid))
                        return;
                }
                getMemBookDetails(bid, mid);
                prepareIssue();
            }

            //code ends..   


        }

        private void btnBDissuedet_Click(object sender, EventArgs e)
        {
            btnIDisudet_Click(null, null);
            textIDsearch.Text = textBDbookid.Text;
            comboIDfield.SelectedIndex = 0;
            btnIDsearch_Click(null, null);
            cmdIssueDetails_Click(null, null);

        }



        private void btnISissue_Click(object sender, EventArgs e)
        {
            try
            {
            SQLiteCommand com = new SQLiteCommand(con);

            string bid = textISbid2.Text;
            string mid = textISmid2.Text;
            
                string cmdtext ="INSERT INTO IssueDetails(BookID,MemberID,IssueDate,DueDate,BookTitle,MemberName) VALUES(@bid,@mid,@id,@dd,@title,@memname); ";
                com.CommandText = cmdtext;

                com.Parameters.Add(new SQLiteParameter("@bid",bid));
                com.Parameters.Add(new SQLiteParameter("@mid",mid));
                com.Parameters.Add(new SQLiteParameter("@id",dpISIBissuedate.Value.ToString("dd/MM/yyyy")));
                com.Parameters.Add(new SQLiteParameter("@dd",textISIBduedate.Text));
                com.Parameters.Add(new SQLiteParameter("@title",textIStitle.Text));
                com.Parameters.Add(new SQLiteParameter("@memname",textIsName.Text));

                com.ExecuteNonQuery();

                cmdtext = String.Format("UPDATE BookDetails SET Available='{0}' WHERE BookID={1};", false.ToString(), bid);
                com.CommandText = cmdtext;
                com.ExecuteNonQuery();
                panelIScontainer.Hide();
                lblStatus.Text = "The Book " + bid + " was successfully issued";
                pnlISshow.Hide();
                dataGridID.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }

        }



        private void btnISIBchgdue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textISIBdays.Text))
                return;
         //   textISIBduedate.Text = DateTime.ParseExact(textISIBissuedate.Text, "dd/MM/yyyy", null).AddDays(Convert.ToInt32(textISIBdays.Text)).ToString("dd/MM/yyyy");
            textISIBduedate.Text = dpISIBissuedate.Value.AddDays(Convert.ToInt32(textISIBdays.Text)).ToString("dd/MM/yyyy");
        }

        private void btnISsubmitbook_Click(object sender, EventArgs e)
        {
            string bid = textISbid2.Text;
            string mid = textISmid2.Text;
            SQLiteCommand cmd = new SQLiteCommand(con);

            try
            {
                string fine;
                fine = textISSBfine.Text;
                string cmdtext = String.Format("DELETE FROM IssueDetails WHERE BookID={0} AND MemberID='{1}';", bid, mid);
                cmd.CommandText = cmdtext;
                cmd.ExecuteNonQuery();
                cmdtext = "INSERT INTO SubmittedBooks(BookID,MemberID,IssueDate,DueDate,SubmitDate,Fine,BookTitle,MemberName) VALUES(@bid,@mid,@id,@dd,@sd,@fine,@title,@memname);";
                cmd.CommandText = cmdtext;

                cmd.Parameters.Add(new SQLiteParameter("@bid",bid));
                cmd.Parameters.Add(new SQLiteParameter("@mid",mid));
                cmd.Parameters.Add(new SQLiteParameter("@id",textISSBissuedate.Text));
                cmd.Parameters.Add(new SQLiteParameter("@dd",textISSBduedate.Text));
                cmd.Parameters.Add(new SQLiteParameter("@sd",dpISSBsubmitdate.Value.ToString("dd/MM/yyyy")));
                cmd.Parameters.Add(new SQLiteParameter("@fine",fine));
                cmd.Parameters.Add(new SQLiteParameter("@title",  textIStitle.Text));
                cmd.Parameters.Add(new SQLiteParameter("@memname", textIsName.Text));

                cmd.ExecuteNonQuery();

                cmdtext = String.Format("UPDATE BookDetails SET Available='{0}' WHERE BookID={1};", true.ToString(), bid);
                cmd.CommandText = cmdtext;
                cmd.ExecuteNonQuery();
                panelIScontainer.Hide();
                pnlISshow.Hide();
                lblStatus.Text = "The Book " + bid + " was successfully Submitted";


                btnIDextendDD.Hide();
                btnIDsubmitbook.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Opacity = 0.7;
            
            if (clickedButton.Tag != null)
                dbsettings.lastView= clickedButton.Tag.ToString();
           
            dbsettings.writeSettings();
        }

        private void btnIDsubdet_Click(object sender, EventArgs e)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            btnIDsubdet.BackColor = Color.LightBlue;
            btnIDisudet.BackColor = Color.WhiteSmoke;

            labelIDfine.Show();
            labelIDsubd.Show();
            textIDfine.Show();
            textIDsubdate.Show();


            btnIDextendDD.Hide();
            btnIDsubmitbook.Hide();

            string cmdtext = "select BookID,MemberID,BookTitle,MemberName,IssueDate,DueDate,SubmitDate,Fine from SubmittedBooks; ";
            com.CommandText = cmdtext;
            dtr = com.ExecuteReader();
            if (dtr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dtr.Close();
                dataGridID.DataSource = dt;

                textIDbid.Text = dataGridID.SelectedRows[0].Cells["BookID"].Value.ToString();
                textIDmid.Text = dataGridID.SelectedRows[0].Cells["MemberID"].Value.ToString();
                textIDtitle.Text = dataGridID.SelectedRows[0].Cells["BookTitle"].Value.ToString();
                textIDname.Text = dataGridID.SelectedRows[0].Cells["MemberName"].Value.ToString();
                textIDidate.Text = dataGridID.SelectedRows[0].Cells["IssueDate"].Value.ToString();



                DateTime dta = Convert.ToDateTime(dataGridID.SelectedRows[0].Cells["DueDate"].Value.ToString(), System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);

                textIDdd.Text = dta.ToString("dd/MM/yyyy");

                textIDsubdate.Text = dataGridID.SelectedRows[0].Cells["SubmitDate"].Value.ToString();
                textIDfine.Text = dataGridID.SelectedRows[0].Cells["Fine"].Value.ToString();

                dataGridID.Show();
                lblStatus.Text = "List of Books which were Submitted Successfully.";
            }
            else
            {
                dataGridID.Hide();
                lblStatus.Text = "Submitted Books is Empty.";
            }
            dtr.Close();
        }
        private void btnIDisudetFillGrid()
        {

        }
        private void btnIDisudet_Click(object sender, EventArgs e)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            btnIDisudet.BackColor = Color.LightBlue;
            btnIDsubdet.BackColor = Color.WhiteSmoke;
            labelIDfine.Hide();
            labelIDsubd.Hide();
            textIDfine.Hide();
            textIDsubdate.Hide();


            btnIDsubmitbook.Show();
            btnIDextendDD.Show();


            string cmdtext = "select BookID,MemberID,BookTitle,MemberName,IssueDate,DueDate from IssueDetails; ";
            com.CommandText = cmdtext;
            dtr = com.ExecuteReader();
            if (dtr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dtr.Close();

                dataGridID.DataSource = dt;

                textIDbid.Text = dataGridID.SelectedRows[0].Cells["BookID"].Value.ToString();
                textIDmid.Text = dataGridID.SelectedRows[0].Cells["MemberID"].Value.ToString();
                textIDtitle.Text = dataGridID.SelectedRows[0].Cells["BookTitle"].Value.ToString();
                textIDname.Text = dataGridID.SelectedRows[0].Cells["MemberName"].Value.ToString();
                textIDidate.Text = dataGridID.SelectedRows[0].Cells["IssueDate"].Value.ToString();

                DateTime dta = Convert.ToDateTime(dataGridID.SelectedRows[0].Cells["DueDate"].Value.ToString(), System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);

                textIDdd.Text = dta.ToString("dd/MM/yyyy");



                dataGridID.Show();
                lblStatus.Text = "List of Books which were Issued but not Submitted.";
            }
            else
            {

                btnIDsubmitbook.Hide();
                dataGridID.Hide();
                lblStatus.Text = "Issued Books is Empty.";
            }

        }

        private void dataGridID_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textIDbid.Text = dataGridID.SelectedRows[0].Cells["BookID"].Value.ToString();
            textIDmid.Text = dataGridID.SelectedRows[0].Cells["MemberID"].Value.ToString();
            textIDtitle.Text = dataGridID.SelectedRows[0].Cells["BookTitle"].Value.ToString();
            textIDname.Text = dataGridID.SelectedRows[0].Cells["MemberName"].Value.ToString();
            textIDidate.Text = dataGridID.SelectedRows[0].Cells["IssueDate"].Value.ToString();

            DateTime dt = Convert.ToDateTime(dataGridID.SelectedRows[0].Cells["DueDate"].Value.ToString(), System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);

            // dateIDdd.Value = dt;
            textIDdd.Text = dt.ToString("dd/MM/yyyy");
            if (btnIDsubdet.BackColor == Color.LightBlue)
            {

                textIDsubdate.Text = dataGridID.SelectedRows[0].Cells["SubmitDate"].Value.ToString();
                textIDfine.Text = dataGridID.SelectedRows[0].Cells["Fine"].Value.ToString();
            }

        }

        private void btnIDchdate_Click(object sender, EventArgs e)
        {



        }




        private void btnMBeditdel_Click(object sender, EventArgs e)
        {
            frmEditBook eb = new frmEditBook();
            eb.ShowDialog();

            bool BDhasdel = dbsettings.hasDelBookDetails;
            int bookid = readonlyNextID(BDhasdel, "BookDetails");
            textMBbid.Text = bookid.ToString();
        }

        private void btnMBadd2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMBtitle.Text))
            {
                MessageBox.Show("Enter Title");
                return;
            }
            if (MBcombobtype.Text != "Hardcopy Only" && textMBpdfurl.Text == "")
            {
                MessageBox.Show("Select pdf file");
                return;
            }
            string price = null;
            if (string.IsNullOrEmpty(textMBprice.Text.Trim()) != true)
            {
                price = textMBprice.Text.Trim();
            }
            
            bool BDhasdel = dbsettings.hasDelBookDetails;
            int bookid =getNextID(BDhasdel, "BookDetails");
            string haspdf;
            if (String.IsNullOrEmpty(textMBpdfurl.Text))
            {
                haspdf = "False";
            }
            else
            {
                haspdf = "True";
            }

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM BookDetails WHERE Title = @Title AND ISBN = @ISBN", con);
            cmd.Parameters.AddWithValue("@Title", textMBtitle.Text);
            cmd.Parameters.AddWithValue("@ISBN", textMBisbn.Text);

            SQLiteDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("Ya existe un libro con ese título y número ISBN. Inténtelo nuevamente con otra combinación.");
                return;
            }

            //while (dr.Read())
            //{
            //    if(dr.HasRows)
            //}

            SQLiteCommand comm = new SQLiteCommand(con);
            string cmdtext = @"INSERT INTO BookDetails
(BookID,BookNo,ISBN,Title,Author,Description,Category,Publisher,Language,
Year,Pages,Shelf,DateAdded,Type,Available,Price,HasPdf)
VALUES(@bid,@bookno,@isbn,@title,@author,@desc,@categ,@pub,@lang,
@year,@pages,@shelf,@date,@type,@avail,@price,@haspdf);";

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
            comm.Parameters.Add(new SQLiteParameter("@price", textMBprice.Text));
            comm.Parameters.Add(new SQLiteParameter("@haspdf", haspdf));


            comm.ExecuteNonQuery();



            if (byteArrayMBimage != null)
            {

                comm.CommandText = string.Format("UPDATE BookDetails SET Image=@Picture WHERE BookID={0};", bookid);
                comm.Connection = con;
                comm.Parameters.Add("@Picture", System.Data.DbType.Binary);
                comm.Parameters["@Picture"].Value = byteArrayMBimage;
                comm.ExecuteNonQuery();

            }
            if (!String.IsNullOrEmpty(textMBpdfurl.Text))
            {
              /*  string fileName = bookid.ToString() + ".pdf"; 
                string source = textMBpdfurl.Text;
                //string cur = Environment.CurrentDirectory + @"\Ebooks";
                string cur =datafolder + @"\Ebooks";

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

            lblStatus.Text = "The Book '" + textMBtitle.Text + "' ID: " + bookid + " was ADDED successfully. " + "ADD another Book ..";
            btnMBclear_Click(null, null);



        }


        public static int getNextID(bool hasdeleted, string tablename)
        {
            int id;
            int count;
            SQLiteCommand com = new SQLiteCommand(con);
            try
            {
                com.CommandText = String.Format("select count(*) from {0}", tablename);
                count = Convert.ToInt32(com.ExecuteScalar());
                if (count == 0)
                {
                    id = 1;
                }
                else
                {
                    if (hasdeleted == true)
                    {

                        com.CommandText = String.Format("select count(deletedID) from DeletedID where tablename='{0}'", tablename);
                        int delcount = Convert.ToInt32(com.ExecuteScalar());
                        if (delcount == 0)
                        {
                            id = Convert.ToInt32(count) + 1;
                            switch (tablename)
                            {
                                case "BookDetails":
                                    dbsettings.hasDelBookDetails = false;
                                    break;
                                case "MemberDetails":
                                    dbsettings.hasDelMemberDetails = false;
                                    break;
                                case "Categories":
                                    dbsettings.hasDelCategories = false;
                                    break;
                                case "Packages":
                                    dbsettings.hasDelPackages = false;
                                    break;

                            }
                          
                            return id;
                        }

                        com.CommandText = String.Format("select min(deletedID) from DeletedID where tablename='{0}'", tablename);
                        id = Convert.ToInt32(com.ExecuteScalar());
                        com.CommandText = String.Format("delete from DeletedID where tablename='{0}' and DeletedID={1}", tablename, id);
                        com.ExecuteNonQuery();

                    }
                    else
                    {
                        id = Convert.ToInt32(count) + 1;
                    }


                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while generating next id :" + ex.Message + "\n Source :" + ex.Source);
                return 1;
            }

        }

        //no delete from deletedid table
        public static int readonlyNextID(bool hasdeleted, string tablename)
        {
            int id;
            int count;
            SQLiteCommand com = new SQLiteCommand(con);
            try
            {
                com.CommandText = String.Format("select count(*) from {0}", tablename);
                count = Convert.ToInt32(com.ExecuteScalar());
                if (count == 0)
                {
                    id = 1;
                }
                else
                {
                    if (hasdeleted == true)
                    {

                        com.CommandText = String.Format("select count(deletedID) from DeletedID where tablename='{0}'", tablename);
                        int delcount = Convert.ToInt32(com.ExecuteScalar());
                        if (delcount == 0)
                        {
                            id = Convert.ToInt32(count) + 1;
                            return id;
                        }

                        com.CommandText = String.Format("select min(deletedID) from DeletedID where tablename='{0}'", tablename);
                        id = Convert.ToInt32(com.ExecuteScalar());
                       // com.CommandText = String.Format("delete from DeletedID where tablename='{0}' and DeletedID={1}", tablename, id);
                        //com.ExecuteNonQuery();

                    }
                    else
                    {
                        id = Convert.ToInt32(count) + 1;
                    }


                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while generating next id :" + ex.Message + "\n Source :" + ex.Source);
                return 1;
            }

        }

        private void MBclear()
        {
            foreach (Control c in panelManageBooks.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == "textMBshelf")
                        continue;
                    c.Text = "";

                }
            }
            labelMBpicsize.Hide();
            textMBdateadd.Text = DateTime.Today.ToString("dd/MM/yyyy");

            byteArrayMBimage = null;

            pictureMB.Image = null;
            comboMBcateg.SelectedItem = dbsettings.defaultCateg;
            bool BDhasdel = dbsettings.hasDelBookDetails;
            int bookid =readonlyNextID(BDhasdel, "BookDetails");
            textMBbid.Text = bookid.ToString();
        }



        private void btnMBeditsave_Click(object sender, EventArgs e)
        {


        }

        private void btnMBopenfile_Click(object sender, EventArgs e)
        {
            try
            {

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
                if (pictureMB.SizeMode != PictureBoxSizeMode.CenterImage)
                    labelMBenlarge.Text = "Click to Enlarge";
                else
                    labelMBenlarge.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with opening file :" + ex.Message);
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
        public static void MBpicboxsetsizemode(PictureBox pic)
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
        private void picBookCover_Click(object sender, EventArgs e)
        {
            if (picBookCover.Image == null)
                return;
            if (picBookCover.Dock == DockStyle.Fill)
            {
               
                picBookCover.Dock = DockStyle.None;
                
                MBpicboxsetsizemode(picBookCover);
             
                return;
            }
            if (picBookCover.SizeMode == PictureBoxSizeMode.Zoom)
            {
                
                picBookCover.Dock = DockStyle.Fill;
               
                MBpicboxsetsizemode(picBookCover);
                
                
            }




        }



        private void pictureMB_Paint(object sender, PaintEventArgs e)
        {

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
                    return;

                FileInfo fiImage = new FileInfo(strFn);
                imageFileLength = fiImage.Length;


                textMBpdfurl.Text = strFn;
                labelMBpdfsize.Text = "Size : " + Convert.ToString(Math.Round(imageFileLength / 1024.00, 2)) + " KB ";

                openFileDialogMBpic.Filter = "";
                openFileDialogMBpic.FileName = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void pictureMB_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMBopenfile_Click_1(object sender, EventArgs e)
        {

        }

        private void MBcombobtype_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnMBgbooksapi_Click(object sender, EventArgs e)
        {
            /*
            if (bform == null)
            {
                bform = new BooksAPIForm();

            }*/
            bform = new BooksAPIForm();
            bform.ShowDialog();
            textMBtitle.Text = gtitle;
            textMBauthor.Text = gauthor;
            textMBdesc.Text = gdesc;
            textMBpub.Text = gpublisher;
            textMBpage.Text = gpages;
            textMByear.Text = gpubyear;
            textMBisbn.Text = gisbn;
            if (gimg != null)
            {
                pictureMB.Image = gimg;

                MemoryStream ms = new MemoryStream();
                gimg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byteArrayMBimage = ms.ToArray();

                MBpicboxsetsizemode(pictureMB);
            }
            if (pictureMB.SizeMode != PictureBoxSizeMode.CenterImage)
                labelMBenlarge.Text = "Click to Enlarge";
            else
                labelMBenlarge.Text = "";
        }



        private void textMBenterbid_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnMBeditdel;
        }



        private void btnMBdelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBDviewebook_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] pdfba = null;
            if (!(retvalpdf is DBNull))
            {                
                pdfba = (byte[])retvalpdf;
                

                string fpath;
                fpath = @"\Ebooks\" + textBDbookid.Text + ".pdf";
                //fpath = AppDomain.CurrentDomain.BaseDirectory + fpath;
                fpath = datafolder + fpath;

                File.WriteAllBytes(fpath, pdfba);

                System.Diagnostics.Process.Start(fpath);
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* private void btnBDopenpdffolder_Click(object sender, EventArgs e)
        {
            string fpath = @"DownloadedEbooks\" + textBDtitle.Text + " " + textBDbookid.Text + ".pdf";
            string arg = "/select, " + AppDomain.CurrentDomain.BaseDirectory + fpath;

            System.Diagnostics.Process.Start("explorer.exe", arg);
        }*/

        private void panelManageMembers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMMadd_Click(object sender, EventArgs e)
        {
            frmAddMem add = new frmAddMem();



            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK && dbsettings.usePackages==true)
            {
                frmSetPackage.openwithmid = newmid;
                frmSetPackage pk = new frmSetPackage();
                pk.ShowDialog();
            
            }

            btnMMviewall_Click(null, null);

            
        }


        private void btnMMviewall_Click(object sender, EventArgs e)
        {
            viewall(0);
        }

        private void viewall(int limit)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            SQLiteDataReader dr;

            if(limit==0)
            cmd.CommandText = "SELECT MemberID,Name,Course,AdmissionYear,RollNo,PhoneNumber,Dob,Email from MemberDetails ORDER BY MemberID";
            else
                cmd.CommandText = "SELECT MemberID,Name,Course,AdmissionYear,RollNo,PhoneNumber,Dob,Email from MemberDetails ORDER BY MemberID limit "+limit.ToString();


            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridMM.DataSource = dt;



                lblStatus.Text = "Displaying Details of All " + dt.Rows.Count + " Library Members.";
            }
            else
            {


                lblStatus.Text = "Member Details is Empty.";
                dataGridMM.DataSource = null;
            }
            dr.Close();
        }
        private void mmsearch()
        {
            string searchterm;
            string selectcmd;
            try
            {
                searchterm = textMMsearchterm.Text;
                if (string.IsNullOrEmpty(searchterm))
                {
                    lblStatus.Text = "Enter a Search Term for Searching Library Members.";
                    return;
                }
                selectcmd = string.Format("select MemberID,Name,Course,AdmissionYear,RollNo,PhoneNumber,Dob,Email from MemberDetails where {0} LIKE('%{1}%')", comboMMfields.Text, searchterm);
                SQLiteCommand cmd = new SQLiteCommand(selectcmd, con);
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridMM.DataSource = dt;



                    lblStatus.Text = string.Format("Displaying {2} Search Results for ' {0} ' in {1} of Library Members.", searchterm, comboMMfields.Text, dt.Rows.Count);
                }
                else
                {

                    dataGridMM.DataSource = null;
                    lblStatus.Text = lblStatus.Text = string.Format("No Search Results for '{0}' in {1} of Library Members.", searchterm, comboMMfields.Text);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnMMsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void textMMsearchterm_Click(object sender, EventArgs e)
        {
            
        }
        private void idsearch()
        {
            try
            {
                string searchterm;
                string selectcmd;

                searchterm = textIDsearch.Text;
                if (string.IsNullOrEmpty(searchterm))
                {
                    lblStatus.Text = "Enter a Search Term for Searching Library Users.";
                    return;
                }

                if (btnIDisudet.BackColor == Color.LightBlue)
                {
                    selectcmd = string.Format("select * from IssueDetails where {0} LIKE('%{1}%')", comboIDfield.Text, searchterm);
                }
                else
                {
                    selectcmd = string.Format("select * from SubmittedBooks where {0} LIKE('%{1}%')", comboIDfield.Text, searchterm);

                }
                SQLiteCommand cmd = new SQLiteCommand(con);
                SQLiteDataReader dr;
                cmd.CommandText = selectcmd;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridID.DataSource = dt;

                    textIDbid.Text = dataGridID.SelectedRows[0].Cells["BookID"].Value.ToString();
                    textIDmid.Text = dataGridID.SelectedRows[0].Cells["MemberID"].Value.ToString();
                    textIDtitle.Text = dataGridID.SelectedRows[0].Cells["BookTitle"].Value.ToString();
                    textIDname.Text = dataGridID.SelectedRows[0].Cells["MemberName"].Value.ToString();
                    textIDidate.Text = dataGridID.SelectedRows[0].Cells["IssueDate"].Value.ToString();


                    textIDdd.Text = dataGridID.SelectedRows[0].Cells["DueDate"].Value.ToString();

                    if (btnIDsubdet.BackColor == Color.LightBlue)
                    {

                        textIDsubdate.Text = dataGridID.SelectedRows[0].Cells["SubmitDate"].Value.ToString();
                        textIDfine.Text = dataGridID.SelectedRows[0].Cells["Fine"].Value.ToString();
                    }

                }
                else
                {


                    lblStatus.Text = lblStatus.Text = "No Search Results .";
                    dataGridID.DataSource = null;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnIDsearch_Click(object sender, EventArgs e)
        {

            
            
        }

        private void btnBDIssueSub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBDbookid.Text))
            {
                return;
            }

            textISbid.Text = textBDbookid.Text;
            cmdIssueSubmitBook_Click(null, null);
        }


        private void textIDsearch_Enter(object sender, EventArgs e)
        {
           
        }


        private void btnBDManage_Click(object sender, EventArgs e)
        {
            //textMBenterbid.Text = textBDbookid.Text;
            frmEditBook.bid = textBDbookid.Text;
            frmEditBook eb = new frmEditBook();
            eb.ShowDialog();

            bool BDhasdel = dbsettings.hasDelBookDetails;
            int bookid =readonlyNextID(BDhasdel, "BookDetails");
            textMBbid.Text = bookid.ToString();
        }

        private void btnIDsubmitbook_Click(object sender, EventArgs e)
        {
            textISbid.Text = textIDbid.Text;
            textISmid.Text = textIDmid.Text;
            btnISok_Click(null, null);
            cmdIssueSubmitBook_Click(null, null);
        }

        private void dataGridID_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnIDisudet.BackColor == Color.LightBlue)
                btnIDsubmitbook_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnEBviewall_Click(object sender, EventArgs e)
        {
            int res=fillGrid(selectallbooks + " ORDER BY BookID ");
            lblStatus.Text = "Displaying All " + res + " Books ";
        }


        private void treeViewExplore_Click(object sender, EventArgs e)
        {



        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("width:" + this.Width.ToString() + "height:" + this.Height.ToString());

        }


        private void explore_Search()
        {
            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            string searchterm;
            string selectcmd;
            searchterm = textSearchTerm.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(searchterm))
            {
                lblStatus.Text = "Enter a Search Term for Searching Books.";
                return;
            }
            selectcmd = string.Format(selectallbooks + " where REPLACE({0}, ' ', '') LIKE('%{1}%')", comboSearchFields.Text, searchterm);
            com.CommandText = selectcmd;
            dtr = com.ExecuteReader();
            if (dtr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dtr.Close();
                gridviewExplore.DataSource = dt;


                lblStatus.Text = string.Format("Displaying {2} Search Results for ' {0} ' in {1} of Books.", searchterm, comboSearchFields.Text, dt.Rows.Count);
            }
            else
            {

                gridviewExplore.DataSource = null;
                lblStatus.Text = lblStatus.Text = string.Format("No Search Results for ' {0} ' in {1} of Books.", searchterm, comboSearchFields.Text);

            }

        }
        private void textSearchTerm_TextChanged(object sender, EventArgs e)
        {
            explore_Search();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmdMenu_Click(object sender, EventArgs e)
        {


            if (!navigate(cmdMenu))
                return;
            panelExtraMenu.Show();
            prevpanel.Hide();
            prevpanel = panelExtraMenu;


        }



        private void btnMMdetails_Click(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;

            frmMemberDetails.openwithmid = dataGridMM.SelectedRows[0].Cells["MemberID"].Value.ToString();
            frmMemberDetails md = new frmMemberDetails();
            md.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;

            frmSetPackage.openwithmid = dataGridMM.SelectedRows[0].Cells["MemberID"].Value.ToString();
            frmSetPackage pf = new frmSetPackage();
            pf.ShowDialog();
            lblStatus.Text = msg;
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;
            frmEditMembers.openwithmid = dataGridMM.SelectedRows[0].Cells["MemberID"].Value.ToString();
            frmEditMembers em = new frmEditMembers();
            em.ShowDialog();
            btnMMviewall_Click(null, null);
        }

        private void btnMenuAbout_Click(object sender, EventArgs e)
        {
            SplashForm.focusclose = true;
            SplashForm sf = new SplashForm();
            sf.Show();
        }

        private void btnMenuCateg_Click(object sender, EventArgs e)
        {
          
           // MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            frmCategories cat = new frmCategories();
            cat.ShowDialog();
            loadCategory();
            if (string.IsNullOrEmpty(dbsettings.defaultCateg))
            {
                if(comboMBcateg.Items.Count!=0)
                comboMBcateg.SelectedIndex = 0;
            }
            else
            {
                comboMBcateg.SelectedItem = dbsettings.defaultCateg;
            }

        }

        private void btnMBclear_Click(object sender, EventArgs e)
        {
            MBclear();
        }


        private void btnMenuLang_Click(object sender, EventArgs e)
        {
            frmLang la = new frmLang();
            la.ShowDialog();
            loadlang();

        }

        private void btnMenuPackages_Click(object sender, EventArgs e)
        {
            frmPackages pkg = new frmPackages();
            pkg.ShowDialog();
        }

        private void btnMenuUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers mu = new frmManageUsers();
            mu.ShowDialog();
        }

        private void dataGridID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateIDdd_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMenuUserDetails_Click(object sender, EventArgs e)
        {
            //frmUserDetails ud = new frmUserDetails();
            //ud.ShowDialog();

            using (var ud = new frmUserDetails())
            {
                if (ud.ShowDialog() != DialogResult.OK)
                    return;
            }
        }

        private void dataGridMM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridMM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;

            frmMemberDetails.openwithmid = dataGridMM.SelectedRows[0].Cells["MemberID"].Value.ToString();
            frmMemberDetails md = new frmMemberDetails();
            md.Show();
        }

        private void dataGridMM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void btnMenuOptions_Click(object sender, EventArgs e)
        {
            frmOptions opt = new frmOptions();
            opt.ShowDialog();
        }

        private void comboSearchFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            explore_Search();
        }

        private void treeViewExplore_Leave(object sender, EventArgs e)
        {
            treeViewExplore.SelectedNode = null;
        }

        private void textSearchTerm_Enter(object sender, EventArgs e)
        {
            explore_Search();
        }

        private void btnIDextendDD_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(textIDdd.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);
            frmExtendDueDate dd = new frmExtendDueDate(dt, textIDbid.Text, textIDmid.Text);

            DialogResult dr = dd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                dataGridID.SelectedRows[0].Cells["DueDate"].Value = dd.returndate;
                textIDdd.Text = dd.returndate;
            }
       
            //end of class MainForm
        }

        private void textIDsearch_TextChanged(object sender, EventArgs e)
        {
            idsearch();
        }

        private void comboIDfield_SelectedIndexChanged(object sender, EventArgs e)
        {
            idsearch();
        }

        private void textIDsearch_Enter_1(object sender, EventArgs e)
        {
            idsearch();
        }

        private void comboMMfields_SelectedIndexChanged(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void textMMsearchterm_TextChanged(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void textMMsearchterm_Enter(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void btnMBcopy_Click(object sender, EventArgs e)
        {
            frmBookCopy bc = new frmBookCopy();

            DialogResult drs = bc.ShowDialog();
            string id="";
            if (drs == DialogResult.OK)
            {
              id = bc.returnid;
                
            }


            //code for bookdetails




            object retval=null;
            byte[] img = null;

            string price = "";
            if (String.IsNullOrEmpty(id))
            {
                
                return;
            }
            string cmdtext = String.Format("select * from BookDetails where BookID={0};",id);
            SQLiteCommand cmd = new SQLiteCommand(cmdtext, con);

            SQLiteDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                MessageBox.Show("Book does not exist");
                dr.Close();
                return;
            }

            while (dr.Read())
            {

              
                textMBisbn.Text = dr["ISBN"].ToString();
                textMBbookno.Text = dr["BookNo"].ToString();
                textMBtitle.Text = dr["Title"].ToString();
                textMBauthor.Text = dr["Author"].ToString();
                comboMBcateg.Text= dr["Category"].ToString();
               textMBdesc.Text= dr["Description"].ToString();

               textMByear.Text = dr["Year"].ToString();
                textMBpub.Text= dr["Publisher"].ToString();
               comboMBlang.Text = dr["Language"].ToString();
                price = dr["Price"].ToString();
               textMBpage.Text= dr["Pages"].ToString();
               textMBshelf.Text= dr["Shelf"].ToString();
               MBcombobtype.Text = dr["Type"].ToString();
               textMBdateadd.Text = dr["DateAdded"].ToString();
                retval = dr["Image"];
               

            }


            if (!(retval is DBNull))
            {
                img = (byte[])retval;
                System.IO.MemoryStream myMemoryStream = new System.IO.MemoryStream(img);
                System.Drawing.Image myImage = System.Drawing.Image.FromStream(myMemoryStream);
               pictureMB.Image = myImage;

               MemoryStream ms = new MemoryStream();
               pictureMB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
               byteArrayMBimage = ms.GetBuffer();
                /*
               ImageConverter converter = new ImageConverter();
               byteArrayMBimage=(byte[])converter.ConvertTo(pictureMB.Image, typeof(byte[]));
                */

                MBpicboxsetsizemode(pictureMB);
                if (pictureMB.SizeMode == PictureBoxSizeMode.Zoom)
                    labelMBenlarge.Text = "Click to Enlarge";
                else
                    labelMBenlarge.Text= "";

            }
            else
            {
                labelMBenlarge.Text = "";
            }
    
            

            textBDprice.Text = price;

        }

        private void btnEBissret_Click(object sender, EventArgs e)
        {
            if (gridviewExplore.RowCount == 0)
                return;
            textISbid.Text = gridviewExplore.SelectedRows[0].Cells["BookID"].Value.ToString();
            cmdIssueSubmitBook_Click(null, null);
        }

        private void btnMMissret_Click(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;
            textISmid.Text = dataGridMM.SelectedRows[0].Cells["MemberID"].Value.ToString();
            cmdIssueSubmitBook_Click(null, null);
        }

        private void panelExtraMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuLibInfo_Click(object sender, EventArgs e)
        {
            frmLibInfo li = new frmLibInfo();
            li.ShowDialog();
        }

        private void lblUsersStatus_Click(object sender, EventArgs e)
        {

        }

       
        
        private void btnMenuExport_Click(object sender, EventArgs e)
        {
            frmExport ex = new frmExport();
            ex.ShowDialog();
        }

        private void btnMMBooksToSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;
            textIDsearch.Text= dataGridMM.SelectedRows[0].Cells["MemberID"].Value.ToString();
            comboIDfield.Text = "MemberID";
            cmdIssueDetails_Click(null, null);
        }

        private void btnMenuHelp_Click(object sender, EventArgs e)
        {
            try
            {
                string fpath;
                fpath = @"\lmshelp.chm";

                fpath = datafolder + fpath;


                System.Diagnostics.Process.Start(fpath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboMBcateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(comboMBcateg.Text))
            {
                return;
            }
           
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select Shelf from Categories where Category='{0}';",comboMBcateg.Text);
         

            string shelf = com.ExecuteScalar().ToString();
            textMBshelf.Text = shelf;
        }

        private void MainForm_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnMenuLang_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMenuCourses_Click(object sender, EventArgs e)
        {
            frmCourses cs = new frmCourses();
            cs.ShowDialog();
        }

        private void btnCategoryModal_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Add new Category";
            pnlAddCateg.Show();
            pnlAddCateg.BringToFront();
            txtAddCateg.Focus();
        }

        private void btnAddOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAddCateg.Text.Trim()))
                {
                    MessageBox.Show("Enter Category Name");
                    txtAddCateg.Clear();
                    txtAddCateg.Focus();
                    return;
                }

                int id;
                bool hasdel = MainForm.dbsettings.hasDelCategories; ;
                id = MainForm.getNextID(hasdel, "Categories");
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Categories(ID,Category,Shelf) VALUES(@id,@categ,@shelf);";

                cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                cmd.Parameters.Add("@categ", DbType.String).Value = txtAddCateg.Text;
                cmd.Parameters.Add("@shelf", DbType.String).Value = txtAddShelf.Text;
                cmd.ExecuteNonQuery();
                lblStatus.Text = "Category " + txtAddCateg.Text + " was added.";
                txtAddCateg.Clear();
                txtAddShelf.Clear();
                loadCategory();
                comboMBcateg.SelectedItem = dbsettings.defaultCateg;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pnlAddCateg.Hide();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnMMexploreMembers_Click(object sender, EventArgs e)
        {
            frmExploreMembers em = new frmExploreMembers();
            em.ShowDialog();
        }

        private void btnBDebookfolder_Click(object sender, EventArgs e)
        {
            try
            {
                string fpath;
                fpath = @"\Ebooks\" ;

                //fpath = AppDomain.CurrentDomain.BaseDirectory + fpath;
                fpath = datafolder + fpath;


                System.Diagnostics.Process.Start(fpath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMenuMngDB_Click(object sender, EventArgs e)
        {
            frmManageDatabase md = new frmManageDatabase();
            md.ShowDialog();
          
        }

        private void pictureMB_MouseEnter(object sender, EventArgs e)
        {
            if (pictureMB.SizeMode != PictureBoxSizeMode.CenterImage)
                pictureMB.Cursor = Cursors.Hand;
            if (pictureMB.SizeMode == PictureBoxSizeMode.CenterImage)
                pictureMB.Cursor = Cursors.Default;
            //MessageBox.Show(pictureMB.SizeMode.ToString());
        }

        private void picBookCover_MouseEnter(object sender, EventArgs e)
        {
            if (picBookCover.SizeMode != PictureBoxSizeMode.CenterImage)
                picBookCover.Cursor = Cursors.Hand;
            if (picBookCover.SizeMode == PictureBoxSizeMode.CenterImage)
                picBookCover.Cursor = Cursors.Default;
        }

        private void dpISIBissuedate_ValueChanged(object sender, EventArgs e)
        {
         int dti = dbsettings.daysToIssue;
         textISIBduedate.Text = dpISIBissuedate.Value.AddDays(dti).ToString("dd/MM/yyyy");
        }

        private void dpISSBsubmitdate_ValueChanged(object sender, EventArgs e)
        {
            string dd = textISSBduedate.Text;
            DateTime duedate = DateTime.ParseExact(dd, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan ts = dpISSBsubmitdate.Value - duedate;

            if (ts.Days > 0)
            {
                int dailyFine = dbsettings.dailyFine;
                int fine = ts.Days * dailyFine;
                textISSBfine.Text = fine.ToString();

               // MessageBox.Show("Days:" + ts.Days + "  dailyfine:" + dailyFine + "  FineTotal:" + fine);
            }
            else
            {
                textISSBfine.Text = "0";
               // MessageBox.Show("zero");
            }
        }

       

        
        


    }
    public static class StringCipher
    {
        public static string enckey="87hjsi$hs8jnglwoxhjk";
        // This constant string is used as a "salt" value for the PasswordDeriveBytes function calls.
        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");

        // This constant is used to determine the keysize of the encryption algorithm.
        private const int keysize = 256;

        public static string Encrypt(string plainText, string passPhrase)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);

            byte[] keyBytes = password.GetBytes(keysize / 8);
            using (RijndaelManaged symmetricKey = new RijndaelManaged())
            {
                symmetricKey.Mode = CipherMode.CBC;
                using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                            cryptoStream.FlushFinalBlock();
                            byte[] cipherTextBytes = memoryStream.ToArray();
                            return Convert.ToBase64String(cipherTextBytes);
                        }
                    }
                }
            }

        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);

            byte[] keyBytes = password.GetBytes(keysize / 8);
            using (RijndaelManaged symmetricKey = new RijndaelManaged())
            {
                symmetricKey.Mode = CipherMode.CBC;
                using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes))
                {
                    using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                        }
                    }
                }
            }

        }
    }
}


   
    

