namespace LibraryManagementSystem
{
    partial class frmManageDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDatabase));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.listAvailDBs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMakeDefault = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlDbName = new System.Windows.Forms.Panel();
            this.picCloseDbName = new System.Windows.Forms.PictureBox();
            this.txtDBname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbldefault = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlDbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseDbName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(12, 281);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(130, 59);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Selected Database";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(281, 43);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(184, 51);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import Database";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // listAvailDBs
            // 
            this.listAvailDBs.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAvailDBs.FormattingEnabled = true;
            this.listAvailDBs.ItemHeight = 20;
            this.listAvailDBs.Location = new System.Drawing.Point(12, 43);
            this.listAvailDBs.Name = "listAvailDBs";
            this.listAvailDBs.Size = new System.Drawing.Size(263, 164);
            this.listAvailDBs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 186;
            this.label1.Text = "Available Databases :";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(145, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 59);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Selected Database";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMakeDefault
            // 
            this.btnMakeDefault.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDefault.Location = new System.Drawing.Point(12, 213);
            this.btnMakeDefault.Name = "btnMakeDefault";
            this.btnMakeDefault.Size = new System.Drawing.Size(263, 62);
            this.btnMakeDefault.TabIndex = 2;
            this.btnMakeDefault.Text = "Set Selected Database as the Default";
            this.btnMakeDefault.UseVisualStyleBackColor = true;
            this.btnMakeDefault.Click += new System.EventHandler(this.btnMakeDefault_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Database Files|*.db|All Files|*.*";
            // 
            // pnlDbName
            // 
            this.pnlDbName.BackColor = System.Drawing.Color.White;
            this.pnlDbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDbName.Controls.Add(this.picCloseDbName);
            this.pnlDbName.Controls.Add(this.txtDBname);
            this.pnlDbName.Controls.Add(this.label2);
            this.pnlDbName.Controls.Add(this.btnSave);
            this.pnlDbName.Location = new System.Drawing.Point(12, 12);
            this.pnlDbName.Name = "pnlDbName";
            this.pnlDbName.Size = new System.Drawing.Size(453, 153);
            this.pnlDbName.TabIndex = 189;
            // 
            // picCloseDbName
            // 
            this.picCloseDbName.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.picCloseDbName.Location = new System.Drawing.Point(417, 3);
            this.picCloseDbName.Name = "picCloseDbName";
            this.picCloseDbName.Size = new System.Drawing.Size(31, 31);
            this.picCloseDbName.TabIndex = 90;
            this.picCloseDbName.TabStop = false;
            this.picCloseDbName.Click += new System.EventHandler(this.picCloseDbName_Click);
            // 
            // txtDBname
            // 
            this.txtDBname.BackColor = System.Drawing.SystemColors.Window;
            this.txtDBname.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBname.Location = new System.Drawing.Point(178, 40);
            this.txtDBname.Name = "txtDBname";
            this.txtDBname.Size = new System.Drawing.Size(195, 25);
            this.txtDBname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Set Database Name :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(132, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbldefault
            // 
            this.lbldefault.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefault.Location = new System.Drawing.Point(290, 213);
            this.lbldefault.Name = "lbldefault";
            this.lbldefault.Size = new System.Drawing.Size(185, 127);
            this.lbldefault.TabIndex = 190;
            this.lbldefault.Text = "Default Database :";
            this.lbldefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckPathExists = false;
            this.saveFileDialog1.DefaultExt = "db";
            this.saveFileDialog1.Filter = "Database Files|*.db|All Files|*.*";
            // 
            // frmManageDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 353);
            this.Controls.Add(this.lbldefault);
            this.Controls.Add(this.btnMakeDefault);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAvailDBs);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pnlDbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Database";
            this.Load += new System.EventHandler(this.frmManageDatabase_Load);
            this.pnlDbName.ResumeLayout(false);
            this.pnlDbName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseDbName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ListBox listAvailDBs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMakeDefault;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlDbName;
        private System.Windows.Forms.PictureBox picCloseDbName;
        private System.Windows.Forms.TextBox txtDBname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbldefault;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}