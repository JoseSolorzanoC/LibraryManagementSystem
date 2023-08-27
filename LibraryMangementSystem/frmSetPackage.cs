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
    public partial class frmSetPackage : Form

    {
        string maxb;
        DateTime start, end;
        string memid;
        string item;
      string selPkgid;
        string stdate, endate;
        string hasfee;
        SQLiteCommand cmd = new SQLiteCommand(MainForm.con);
        SQLiteDataReader dr;
       
        string cmdtext;
        SQLiteConnection con;
        public static string openwithmid;
        public frmSetPackage()
        {
            con = MainForm.con;
            InitializeComponent();
        }

        private void frmSetPackage_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(openwithmid))
            {

                txtMemID.Text = openwithmid;
                btnOk_Click(null, null);
                }
            
            cmd = new SQLiteCommand("select PackageTitle from Packages", con);
            dr = cmd.ExecuteReader();
            cmbPackage.Items.Clear();

            while (dr.Read())
            {
                cmbPackage.Items.Add(dr[0].ToString());
            }
            
            dr.Close();
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            memid = txtMemID.Text;
            txtMemID.Clear();
            if (String.IsNullOrEmpty(memid.Trim()))
            {
                MessageBox.Show("Please Enter Member ID.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemID.Clear();
                return;
            }

            cmdtext = String.Format("select Name from MemberDetails where MemberID='{0}';", memid);
                      cmd = new SQLiteCommand(cmdtext, con);

                      object res = cmd.ExecuteScalar();

                      if (res != null)
                      {
                          txtName.Text = res.ToString();
                          txtMemID2.Text = memid;
                      }
                      else
                      {
                          MessageBox.Show("Member Does not exist.", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                          txtMemID.Clear();
                      }
                
            
        }

        private void calcTotal()
        {
            string item="0";
            int fee=0;
            
            if (cmbMonths.SelectedItem != null)
            {
                 fee= Convert.ToInt32(txtMonthlyFee.Text);
            }
            

            if (cmbMonths.SelectedItem != null)
            {
               item  = cmbMonths.SelectedItem.ToString();
            }
            int months=Convert.ToInt32(item);
            int total = fee * months;
            txtTotal.Text = total.ToString(); ;
        }
        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {

            item = cmbPackage.SelectedItem.ToString();
            cmdtext = string.Format("select ID from Packages where PackageTitle='{0}'", item);
               cmd = new SQLiteCommand(cmdtext, con);
           selPkgid =cmd.ExecuteScalar().ToString();


           cmdtext = string.Format("select MaxBooks from Packages where ID={0}", selPkgid);
           cmd = new SQLiteCommand(cmdtext, con);
            maxb = cmd.ExecuteScalar().ToString();
            txtMaxBooks.Text = maxb;
          //  MessageBox.Show(maxb);


          cmdtext= string.Format("select HasFee from Packages where ID={0}",selPkgid);
          
             cmd = new SQLiteCommand(cmdtext, con);
              hasfee = cmd.ExecuteScalar().ToString();
             if (hasfee == "True")
             {
                 lblmfee.Enabled = true;
                 lblmonth.Enabled = true;
                 lbltotal.Enabled = true;
                 txtMonthlyFee.Enabled = true;
                 cmbMonths.Enabled = true;
                 txtTotal.Enabled = true;

                 cmdtext = string.Format("select MonthlyFee from Packages where ID={0}",selPkgid);
                 cmd = new SQLiteCommand(cmdtext, con);
                 string fee = cmd.ExecuteScalar().ToString();
                 txtMonthlyFee.Text = fee;
                 
                 calcTotal();
             }
             else
             {
                 lblmfee.Enabled = false;
                 lblmonth.Enabled = false;
                 lbltotal.Enabled = false;
                 txtMonthlyFee.Enabled = false;
                 cmbMonths.Enabled = false;
                 txtTotal.Enabled = false;
             }

        }

        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcTotal();
            int months=0;
            if(cmbMonths.SelectedItem.ToString()!=null)
            {
            months=Convert.ToInt32(cmbMonths.SelectedItem.ToString());
            }
           // days=days*30;
            

            cmdtext =string.Format( "select max(EndDate) from SetPackages where MemberID={0}",memid);
            cmd = new SQLiteCommand(cmdtext, con);
            string date = cmd.ExecuteScalar().ToString();
            //MessageBox.Show(string.IsNullOrEmpty(date).ToString());
            if (!string.IsNullOrEmpty(date))
            {

                if (date != "0")
                {
                    start = DateTime.ParseExact(date, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                    start = start.AddDays(1);
                }
            }
            else
                start = DateTime.Today;

            end = start.AddMonths(months);
          //  end=start.AddDays(days);
            stdate=start.ToString("dd/MM/yyyy");
            endate=end.ToString("dd/MM/yyyy");
            string dur="Duration : "+stdate+" to "+endate;
            // textISIBduedate.Text = DateTime.ParseExact(textISIBissuedate.Text, "dd/MM/yyyy", null).AddDays(Convert.ToInt32(textISIBdays.Text)).ToString("dd/MM/yyyy");

            lblDuration.Text = dur;
        }

        private void frmSetPackage_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainForm.dbsettings.defaultPkg.Trim()))
            {
                if(cmbPackage.Items.Count!=0)
                cmbPackage.SelectedIndex = 0;
            }
            else
            {
                cmbPackage.SelectedItem = MainForm.dbsettings.defaultPkg;
            }
            cmbMonths.SelectedIndex = 0;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbPackage.Items.Count == 0)
            {
                MessageBox.Show("No Packages are defined.");
                return;
            }

            bool fee=false;
            if (hasfee == "True")
                fee = true;
            
                int c=0;
                int memid,pkgid;
                pkgid =Convert.ToInt32(selPkgid);
                   memid =Convert.ToInt32(txtMemID2.Text);

               //cannot set package if member has a no fee pkg already
                   cmdtext =string.Format( "select count(*) from SetPackages where HasFee='False' AND MemberID={0}",memid);
                   cmd = new SQLiteCommand(cmdtext, con);
                    c =Convert.ToInt32( cmd.ExecuteScalar().ToString());
                   if (c != 0)
                   {
                       MessageBox.Show("Cannot set Package.\nThis Member already has a No Fee Package activated.\nCancel the existing package for new activation");
                       return;
                   }

                 //we cannot set nofee pkg into pkg with fees.
                   if (hasfee =="False")
                   {
                       cmdtext =string.Format( "select count(*) from SetPackages where HasFee='True' AND MemberID={0}",memid);
                       cmd = new SQLiteCommand(cmdtext, con);
                       c = Convert.ToInt32(cmd.ExecuteScalar());
                       if (c != 0)
                       {
                           MessageBox.Show("Cannot set Package.\nThis Member already has a Package with Fee activated.\nCancel the existing package for new activation");
                           return;
                       }
                       cmd.CommandText = "INSERT INTO SetPackages(MemberID,PackageID,PackageTitle,HasFee,StartDate,EndDate,MaxBooks,TotalFee) VALUES(@memid,@pkgid,@pkgtitle,@hasfee,@stdate,@endate,@max,0);";
                       cmd.Parameters.Add("@max", DbType.Int32).Value =maxb ;
                       cmd.Parameters.Add("@memid", DbType.Int32).Value = memid;
                       cmd.Parameters.Add("@pkgid", DbType.Int32).Value = pkgid;
                       cmd.Parameters.Add("@pkgtitle", DbType.String).Value = item;
                       cmd.Parameters.Add("@hasfee", DbType.String).Value = fee.ToString();
                       cmd.Parameters.Add("@stdate", DbType.String).Value = 0;
                       cmd.Parameters.Add("@endate", DbType.String).Value = 0;
                       
                       cmd.ExecuteNonQuery();


                       MainForm.msg = "The Package " + item + " was added for Member " + txtName.Text;
                       this.Close();
                   }
                   else
                   {
                       cmd.CommandText = "INSERT INTO SetPackages(MemberID,PackageID,PackageTitle,HasFee,StartDate,EndDate,MaxBooks,TotalFee) VALUES(@memid,@pkgid,@pkgtitle,@hasfee,@stdate,@endate,@max,@totalfee);";
                       cmd.Parameters.Add("@max", DbType.Int32).Value = maxb;
                       cmd.Parameters.Add("@memid", DbType.Int32).Value = memid;
                       cmd.Parameters.Add("@pkgid", DbType.Int32).Value = pkgid;
                       cmd.Parameters.Add("@pkgtitle", DbType.String).Value = item;
                       cmd.Parameters.Add("@hasfee", DbType.String).Value = fee.ToString();
                       cmd.Parameters.Add("@stdate", DbType.String).Value = start.ToString("yyyy/MM/dd"); 
                       cmd.Parameters.Add("@endate", DbType.String).Value = end.ToString("yyyy/MM/dd");
                       cmd.Parameters.Add(new SQLiteParameter("@totalfee", txtTotal.Text));
                       cmd.ExecuteNonQuery();

                       SQLiteCommand comm = new SQLiteCommand(con);
                       comm.CommandText = "INSERT INTO PackageAccounting(MemberID,PackageID,TotalFee) VALUES(@memid,@pkgid,@totalfee);";
                       comm.Parameters.Add(new SQLiteParameter("@memid", memid));
                       comm.Parameters.Add(new SQLiteParameter("@pkgid", pkgid));
                       comm.Parameters.Add(new SQLiteParameter("@totalfee",txtTotal.Text));
                       comm.ExecuteNonQuery();

                       MainForm.msg = "The Package " + item + " was added for Member " + txtName.Text;
                   //    MessageBox.Show(cmd.CommandText);
                       this.Close();
                   }
                     

                  
                
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
