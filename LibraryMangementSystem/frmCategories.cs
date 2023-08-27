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
    public partial class frmCategories : Form
    {
        SQLiteCommand cmd = new SQLiteCommand(MainForm.con);
        SQLiteDataReader dr;
        string editid;
        string cmdtext;
        SQLiteConnection con;
        public frmCategories()
        {
            con = MainForm.con;
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            pnlAddCateg.Hide();
            pnlEditCateg.Hide();
            fillgrid();
            
            lbldefault.Text = "Default Category :\n" + MainForm.dbsettings.defaultCateg;  
        }
        private void fillgrid()
        {
            cmd.CommandText = "SELECT * from Categories ORDER BY ID";
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                datagridCateg.DataSource = dt;



            }
           
            dr.Close();
        }
        private void textBDbookid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAddCateg.Text.Trim()))
                {
                    MessageBox.Show("Enter Category Name");
                    txtAddCateg.Clear();
                    txtAddCateg.Focus();
                    return;
                }
             
                int id;
                bool hasdel = MainForm.dbsettings.hasDelCategories; ;
                id = MainForm.getNextID(hasdel, "Categories");
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Categories(ID,Category,Shelf) VALUES(@id,@categ,@shelf);";

                cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                cmd.Parameters.Add("@categ", DbType.String).Value = txtAddCateg.Text;
                cmd.Parameters.Add("@shelf", DbType.String).Value = txtAddShelf.Text;
                cmd.ExecuteNonQuery();
                lblStatus.Text = "Category " + txtAddCateg.Text + " was added.";
                txtAddCateg.Clear();
                txtAddShelf.Clear();
           

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblStatus.Text= "Add new Category";
            pnlAddCateg.Show();
            pnlAddCateg.BringToFront();
            txtAddCateg.Focus();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlAddCateg.Hide();
            fillgrid();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           lblStatus.Text = "Edit Category";
            editid = datagridCateg.SelectedRows[0].Cells["ID"].Value.ToString();
         
            if (String.IsNullOrEmpty(editid.Trim()))
            {
                MessageBox.Show("Please Select a Category to Edit.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

           cmdtext = String.Format("select * from Categories where ID={0};", editid);
            //  cmd.CommandText = cmdtext;
            cmd = new SQLiteCommand(cmdtext, con);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Category not found.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
                    dr.Close();
                    return;
                }

                while (dr.Read())
                {
                  txtEditCateg.Text = dr["Category"].ToString();
                 txtEditShelf.Text = dr["Shelf"].ToString();
                 

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }



            
          
          
          pnlEditCateg.Show();
          pnlEditCateg.BringToFront();
          

        }

        private void picCloseEdit_Click(object sender, EventArgs e)
        {
            pnlEditCateg.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditCateg.Text.Trim()))
            {
                MessageBox.Show("Enter Category Name");
                txtEditCateg.Clear();
                txtEditCateg.Focus();
               
                return;
            }

            string categ = txtEditCateg.Text;
            string shelf = txtEditShelf.Text;
 
            cmdtext = String.Format("UPDATE Categories SET Category='{0}',Shelf='{1}' WHERE ID={2};",categ,shelf,editid);
            //     cmd.CommandText = cmdtext;
            cmd.CommandText = cmdtext;
            cmd.ExecuteNonQuery();
            lblStatus.Text = "Category Saved.";
            fillgrid();
            pnlEditCateg.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          string delid = datagridCateg.SelectedRows[0].Cells["ID"].Value.ToString();
          string categname = datagridCateg.SelectedRows[0].Cells["Category"].Value.ToString();
          DialogResult dres = MessageBox.Show("Do you want to DELETE this Category ?\nName: " + categname , "Confirm DELETE Operation", MessageBoxButtons.YesNo);
          if (dres == DialogResult.Yes)
          {


              cmd.CommandText = string.Format("DELETE FROM Categories WHERE ID={0}", delid);
              cmd.ExecuteNonQuery();
            string  msg = "The Category '" + categname + "'  ID:" + delid + " was DELETED successfully.";
            lblStatus.Text = msg;


              cmd.CommandText = string.Format("INSERT INTO DeletedID(tablename,deletedid) VALUES('{0}',{1});", "Categories", delid);
              cmd.ExecuteNonQuery();
              MainForm.dbsettings.hasDelCategories = true;
             
              fillgrid();

          }
          else
          {
              lblStatus.Text = "DELETE Action was Cancelled.";
          }
        }

        private void btnMakeDefault_Click(object sender, EventArgs e)
        {
            string cat=datagridCateg.SelectedRows[0].Cells["Category"].Value.ToString();
            
            MainForm.dbsettings.defaultCateg = cat;
                
               // lblStatus.Text = "Default category is " + cat;
            lbldefault.Text = "Default Category :\n" + cat;  

        }
    }
}
 