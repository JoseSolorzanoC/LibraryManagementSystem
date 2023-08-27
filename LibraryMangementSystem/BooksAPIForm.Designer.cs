namespace LibraryManagementSystem
{
    partial class BooksAPIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksAPIForm));
            this.btnSearch = new System.Windows.Forms.Button();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBook = new System.Windows.Forms.Panel();
            this.labelNoImage = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.labelPub = new System.Windows.Forms.Label();
            this.labelPage = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            this.labelSearchstatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.labelSearchPageNo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.panelBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(523, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 42);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textQuery
            // 
            this.textQuery.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuery.Location = new System.Drawing.Point(106, 19);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(400, 25);
            this.textQuery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Name :";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel.Controls.Add(this.panelBook);
            this.flowLayoutPanel.Location = new System.Drawing.Point(2, 104);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(997, 604);
            this.flowLayoutPanel.TabIndex = 7;
            // 
            // panelBook
            // 
            this.panelBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBook.BackColor = System.Drawing.SystemColors.Control;
            this.panelBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBook.Controls.Add(this.labelNoImage);
            this.panelBook.Controls.Add(this.textTitle);
            this.panelBook.Controls.Add(this.labelPub);
            this.panelBook.Controls.Add(this.labelPage);
            this.panelBook.Controls.Add(this.labelAuth);
            this.panelBook.Controls.Add(this.picbox);
            this.panelBook.Controls.Add(this.btnSelect);
            this.panelBook.Location = new System.Drawing.Point(3, 3);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(501, 183);
            this.panelBook.TabIndex = 0;
            // 
            // labelNoImage
            // 
            this.labelNoImage.AutoSize = true;
            this.labelNoImage.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoImage.Location = new System.Drawing.Point(39, 80);
            this.labelNoImage.Name = "labelNoImage";
            this.labelNoImage.Size = new System.Drawing.Size(73, 20);
            this.labelNoImage.TabIndex = 7;
            this.labelNoImage.Text = "No Image";
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.SystemColors.Control;
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(160, 11);
            this.textTitle.Multiline = true;
            this.textTitle.Name = "textTitle";
            this.textTitle.ReadOnly = true;
            this.textTitle.Size = new System.Drawing.Size(326, 67);
            this.textTitle.TabIndex = 6;
            this.textTitle.Text = "Title";
            // 
            // labelPub
            // 
            this.labelPub.AutoSize = true;
            this.labelPub.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPub.Location = new System.Drawing.Point(159, 142);
            this.labelPub.Name = "labelPub";
            this.labelPub.Size = new System.Drawing.Size(68, 20);
            this.labelPub.TabIndex = 5;
            this.labelPub.Text = "Publisher";
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.Location = new System.Drawing.Point(159, 119);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(47, 20);
            this.labelPage.TabIndex = 4;
            this.labelPage.Text = "Pages";
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuth.Location = new System.Drawing.Point(159, 97);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(54, 20);
            this.labelAuth.TabIndex = 3;
            this.labelAuth.Text = "Author";
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.Color.Gainsboro;
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Location = new System.Drawing.Point(6, 4);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(137, 171);
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelect.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(400, 136);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(96, 42);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureLoading
            // 
            this.pictureLoading.BackColor = System.Drawing.SystemColors.Control;
            this.pictureLoading.Image = global::LibraryManagementSystem.Properties.Resources.gif3;
            this.pictureLoading.Location = new System.Drawing.Point(516, 112);
            this.pictureLoading.Name = "pictureLoading";
            this.pictureLoading.Size = new System.Drawing.Size(141, 135);
            this.pictureLoading.TabIndex = 1;
            this.pictureLoading.TabStop = false;
            this.pictureLoading.Visible = false;
            // 
            // labelSearchstatus
            // 
            this.labelSearchstatus.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchstatus.Location = new System.Drawing.Point(25, 66);
            this.labelSearchstatus.Name = "labelSearchstatus";
            this.labelSearchstatus.Size = new System.Drawing.Size(481, 22);
            this.labelSearchstatus.TabIndex = 8;
            this.labelSearchstatus.Text = "Status";
            this.labelSearchstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(696, 54);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 42);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprev.Location = new System.Drawing.Point(523, 56);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(100, 42);
            this.btnprev.TabIndex = 3;
            this.btnprev.Text = "<< Previous";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(649, 11);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(100, 42);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // labelSearchPageNo
            // 
            this.labelSearchPageNo.AutoSize = true;
            this.labelSearchPageNo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchPageNo.Location = new System.Drawing.Point(636, 65);
            this.labelSearchPageNo.Name = "labelSearchPageNo";
            this.labelSearchPageNo.Size = new System.Drawing.Size(46, 20);
            this.labelSearchPageNo.TabIndex = 12;
            this.labelSearchPageNo.Text = "Page ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(756, 28);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(236, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(993, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 14;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercent.Location = new System.Drawing.Point(869, 4);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(31, 20);
            this.labelPercent.TabIndex = 15;
            this.labelPercent.Text = "0 %";
            // 
            // BooksAPIForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 712);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.pictureLoading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelSearchPageNo);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelSearchstatus);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQuery);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BooksAPIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BooksAPIForm_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label labelPub;
        private System.Windows.Forms.Label labelSearchstatus;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label labelNoImage;
        private System.Windows.Forms.PictureBox pictureLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label labelSearchPageNo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPercent;
    }
}