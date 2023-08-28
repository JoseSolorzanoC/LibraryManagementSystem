namespace LibraryManagementSystem
{
    partial class frmExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExport));
            this.label19 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.comboTablename = new System.Windows.Forms.ComboBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(25, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 20);
            this.label19.TabIndex = 90;
            this.label19.Text = "Nombre de tabla :";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(163, 100);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(220, 37);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Exportar a Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // comboTablename
            // 
            this.comboTablename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTablename.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTablename.FormattingEnabled = true;
            this.comboTablename.Items.AddRange(new object[] {
            "BookDetails",
            "MemberDetails",
            "SubmittedBooks",
            "IssueDetails",
            "UserDetails",
            "SetPackages",
            "Packages",
            "Categories",
            "PackageAccounting"});
            this.comboTablename.Location = new System.Drawing.Point(163, 37);
            this.comboTablename.Name = "comboTablename";
            this.comboTablename.Size = new System.Drawing.Size(341, 28);
            this.comboTablename.TabIndex = 0;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.Location = new System.Drawing.Point(393, 100);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(111, 37);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.Text = "Abrir carpeta";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(-3, 167);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(565, 90);
            this.lblStatus.TabIndex = 137;
            this.lblStatus.Text = "Estatus";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmExport
            // 
            this.AcceptButton = this.btnExport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 257);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.comboTablename);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnExport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export To Excel";
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox comboTablename;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lblStatus;
    }
}