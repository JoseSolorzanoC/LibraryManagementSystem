namespace LibraryManagementSystem
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            this.datagridCateg = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlAddCateg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddCateg = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAddShelf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddOk = new System.Windows.Forms.Button();
            this.pnlEditCateg = new System.Windows.Forms.Panel();
            this.picCloseEdit = new System.Windows.Forms.PictureBox();
            this.txtEditCateg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditShelf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnMakeDefault = new System.Windows.Forms.Button();
            this.lbldefault = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCateg)).BeginInit();
            this.pnlAddCateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEditCateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridCateg
            // 
            this.datagridCateg.AllowDrop = true;
            this.datagridCateg.AllowUserToAddRows = false;
            this.datagridCateg.AllowUserToDeleteRows = false;
            this.datagridCateg.AllowUserToResizeRows = false;
            this.datagridCateg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridCateg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridCateg.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridCateg.Location = new System.Drawing.Point(12, 57);
            this.datagridCateg.Name = "datagridCateg";
            this.datagridCateg.ReadOnly = true;
            this.datagridCateg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCateg.Size = new System.Drawing.Size(656, 324);
            this.datagridCateg.StandardTab = true;
            this.datagridCateg.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(238, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(211, 39);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(455, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(213, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlAddCateg
            // 
            this.pnlAddCateg.BackColor = System.Drawing.Color.White;
            this.pnlAddCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddCateg.Controls.Add(this.pictureBox1);
            this.pnlAddCateg.Controls.Add(this.txtAddCateg);
            this.pnlAddCateg.Controls.Add(this.label19);
            this.pnlAddCateg.Controls.Add(this.txtAddShelf);
            this.pnlAddCateg.Controls.Add(this.label5);
            this.pnlAddCateg.Controls.Add(this.btnAddOk);
            this.pnlAddCateg.Location = new System.Drawing.Point(139, 67);
            this.pnlAddCateg.Name = "pnlAddCateg";
            this.pnlAddCateg.Size = new System.Drawing.Size(445, 296);
            this.pnlAddCateg.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(411, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtAddCateg
            // 
            this.txtAddCateg.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddCateg.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCateg.Location = new System.Drawing.Point(178, 40);
            this.txtAddCateg.Name = "txtAddCateg";
            this.txtAddCateg.Size = new System.Drawing.Size(238, 25);
            this.txtAddCateg.TabIndex = 0;
            this.txtAddCateg.TextChanged += new System.EventHandler(this.textBDbookid_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 20);
            this.label19.TabIndex = 87;
            this.label19.Text = "Nombre de la categoría :";
            // 
            // txtAddShelf
            // 
            this.txtAddShelf.AcceptsReturn = true;
            this.txtAddShelf.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddShelf.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddShelf.Location = new System.Drawing.Point(178, 88);
            this.txtAddShelf.Multiline = true;
            this.txtAddShelf.Name = "txtAddShelf";
            this.txtAddShelf.Size = new System.Drawing.Size(238, 91);
            this.txtAddShelf.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Estante :";
            // 
            // btnAddOk
            // 
            this.btnAddOk.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOk.Location = new System.Drawing.Point(112, 222);
            this.btnAddOk.Name = "btnAddOk";
            this.btnAddOk.Size = new System.Drawing.Size(220, 37);
            this.btnAddOk.TabIndex = 2;
            this.btnAddOk.Text = "OK";
            this.btnAddOk.UseVisualStyleBackColor = true;
            this.btnAddOk.Click += new System.EventHandler(this.btnAddOk_Click);
            // 
            // pnlEditCateg
            // 
            this.pnlEditCateg.BackColor = System.Drawing.Color.White;
            this.pnlEditCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditCateg.Controls.Add(this.picCloseEdit);
            this.pnlEditCateg.Controls.Add(this.txtEditCateg);
            this.pnlEditCateg.Controls.Add(this.label2);
            this.pnlEditCateg.Controls.Add(this.txtEditShelf);
            this.pnlEditCateg.Controls.Add(this.label3);
            this.pnlEditCateg.Controls.Add(this.btnSave);
            this.pnlEditCateg.Location = new System.Drawing.Point(115, 71);
            this.pnlEditCateg.Name = "pnlEditCateg";
            this.pnlEditCateg.Size = new System.Drawing.Size(445, 296);
            this.pnlEditCateg.TabIndex = 5;
            // 
            // picCloseEdit
            // 
            this.picCloseEdit.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.picCloseEdit.Location = new System.Drawing.Point(411, 3);
            this.picCloseEdit.Name = "picCloseEdit";
            this.picCloseEdit.Size = new System.Drawing.Size(31, 31);
            this.picCloseEdit.TabIndex = 90;
            this.picCloseEdit.TabStop = false;
            this.picCloseEdit.Click += new System.EventHandler(this.picCloseEdit_Click);
            // 
            // txtEditCateg
            // 
            this.txtEditCateg.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditCateg.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCateg.Location = new System.Drawing.Point(178, 40);
            this.txtEditCateg.Name = "txtEditCateg";
            this.txtEditCateg.Size = new System.Drawing.Size(238, 25);
            this.txtEditCateg.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nombre de la categoría :";
            // 
            // txtEditShelf
            // 
            this.txtEditShelf.AcceptsReturn = true;
            this.txtEditShelf.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditShelf.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditShelf.Location = new System.Drawing.Point(178, 88);
            this.txtEditShelf.Multiline = true;
            this.txtEditShelf.Name = "txtEditShelf";
            this.txtEditShelf.Size = new System.Drawing.Size(238, 91);
            this.txtEditShelf.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Estante :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(122, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 441);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(677, 30);
            this.lblStatus.TabIndex = 136;
            this.lblStatus.Text = "Estado";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMakeDefault
            // 
            this.btnMakeDefault.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDefault.Location = new System.Drawing.Point(448, 391);
            this.btnMakeDefault.Name = "btnMakeDefault";
            this.btnMakeDefault.Size = new System.Drawing.Size(220, 37);
            this.btnMakeDefault.TabIndex = 7;
            this.btnMakeDefault.Text = "Establecer categoría por defecto";
            this.btnMakeDefault.UseVisualStyleBackColor = true;
            this.btnMakeDefault.Click += new System.EventHandler(this.btnMakeDefault_Click);
            // 
            // lbldefault
            // 
            this.lbldefault.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefault.Location = new System.Drawing.Point(12, 391);
            this.lbldefault.Name = "lbldefault";
            this.lbldefault.Size = new System.Drawing.Size(300, 37);
            this.lbldefault.TabIndex = 191;
            this.lbldefault.Text = "Categoría por defecto :";
            this.lbldefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 471);
            this.Controls.Add(this.pnlEditCateg);
            this.Controls.Add(this.pnlAddCateg);
            this.Controls.Add(this.lbldefault);
            this.Controls.Add(this.btnMakeDefault);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.datagridCateg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Categories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCateg)).EndInit();
            this.pnlAddCateg.ResumeLayout(false);
            this.pnlAddCateg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEditCateg.ResumeLayout(false);
            this.pnlEditCateg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridCateg;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlAddCateg;
        private System.Windows.Forms.Button btnAddOk;
        private System.Windows.Forms.TextBox txtAddCateg;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAddShelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlEditCateg;
        private System.Windows.Forms.PictureBox picCloseEdit;
        private System.Windows.Forms.TextBox txtEditCateg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditShelf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnMakeDefault;
        private System.Windows.Forms.Label lbldefault;
    }
}