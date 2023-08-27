namespace LibraryManagementSystem
{
    partial class frmExploreMembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExploreMembers));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewExplore = new System.Windows.Forms.TreeView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lblresultCount = new System.Windows.Forms.Label();
            this.lblCourseAdmYr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSearchFields = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSearchTerm = new System.Windows.Forms.TextBox();
            this.gridviewExplore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewExplore)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.treeViewExplore);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 629);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Course and Admission Year";
            // 
            // treeViewExplore
            // 
            this.treeViewExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewExplore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewExplore.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewExplore.Location = new System.Drawing.Point(3, 31);
            this.treeViewExplore.Name = "treeViewExplore";
            this.treeViewExplore.Size = new System.Drawing.Size(223, 597);
            this.treeViewExplore.TabIndex = 0;
            this.treeViewExplore.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewExplore_AfterSelect);
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lblresultCount);
            this.splitContainer4.Panel1.Controls.Add(this.lblCourseAdmYr);
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            this.splitContainer4.Panel1.Controls.Add(this.comboSearchFields);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.Controls.Add(this.textSearchTerm);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.gridviewExplore);
            this.splitContainer4.Size = new System.Drawing.Size(771, 629);
            this.splitContainer4.SplitterDistance = 122;
            this.splitContainer4.TabIndex = 0;
            this.splitContainer4.TabStop = false;
            // 
            // lblresultCount
            // 
            this.lblresultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblresultCount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultCount.Location = new System.Drawing.Point(72, 90);
            this.lblresultCount.Name = "lblresultCount";
            this.lblresultCount.Size = new System.Drawing.Size(653, 18);
            this.lblresultCount.TabIndex = 6;
            this.lblresultCount.Text = "Members count";
            this.lblresultCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourseAdmYr
            // 
            this.lblCourseAdmYr.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseAdmYr.Location = new System.Drawing.Point(508, 7);
            this.lblCourseAdmYr.Name = "lblCourseAdmYr";
            this.lblCourseAdmYr.Size = new System.Drawing.Size(206, 83);
            this.lblCourseAdmYr.TabIndex = 5;
            this.lblCourseAdmYr.Text = "Select Course and Admission Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Field :";
            // 
            // comboSearchFields
            // 
            this.comboSearchFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchFields.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchFields.FormattingEnabled = true;
            this.comboSearchFields.Items.AddRange(new object[] {
            "Name",
            "MemberID",
            "Course",
            "AdmissionYear",
            "RollNo",
            "Address",
            "PhoneNumber",
            "Dob",
            "Email"});
            this.comboSearchFields.Location = new System.Drawing.Point(89, 46);
            this.comboSearchFields.Name = "comboSearchFields";
            this.comboSearchFields.Size = new System.Drawing.Size(396, 28);
            this.comboSearchFields.TabIndex = 1;
            this.comboSearchFields.SelectedIndexChanged += new System.EventHandler(this.comboSearchFields_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search :";
            // 
            // textSearchTerm
            // 
            this.textSearchTerm.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchTerm.Location = new System.Drawing.Point(89, 7);
            this.textSearchTerm.Name = "textSearchTerm";
            this.textSearchTerm.Size = new System.Drawing.Size(396, 25);
            this.textSearchTerm.TabIndex = 0;
            this.textSearchTerm.TextChanged += new System.EventHandler(this.textSearchTerm_TextChanged);
            this.textSearchTerm.Enter += new System.EventHandler(this.textSearchTerm_Enter);
            // 
            // gridviewExplore
            // 
            this.gridviewExplore.AllowUserToAddRows = false;
            this.gridviewExplore.AllowUserToDeleteRows = false;
            this.gridviewExplore.AllowUserToResizeRows = false;
            this.gridviewExplore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridviewExplore.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridviewExplore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewExplore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewExplore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewExplore.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewExplore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewExplore.Location = new System.Drawing.Point(0, 0);
            this.gridviewExplore.Name = "gridviewExplore";
            this.gridviewExplore.ReadOnly = true;
            this.gridviewExplore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridviewExplore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewExplore.Size = new System.Drawing.Size(769, 501);
            this.gridviewExplore.StandardTab = true;
            this.gridviewExplore.TabIndex = 0;
            this.gridviewExplore.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewExplore_CellDoubleClick);
            // 
            // frmExploreMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 629);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExploreMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explore Members";
            this.Load += new System.EventHandler(this.frmExploreMembers_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewExplore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewExplore;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSearchFields;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSearchTerm;
        private System.Windows.Forms.DataGridView gridviewExplore;
        private System.Windows.Forms.Label lblCourseAdmYr;
        private System.Windows.Forms.Label lblresultCount;

    }
}