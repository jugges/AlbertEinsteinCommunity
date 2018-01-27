using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertEinsteinCommunity
{
    public class Reply
    {
        public int ReplyId { get; set; }
        public int ThreadId { get; set; }
        public User ReplyMaker { get; set; }
        public string ReplyContent { get; set; }
        public DateTime ReplyDate { get; set; }
        public bool IsOp { get; set; }
    }
}
