using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnichanHRMS.Screens
{
    public partial class EditApplicant : Form
    {
        Database database = new Database();
        Applicant applicant = new Applicant();
        DateTime final_inverview_date = DateTime.Now;
        DateTime initial_interview_date = DateTime.Now;
        DateTime requirement_briefing_date = DateTime.Now;
        DataGridView dgv = new DataGridView();

        private SerialPort _serialPort;
        public EditApplicant(ref DataGridView dgv,Applicant applicant)
        {
            InitializeComponent();
            this.applicant = applicant;
            this.dgv = dgv;
        }

        private void GetSerialPorts()
        {

            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                foreach (string s in portList)
                {
                    Console.WriteLine(s);
                }
            }

        }
        private void AddApplicant_Load(object sender, EventArgs e)
        {
            dtpFinalInterviewDate.Text = applicant.final_interview_date;
            dtpInitialInterviewDate.Text = applicant.initial_interview_date;
            dtpExamDate.Value = applicant.exam_date;
            dtpApplicationDate.Value = applicant.application_date;
            tbContact.Text = applicant.contact;
            dtpBirthdate.Value = applicant.birth_date;
            cbGender.Text = applicant.gender;
            tbAge.Text = applicant.age;
            tbLastName.Text = applicant.last_name;
            tbMiddleName.Text = applicant.middle_name;
            tbFirstname.Text = applicant.first_name;
            tbRemarks.Visible = false;
            lblRemarks.Visible = false;

            if (applicant.application_status == "rejected")
            {
                roundedButton1.Visible = false; 
                btnScheduleFinalinterview.Visible = false; 
                btnScheduleInitiralInterview.Visible = false; 
                btnHire.Visible = false;
                tbRemarks.Visible = true;
                tbRemarks.Text = applicant.remarks;
                lblRemarks.Visible = true;
            }

            if (dtpFinalInterviewDate.Text == "NOT SET" && dtpInitialInterviewDate.Text == "NOT SET")
            {
                applicant.application_status = "PENDING"; 
                btnHire.Enabled = false;
                btnScheduleFinalinterview.Enabled = false;
                btnRequirementBriefing.Enabled = false;
            }
            else if (dtpFinalInterviewDate.Text == "NOT SET" && dtpInitialInterviewDate.Text != "NOT SET")
            {
                applicant.application_status = "PASSED EXAMINATION";
                btnHire.Enabled = false;
                btnScheduleInitiralInterview.Enabled = false;
                btnRequirementBriefing.Enabled = false;
            }
            else
            {
                applicant.application_status = "PASSED INITIAL INTERVIEW";
                btnHire.Enabled = true;
                btnRequirementBriefing.Enabled = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            applicant.final_interview_date = dtpFinalInterviewDate.Text;
            applicant.initial_interview_date = dtpInitialInterviewDate.Text;
            applicant.exam_date = dtpExamDate.Value;
            applicant.application_date = dtpApplicationDate.Value;
            applicant.birth_date = dtpBirthdate.Value;
            applicant.contact = tbContact.Text;
            applicant.gender = cbGender.Text;
            applicant.age = tbAge.Text;
            applicant.last_name = tbLastName.Text;
            applicant.middle_name = tbMiddleName.Text;
            applicant.first_name = tbFirstname.Text;
            if (dtpFinalInterviewDate.Text == "NOT SET" && dtpInitialInterviewDate.Text == "NOT SET")
            {
                applicant.application_status = "PENDING";
            }
            else if (dtpFinalInterviewDate.Text == "NOT SET" && dtpInitialInterviewDate.Text != "NOT SET")
            {
                applicant.application_status = "PASSED EXAMINATION";
            }
            else {
                applicant.application_status = "PASSED INITIAL INTERVIEW";
            }
            if (MessageBox.Show("Are you sure you want to save this information?","Updating applicant information",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
            database.updateApplicant(applicant);
            database.fillApplicantsTable(ref dgv);
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this information?\nThis cannot be undone.", "Deleting applicant information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.deleteApplicant(applicant);
                database.fillApplicantsTable(ref dgv);
            }
        }

        private void btnScheduleFinalinterview_Click(object sender, EventArgs e)
        {
            new SetDateDialog(final_inverview_date, setFinalInterviewDate).ShowDialog();

        }
        public void setFinalInterviewDate(DateTime f_i_d)
        {
                applicant.final_interview_date = f_i_d.ToString("MMMM dd, yyyy hh:mm tt");
            string number = applicant.contact;
            String applicant_name = applicant.first_name + " " + applicant.last_name ;
            string message = "Hello, " + applicant.first_name + " " + applicant.last_name + "! This is from Unichan Incorporated Human Resources Department.\nWe would like to inform you that your FINAL" +
                "\nINTERVIEW has been scheduled on " + f_i_d.ToString("MMMM dd, yyyy hh:mm tt") + ". Please be there!";
            new SendMessageDialog(applicant_name, number, message).ShowDialog();
            dtpFinalInterviewDate.Text = applicant.final_interview_date;
        }
        public void setRequirementsBriefing(DateTime f_i_d)
        {
                applicant.final_interview_date = f_i_d.ToString("MMMM dd, yyyy hh:mm tt");
            string number = applicant.contact;
            String applicant_name = applicant.first_name + " " + applicant.last_name ;
            string message = 
                "Congratulations,  " + applicant.first_name +" " + applicant.last_name + "! \r\n\r\nYou have successfully passed the final interview.\r\n\r\nPlease be here on " + f_i_d.ToString("MMMM dd, yyyy hh:mm tt") +
                "for a briefing on the next steps of the hiring process. During the briefing, " +
                "you will receive a list of the requirements needed to complete your employment documents.\r\n\r\nOnce again, " +
                "congratulations and we look forward to having you as part of our team!";
            new SendMessageDialog(applicant_name, number, message).ShowDialog();
            dtpFinalInterviewDate.Text = applicant.final_interview_date;
        }
        // Define other methods and classes here
        public class SerialPortInfo
        {
            public SerialPortInfo(string _id, string _name)
            {
                ID = _id;
                Name = _name;
            }

            public string ID = "";
            public string Name = "";

        }
        public void setInitiallInterviewDate(DateTime f_i_d)
        {
            
            applicant.initial_interview_date = f_i_d.ToString("MMMM dd, yyyy hh:mm tt");

            string number = applicant.contact;
            String applicant_name = applicant.first_name + " " + applicant.last_name ;
            string message = "Hello, " + applicant.first_name + " " + applicant.last_name + "! This is from Unichan Incorporated Human Resources Department.\nWe would like to inform you that your INITIAL" +
                "\nINTERVIEW has been scheduled on "+ f_i_d.ToString("MMMM dd, yyyy hh:mm tt")+". Please be there!";
            new SendMessageDialog(applicant_name, number, message).ShowDialog();
            dtpInitialInterviewDate.Text = applicant.initial_interview_date;
        }

        private void btnScheduleInitiralInterview_Click(object sender, EventArgs e)
        {
            new SetDateDialog(initial_interview_date, setInitiallInterviewDate).ShowDialog();
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            new HireDialog(ref dgv,ref applicant).ShowDialog();
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            applicant.final_interview_date = dtpFinalInterviewDate.Text;
            applicant.initial_interview_date = dtpInitialInterviewDate.Text;
            applicant.exam_date = dtpExamDate.Value;
            applicant.application_date = dtpApplicationDate.Value;
            applicant.birth_date = dtpBirthdate.Value;
            applicant.contact = tbContact.Text;
            applicant.gender = cbGender.Text;
            applicant.age = tbAge.Text;
            applicant.last_name = tbLastName.Text;
            applicant.middle_name = tbMiddleName.Text;
            applicant.first_name = tbFirstname.Text;
            if (dtpFinalInterviewDate.Text == "NOT SET" && dtpInitialInterviewDate.Text == "NOT SET")
            {
                applicant.application_status = "PENDING";
            }
            else if (dtpFinalInterviewDate.Text == "NOT SET" && dtpInitialInterviewDate.Text != "NOT SET")
            {
                applicant.application_status = "PASSED EXAMINATION";
            }
            else
            {
                applicant.application_status = "PASSED INITIAL INTERVIEW";
            }
                applicant.application_status = "rejected";
            if (MessageBox.Show("Are you sure you want to reject this application?", "Reject Applicant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                new RejectApplicant(ref dgv, applicant).ShowDialog();
              
            }
        }

        private void btnRequirementBriefing_Click(object sender, EventArgs e)
        {
            new SetDateDialog(requirement_briefing_date, setRequirementsBriefing).ShowDialog();
        }
    }
}
