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
    public partial class ForumTile : UserControl
    {
        Forum forum;
        ThreadList threadList;
        public ForumTile(Forum forum, ThreadList threadList)
        {
            InitializeComponent();
            this.forum = forum;
            this.threadList = threadList;
        }
        public Image ForumImage { get => forumBtn.BackgroundImage; set => forumBtn.BackgroundImage = value; }

        private void forumBtn_Click(object sender, EventArgs e)
        {
            threadList.SetThreadList(forum.ForumName);
            Console.WriteLine(forum.ForumName+forum.ForumAdmin);
        }
    }
}
