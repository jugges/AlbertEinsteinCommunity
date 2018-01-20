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
        public ThreadTile(Thread thread)
        {
            InitializeComponent();
            this.thread = thread;
            lblThreadName.Text = thread.ThreadName;
            lblThreadMaker.Text = thread.ThreadMaker.Username;
            lblThreadDate.Text = thread.ThreadDate.ToShortDateString();
        }

        private void lblThreadMaker_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(thread.ThreadMaker);
            infoForm.Show();
        }
    }
}
