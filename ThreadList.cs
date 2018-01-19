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
    public partial class ThreadList : UserControl
    {
        Controller controller = new Controller();
        List<UserControl> tiles;
        public ThreadList()
        {
            InitializeComponent();
        }
        public void SetThreadList(string forumName)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 1;
            tiles = controller.LoadThreadList(forumName);
            for (int i = 0; i < tiles.Count; i++)
            {
                tableLayoutPanel.Controls.Add(tiles[i]);
                tableLayoutPanel.SetRow(tiles[i], i);
                tableLayoutPanel.RowStyles[i].SizeType = SizeType.AutoSize;
                tableLayoutPanel.RowCount++;
            }
        }
    }
}
