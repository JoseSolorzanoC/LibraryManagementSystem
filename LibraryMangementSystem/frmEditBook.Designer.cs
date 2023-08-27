namespace LibraryManagementSystem
{
    partial class frmEditBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditBook));
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMBenterid = new System.Windows.Forms.TextBox();
            this.btnMBeditdel = new System.Windows.Forms.Button();
            this.pictureMB = new System.Windows.Forms.PictureBox();
            this.textMBauthor = new System.Windows.Forms.TextBox();
            this.comboMBcateg = new System.Windows.Forms.ComboBox();
            this.comboMBlang = new System.Windows.Forms.ComboBox();
            this.btnMBopenpdf = new System.Windows.Forms.Button();
            this.labelMBpdfsize = new System.Windows.Forms.Label();
            this.textMBpdfurl = new System.Windows.Forms.TextBox();
            this.MBcombobtype = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.labelMBpicsize = new System.Windows.Forms.Label();
            this.btnMBgbooksapi = new System.Windows.Forms.Button();
            this.btnMBopenfile = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.textMBimgurl = new System.Windows.Forms.TextBox();
            this.textMBdesc = new System.Windows.Forms.TextBox();
            this.btnMBdelete = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.btnMBeditsave = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textMBdateadd = new System.Windows.Forms.TextBox();
            this.textMBshelf = new System.Windows.Forms.TextBox();
            this.textMBpage = new System.Windows.Forms.TextBox();
            this.textMBisbn = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.textMBprice = new System.Windows.Forms.TextBox();
            this.textMBpub = new System.Windows.Forms.TextBox();
            this.textMByear = new System.Windows.Forms.TextBox();
            this.textMBtitle = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.openFileDialogMBpic = new System.Windows.Forms.OpenFileDialog();
            this.BDlabelenlarge = new System.Windows.Forms.Label();
            this.textMBbookno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMBbid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1, 578);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1013, 30);
            this.lblStatus.TabIndex = 186;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 185;
            this.label1.Text = "Book ID :";
            // 
            // txtMBenterid
            // 
            this.txtMBenterid.AcceptsReturn = true;
            this.txtMBenterid.BackColor = System.Drawing.SystemColors.Window;
            this.txtMBenterid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMBenterid.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMBenterid.Location = new System.Drawing.Point(129, 12);
            this.txtMBenterid.Name = "txtMBenterid";
            this.txtMBenterid.Size = new System.Drawing.Size(238, 25);
            this.txtMBenterid.TabIndex = 0;
            // 
            // btnMBeditdel
            // 
            this.btnMBeditdel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMBeditdel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBeditdel.Location = new System.Drawing.Point(374, 5);
            this.btnMBeditdel.Name = "btnMBeditdel";
            this.btnMBeditdel.Size = new System.Drawing.Size(275, 39);
            this.btnMBeditdel.TabIndex = 1;
            this.btnMBeditdel.Text = "Edit / Delete";
            this.btnMBeditdel.UseVisualStyleBackColor = true;
            this.btnMBeditdel.Click += new System.EventHandler(this.btnMBeditdel_Click);
            // 
            // pictureMB
            // 
            this.pictureMB.BackColor = System.Drawing.Color.Transparent;
            this.pictureMB.Location = new System.Drawing.Point(804, 4);
            this.pictureMB.Name = "pictureMB";
            this.pictureMB.Size = new System.Drawing.Size(191, 306);
            this.pictureMB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMB.TabIndex = 174;
            this.pictureMB.TabStop = false;
            this.pictureMB.Click += new System.EventHandler(this.pictureMB_Click);
            // 
            // textMBauthor
            // 
            this.textMBauthor.BackColor = System.Drawing.SystemColors.Window;
            this.textMBauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBauthor.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBauthor.Location = new System.Drawing.Point(129, 193);
            this.textMBauthor.Name = "textMBauthor";
            this.textMBauthor.Size = new System.Drawing.Size(513, 25);
            this.textMBauthor.TabIndex = 5;
            // 
            // comboMBcateg
            // 
            this.comboMBcateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMBcateg.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMBcateg.FormattingEnabled = true;
            this.comboMBcateg.Location = new System.Drawing.Point(129, 373);
            this.comboMBcateg.Name = "comboMBcateg";
            this.comboMBcateg.Size = new System.Drawing.Size(241, 28);
            this.comboMBcateg.TabIndex = 7;
            this.comboMBcateg.SelectedIndexChanged += new System.EventHandler(this.comboMBcateg_SelectedIndexChanged);
            // 
            // comboMBlang
            // 
            this.comboMBlang.BackColor = System.Drawing.SystemColors.Window;
            this.comboMBlang.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMBlang.FormattingEnabled = true;
            this.comboMBlang.Items.AddRange(new object[] {
            "English",
            "Malayalam"});
            this.comboMBlang.Location = new System.Drawing.Point(129, 433);
            this.comboMBlang.Name = "comboMBlang";
            this.comboMBlang.Size = new System.Drawing.Size(184, 28);
            this.comboMBlang.TabIndex = 9;
            // 
            // btnMBopenpdf
            // 
            this.btnMBopenpdf.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBopenpdf.Location = new System.Drawing.Point(804, 526);
            this.btnMBopenpdf.Name = "btnMBopenpdf";
            this.btnMBopenpdf.Size = new System.Drawing.Size(101, 36);
            this.btnMBopenpdf.TabIndex = 13;
            this.btnMBopenpdf.Tag = "";
            this.btnMBopenpdf.Text = "Select PDF";
            this.btnMBopenpdf.UseVisualStyleBackColor = true;
            this.btnMBopenpdf.Click += new System.EventHandler(this.btnMBopenpdf_Click);
            // 
            // labelMBpdfsize
            // 
            this.labelMBpdfsize.AutoSize = true;
            this.labelMBpdfsize.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMBpdfsize.Location = new System.Drawing.Point(667, 537);
            this.labelMBpdfsize.Name = "labelMBpdfsize";
            this.labelMBpdfsize.Size = new System.Drawing.Size(41, 20);
            this.labelMBpdfsize.TabIndex = 181;
            this.labelMBpdfsize.Text = "Size:";
            // 
            // textMBpdfurl
            // 
            this.textMBpdfurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBpdfurl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBpdfurl.Location = new System.Drawing.Point(310, 535);
            this.textMBpdfurl.Name = "textMBpdfurl";
            this.textMBpdfurl.Size = new System.Drawing.Size(334, 25);
            this.textMBpdfurl.TabIndex = 154;
            // 
            // MBcombobtype
            // 
            this.MBcombobtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MBcombobtype.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBcombobtype.FormattingEnabled = true;
            this.MBcombobtype.Items.AddRange(new object[] {
            "Hardcopy Only",
            "Ebook Only",
            "Hardcopy and Ebook"});
            this.MBcombobtype.Location = new System.Drawing.Point(129, 534);
            this.MBcombobtype.Name = "MBcombobtype";
            this.MBcombobtype.Size = new System.Drawing.Size(153, 28);
            this.MBcombobtype.TabIndex = 12;
            this.MBcombobtype.SelectedIndexChanged += new System.EventHandler(this.MBcombobtype_SelectedIndexChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(6, 542);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(89, 20);
            this.label48.TabIndex = 180;
            this.label48.Text = "Book Type :";
            // 
            // labelMBpicsize
            // 
            this.labelMBpicsize.AutoSize = true;
            this.labelMBpicsize.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMBpicsize.Location = new System.Drawing.Point(852, 387);
            this.labelMBpicsize.Name = "labelMBpicsize";
            this.labelMBpicsize.Size = new System.Drawing.Size(41, 20);
            this.labelMBpicsize.TabIndex = 179;
            this.labelMBpicsize.Text = "Size:";
            // 
            // btnMBgbooksapi
            // 
            this.btnMBgbooksapi.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBgbooksapi.Location = new System.Drawing.Point(655, 117);
            this.btnMBgbooksapi.Name = "btnMBgbooksapi";
            this.btnMBgbooksapi.Size = new System.Drawing.Size(129, 89);
            this.btnMBgbooksapi.TabIndex = 20;
            this.btnMBgbooksapi.Text = "Get Book Details from Google Books";
            this.btnMBgbooksapi.UseVisualStyleBackColor = true;
            this.btnMBgbooksapi.Click += new System.EventHandler(this.btnMBgbooksapi_Click);
            // 
            // btnMBopenfile
            // 
            this.btnMBopenfile.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBopenfile.Location = new System.Drawing.Point(846, 343);
            this.btnMBopenfile.Name = "btnMBopenfile";
            this.btnMBopenfile.Size = new System.Drawing.Size(101, 36);
            this.btnMBopenfile.TabIndex = 18;
            this.btnMBopenfile.Text = "Select Image";
            this.btnMBopenfile.UseVisualStyleBackColor = true;
            this.btnMBopenfile.Click += new System.EventHandler(this.btnMBopenfile_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(6, 502);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(104, 20);
            this.label34.TabIndex = 176;
            this.label34.Text = "Cover Image :";
            // 
            // textMBimgurl
            // 
            this.textMBimgurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBimgurl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBimgurl.Location = new System.Drawing.Point(129, 499);
            this.textMBimgurl.Name = "textMBimgurl";
            this.textMBimgurl.Size = new System.Drawing.Size(387, 25);
            this.textMBimgurl.TabIndex = 11;
            // 
            // textMBdesc
            // 
            this.textMBdesc.AcceptsReturn = true;
            this.textMBdesc.BackColor = System.Drawing.SystemColors.Window;
            this.textMBdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBdesc.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBdesc.Location = new System.Drawing.Point(129, 224);
            this.textMBdesc.Multiline = true;
            this.textMBdesc.Name = "textMBdesc";
            this.textMBdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMBdesc.Size = new System.Drawing.Size(515, 139);
            this.textMBdesc.TabIndex = 6;
            // 
            // btnMBdelete
            // 
            this.btnMBdelete.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBdelete.Location = new System.Drawing.Point(655, 5);
            this.btnMBdelete.Name = "btnMBdelete";
            this.btnMBdelete.Size = new System.Drawing.Size(129, 89);
            this.btnMBdelete.TabIndex = 21;
            this.btnMBdelete.Text = "Delete Book";
            this.btnMBdelete.UseVisualStyleBackColor = true;
            this.btnMBdelete.Click += new System.EventHandler(this.btnMBdelete_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(6, 226);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(94, 20);
            this.label32.TabIndex = 173;
            this.label32.Text = "Description :";
            // 
            // btnMBeditsave
            // 
            this.btnMBeditsave.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBeditsave.Location = new System.Drawing.Point(655, 233);
            this.btnMBeditsave.Name = "btnMBeditsave";
            this.btnMBeditsave.Size = new System.Drawing.Size(129, 89);
            this.btnMBeditsave.TabIndex = 19;
            this.btnMBeditsave.Text = "Save Changes";
            this.btnMBeditsave.UseVisualStyleBackColor = true;
            this.btnMBeditsave.Click += new System.EventHandler(this.btnMBeditsave_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(6, 377);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(80, 20);
            this.label33.TabIndex = 163;
            this.label33.Text = "Category :";
            // 
            // textMBdateadd
            // 
            this.textMBdateadd.BackColor = System.Drawing.SystemColors.Window;
            this.textMBdateadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBdateadd.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBdateadd.Location = new System.Drawing.Point(696, 457);
            this.textMBdateadd.Name = "textMBdateadd";
            this.textMBdateadd.Size = new System.Drawing.Size(107, 25);
            this.textMBdateadd.TabIndex = 14;
            // 
            // textMBshelf
            // 
            this.textMBshelf.BackColor = System.Drawing.SystemColors.Window;
            this.textMBshelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBshelf.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBshelf.Location = new System.Drawing.Point(696, 428);
            this.textMBshelf.Name = "textMBshelf";
            this.textMBshelf.Size = new System.Drawing.Size(107, 25);
            this.textMBshelf.TabIndex = 15;
            // 
            // textMBpage
            // 
            this.textMBpage.BackColor = System.Drawing.SystemColors.Window;
            this.textMBpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBpage.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBpage.Location = new System.Drawing.Point(696, 400);
            this.textMBpage.Name = "textMBpage";
            this.textMBpage.Size = new System.Drawing.Size(107, 25);
            this.textMBpage.TabIndex = 16;
            // 
            // textMBisbn
            // 
            this.textMBisbn.BackColor = System.Drawing.SystemColors.Window;
            this.textMBisbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBisbn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBisbn.Location = new System.Drawing.Point(496, 90);
            this.textMBisbn.Name = "textMBisbn";
            this.textMBisbn.Size = new System.Drawing.Size(148, 25);
            this.textMBisbn.TabIndex = 3;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 62);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(70, 20);
            this.label36.TabIndex = 172;
            this.label36.Text = "Book ID :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(383, 91);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(107, 20);
            this.label37.TabIndex = 171;
            this.label37.Text = "ISBN Number :";
            // 
            // textMBprice
            // 
            this.textMBprice.BackColor = System.Drawing.SystemColors.Window;
            this.textMBprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBprice.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBprice.Location = new System.Drawing.Point(129, 466);
            this.textMBprice.Name = "textMBprice";
            this.textMBprice.Size = new System.Drawing.Size(97, 25);
            this.textMBprice.TabIndex = 10;
            // 
            // textMBpub
            // 
            this.textMBpub.BackColor = System.Drawing.SystemColors.Window;
            this.textMBpub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBpub.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBpub.Location = new System.Drawing.Point(129, 404);
            this.textMBpub.Name = "textMBpub";
            this.textMBpub.Size = new System.Drawing.Size(341, 25);
            this.textMBpub.TabIndex = 8;
            // 
            // textMByear
            // 
            this.textMByear.BackColor = System.Drawing.SystemColors.Window;
            this.textMByear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMByear.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMByear.Location = new System.Drawing.Point(696, 372);
            this.textMByear.Name = "textMByear";
            this.textMByear.Size = new System.Drawing.Size(107, 25);
            this.textMByear.TabIndex = 17;
            // 
            // textMBtitle
            // 
            this.textMBtitle.AcceptsReturn = true;
            this.textMBtitle.BackColor = System.Drawing.SystemColors.Window;
            this.textMBtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBtitle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBtitle.Location = new System.Drawing.Point(129, 121);
            this.textMBtitle.Multiline = true;
            this.textMBtitle.Name = "textMBtitle";
            this.textMBtitle.Size = new System.Drawing.Size(512, 55);
            this.textMBtitle.TabIndex = 4;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(578, 459);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(97, 20);
            this.label38.TabIndex = 170;
            this.label38.Text = "Date Added :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(565, 428);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(110, 20);
            this.label39.TabIndex = 169;
            this.label39.Text = "Shelf Number :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(617, 402);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(58, 20);
            this.label40.TabIndex = 168;
            this.label40.Text = "Pages :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(6, 477);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(58, 20);
            this.label41.TabIndex = 167;
            this.label41.Text = "Price : ";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(6, 443);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(73, 20);
            this.label42.TabIndex = 166;
            this.label42.Text = "Language";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(6, 413);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(68, 20);
            this.label43.TabIndex = 165;
            this.label43.Text = "Publisher";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(624, 374);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(51, 20);
            this.label44.TabIndex = 164;
            this.label44.Text = "Year :";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(6, 196);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 20);
            this.label45.TabIndex = 162;
            this.label45.Text = "Author :";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(6, 128);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(50, 20);
            this.label46.TabIndex = 160;
            this.label46.Text = "Title :";
            // 
            // BDlabelenlarge
            // 
            this.BDlabelenlarge.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDlabelenlarge.Location = new System.Drawing.Point(804, 313);
            this.BDlabelenlarge.Name = "BDlabelenlarge";
            this.BDlabelenlarge.Size = new System.Drawing.Size(191, 20);
            this.BDlabelenlarge.TabIndex = 187;
            this.BDlabelenlarge.Text = "Click to Enlarge";
            this.BDlabelenlarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textMBbookno
            // 
            this.textMBbookno.BackColor = System.Drawing.SystemColors.Window;
            this.textMBbookno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBbookno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textMBbookno.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBbookno.Location = new System.Drawing.Point(129, 89);
            this.textMBbookno.Name = "textMBbookno";
            this.textMBbookno.Size = new System.Drawing.Size(238, 25);
            this.textMBbookno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 189;
            this.label2.Text = "Book Number :";
            // 
            // textMBbid
            // 
            this.textMBbid.AutoSize = true;
            this.textMBbid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBbid.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBbid.Location = new System.Drawing.Point(129, 60);
            this.textMBbid.Name = "textMBbid";
            this.textMBbid.Size = new System.Drawing.Size(35, 22);
            this.textMBbid.TabIndex = 190;
            this.textMBbid.Text = "000";
            // 
            // frmEditBook
            // 
            this.AcceptButton = this.btnMBeditdel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 612);
            this.Controls.Add(this.pictureMB);
            this.Controls.Add(this.textMBbid);
            this.Controls.Add(this.textMBbookno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BDlabelenlarge);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMBenterid);
            this.Controls.Add(this.btnMBeditdel);
            this.Controls.Add(this.textMBauthor);
            this.Controls.Add(this.comboMBcateg);
            this.Controls.Add(this.comboMBlang);
            this.Controls.Add(this.btnMBopenpdf);
            this.Controls.Add(this.labelMBpdfsize);
            this.Controls.Add(this.textMBpdfurl);
            this.Controls.Add(this.MBcombobtype);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.labelMBpicsize);
            this.Controls.Add(this.btnMBgbooksapi);
            this.Controls.Add(this.btnMBopenfile);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.textMBimgurl);
            this.Controls.Add(this.textMBdesc);
            this.Controls.Add(this.btnMBdelete);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnMBeditsave);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.textMBdateadd);
            this.Controls.Add(this.textMBshelf);
            this.Controls.Add(this.textMBpage);
            this.Controls.Add(this.textMBisbn);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.textMBprice);
            this.Controls.Add(this.textMBpub);
            this.Controls.Add(this.textMByear);
            this.Controls.Add(this.textMBtitle);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit or Delete";
            this.Load += new System.EventHandler(this.frmEditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMBenterid;
        private System.Windows.Forms.Button btnMBeditdel;
        private System.Windows.Forms.PictureBox pictureMB;
        private System.Windows.Forms.TextBox textMBauthor;
        private System.Windows.Forms.ComboBox comboMBcateg;
        private System.Windows.Forms.ComboBox comboMBlang;
        private System.Windows.Forms.Button btnMBopenpdf;
        private System.Windows.Forms.Label labelMBpdfsize;
        private System.Windows.Forms.TextBox textMBpdfurl;
        private System.Windows.Forms.ComboBox MBcombobtype;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label labelMBpicsize;
        private System.Windows.Forms.Button btnMBgbooksapi;
        private System.Windows.Forms.Button btnMBopenfile;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textMBimgurl;
        private System.Windows.Forms.TextBox textMBdesc;
        private System.Windows.Forms.Button btnMBdelete;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnMBeditsave;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textMBdateadd;
        private System.Windows.Forms.TextBox textMBshelf;
        private System.Windows.Forms.TextBox textMBpage;
        private System.Windows.Forms.TextBox textMBisbn;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textMBprice;
        private System.Windows.Forms.TextBox textMBpub;
        private System.Windows.Forms.TextBox textMByear;
        private System.Windows.Forms.TextBox textMBtitle;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.OpenFileDialog openFileDialogMBpic;
        private System.Windows.Forms.Label BDlabelenlarge;
        private System.Windows.Forms.TextBox textMBbookno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textMBbid;

    }
}