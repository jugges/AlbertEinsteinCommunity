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
    public partial class ReplyTile : UserControl
    {
        Reply reply;
        public ReplyTile(Reply reply)
        {
            InitializeComponent();
            this.reply = reply;
            lblReplyMaker.Text = reply.ReplyMaker.Username;
            richtextboxReplyContent.Rtf = reply.ReplyContent;
            lblReplyDate.Text = reply.ReplyDate.ToShortDateString() + " " + reply.ReplyDate.ToShortTimeString();
        }
    }
}
