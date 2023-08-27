namespace LibraryManagementSystem
{
    partial class frmPackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackages));
            this.grpDisable = new System.Windows.Forms.GroupBox();
            this.btnSaveMaxBooks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxBooks = new System.Windows.Forms.TextBox();
            this.grpEnable = new System.Windows.Forms.GroupBox();
            this.btnMakeDefault = new System.Windows.Forms.Button();
            this.pnlAddPkg = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddPkgMaxBooks = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.radioNoFee = new System.Windows.Forms.RadioButton();
            this.radioHasFee = new System.Windows.Forms.RadioButton();
            this.picCloseAdd = new System.Windows.Forms.PictureBox();
            this.txtAddPkgTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.datagridPackages = new System.Windows.Forms.DataGridView();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnDelPkg = new System.Windows.Forms.Button();
            this.btnEditPkg = new System.Windows.Forms.Button();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.radioEnable = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioDisable = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpDisable.SuspendLayout();
            this.grpEnable.SuspendLayout();
            this.pnlAddPkg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDisable
            // 
            this.grpDisable.Controls.Add(this.btnSaveMaxBooks);
            this.grpDisable.Controls.Add(this.label2);
            this.grpDisable.Controls.Add(this.txtMaxBooks);
            this.grpDisable.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.grpDisable.Location = new System.Drawing.Point(53, 86);
            this.grpDisable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDisable.Name = "grpDisable";
            this.grpDisable.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDisable.Size = new System.Drawing.Size(780, 115);
            this.grpDisable.TabIndex = 0;
            this.grpDisable.TabStop = false;
            this.grpDisable.Text = "Set Maximum Books";
            this.grpDisable.Enter += new System.EventHandler(this.grpDisable_Enter);
            // 
            // btnSaveMaxBooks
            // 
            this.btnSaveMaxBooks.Location = new System.Drawing.Point(390, 41);
            this.btnSaveMaxBooks.Name = "btnSaveMaxBooks";
            this.btnSaveMaxBooks.Size = new System.Drawing.Size(89, 32);
            this.btnSaveMaxBooks.TabIndex = 1;
            this.btnSaveMaxBooks.Text = "Save";
            this.btnSaveMaxBooks.UseVisualStyleBackColor = true;
            this.btnSaveMaxBooks.Click += new System.EventHandler(this.btnSaveMaxBooks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum Books :";
            // 
            // txtMaxBooks
            // 
            this.txtMaxBooks.AcceptsReturn = true;
            this.txtMaxBooks.Location = new System.Drawing.Point(228, 48);
            this.txtMaxBooks.Name = "txtMaxBooks";
            this.txtMaxBooks.Size = new System.Drawing.Size(131, 25);
            this.txtMaxBooks.TabIndex = 0;
            // 
            // grpEnable
            // 
            this.grpEnable.Controls.Add(this.btnMakeDefault);
            this.grpEnable.Controls.Add(this.pnlAddPkg);
            this.grpEnable.Controls.Add(this.datagridPackages);
            this.grpEnable.Controls.Add(this.btnMaximize);
            this.grpEnable.Controls.Add(this.btnDelPkg);
            this.grpEnable.Controls.Add(this.btnEditPkg);
            this.grpEnable.Controls.Add(this.btnAddPkg);
            this.grpEnable.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.grpEnable.Location = new System.Drawing.Point(53, 245);
            this.grpEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Size = new System.Drawing.Size(780, 403);
            this.grpEnable.TabIndex = 1;
            this.grpEnable.TabStop = false;
            this.grpEnable.Text = "Manage Packages";
            // 
            // btnMakeDefault
            // 
            this.btnMakeDefault.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDefault.Location = new System.Drawing.Point(472, 26);
            this.btnMakeDefault.Name = "btnMakeDefault";
            this.btnMakeDefault.Size = new System.Drawing.Size(145, 56);
            this.btnMakeDefault.TabIndex = 3;
            this.btnMakeDefault.Text = "Make Default Package";
            this.btnMakeDefault.UseVisualStyleBackColor = true;
            this.btnMakeDefault.Click += new System.EventHandler(this.btnMakeDefault_Click);
            // 
            // pnlAddPkg
            // 
            this.pnlAddPkg.BackColor = System.Drawing.Color.White;
            this.pnlAddPkg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddPkg.Controls.Add(this.label4);
            this.pnlAddPkg.Controls.Add(this.txtAddPkgMaxBooks);
            this.pnlAddPkg.Controls.Add(this.lblAmount);
            this.pnlAddPkg.Controls.Add(this.txtFee);
            this.pnlAddPkg.Controls.Add(this.radioNoFee);
            this.pnlAddPkg.Controls.Add(this.radioHasFee);
            this.pnlAddPkg.Controls.Add(this.picCloseAdd);
            this.pnlAddPkg.Controls.Add(this.txtAddPkgTitle);
            this.pnlAddPkg.Controls.Add(this.label3);
            this.pnlAddPkg.Controls.Add(this.btnAdd);
            this.pnlAddPkg.Location = new System.Drawing.Point(151, 88);
            this.pnlAddPkg.Name = "pnlAddPkg";
            this.pnlAddPkg.Size = new System.Drawing.Size(445, 296);
            this.pnlAddPkg.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Maximum Books :";
            // 
            // txtAddPkgMaxBooks
            // 
            this.txtAddPkgMaxBooks.AcceptsTab = true;
            this.txtAddPkgMaxBooks.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddPkgMaxBooks.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPkgMaxBooks.Location = new System.Drawing.Point(178, 170);
            this.txtAddPkgMaxBooks.Name = "txtAddPkgMaxBooks";
            this.txtAddPkgMaxBooks.Size = new System.Drawing.Size(238, 25);
            this.txtAddPkgMaxBooks.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(19, 122);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(72, 20);
            this.lblAmount.TabIndex = 94;
            this.lblAmount.Text = "Amount :";
            // 
            // txtFee
            // 
            this.txtFee.AcceptsTab = true;
            this.txtFee.BackColor = System.Drawing.SystemColors.Window;
            this.txtFee.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(97, 119);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(238, 25);
            this.txtFee.TabIndex = 3;
            // 
            // radioNoFee
            // 
            this.radioNoFee.AutoSize = true;
            this.radioNoFee.Location = new System.Drawing.Point(158, 85);
            this.radioNoFee.Name = "radioNoFee";
            this.radioNoFee.Size = new System.Drawing.Size(74, 24);
            this.radioNoFee.TabIndex = 2;
            this.radioNoFee.TabStop = true;
            this.radioNoFee.Text = "No Fee";
            this.radioNoFee.UseVisualStyleBackColor = true;
            this.radioNoFee.CheckedChanged += new System.EventHandler(this.radioNoFee_CheckedChanged);
            // 
            // radioHasFee
            // 
            this.radioHasFee.AutoSize = true;
            this.radioHasFee.Location = new System.Drawing.Point(23, 85);
            this.radioHasFee.Name = "radioHasFee";
            this.radioHasFee.Size = new System.Drawing.Size(107, 24);
            this.radioHasFee.TabIndex = 1;
            this.radioHasFee.TabStop = true;
            this.radioHasFee.Text = "Monthly Fee";
            this.radioHasFee.UseVisualStyleBackColor = true;
            this.radioHasFee.CheckedChanged += new System.EventHandler(this.radioHasFee_CheckedChanged);
            // 
            // picCloseAdd
            // 
            this.picCloseAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picCloseAdd.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.picCloseAdd.Location = new System.Drawing.Point(411, 3);
            this.picCloseAdd.Name = "picCloseAdd";
            this.picCloseAdd.Size = new System.Drawing.Size(31, 31);
            this.picCloseAdd.TabIndex = 90;
            this.picCloseAdd.TabStop = false;
            this.picCloseAdd.Click += new System.EventHandler(this.picCloseAdd_Click);
            // 
            // txtAddPkgTitle
            // 
            this.txtAddPkgTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddPkgTitle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPkgTitle.Location = new System.Drawing.Point(178, 40);
            this.txtAddPkgTitle.Name = "txtAddPkgTitle";
            this.txtAddPkgTitle.Size = new System.Drawing.Size(238, 25);
            this.txtAddPkgTitle.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Title : *";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(122, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // datagridPackages
            // 
            this.datagridPackages.AllowDrop = true;
            this.datagridPackages.AllowUserToAddRows = false;
            this.datagridPackages.AllowUserToDeleteRows = false;
            this.datagridPackages.AllowUserToResizeRows = false;
            this.datagridPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPackages.Location = new System.Drawing.Point(20, 88);
            this.datagridPackages.Name = "datagridPackages";
            this.datagridPackages.ReadOnly = true;
            this.datagridPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPackages.Size = new System.Drawing.Size(730, 255);
            this.datagridPackages.TabIndex = 55;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(634, 26);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(116, 56);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "Maximize Table";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnDelPkg
            // 
            this.btnDelPkg.Location = new System.Drawing.Point(348, 39);
            this.btnDelPkg.Name = "btnDelPkg";
            this.btnDelPkg.Size = new System.Drawing.Size(96, 43);
            this.btnDelPkg.TabIndex = 2;
            this.btnDelPkg.Text = "Delete";
            this.btnDelPkg.UseVisualStyleBackColor = true;
            this.btnDelPkg.Click += new System.EventHandler(this.btnDelPkg_Click);
            // 
            // btnEditPkg
            // 
            this.btnEditPkg.Location = new System.Drawing.Point(229, 39);
            this.btnEditPkg.Name = "btnEditPkg";
            this.btnEditPkg.Size = new System.Drawing.Size(96, 43);
            this.btnEditPkg.TabIndex = 1;
            this.btnEditPkg.Text = "Edit ";
            this.btnEditPkg.UseVisualStyleBackColor = true;
            this.btnEditPkg.Click += new System.EventHandler(this.btnEditPkg_Click);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Location = new System.Drawing.Point(42, 39);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(164, 43);
            this.btnAddPkg.TabIndex = 0;
            this.btnAddPkg.Text = "Add New Package";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // radioEnable
            // 
            this.radioEnable.AutoSize = true;
            this.radioEnable.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.radioEnable.Location = new System.Drawing.Point(26, 211);
            this.radioEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioEnable.Name = "radioEnable";
            this.radioEnable.Size = new System.Drawing.Size(221, 24);
            this.radioEnable.TabIndex = 33;
            this.radioEnable.Text = "Enable Membership Packages";
            this.radioEnable.UseVisualStyleBackColor = true;
            this.radioEnable.CheckedChanged += new System.EventHandler(this.radioEnable_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 41);
            this.label1.TabIndex = 34;
            this.label1.Text = "Disable packages for just specifying the Maximum number of books that a member ca" +
    "n take.Its more fast and simple.";
            // 
            // radioDisable
            // 
            this.radioDisable.AutoSize = true;
            this.radioDisable.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.radioDisable.Location = new System.Drawing.Point(26, 11);
            this.radioDisable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioDisable.Name = "radioDisable";
            this.radioDisable.Size = new System.Drawing.Size(224, 24);
            this.radioDisable.TabIndex = 32;
            this.radioDisable.Text = "Disable Membership Packages";
            this.radioDisable.UseVisualStyleBackColor = true;
            this.radioDisable.CheckedChanged += new System.EventHandler(this.radioDisable_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1, 666);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(874, 30);
            this.lblStatus.TabIndex = 137;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 696);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpEnable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioEnable);
            this.Controls.Add(this.radioDisable);
            this.Controls.Add(this.grpDisable);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership Packages";
            this.Load += new System.EventHandler(this.frmPackages_Load);
            this.Shown += new System.EventHandler(this.frmPackages_Shown);
            this.grpDisable.ResumeLayout(false);
            this.grpDisable.PerformLayout();
            this.grpEnable.ResumeLayout(false);
            this.pnlAddPkg.ResumeLayout(false);
            this.pnlAddPkg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDisable;
        private System.Windows.Forms.GroupBox grpEnable;
        private System.Windows.Forms.RadioButton radioEnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxBooks;
        private System.Windows.Forms.Button btnSaveMaxBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditPkg;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.Button btnDelPkg;
        private System.Windows.Forms.DataGridView datagridPackages;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.RadioButton radioDisable;
        private System.Windows.Forms.Panel pnlAddPkg;
        private System.Windows.Forms.PictureBox picCloseAdd;
        private System.Windows.Forms.TextBox txtAddPkgTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.RadioButton radioNoFee;
        private System.Windows.Forms.RadioButton radioHasFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddPkgMaxBooks;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnMakeDefault;
    }
}