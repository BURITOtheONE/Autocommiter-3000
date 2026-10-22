namespace Autocommiter_3000
{
    partial class Autocommiter3000
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autocommiter3000));
            this.Welcome = new System.Windows.Forms.Label();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.done = new System.Windows.Forms.Button();
            this.interval = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repo_browse = new System.Windows.Forms.Button();
            this.mail_label = new System.Windows.Forms.Label();
            this.usr_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.default_commit_msg = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.TextBox();
            this.repo = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.usr = new System.Windows.Forms.TextBox();
            this.logo_large = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            this.main_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_large)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.Location = new System.Drawing.Point(1, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(525, 93);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to the GitHub opensource Autocommiter 3000";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // main_pnl
            // 
            this.main_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.main_pnl.Controls.Add(this.stop);
            this.main_pnl.Controls.Add(this.done);
            this.main_pnl.Controls.Add(this.interval);
            this.main_pnl.Controls.Add(this.label5);
            this.main_pnl.Controls.Add(this.repo_browse);
            this.main_pnl.Controls.Add(this.mail_label);
            this.main_pnl.Controls.Add(this.usr_label);
            this.main_pnl.Controls.Add(this.label2);
            this.main_pnl.Controls.Add(this.label1);
            this.main_pnl.Controls.Add(this.default_commit_msg);
            this.main_pnl.Controls.Add(this.msg);
            this.main_pnl.Controls.Add(this.repo);
            this.main_pnl.Controls.Add(this.mail);
            this.main_pnl.Controls.Add(this.usr);
            this.main_pnl.Location = new System.Drawing.Point(22, 96);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(504, 331);
            this.main_pnl.TabIndex = 1;
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(139, 285);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(177, 43);
            this.done.TabIndex = 14;
            this.done.Text = "Start Autocomitter";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // interval
            // 
            this.interval.FormattingEnabled = true;
            this.interval.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.interval.Location = new System.Drawing.Point(32, 253);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(59, 21);
            this.interval.TabIndex = 13;
            this.interval.SelectedIndexChanged += new System.EventHandler(this.interval_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Auto-commit interval (minutes)";
            // 
            // repo_browse
            // 
            this.repo_browse.Location = new System.Drawing.Point(292, 122);
            this.repo_browse.Name = "repo_browse";
            this.repo_browse.Size = new System.Drawing.Size(125, 19);
            this.repo_browse.TabIndex = 9;
            this.repo_browse.Text = "Browse";
            this.repo_browse.UseVisualStyleBackColor = true;
            this.repo_browse.Click += new System.EventHandler(this.repo_browse_Click);
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mail_label.Location = new System.Drawing.Point(289, 61);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(110, 13);
            this.mail_label.TabIndex = 8;
            this.mail_label.Text = "GitHub e-mail address";
            // 
            // usr_label
            // 
            this.usr_label.AutoSize = true;
            this.usr_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usr_label.Location = new System.Drawing.Point(289, 35);
            this.usr_label.Name = "usr_label";
            this.usr_label.Size = new System.Drawing.Size(91, 13);
            this.usr_label.TabIndex = 7;
            this.usr_label.Text = "GitHub Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repository location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Automated commit message";
            // 
            // default_commit_msg
            // 
            this.default_commit_msg.Location = new System.Drawing.Point(292, 183);
            this.default_commit_msg.Name = "default_commit_msg";
            this.default_commit_msg.Size = new System.Drawing.Size(125, 19);
            this.default_commit_msg.TabIndex = 4;
            this.default_commit_msg.Text = "Default";
            this.default_commit_msg.UseVisualStyleBackColor = true;
            this.default_commit_msg.Click += new System.EventHandler(this.default_commit_msg_Click);
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(32, 183);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(245, 20);
            this.msg.TabIndex = 3;
            this.msg.TextChanged += new System.EventHandler(this.msg_TextChanged);
            // 
            // repo
            // 
            this.repo.Location = new System.Drawing.Point(32, 122);
            this.repo.Name = "repo";
            this.repo.Size = new System.Drawing.Size(245, 20);
            this.repo.TabIndex = 2;
            this.repo.TextChanged += new System.EventHandler(this.repo_TextChanged);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(32, 58);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(245, 20);
            this.mail.TabIndex = 1;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // usr
            // 
            this.usr.Location = new System.Drawing.Point(32, 32);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(245, 20);
            this.usr.TabIndex = 0;
            this.usr.TextChanged += new System.EventHandler(this.usr_TextChanged);
            // 
            // logo_large
            // 
            this.logo_large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logo_large.Image = ((System.Drawing.Image)(resources.GetObject("logo_large.Image")));
            this.logo_large.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo_large.InitialImage")));
            this.logo_large.Location = new System.Drawing.Point(547, 196);
            this.logo_large.Name = "logo_large";
            this.logo_large.Size = new System.Drawing.Size(241, 242);
            this.logo_large.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_large.TabIndex = 2;
            this.logo_large.TabStop = false;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(322, 285);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(177, 43);
            this.stop.TabIndex = 15;
            this.stop.Text = "Stop Autocomitter";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // Autocommiter3000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logo_large);
            this.Controls.Add(this.main_pnl);
            this.Controls.Add(this.Welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autocommiter3000";
            this.Text = "Autocommiter 3000";
            this.main_pnl.ResumeLayout(false);
            this.main_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_large)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.PictureBox logo_large;
        private System.Windows.Forms.Button repo_browse;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.Label usr_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button default_commit_msg;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.TextBox repo;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox usr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox interval;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button stop;
    }
}

