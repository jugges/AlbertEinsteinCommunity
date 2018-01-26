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
    public partial class ThreadTile : UserControl
    {
        Thread thread;
        WelcomeForm welcomeForm;
        bool isMine;
        public ThreadTile(Thread thread , WelcomeForm welcomeForm, bool isMine)
        {
            InitializeComponent();
            this.thread = thread;
            this.welcomeForm = welcomeForm;
            this.isMine = isMine;
            if (isMine)
                tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(177)))));
            lblThreadName.Text = thread.ThreadName;
            lblThreadMaker.Text = thread.ThreadMaker.Username;
            lblThreadDate.Text = thread.ThreadDate.ToShortDateString() + " " + thread.ThreadDate.ToShortTimeString();
        }

        private void lblThreadMaker_Click(object sender, EventArgs e)
        {
            new InfoForm(thread.ThreadMaker,isMine).ShowDialog();
        }

        private void lblThreadName_Click(object sender, EventArgs e)
        {
            welcomeForm.SetReplyList(thread.ThreadId);
        }
    }
}
