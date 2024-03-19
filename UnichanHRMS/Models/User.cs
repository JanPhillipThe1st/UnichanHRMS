using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnichanHRMS.Models
{
    public class User
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string access { get; set; }
    }
}
