using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertEinsteinCommunity
{
    public partial class AddTile : UserControl
    {
        WelcomeForm welcomeForm;
        public AddTile(WelcomeForm welcomeForm)
        {
            InitializeComponent();
            this.welcomeForm = welcomeForm;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            RTFEditorForm rtfEditorForm = new RTFEditorForm(welcomeForm.replyCreation);
            rtfEditorForm.ShowDialog();
            if (rtfEditorForm.isEdited)
                if (welcomeForm.replyCreation)
                {
                    Reply newReply = new Reply();
                    newReply.ReplyMaker = welcomeForm.user;
                    newReply.ReplyContent = rtfEditorForm.rtf;
                    newReply.ThreadId = welcomeForm.currentThreadId;
                    new Controller().AddReply(newReply);
                    welcomeForm.SetReplyList(welcomeForm.currentThreadId);
                }
                else
                {
                    Thread newThread = new Thread();
                    newThread.ThreadMaker = welcomeForm.user;
                    newThread.ThreadName = rtfEditorForm.threadName;
                    newThread.ThreadContent = rtfEditorForm.rtf;
                    newThread.ForumName = welcomeForm.currentForumName;
                    new Controller().AddThread(newThread);
                    welcomeForm.SetThreadList(welcomeForm.currentForumName);
                }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (welcomeForm.replyCreation)
                welcomeForm.SetReplyList(welcomeForm.currentThreadId);
            else
                welcomeForm.SetThreadList(welcomeForm.currentForumName);
        }
    }
}
