using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmBookCopy : Form
    {
        public string returnid { get; set; } 
        public frmBookCopy()
        {
            InitializeComponent();
        }

        private void frmBookCopy_Load(object sender, EventArgs e)
        {
            textBid.Focus();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBid.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                //textBid.Text= textBid.Text.Remove(textBid.Text.Length - 1);
                return;

            }

            returnid = textBid.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void textBid_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
