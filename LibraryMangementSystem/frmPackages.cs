using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace LibraryManagementSystem
{
    public partial class frmPackages : Form
    {
        SQLiteCommand cmd = new SQLiteCommand(MainForm.con);
        SQLiteDataReader dr;
        string editid;
        string cmdtext;
        SQLiteConnection con;
        public frmPackages()
        {
            con = MainForm.con;
            InitializeComponent();
        }

        private void radioDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDisable.Checked)
            {
                grpDisable.Enabled = true;
                grpEnable.Enabled = false;
                txtMaxBooks.Text = MainForm.dbsettings.maxBooks.ToString();

               MainForm.dbsettings.usePackages = false;

               
            }
            
        }

        private void grpDisable_Enter(object sender, EventArgs e)
        {

        }

      

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (grpEnable.Dock != DockStyle.Fill)
                        grpEnable.Dock = DockStyle.Fill;             
                  else
                grpEnable.Dock = DockStyle.None;
            
        }

        private void radioHasFee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHasFee.Checked)
            {
                txtFee.Enabled = true;
                lblAmount.Enabled = true;
            }
            
        }
        private void fillgrid()
        {
            cmd.CommandText = "SELECT * from Packages ORDER BY ID";
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                datagridPackages.DataSource = dt;



            }
            else
            {


             
                datagridPackages.DataSource = null;
            }
            dr.Close();
        }
        private void frmPackages_Load(object sender, EventArgs e)
        {
            pnlAddPkg.Hide();
            fillgrid();
        }

        private void radioEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(radioEnable.Checked)
            {
                grpDisable.Enabled = false;
                grpEnable.Enabled = true;
             MainForm.dbsettings.usePackages = true;
                

                
            }
        }

        private void frmPackages_Shown(object sender, EventArgs e)
        {
            radioNoFee.Checked = true;
            if (MainForm.dbsettings.usePackages)
                radioEnable.Checked = true;
            else
            radioDisable.Checked = true;
        }

        private void radioNoFee_CheckedChanged(object sender, EventArgs e)
        {
            if(radioNoFee.Checked)
            {
            
                txtFee.Enabled = false;
                lblAmount.Enabled = false;
            }
        }

        private void picCloseAdd_Click(object sender, EventArgs e)
        {
            txtAddPkgTitle.Clear();
            txtFee.Clear();
            txtAddPkgMaxBooks.Clear();
            pnlAddPkg.Hide();
            fillgrid();
        }

        private void btnAddPkg_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
            pnlAddPkg.Show();
        }

        private void btnSaveMaxBooks_Click(object sender, EventArgs e)
        {
         
            MainForm.dbsettings.maxBooks = Convert.ToInt32(txtMaxBooks.Text);
           
            lblStatus.Text = "Maximum Books Saved.";
            
        }
        private void addPkg()
        {
            try
            {
                if (String.IsNullOrEmpty(txtAddPkgTitle.Text))
                {
                    MessageBox.Show("Enter Package Title");
                    return;
                }
                int fee = 0; bool hasfee = false;
                int id;
                bool hasdel =MainForm.dbsettings.hasDelPackages;
                id = MainForm.getNextID(hasdel, "Packages");
                
                if (radioHasFee.Checked)
                {
                    if(String.IsNullOrEmpty(txtFee.Text))
                {
                        MessageBox.Show("Enter Monthly Fee");
                        return;
                }
                  
                         fee = Convert.ToInt32(txtFee.Text);

                    hasfee = true;
                }
                if (String.IsNullOrEmpty(txtAddPkgMaxBooks.Text))
                {
                    MessageBox.Show("Enter Maximum Books");
                    return;
                }
                int maxBooks = Convert.ToInt32(txtAddPkgMaxBooks.Text);
                string pkgtitle = txtAddPkgTitle.Text;

                cmd.CommandText = "INSERT INTO Packages(ID,PackageTitle,HasFee,MonthlyFee,MaxBooks) VALUES(@id,@title,@hasfee,@monthfee,@maxbooks);";

                cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                cmd.Parameters.Add("@title", DbType.String).Value = pkgtitle;
                cmd.Parameters.Add("@hasfee", DbType.String).Value = hasfee.ToString();
                cmd.Parameters.Add("@monthfee", DbType.Int32).Value = fee;
                cmd.Parameters.Add("@maxbooks", DbType.Int32).Value = maxBooks;
                cmd.ExecuteNonQuery();
                lblStatus.Text = "Package " + pkgtitle + " was added.";
                txtAddPkgTitle.Clear();
                txtFee.Clear();
                txtAddPkgMaxBooks.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void editPkg()
        {
            try
            {
                
                int fee = 0; bool hasfee = false;
                if (radioHasFee.Checked)
                {
                    fee = Convert.ToInt32(txtFee.Text);
                    hasfee = true;
                }
                int maxBooks = Convert.ToInt32(txtAddPkgMaxBooks.Text);
                string pkgtitle = txtAddPkgTitle.Text;

                cmd.CommandText = "UPDATE Packages SET PackageTitle=@title,HasFee=@hasfee,MonthlyFee=@monthfee,MaxBooks=@maxbooks WHERE ID=@id";

                cmd.Parameters.Add("@id", DbType.Int32).Value = editid;
                cmd.Parameters.Add("@title", DbType.String).Value = pkgtitle;
                cmd.Parameters.Add("@hasfee", DbType.String).Value = hasfee.ToString();
                cmd.Parameters.Add("@monthfee", DbType.Int32).Value = fee;
                cmd.Parameters.Add("@maxbooks", DbType.Int32).Value = maxBooks;
                cmd.ExecuteNonQuery();
                lblStatus.Text = "Package " + pkgtitle + " was Saved.";
                txtAddPkgTitle.Clear();
                txtFee.Clear();
                txtAddPkgMaxBooks.Clear();
                picCloseAdd_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
                addPkg();
            else
                editPkg();
        }

        private void btnEditPkg_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Save Changes";
            lblStatus.Text = "Edit Packages";
            editid = datagridPackages.SelectedRows[0].Cells["ID"].Value.ToString();

            if (String.IsNullOrEmpty(editid.Trim()))
            {
                MessageBox.Show("Please Select a Package to Edit.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            cmdtext = String.Format("select * from Packages where ID={0};", editid);
            //  cmd.CommandText = cmdtext;
            cmd = new SQLiteCommand(cmdtext, con);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Package not found.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dr.Close();
                    return;
                }

                while (dr.Read())
                {
                    txtAddPkgTitle.Text = dr["PackageTitle"].ToString();
                    bool hasfee = Convert.ToBoolean(dr["HasFee"].ToString());
                    if (hasfee)
                        radioHasFee.Checked = true;
                    txtFee.Text = dr["MonthlyFee"].ToString();
                    txtAddPkgMaxBooks.Text = dr["MaxBooks"].ToString();



                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }

            btnAdd.Text = "Save Changes";
            pnlAddPkg.Show();
            pnlAddPkg.BringToFront();




        
        }

        private void btnDelPkg_Click(object sender, EventArgs e)
        {
            
            string delid =   datagridPackages.SelectedRows[0].Cells["ID"].Value.ToString();
            string pkgtitle =   datagridPackages.SelectedRows[0].Cells["PackageTitle"].Value.ToString();
            DialogResult dres = MessageBox.Show("Do you want to DELETE this Package ?\nName: " + pkgtitle, "Confirm DELETE Operation", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {


                cmd.CommandText = string.Format("DELETE FROM Packages WHERE ID={0}", delid);
                cmd.ExecuteNonQuery();
                string msg = "The Package '" + pkgtitle + "'  ID:" + delid + " was DELETED successfully.";
                lblStatus.Text = msg;


                cmd.CommandText = string.Format("INSERT INTO DeletedID(tablename,deletedid) VALUES('{0}',{1});", "Packages", delid);
                cmd.ExecuteNonQuery();
                MainForm.dbsettings.hasDelPackages= true;
                
                fillgrid();

            }
            else
            {
                lblStatus.Text = "DELETE Action was Cancelled.";
            }
        }

        private void btnMakeDefault_Click(object sender, EventArgs e)
        {
            string pkg = datagridPackages.SelectedRows[0].Cells["PackageTitle"].Value.ToString();
            MainForm.dbsettings.defaultPkg = pkg;

         
            lblStatus.Text = "Default package is " + pkg;
        }
    }
}
