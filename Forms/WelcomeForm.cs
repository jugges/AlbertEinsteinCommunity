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
        List<UserControl> forumTiles;
        List<UserControl> threadTiles;
        List<UserControl> replyTiles;
        Controller controller = new Controller();
        public User user;
        private int permissionLevel = 0;
        public bool permissionGranted = false;
        private bool replyCreation;
        private int currentThreadId;
        private string currentForumName;
        public WelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;
            string permissionType = user.Permission.PermissionType;
            if (permissionType == "master")
            {
                permissionLevel = 2;
                permissionGranted = true;
            }
            else if (permissionType == "specific")
                permissionLevel = 1;
            else
                permissionLevel = 0;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Save();
            new LoginForm().ShowDialog();
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
                //forumTiles[i].Dock = DockStyle.Fill;
                //forumList.RowStyles[i].SizeType = SizeType.AutoSize;
                forumList.RowCount++;
            }
        }

        public void SetThreadList(string forumName)
        {
            currentForumName = forumName;
            threadList.Controls.Clear();
            threadList.RowCount = 1;
            threadTiles = controller.LoadThreadList(forumName, this);
            for (int i = 0; i < threadTiles.Count; i++)
            {
                threadList.Controls.Add(threadTiles[i]);
                threadList.SetRow(threadTiles[i], i);
                threadTiles[i].Dock = DockStyle.Top;
                //threadList.RowStyles[i].SizeType = SizeType.AutoSize;
                threadList.RowCount++;
            }
            replyCreation = false;
            if (permissionLevel==1)
                permissionGranted = user.Permission.SpecificPermissionForum == forumName;
        }

        public void SetReplyList(int threadId)
        {
            currentThreadId = threadId;
            threadList.Controls.Clear();
            threadList.RowCount = 1;
            replyTiles = controller.LoadReplyList(threadId, this, controller.GetThread(threadId));
            for (int i = 0; i < replyTiles.Count; i++)
            {
                threadList.Controls.Add(replyTiles[i]);
                threadList.SetRow(replyTiles[i], i);
                replyTiles[i].Dock = DockStyle.Top;
                //threadList.RowStyles[i].SizeType = SizeType.AutoSize;
                threadList.RowCount++;
            }
            replyCreation = true;
        }

        public void Wysiwyg()
        {
            RTFEditorForm rtfEditorForm = new RTFEditorForm(replyCreation);
            rtfEditorForm.ShowDialog();
            if (rtfEditorForm.isEdited)
                if (replyCreation)
                {
                    Reply newReply = new Reply();
                    newReply.ReplyMaker = user;
                    newReply.ReplyContent = rtfEditorForm.rtf;
                    newReply.ThreadId = currentThreadId;
                    controller.AddReply(newReply);
                    SetReplyList(currentThreadId);
                }
                else
                {
                    Thread newThread = new Thread();
                    newThread.ThreadMaker = user;
                    newThread.ThreadName = rtfEditorForm.threadName;
                    newThread.ThreadContent = rtfEditorForm.rtf;
                    newThread.ForumName = currentForumName;
                    controller.AddThread(newThread);
                    SetThreadList(currentForumName);
                }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoForm(user, true).ShowDialog();
        }
    }
}
