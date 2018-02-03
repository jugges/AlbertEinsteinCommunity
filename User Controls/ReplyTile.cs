using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AlbertEinsteinCommunity
{
    public partial class ReplyTile : UserControl
    {
        Reply reply;
        private bool isMine;
        WelcomeForm welcomeForm;
        public ReplyTile(Reply reply, WelcomeForm welcomeForm, bool isMine, bool isMaker)
        {
            InitializeComponent();
            this.welcomeForm = welcomeForm;
            this.reply = reply;
            this.isMine = isMine;
            if (isMine)
                tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(150)))));
            else
            {
                if (!welcomeForm.permissionGranted)
                {
                    picEdit.Dispose();
                    picDel.Dispose();
                }
                if (isMaker)
                    tableLayoutPanel.BackColor = Color.PapayaWhip;
            }
            lblReplyMaker.Text = reply.ReplyMaker.Username;
            richtextboxReplyContent.Rtf = reply.ReplyContent;
            lblReplyDate.Text = reply.ReplyDate.ToShortDateString() + " " + reply.ReplyDate.ToShortTimeString();
        }

        private void lblReplyMaker_Click(object sender, EventArgs e)
        {
            new InfoForm(reply.ReplyMaker, isMine).ShowDialog();
        }

        private void richtextboxReplyContent_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = 5;
            richtextboxReplyContent.Height = e.NewRectangle.Height + margin;
        }
        
        private void picEdit_Click(object sender, EventArgs e)
        {
            RTFEditorForm rtfEditorForm = new RTFEditorForm(true);
            rtfEditorForm.SetRTF(reply.ReplyContent);
            rtfEditorForm.ShowDialog();
            if (rtfEditorForm.isEdited)
            {
                reply.ReplyContent = rtfEditorForm.rtf;
                if (reply.IsOp)
                    new Controller().EditThread(reply);
                else
                    new Controller().EditReply(reply);
            }
            welcomeForm.SetReplyList(reply.ThreadId);
        }

        private void richtextboxReplyContent_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void picDel_Click(object sender, EventArgs e)
        {
            if (reply.IsOp)
            {
                if (MessageBox.Show("Are you sure about deleting this thread?", "Authentication Required", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    new Controller().DeleteThread(reply.ThreadId);
            }
            else
                if (MessageBox.Show("Are you sure about deleting this reply?", "Authentication Required", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    new Controller().DeleteReply(reply.ReplyId);
        }
    }
}
