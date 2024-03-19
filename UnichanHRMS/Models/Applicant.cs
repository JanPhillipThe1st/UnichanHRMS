
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnichanHRMS
{
    public class Applicant
    {
        public int applicant_ID { get; set; }
        public int batch_number { get; set; }
        public String first_name { get; set; }
        public String middle_name { get; set; }
        public String last_name { get; set; }
        public String age { get; set; }
        public String gender { get; set; }
        public String contact { get; set; }
        public DateTime birth_date { get; set; }
        public String application_status { get; set; }
        public DateTime application_date { get; set; }
        public DateTime exam_date { get; set; }
        public String initial_interview_date { get; set; }
        public String final_interview_date { get; set; }
        public String remarks { get; set; }
    }
}