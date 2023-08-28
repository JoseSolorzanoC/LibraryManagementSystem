namespace LibraryManagementSystem
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.label14 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.NumericUpDown();
            this.txtDaysToIssue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaysToIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 20);
            this.label14.TabIndex = 120;
            this.label14.Text = "Multa por día : ";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(66, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(276, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Días de expedición : ";
            // 
            // txtFine
            // 
            this.txtFine.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.Location = new System.Drawing.Point(138, 29);
            this.txtFine.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(238, 25);
            this.txtFine.TabIndex = 0;
            // 
            // txtDaysToIssue
            // 
            this.txtDaysToIssue.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysToIssue.Location = new System.Drawing.Point(138, 83);
            this.txtDaysToIssue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtDaysToIssue.Name = "txtDaysToIssue";
            this.txtDaysToIssue.Size = new System.Drawing.Size(238, 25);
            this.txtDaysToIssue.TabIndex = 1;
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 420);
            this.Controls.Add(this.txtDaysToIssue);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Options";
            this.Load += new System.EventHandler(this.frmFine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaysToIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtFine;
        private System.Windows.Forms.NumericUpDown txtDaysToIssue;
    }
}