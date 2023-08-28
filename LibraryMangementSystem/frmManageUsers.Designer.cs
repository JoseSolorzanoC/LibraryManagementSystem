namespace LibraryManagementSystem
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.btnEnable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.btnMakeDefault = new System.Windows.Forms.Button();
            this.datagridUsers = new System.Windows.Forms.DataGridView();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddPass2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAddPass1 = new System.Windows.Forms.TextBox();
            this.picCloseAdd = new System.Windows.Forms.PictureBox();
            this.txtAddUname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlEditUsers = new System.Windows.Forms.Panel();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picCloseEdit = new System.Windows.Forms.PictureBox();
            this.txtEditUname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsers)).BeginInit();
            this.pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseAdd)).BeginInit();
            this.pnlEditUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(17, 12);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(146, 61);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Habilitar usuarios";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 54);
            this.label1.TabIndex = 35;
            this.label1.Text = "Habilitar Usuarios para múltiples usuarios con nombre de usuario y contraseña y u" +
    "n Administrador.Deshabilitarlo para un simple autologin de Administrador sin mos" +
    "trar la ventana de login.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.btnMakeDefault);
            this.grpUsers.Controls.Add(this.datagridUsers);
            this.grpUsers.Controls.Add(this.btnDelUser);
            this.grpUsers.Controls.Add(this.btnEditUser);
            this.grpUsers.Controls.Add(this.btnAddNewUser);
            this.grpUsers.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.grpUsers.Location = new System.Drawing.Point(17, 81);
            this.grpUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUsers.Size = new System.Drawing.Size(780, 483);
            this.grpUsers.TabIndex = 1;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Manage Users";
            // 
            // btnMakeDefault
            // 
            this.btnMakeDefault.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDefault.Location = new System.Drawing.Point(573, 39);
            this.btnMakeDefault.Name = "btnMakeDefault";
            this.btnMakeDefault.Size = new System.Drawing.Size(164, 43);
            this.btnMakeDefault.TabIndex = 3;
            this.btnMakeDefault.Text = "Hacer usuario por defecto";
            this.btnMakeDefault.UseVisualStyleBackColor = true;
            this.btnMakeDefault.Click += new System.EventHandler(this.btnMakeDefault_Click);
            // 
            // datagridUsers
            // 
            this.datagridUsers.AllowDrop = true;
            this.datagridUsers.AllowUserToAddRows = false;
            this.datagridUsers.AllowUserToDeleteRows = false;
            this.datagridUsers.AllowUserToResizeRows = false;
            this.datagridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUsers.Location = new System.Drawing.Point(20, 88);
            this.datagridUsers.Name = "datagridUsers";
            this.datagridUsers.ReadOnly = true;
            this.datagridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridUsers.Size = new System.Drawing.Size(730, 362);
            this.datagridUsers.StandardTab = true;
            this.datagridUsers.TabIndex = 4;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(393, 39);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(164, 43);
            this.btnDelUser.TabIndex = 2;
            this.btnDelUser.Text = "Borrar usuario";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(213, 39);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(164, 43);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Editar/Ver Usuario";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(33, 39);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(164, 43);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "Añadir nuevo usuario";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.BackColor = System.Drawing.Color.White;
            this.pnlAddUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddUser.Controls.Add(this.txtAddEmail);
            this.pnlAddUser.Controls.Add(this.label7);
            this.pnlAddUser.Controls.Add(this.txtAddPhone);
            this.pnlAddUser.Controls.Add(this.label6);
            this.pnlAddUser.Controls.Add(this.txtAddAddress);
            this.pnlAddUser.Controls.Add(this.label5);
            this.pnlAddUser.Controls.Add(this.txtAddName);
            this.pnlAddUser.Controls.Add(this.label4);
            this.pnlAddUser.Controls.Add(this.txtAddPass2);
            this.pnlAddUser.Controls.Add(this.label2);
            this.pnlAddUser.Controls.Add(this.lblAmount);
            this.pnlAddUser.Controls.Add(this.txtAddPass1);
            this.pnlAddUser.Controls.Add(this.picCloseAdd);
            this.pnlAddUser.Controls.Add(this.txtAddUname);
            this.pnlAddUser.Controls.Add(this.label3);
            this.pnlAddUser.Controls.Add(this.btnAdd);
            this.pnlAddUser.Location = new System.Drawing.Point(203, 79);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(445, 542);
            this.pnlAddUser.TabIndex = 2;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddEmail.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEmail.Location = new System.Drawing.Point(182, 413);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(238, 25);
            this.txtAddEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 103;
            this.label7.Text = "Email : ";
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddPhone.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPhone.Location = new System.Drawing.Point(182, 371);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(238, 25);
            this.txtAddPhone.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "Número de teléfono : ";
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.AcceptsReturn = true;
            this.txtAddAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddAddress.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress.Location = new System.Drawing.Point(182, 245);
            this.txtAddAddress.Multiline = true;
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(238, 97);
            this.txtAddAddress.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 99;
            this.label5.Text = "Direccion :";
            // 
            // txtAddName
            // 
            this.txtAddName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(178, 192);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(238, 25);
            this.txtAddName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Nombre";
            // 
            // txtAddPass2
            // 
            this.txtAddPass2.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddPass2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPass2.Location = new System.Drawing.Point(178, 152);
            this.txtAddPass2.Name = "txtAddPass2";
            this.txtAddPass2.PasswordChar = '*';
            this.txtAddPass2.Size = new System.Drawing.Size(238, 25);
            this.txtAddPass2.TabIndex = 2;
            this.txtAddPass2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Reescribir contraseña :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(19, 114);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(95, 20);
            this.lblAmount.TabIndex = 94;
            this.lblAmount.Text = "Contraseña :";
            // 
            // txtAddPass1
            // 
            this.txtAddPass1.AcceptsTab = true;
            this.txtAddPass1.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddPass1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPass1.Location = new System.Drawing.Point(178, 109);
            this.txtAddPass1.Name = "txtAddPass1";
            this.txtAddPass1.PasswordChar = '*';
            this.txtAddPass1.Size = new System.Drawing.Size(238, 25);
            this.txtAddPass1.TabIndex = 1;
            this.txtAddPass1.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            // 
            // picCloseAdd
            // 
            this.picCloseAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picCloseAdd.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.picCloseAdd.Location = new System.Drawing.Point(409, 3);
            this.picCloseAdd.Name = "picCloseAdd";
            this.picCloseAdd.Size = new System.Drawing.Size(31, 31);
            this.picCloseAdd.TabIndex = 90;
            this.picCloseAdd.TabStop = false;
            this.picCloseAdd.Click += new System.EventHandler(this.picCloseAdd_Click);
            // 
            // txtAddUname
            // 
            this.txtAddUname.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddUname.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddUname.Location = new System.Drawing.Point(178, 65);
            this.txtAddUname.Name = "txtAddUname";
            this.txtAddUname.Size = new System.Drawing.Size(238, 25);
            this.txtAddUname.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Nombre de usuario : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(131, 475);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 37);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Añadir Usuario";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1, 576);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(815, 30);
            this.lblStatus.TabIndex = 138;
            this.lblStatus.Text = "Estado";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEditUsers
            // 
            this.pnlEditUsers.BackColor = System.Drawing.Color.White;
            this.pnlEditUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditUsers.Controls.Add(this.btnResetPass);
            this.pnlEditUsers.Controls.Add(this.txtEditEmail);
            this.pnlEditUsers.Controls.Add(this.label8);
            this.pnlEditUsers.Controls.Add(this.txtEditPhone);
            this.pnlEditUsers.Controls.Add(this.label9);
            this.pnlEditUsers.Controls.Add(this.txtEditAddress);
            this.pnlEditUsers.Controls.Add(this.label10);
            this.pnlEditUsers.Controls.Add(this.txtEditName);
            this.pnlEditUsers.Controls.Add(this.label11);
            this.pnlEditUsers.Controls.Add(this.picCloseEdit);
            this.pnlEditUsers.Controls.Add(this.txtEditUname);
            this.pnlEditUsers.Controls.Add(this.label14);
            this.pnlEditUsers.Controls.Add(this.btnEditSave);
            this.pnlEditUsers.Location = new System.Drawing.Point(231, 79);
            this.pnlEditUsers.Name = "pnlEditUsers";
            this.pnlEditUsers.Size = new System.Drawing.Size(445, 538);
            this.pnlEditUsers.TabIndex = 4;
            this.pnlEditUsers.Leave += new System.EventHandler(this.pnlEditUsers_Leave);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.Location = new System.Drawing.Point(23, 102);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(220, 37);
            this.btnResetPass.TabIndex = 1;
            this.btnResetPass.Text = "Restablecer contraseña: ";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.txtResetPass_Click);
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditEmail.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEmail.Location = new System.Drawing.Point(178, 382);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(238, 25);
            this.txtEditEmail.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Email : ";
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditPhone.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPhone.Location = new System.Drawing.Point(178, 335);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(238, 25);
            this.txtEditPhone.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 101;
            this.label9.Text = "Número de teléfono : ";
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.AcceptsReturn = true;
            this.txtEditAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtEditAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditAddress.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAddress.Location = new System.Drawing.Point(178, 214);
            this.txtEditAddress.Multiline = true;
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(238, 97);
            this.txtEditAddress.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 99;
            this.label10.Text = "Direccion : ";
            // 
            // txtEditName
            // 
            this.txtEditName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtEditName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditName.Location = new System.Drawing.Point(178, 161);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(238, 25);
            this.txtEditName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 97;
            this.label11.Text = "Nombre :";
            // 
            // picCloseEdit
            // 
            this.picCloseEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picCloseEdit.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.picCloseEdit.Location = new System.Drawing.Point(409, 3);
            this.picCloseEdit.Name = "picCloseEdit";
            this.picCloseEdit.Size = new System.Drawing.Size(31, 31);
            this.picCloseEdit.TabIndex = 90;
            this.picCloseEdit.TabStop = false;
            this.picCloseEdit.Click += new System.EventHandler(this.picCloseEdit_Click);
            // 
            // txtEditUname
            // 
            this.txtEditUname.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditUname.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditUname.Location = new System.Drawing.Point(178, 65);
            this.txtEditUname.Name = "txtEditUname";
            this.txtEditUname.Size = new System.Drawing.Size(238, 25);
            this.txtEditUname.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 20);
            this.label14.TabIndex = 87;
            this.label14.Text = "Nombre de usuario : ";
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.Location = new System.Drawing.Point(118, 444);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(220, 37);
            this.btnEditSave.TabIndex = 6;
            this.btnEditSave.Text = "Guardar Cambios";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 607);
            this.Controls.Add(this.pnlAddUser);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlEditUsers);
            this.Controls.Add(this.grpUsers);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageUsers_FormClosing);
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.grpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsers)).EndInit();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseAdd)).EndInit();
            this.pnlEditUsers.ResumeLayout(false);
            this.pnlEditUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.Button btnMakeDefault;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.PictureBox picCloseAdd;
        private System.Windows.Forms.TextBox txtAddUname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView datagridUsers;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.TextBox txtAddPass2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddPass1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlEditUsers;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picCloseEdit;
        private System.Windows.Forms.TextBox txtEditUname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEditSave;
    }
}