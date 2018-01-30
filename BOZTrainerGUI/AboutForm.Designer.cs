namespace BOZTrainerGUI
{
    partial class AboutForm
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
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.YouTubeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::BOZTrainerGUI.Properties.Resources.BOZT_LOGO;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoPanel.Location = new System.Drawing.Point(0, 76);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(284, 261);
            this.LogoPanel.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cl0ck W0rk Dev Group On Discord";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // YouTubeLinkLabel
            // 
            this.YouTubeLinkLabel.AutoSize = true;
            this.YouTubeLinkLabel.Location = new System.Drawing.Point(12, 9);
            this.YouTubeLinkLabel.Name = "YouTubeLinkLabel";
            this.YouTubeLinkLabel.Size = new System.Drawing.Size(133, 13);
            this.YouTubeLinkLabel.TabIndex = 4;
            this.YouTubeLinkLabel.TabStop = true;
            this.YouTubeLinkLabel.Text = "0v3r cl0ck3d On YouTube";
            this.YouTubeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YouTubeLinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(12, 60);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(130, 13);
            this.GitHubLinkLabel.TabIndex = 5;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "BOZ Trainer GitHub Repo";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 337);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.YouTubeLinkLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LogoPanel);
            this.DoubleBuffered = true;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel YouTubeLinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
    }
}