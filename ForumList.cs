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
    public partial class ForumList : UserControl
    {
        Controller controller = new Controller();
        List<UserControl> tiles;
        public ForumList()
        {
            InitializeComponent();
        }
        public void SetForumList(ThreadList threadList)
        {
            tiles = controller.LoadForumList(threadList);
            for (int i = 0; i < tiles.Count; i++)
            {
                tableLayoutPanel.Controls.Add(tiles[i]);
                tableLayoutPanel.SetRow(tiles[i], i);
            }
        }
    }
}
