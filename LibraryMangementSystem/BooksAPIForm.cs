using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;

using System.Net;
using Newtonsoft.Json;

namespace LibraryManagementSystem
{
    public partial class BooksAPIForm : Form
    {
        BookResults retObject;
        bool stoploading = false;
        int sindex = 0;

        string searchtext;
        List<Panel> panellist;

        public BooksAPIForm()
        {
            CheckForIllegalCrossThreadCalls = false; //Not recommended.used to access controls created by another thread.
           
            InitializeComponent();
            panellist = new List<Panel>();
        }


        private void BooksAPIForm_Load(object sender, EventArgs e)
        {
            
            panelBook.Hide();
           // flowLayoutPanel.Hide();
            
          

            
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textQuery.Text))
            {
                MessageBox.Show("Please Enter Search Term.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textQuery.Clear();
                return;
            }

            sindex = 0;
            searchtext = textQuery.Text;
            textQuery.Clear();
            startsearch();

           
    }
        private void startsearch()
        {
            stoploading = false;
            btnNext.Enabled = false;
            btnprev.Enabled = false;
            btnSearch.Enabled = false;
            
            labelSearchPageNo.Text = "Page " + (sindex / 10 + 1);
            labelSearchstatus.Text = "Searching...";
            flowLayoutPanel.Hide();
            flowLayoutPanel.Controls.Clear();
            panellist.Clear();
            pictureLoading.Show();
            pictureLoading.BringToFront();
            backgroundWorker1.RunWorkerAsync();
           
        }
                         
            
        
        private void loadresults()
        {

            
        }
        

     

        void rbtnsel_Click(object sender, EventArgs e)
        {
            try
            {
                string pos = ""; int i;
                Button bt = (Button)sender;
                pos = bt.Tag.ToString(); ;
                if (String.IsNullOrEmpty(pos) == false)
                {
                    i = Convert.ToInt32(pos);
                    VolumeInfo dt = retObject.items[i].volumeInfo;
                   // Volume.VolumeInfoData dt = vols.Items[i].VolumeInfo;
                    
                    MainForm.gtitle = dt.title;
                    MainForm.gauthor = "";
                    IList<string> mylist = dt.authors;
                    int j = 0;
                    foreach (string value in mylist)
                    {
                        j++;
                        MainForm.gauthor += value;
                        if (j != mylist.Count)
                            MainForm.gauthor += ", ";
                    }

                    MainForm.gpublisher = dt.publisher;
                    MainForm.gpages = dt.pageCount.ToString();
                    MainForm.glang = dt.language;
                    MainForm.gdesc = dt.description;
                    MainForm.gpubyear = dt.publishedDate;
                   
                    // MainForm.gisbn=dt.IndustryIdentifiers;
                    IList<IndustryIdentifier> isbnnos = dt.industryIdentifiers;
                   

                    if (isbnnos != null)
                    {
                        foreach (IndustryIdentifier value in isbnnos)
                        {
                            if (value.identifier != null)
                            {
                                MainForm.gisbn = value.identifier;
                            }

                        }
                    }
                    PictureBox pb=(PictureBox) bt.Parent.Controls["rpicBox"];
                    MainForm.gimg = pb.Image;

                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured:" + ex.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var client = new WebClient();
                string url = string.Format("https://www.googleapis.com/books/v1/volumes?q={0}&startIndex={1}&country=US", searchtext, sindex);
                
                string html = client.DownloadString(url);
                
                retObject = JsonConvert.DeserializeObject<BookResults>(html);
                //MessageBox.Show(retObject.items.Count.ToString());
                /*
                BooksService bs = new BooksService();
            
                VolumesResource.ListRequest list = bs.Volumes.List(searchtext);
                

                list.StartIndex = sindex;
                

                int p=0;
                vols = list.Fetch();*/
                
   
                
              //  MessageBox.Show("fetch completed");
                int p = 0;
                if (retObject.items == null)
                {
                    labelSearchstatus.Text = "No Books Found.";
                    return;
                }
                

                //    statinit=string.Format("Search Completed.{0} Books found.Page {1} of {2}.",vols.TotalItems ,(sindex/10 + 1),Math.Ceiling(Convert.ToDouble( vols.TotalItems)/10));
               //labelSearchstatus.Text=statinit;
               progressBar1.Maximum = retObject.items.Count;
               progressBar1.Value = 0;
                foreach (Item v in retObject.items)
                {
                    p++;
                    try
                    {
                        if (stoploading == true)
                        {
                            labelSearchstatus.Text+= "Stopped.";
                            return;
                        }
                       
                        progressBar1.PerformStep();
                        labelPercent.Text = (progressBar1.Value*100 / progressBar1.Maximum) + " %";
                        labelSearchstatus.Text =string.Format("Loading Book {0} of {1} Books...", p, retObject.items.Count.ToString());
                        
                        
                        Panel pan = new Panel();
                        pan.Size = panelBook.Size;


                        Button rbtnsel = new Button();
                        TextBox rlabelTitle = new TextBox();
                        Label rlabelAuth = new Label();
                        Label rlabelPage = new Label();
                        Label rlabelPub = new Label();
                        PictureBox rpicBox = new PictureBox();
                        rpicBox.Name="rpicBox";

                        pan.Controls.Add(rbtnsel);
                        pan.Controls.Add(rlabelTitle);
                        pan.Controls.Add(rlabelAuth);
                        pan.Controls.Add(rlabelPage);
                        pan.Controls.Add(rlabelPub);
                        pan.Controls.Add(rpicBox);


                        rbtnsel.Size = btnSelect.Size;
                        rbtnsel.Location = btnSelect.Location;
                        rbtnsel.Text = "Select";
                        rbtnsel.FlatStyle = FlatStyle.System;


                        rlabelTitle.Font = textTitle.Font;
                        rlabelTitle.Location = textTitle.Location;
                        rlabelTitle.ReadOnly = true;
                        //rlabelTitle.BackColor = SystemColors.Control;
                        rlabelTitle.BorderStyle = textTitle.BorderStyle;
                        rlabelTitle.Size = textTitle.Size;
                        rlabelTitle.Multiline = true;
                       
                        rlabelTitle.Text = v.volumeInfo.title ?? "No Data";

                        rlabelAuth.Font = labelAuth.Font;
                        rlabelAuth.Location = labelAuth.Location;
                        rlabelAuth.AutoSize = true;
                        rlabelAuth.Text = "Authors : ";
                     //   Volume newvol = new Volume();


                        if (v.volumeInfo.authors != null)
                        {
                            
                            int j = 0;
                            foreach (string value in v.volumeInfo.authors)
                            {
                                j++;
                                rlabelAuth.Text += value;
                                if (j != v.volumeInfo.authors.Count)
                                   rlabelAuth.Text += ", ";
                            }
                        }
                        else
                        {
                            rlabelAuth.Text = "Authors : No Data";
                        }

                        rlabelPage.Font=labelPage.Font;
                        rlabelPage.Location = labelPage.Location;
                        rlabelPage.AutoSize = true;

                        rlabelPage.Text = "Pages : ";

                        if (v.volumeInfo.pageCount!= null)
                            rlabelPage.Text += v.volumeInfo.pageCount;
                        else
                            rlabelPage.Text += "No Data";


                        rlabelPub.Font=labelPub.Font;
                        rlabelPub.Location = labelPub.Location;
                        rlabelPub.AutoSize = true;
                        rlabelPub.Text = "Publisher : " + (v.volumeInfo.publisher?? "No Data");
                        rpicBox.Location = picbox.Location;
                        rpicBox.Size = picbox.Size;
                        rpicBox.SizeMode = PictureBoxSizeMode.Zoom;
                        string imgurl = "";

                        if (v.volumeInfo.imageLinks!= null)
                        {
                            imgurl = v.volumeInfo.imageLinks.thumbnail;
                        }
                        if (String.IsNullOrEmpty(imgurl) == false)
                        {
                            byte[] ba = new byte[0];
                            System.Net.WebClient wc = new System.Net.WebClient();

                            ba = wc.DownloadData(imgurl);


                            System.IO.MemoryStream myMemoryStream = new System.IO.MemoryStream(ba);

                            rpicBox.Image = System.Drawing.Image.FromStream(myMemoryStream);

                            
                        }
                        else
                        {
                            Label rlabelNoimg = new Label();
                            rlabelNoimg.Text = "No Image";
                            rlabelNoimg.Font = labelNoImage.Font;
                            rlabelNoimg.Location = labelNoImage.Location;
                            rlabelNoimg.AutoSize = true;
                            rpicBox.BorderStyle = picbox.BorderStyle;
                            pan.Controls.Add(rlabelNoimg);
                            rlabelNoimg.BringToFront();
                        }
                        rbtnsel.Tag = p-1;
                        
                        rbtnsel.Click += new EventHandler(rbtnsel_Click);
                        panellist.Add(pan);
                        
                       

                    }



                    catch (Exception ex2)
                    {

                        MessageBox.Show("Failed to Connect to Google Books.\n"+ex2.Message + "\nSource :" + ex2.Source);

                    }
                }
              //  stat = vols.Items.Count.ToString() + " Results Found.";

                labelSearchstatus.Text += "Completed.";
                btnNext.Enabled = true;
                btnprev.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured.Failed to Connect to Google Books.\n" + ex.Message);
                labelSearchstatus.Text = "An Error Occured.";

            }
         
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            flowLayoutPanel.Controls.AddRange(panellist.ToArray());                     
            pictureLoading.Hide();
            flowLayoutPanel.Show();
            btnSearch.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            sindex += 10;
            startsearch();
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            sindex -= 10;
            if (sindex >= 0)
            {
                startsearch();
            }
            
            
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            stoploading = true;
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        
       

        


    }



    //class

    public class IndustryIdentifier
    {
        public string type { get; set; }
        public string identifier { get; set; }
    }

    public class ReadingModes
    {
        public bool text { get; set; }
        public bool image { get; set; }
    }

    public class ImageLinks
    {
        public string smallThumbnail { get; set; }
        public string thumbnail { get; set; }
    }

    public class VolumeInfo
    {
        public string title { get; set; }
        public IList<string> authors { get; set; }
        public string publisher { get; set; }
        public string publishedDate { get; set; }
        public string description { get; set; }
        public IList<IndustryIdentifier> industryIdentifiers { get; set; }
        public ReadingModes readingModes { get; set; }
        public string printType { get; set; }
        public IList<string> categories { get; set; }
        public double averageRating { get; set; }
        public int ratingsCount { get; set; }
        public string contentVersion { get; set; }
        public ImageLinks imageLinks { get; set; }
        public string language { get; set; }
        public string previewLink { get; set; }
        public string infoLink { get; set; }
        public string canonicalVolumeLink { get; set; }
        public int? pageCount { get; set; }
        public string subtitle { get; set; }
    }

    public class ListPrice
    {
        public double amount { get; set; }
        public string currencyCode { get; set; }
    }

    public class RetailPrice
    {
        public double amount { get; set; }
        public string currencyCode { get; set; }
    }

    public class ListPrice2
    {
        public double amountInMicros { get; set; }
        public string currencyCode { get; set; }
    }

    public class RetailPrice2
    {
        public double amountInMicros { get; set; }
        public string currencyCode { get; set; }
    }

    public class Offer
    {
        public int finskyOfferType { get; set; }
        public ListPrice2 listPrice { get; set; }
        public RetailPrice2 retailPrice { get; set; }
    }

    public class SaleInfo
    {
        public string country { get; set; }
        public string saleability { get; set; }
        public bool isEbook { get; set; }
        public ListPrice listPrice { get; set; }
        public RetailPrice retailPrice { get; set; }
        public string buyLink { get; set; }
        public IList<Offer> offers { get; set; }
    }

    public class Epub
    {
        public bool isAvailable { get; set; }
        public string acsTokenLink { get; set; }
    }

    public class Pdf
    {
        public bool isAvailable { get; set; }
        public string acsTokenLink { get; set; }
    }

    public class AccessInfo
    {
        public string country { get; set; }
        public string viewability { get; set; }
        public bool embeddable { get; set; }
        public bool publicDomain { get; set; }
        public string textToSpeechPermission { get; set; }
        public Epub epub { get; set; }
        public Pdf pdf { get; set; }
        public string webReaderLink { get; set; }
        public string accessViewStatus { get; set; }
        public bool quoteSharingAllowed { get; set; }
    }

    public class SearchInfo
    {
        public string textSnippet { get; set; }
    }

    public class Item
    {
        public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public VolumeInfo volumeInfo { get; set; }
        public SaleInfo saleInfo { get; set; }
        public AccessInfo accessInfo { get; set; }
        public SearchInfo searchInfo { get; set; }
    }

    public class BookResults
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public IList<Item> items { get; set; }
    }
    //end class
}
