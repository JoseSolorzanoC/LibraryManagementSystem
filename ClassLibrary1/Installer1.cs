using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.IO;

namespace ClassLibrary1
{
    [RunInstaller(true)]
    public partial class Installer1 : Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            String p = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LibraryManagementSystem");
            string[] ss = Directory.GetDirectories(p, "LibraryManagementSystem.*");
            foreach (string s in ss)
            {
                //if (MessageBox.Show("Delete " + s + "?", "Delete Settings?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Directory.Delete(s, true);
            }

 string datafolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LibraryManagementSystem");


 Directory.Delete(datafolder, true);
            base.Uninstall(savedState);
        }
    }
}
