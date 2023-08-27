using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace LibraryManagementSystem
{
    public partial class frmExploreMembers : Form
    {

        SQLiteConnection con;
        string course, year;

        public frmExploreMembers()
        {
            InitializeComponent();
            con= MainForm.con;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmExploreMembers_Load(object sender, EventArgs e)
        {
            comboSearchFields.SelectedIndex = 0;
            /*
             * comboMBcateg.Items.Clear();
                while (dr.Read())
                {
                    treeViewExplore.Nodes["nodeCateg"].Nodes.Add(dr[0].ToString());

                    comboMBcateg.Items.Add(dr[0].ToString());
                }
                treeViewExplore.ExpandAll();
                dr.Close();
             */
            SQLiteCommand cmd = new SQLiteCommand("select distinct Course from MemberDetails", con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            int  i = 0;
            while (dr.Read())
            {
                treeViewExplore.Nodes.Add(dr[0].ToString());

               // treeViewExplore.Nodes.Add("nodeCateg", "Categories");

                SQLiteCommand cmd2 = new SQLiteCommand("select distinct AdmissionYear from MemberDetails ORDER by AdmissionYear desc", con);
                SQLiteDataReader dr2 = cmd2.ExecuteReader();
             //   treeViewExplore.Nodes["nodeCateg"].Nodes.Clear();
                while (dr2.Read())
                {
                    treeViewExplore.Nodes[i].Nodes.Add(dr2[0].ToString());

                }

                i++;
            }
        }

        private void treeViewExplore_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
           if (treeViewExplore.SelectedNode == null)
            {
                return;
            }
            if (treeViewExplore.SelectedNode.Level!=1)
            {
                return;
            }
            TreeNode selnode = treeViewExplore.SelectedNode;
            year = selnode.Text;
            course = selnode.Parent.Text;
            lblCourseAdmYr.Text = "Search in \nCourse : "+course +"\nAdmission Year : "+year;

            int res = 0;
            string fillcmd = string.Format("select MemberID,Name,Course,AdmissionYear,RollNo,PhoneNumber,Dob,Email from MemberDetails " + " where Course='{0}' and AdmissionYear='{1}' ORDER BY Name",course,year);
            res = fillGrid(fillcmd);
            if (res == 0)
            {
              lblresultCount.Text= "No Members to Display ";
            }
            else
            {
             lblresultCount.Text = "Displaying " + res + " Members ";
            }
           
            
        }

        private int fillGrid(string cmdtext)
        {
            SQLiteCommand com = new SQLiteCommand(cmdtext, con);
            SQLiteDataReader dtr;
            dtr = com.ExecuteReader();
            DataTable tableExplore = new DataTable();

            tableExplore.Load(dtr);
            dtr.Close();

            gridviewExplore.DataSource = tableExplore;

            return tableExplore.Rows.Count;
        }

        private void textSearchTerm_TextChanged(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void mmsearch()
        {
            string searchterm;
            string selectcmd;
            try
            {
                searchterm =textSearchTerm.Text;
                if (string.IsNullOrEmpty(searchterm))
                {
                    lblresultCount.Text = "Enter a Search Term for Searching Library Members.";
                    treeViewExplore_AfterSelect(null, null);
                    return;
                }
                selectcmd = string.Format("select MemberID,Name,Course,AdmissionYear,RollNo,PhoneNumber,Dob,Email from MemberDetails where {0} LIKE('%{1}%') AND Course='{2}' AND AdmissionYear='{3}' ", comboSearchFields.Text, searchterm,course,year);
                SQLiteCommand cmd = new SQLiteCommand(selectcmd, con);
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                  gridviewExplore.DataSource = dt;

                  int c = dt.Rows.Count;
                  lblresultCount.Text = "Displaying " + c + " Members ";
                   
                }
                else
                {
                    lblresultCount.Text = "No Members to Display ";
                    gridviewExplore.DataSource = null;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboSearchFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void textSearchTerm_Enter(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void gridviewExplore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridviewExplore.RowCount == 0)
                return;

            frmMemberDetails.openwithmid =gridviewExplore.SelectedRows[0].Cells["MemberID"].Value.ToString();
            frmMemberDetails md = new frmMemberDetails();
            md.Show();
        }
    }
}
