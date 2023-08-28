namespace LibraryManagementSystem
{
    partial class frmBookCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookCopy));
            this.textBid = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBid
            // 
            this.textBid.BackColor = System.Drawing.SystemColors.Window;
            this.textBid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBid.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBid.Location = new System.Drawing.Point(160, 57);
            this.textBid.Name = "textBid";
            this.textBid.Size = new System.Drawing.Size(148, 25);
            this.textBid.TabIndex = 0;
            this.textBid.TextChanged += new System.EventHandler(this.textBid_TextChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(63, 59);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 20);
            this.label35.TabIndex = 133;
            this.label35.Text = "Libro ID :";
            // 
            // ok
            // 
            this.ok.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ok.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(114, 129);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(143, 48);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // frmBookCopy
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 215);
            this.Controls.Add(this.textBid);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Copy";
            this.Load += new System.EventHandler(this.frmBookCopy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBid;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button ok;
    }
}