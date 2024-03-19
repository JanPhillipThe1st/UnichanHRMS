using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnichanHRMS.Models
{
    internal class Batch
    {
        public int batch_number { get; set; }
        public int applicants { get; set; }
        public int hired_applicants { get; set; }
        public DateTime hiring_date { get; set; }
    }
}
