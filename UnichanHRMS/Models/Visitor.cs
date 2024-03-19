using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnichanHRMS.Models
{
    public class Visitor
    {
        public int id { get; set; }
        public String name   { get; set; }
        public String company { get; set; }
        public DateTime time_in { get; set; }
        public DateTime time_out { get; set; }
        public DateTime date_of_visit { get; set; }
        public String purpose { get; set; }
    }
}
