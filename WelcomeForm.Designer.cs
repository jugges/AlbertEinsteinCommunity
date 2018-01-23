namespace AlbertEinsteinCommunity
{
    partial class WelcomeForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.wYSIWYGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.forumList = new System.Windows.Forms.TableLayoutPanel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.threadList = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.wYSIWYGToolStripMenuItem});
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.usernameToolStripMenuItem.Text = "USERNAME";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Profile";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // wYSIWYGToolStripMenuItem
            // 
            this.wYSIWYGToolStripMenuItem.Name = "wYSIWYGToolStripMenuItem";
            this.wYSIWYGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wYSIWYGToolStripMenuItem.Text = "WYSIWYG";
            this.wYSIWYGToolStripMenuItem.Click += new System.EventHandler(this.wYSIWYGToolStripMenuItem_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.threadList, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.forumList, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(984, 583);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // forumList
            // 
            this.forumList.AutoScroll = true;
            this.forumList.AutoSize = true;
            this.forumList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forumList.BackColor = System.Drawing.SystemColors.Control;
            this.forumList.ColumnCount = 1;
            this.forumList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.forumList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forumList.Location = new System.Drawing.Point(804, 3);
            this.forumList.Name = "forumList";
            this.forumList.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.forumList.RowCount = 1;
            this.forumList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.forumList.Size = new System.Drawing.Size(177, 577);
            this.forumList.TabIndex = 4;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // threadList
            // 
            this.threadList.AutoScroll = true;
            this.threadList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.threadList.ColumnCount = 1;
            this.threadList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.threadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threadList.Location = new System.Drawing.Point(3, 3);
            this.threadList.Name = "threadList";
            this.threadList.RowCount = 1;
            this.threadList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.threadList.Size = new System.Drawing.Size(795, 577);
            this.threadList.TabIndex = 7;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 607);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "WelcomeForm";
            this.Text = "Albert Einstein Community Forums";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem wYSIWYGToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel threadList;
        private System.Windows.Forms.TableLayoutPanel forumList;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    }
}