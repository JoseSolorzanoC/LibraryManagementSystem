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
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            
            string courses = MainForm.dbsettings.courseList;
            if (string.IsNullOrEmpty(courses.Trim()))
                return;
            string[] coursearray =courses.Split(',');
            foreach (string item in coursearray)
            {
                listCourse.Items.Add(item);
            }
            listCourse.SelectedIndex = 0;
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCourseName.Text.Trim()))
            {
                MessageBox.Show("Enter Course Name");
                txtCourseName.Clear();
                txtCourseName.Focus();
                return;
            }
            if (txtCourseName.Text.Contains(","))
            {
                MessageBox.Show("Comma is not allowed");
                return;
            }
          listCourse.Items.Add(txtCourseName.Text);
           txtCourseName.Clear();
           txtCourseName.Focus();
         listCourse.SelectedIndex =listCourse.Items.Count - 1;
        }

        private void frmCourses_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> list = new List<string>();

            foreach (string arr in listCourse.Items)
            {
                list.Add(arr);
            }

            string courses = string.Join(",", list.ToArray());

            MainForm.dbsettings.courseList= courses;
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             DialogResult dres = MessageBox.Show("Do you want to DELETE this Course ?\nName: " + listCourse.SelectedItem.ToString() , "Confirm DELETE Operation", MessageBoxButtons.YesNo);
             if (dres == DialogResult.Yes)
             {
                 if (listCourse.Items.Count == 0)
                     return;

                 int selindex = listCourse.SelectedIndex;

                 listCourse.Items.Remove(listCourse.SelectedItem);

                 if (selindex >= listCourse.Items.Count)
                     listCourse.SelectedIndex = selindex - 1;
                 else
                     listCourse.SelectedIndex = selindex;
             }
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
            ListBox lb = listCourse;
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

        private void frmCourses_Shown(object sender, EventArgs e)
        {
            txtCourseName.Focus();
        }
    }
}
