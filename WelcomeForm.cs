using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertEinsteinCommunity
{
    public partial class WelcomeForm : Form
    {
        User user;
        List<UserControl> forumTiles;
        List<UserControl> threadTiles;
        List<UserControl> replyTiles;
        Controller controller = new Controller();
        public WelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Save();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            usernameToolStripMenuItem.Text = user.Username;
            SetForumList();
            //int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            //forumList.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }

        public void SetForumList()
        {
            forumList.Controls.Clear();
            forumList.RowCount = 1;
            forumTiles = controller.LoadForumList(this);
            for (int i = 0; i < forumTiles.Count; i++)
            {
                forumList.Controls.Add(forumTiles[i]);
                forumList.SetRow(forumTiles[i], i);
                //forumList.RowStyles[i].SizeType = SizeType.AutoSize;
                forumList.RowCount++;
            }
        }

        public void SetThreadList(string forumName)
        {
            threadList.Controls.Clear();
            threadList.RowCount = 1;
            threadTiles = controller.LoadThreadList(forumName,this);
            for (int i = 0; i < threadTiles.Count; i++)
            {
                threadList.Controls.Add(threadTiles[i]);
                threadList.SetRow(threadTiles[i], i);
                //threadList.RowStyles[i].SizeType = SizeType.AutoSize;
                threadList.RowCount++;
            }
        }

        public void SetReplyList(int threadId)
        {
            threadList.Controls.Clear();
            threadList.RowCount = 1;
            replyTiles = controller.LoadReplyList(threadId);
            for (int i = 0; i < replyTiles.Count; i++)
            {
                threadList.Controls.Add(replyTiles[i]);
                threadList.SetRow(replyTiles[i], i);
                //threadList.RowStyles[i].SizeType = SizeType.AutoSize;
                threadList.RowCount++;
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(user,true);
            infoForm.Show();
        }
    }
}
