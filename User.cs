using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertEinsteinCommunity
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Karma { get; set; }
        public DateTime RegisteringDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Privacy { get; set; }
        public string FirstName { get; set; }
        public string Biography { get; set; }
        public string Job { get; set; }
        public string Sex { get; set; }
        public string LivingArea { get; set; }
        public bool IsAdmin { get; set; }
    }
}
