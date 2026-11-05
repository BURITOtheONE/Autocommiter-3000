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
using System.Threading;



namespace Autocommiter_3000
{
    public partial class Autocommiter3000 : Form
    {
        public string commitMessage = "Autocommited by Autocommiter3000";
        public const string DEFAULTCOMMITMESSAGE = "Autocommited by Autocommiter3000";
        public string repositoryPath = @"C:\Path\To\Your\Repository"; // Change this to your repository path
        public string usrName = "YourUsername"; // Change this to your Git username
        public string email = "youremail@wtv.com"; // Change this to your Git email
        public int commitInterval = 60000; // Time interval in milliseconds (e.g., 60000ms = 1 minute)
        public bool isRunning = false;
        public string strCmdText;

        public Autocommiter3000()
        {
            InitializeComponent();
            MainLoop();
            
        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            
        }

        private void done_Click(object sender, EventArgs e)
        {
            isRunning = true;
        }

        private void usr_TextChanged(object sender, EventArgs e)
        {
            usrName = usr.Text;
        }

        private void mail_TextChanged(object sender, EventArgs e)
        {
            email = mail.Text;
        }

        private void repo_TextChanged(object sender, EventArgs e)
        {
            repositoryPath = repo.Text;
        }

        private void msg_TextChanged(object sender, EventArgs e)
        {
            commitMessage = msg.Text;
        }

        private void interval_SelectedIndexChanged(object sender, EventArgs e)
        {
            commitInterval = int.Parse(interval.Text) * 60000;
        }

        private void repo_browse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;

                    repo.Text = selectedPath;
                    repositoryPath = selectedPath;
                }
            }
        }

        private void default_commit_msg_Click(object sender, EventArgs e)
        {
            msg.Text = DEFAULTCOMMITMESSAGE;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }

        private async Task MainLoop()
        {
            while (true)
            {
                if (isRunning)
                {
                    try
                    {
                        UpdateStatus("Committing...");
                        using (Process process = new Process())
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo();

                            startInfo.FileName = "git";
                            startInfo.WorkingDirectory = repositoryPath;
                            startInfo.Arguments =
                                $"add -A";

                            startInfo.UseShellExecute = false;
                            startInfo.CreateNoWindow = true;

                            process.StartInfo = startInfo;
                            process.Start();
                            await Task.Run(() => process.WaitForExit());
                        }

                        using (Process process = new Process())
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo();

                            startInfo.FileName = "git";
                            startInfo.WorkingDirectory = repositoryPath;
                            startInfo.Arguments =
                                $"commit -m \"{commitMessage}\"";

                            startInfo.UseShellExecute = false;
                            startInfo.CreateNoWindow = true;

                            process.StartInfo = startInfo;
                            process.Start();
                            await Task.Run(() => process.WaitForExit());
                        }

                        using (Process process = new Process())
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo();

                            startInfo.FileName = "git";
                            startInfo.WorkingDirectory = repositoryPath;
                            startInfo.Arguments = "push origin";

                            startInfo.UseShellExecute = false;
                            startInfo.CreateNoWindow = true;

                            process.StartInfo = startInfo;
                            process.Start();
                            await Task.Run(() => process.WaitForExit());
                        }
                        UpdateStatus("Commit completed!");
                    }
                    catch (Exception ex)
                    {
                        UpdateStatus("Error: " + ex.Message);
                    }
                }
                else
                {
                    UpdateStatus("Stopped");
                }

                    await Task.Delay(commitInterval);
            }
        }

        private void UpdateStatus(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => statusLabel.Text = message));
            }
            else
            {
                statusLabel.Text = message;
            }
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
