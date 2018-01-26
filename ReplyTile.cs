﻿using System;
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
    public partial class ReplyTile : UserControl
    {
        Reply reply;
        bool isMine;
        public ReplyTile(Reply reply, bool isMine, bool isMaker)
        {
            InitializeComponent();
            this.reply = reply;
            this.isMine = isMine;
            if(isMine)
                tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(150)))));
            else if (isMaker)
                tableLayoutPanel.BackColor = Color.PapayaWhip;
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
    }
}
