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
    public partial class frmLang : Form
    {
        public frmLang()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLangName.Text.Trim()))
            {
                MessageBox.Show("Enter Language Name");
                txtLangName.Clear();
                txtLangName.Focus();
               
                return;
            }
            if (txtLangName.Text.Contains(","))
            {
                MessageBox.Show("Comma is not allowed");
                return;
            }

            listLang.Items.Add(txtLangName.Text);
            txtLangName.Clear();
            txtLangName.Focus();
            listLang.SelectedIndex = listLang.Items.Count-1;
        }

        private void frmLang_Load(object sender, EventArgs e)
        {
            string langs =MainForm.dbsettings.languageList;
            if (string.IsNullOrEmpty(langs.Trim()))
                return;
            string[] langarray = langs.Split(',');
            foreach (string item in langarray)
            {
               listLang.Items.Add(item);
            }
            listLang.SelectedIndex = 0;
        }

        private void frmLang_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> list = new List<string>();

            foreach (string arr in listLang.Items)
            {
                list.Add(arr);
            }

            string langs = string.Join(",", list.ToArray());

            MainForm.dbsettings.languageList = langs;
          

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listLang.Items.Count == 0)
                return;

            int selindex = listLang.SelectedIndex;
            listLang.Items.Remove(listLang.SelectedItem);

            if (selindex >= listLang.Items.Count)
                 listLang.SelectedIndex = selindex - 1;
            else
                listLang.SelectedIndex = selindex;
     
        }
        public void MoveUp()
        {
            MoveItem(-1);
        }

        public void MoveDown()
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            ListBox lb = listLang;
            // Checking selected item
            if (lb.SelectedItem == null || lb.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lb.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lb.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lb.SelectedItem;

            // Removing removable element
            lb.Items.Remove(selected);
            // Insert it in new position
            lb.Items.Insert(newIndex, selected);
            // Restore selection
            lb.SetSelected(newIndex, true);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void frmLang_Shown(object sender, EventArgs e)
        {
            txtLangName.Focus();
        }

    }
}
