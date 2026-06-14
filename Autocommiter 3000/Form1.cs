using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Xml.Linq;
using System.Diagnostics;



namespace Autocommiter_3000
{
    public partial class Autocommiter3000 : Form
    {
        public string commitMessage = "Autocommited by Autocommiter3000";
        public string repositoryPath = @"C:\Path\To\Your\Repository"; // Change this to your repository path
        public string usrName = "YourUsername"; // Change this to your Git username
        public string email = "youremail@wtv.com"; // Change this to your Git email
        public int commitInterval = 60000; // Time interval in milliseconds (e.g., 60000ms = 1 minute)
        public Autocommiter3000()
        {
            InitializeComponent();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            
        }

        private void done_Click(object sender, EventArgs e)
        {

        }
    }
}
