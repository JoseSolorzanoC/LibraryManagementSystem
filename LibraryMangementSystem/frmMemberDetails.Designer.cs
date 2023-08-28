namespace LibraryManagementSystem
{
    partial class frmMemberDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberDetails));
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmemid2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.btnCancelPkg = new System.Windows.Forms.Button();
            this.btnsummary = new System.Windows.Forms.Button();
            this.datagridPackages = new System.Windows.Forms.DataGridView();
            this.labelenlarge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtAdmYear = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(213, 21);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(259, 25);
            this.txtMemberID.TabIndex = 0;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(499, 13);
            this.btnok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(86, 42);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 184;
            this.label3.Text = "ID de miembro :";
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(213, 281);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(244, 25);
            this.txtEmail.TabIndex = 198;
            this.txtEmail.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 197;
            this.label4.Text = "Email :";
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsTab = true;
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(213, 314);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(244, 25);
            this.txtPhone.TabIndex = 194;
            this.txtPhone.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 193;
            this.label2.Text = "Número de teléfono :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 447);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 192;
            this.label1.Text = "Paquetes de afiliación :";
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(213, 144);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(429, 123);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(659, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(244, 25);
            this.txtName.TabIndex = 3;
            this.txtName.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 189;
            this.label8.Text = "Dirección :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(567, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 188;
            this.label11.Text = "Nombre :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 187;
            this.label10.Text = "Fecha de nacimiento :";
            // 
            // txtmemid2
            // 
            this.txtmemid2.BackColor = System.Drawing.SystemColors.Window;
            this.txtmemid2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmemid2.Location = new System.Drawing.Point(213, 65);
            this.txtmemid2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmemid2.Name = "txtmemid2";
            this.txtmemid2.ReadOnly = true;
            this.txtmemid2.Size = new System.Drawing.Size(244, 25);
            this.txtmemid2.TabIndex = 2;
            this.txtmemid2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 199;
            this.label5.Text = "ID de miembro :";
            // 
            // txtdob
            // 
            this.txtdob.BackColor = System.Drawing.SystemColors.Window;
            this.txtdob.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdob.Location = new System.Drawing.Point(213, 109);
            this.txtdob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdob.Name = "txtdob";
            this.txtdob.ReadOnly = true;
            this.txtdob.Size = new System.Drawing.Size(244, 25);
            this.txtdob.TabIndex = 4;
            this.txtdob.TabStop = false;
            // 
            // btnCancelPkg
            // 
            this.btnCancelPkg.AllowDrop = true;
            this.btnCancelPkg.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPkg.Location = new System.Drawing.Point(851, 470);
            this.btnCancelPkg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelPkg.Name = "btnCancelPkg";
            this.btnCancelPkg.Size = new System.Drawing.Size(127, 66);
            this.btnCancelPkg.TabIndex = 3;
            this.btnCancelPkg.Text = "Cancelar el último paquete";
            this.btnCancelPkg.UseVisualStyleBackColor = true;
            this.btnCancelPkg.Click += new System.EventHandler(this.btnCancelPkg_Click);
            // 
            // btnsummary
            // 
            this.btnsummary.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsummary.Location = new System.Drawing.Point(709, 310);
            this.btnsummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsummary.Name = "btnsummary";
            this.btnsummary.Size = new System.Drawing.Size(155, 45);
            this.btnsummary.TabIndex = 2;
            this.btnsummary.Text = "Resumen";
            this.btnsummary.UseVisualStyleBackColor = true;
            this.btnsummary.Click += new System.EventHandler(this.btnsummary_Click);
            // 
            // datagridPackages
            // 
            this.datagridPackages.AllowUserToAddRows = false;
            this.datagridPackages.AllowUserToDeleteRows = false;
            this.datagridPackages.AllowUserToResizeRows = false;
            this.datagridPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridPackages.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPackages.Location = new System.Drawing.Point(12, 470);
            this.datagridPackages.Name = "datagridPackages";
            this.datagridPackages.ReadOnly = true;
            this.datagridPackages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPackages.Size = new System.Drawing.Size(832, 146);
            this.datagridPackages.TabIndex = 205;
            // 
            // labelenlarge
            // 
            this.labelenlarge.AutoSize = true;
            this.labelenlarge.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelenlarge.Location = new System.Drawing.Point(705, 102);
            this.labelenlarge.Name = "labelenlarge";
            this.labelenlarge.Size = new System.Drawing.Size(159, 20);
            this.labelenlarge.TabIndex = 206;
            this.labelenlarge.Text = "Haga clic para ampliar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 207;
            this.label6.Text = "Curso :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 208;
            this.label7.Text = "Año de admisión :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 416);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 209;
            this.label9.Text = "Número de roll :";
            // 
            // txtCourse
            // 
            this.txtCourse.AcceptsReturn = true;
            this.txtCourse.AcceptsTab = true;
            this.txtCourse.BackColor = System.Drawing.SystemColors.Window;
            this.txtCourse.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(213, 347);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(244, 25);
            this.txtCourse.TabIndex = 210;
            this.txtCourse.TabStop = false;
            // 
            // txtAdmYear
            // 
            this.txtAdmYear.AcceptsTab = true;
            this.txtAdmYear.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdmYear.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmYear.Location = new System.Drawing.Point(213, 380);
            this.txtAdmYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdmYear.Name = "txtAdmYear";
            this.txtAdmYear.ReadOnly = true;
            this.txtAdmYear.Size = new System.Drawing.Size(244, 25);
            this.txtAdmYear.TabIndex = 211;
            this.txtAdmYear.TabStop = false;
            // 
            // txtRollNo
            // 
            this.txtRollNo.AcceptsTab = true;
            this.txtRollNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtRollNo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.Location = new System.Drawing.Point(213, 413);
            this.txtRollNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.ReadOnly = true;
            this.txtRollNo.Size = new System.Drawing.Size(244, 25);
            this.txtRollNo.TabIndex = 212;
            this.txtRollNo.TabStop = false;
            // 
            // picPhoto
            // 
            this.picPhoto.Image = global::LibraryManagementSystem.Properties.Resources.BlankFace;
            this.picPhoto.InitialImage = null;
            this.picPhoto.Location = new System.Drawing.Point(709, 127);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(155, 151);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 178;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            // 
            // frmMemberDetails
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(991, 628);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.txtAdmYear);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelenlarge);
            this.Controls.Add(this.datagridPackages);
            this.Controls.Add(this.btnsummary);
            this.Controls.Add(this.btnCancelPkg);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.txtmemid2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Details";
            this.Load += new System.EventHandler(this.frmMemberDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmemid2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.Button btnCancelPkg;
        private System.Windows.Forms.Button btnsummary;
        private System.Windows.Forms.DataGridView datagridPackages;
        private System.Windows.Forms.Label labelenlarge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtAdmYear;
        private System.Windows.Forms.TextBox txtRollNo;
    }
}