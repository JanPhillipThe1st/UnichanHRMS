
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnichanHRMS
{
    public class Employee
    {
        public int employee_ID { get; set; }
        public String generated_ID { get; set; }
        public int applicant_ID { get; set; }
        public int batch_number { get; set; }
        public String sss_number { get; set; }
        public String philhealth_number { get; set; }
        public String pag_ibig_number { get; set; }
        public String TIN_number { get; set; }
        public DateTime orientation_date { get; set; }
        public String employment_status { get; set; }
        public String employment_remarks { get; set; }
        public int available_leave { get; set; }
        public int leaves_used { get; set; }
        public int leaves_remaining { get; set; }
    }
}