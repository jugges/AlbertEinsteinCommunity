using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertEinsteinCommunity
{
    public class Thread
    {
        public int ThreadId { get; set; }
        public string ForumName { get; set; }
        public string ThreadName { get; set; }
        public User ThreadMaker { get; set; }
        public string ThreadContent { get; set; }
        public DateTime ThreadDate { get; set; }
    }
}
