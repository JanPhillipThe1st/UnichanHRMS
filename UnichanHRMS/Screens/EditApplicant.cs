using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        DataGridView dgv = new DataGridView();
        public EditApplicant(ref DataGridView dgv,Applicant applicant)
        {
            InitializeComponent();
            this.applicant = applicant;
            this.dgv = dgv;
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
            }
            else if (dtpFinalInterviewDate.Text == "NOT SET" && dtpInitialInterviewDate.Text != "NOT SET")
            {
                applicant.application_status = "PASSED EXAMINATION";
                btnHire.Enabled = false;
                btnScheduleInitiralInterview.Enabled = false;
            }
            else
            {
                applicant.application_status = "PASSED INITIAL INTERVIEW";
                btnHire.Enabled = true;
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
            new SetDateDialog(final_inverview_date, setFinalInterviewDate).Show();

        }
        public void setFinalInterviewDate(DateTime f_i_d)
        {
            applicant.final_interview_date = f_i_d.ToString("MMMM dd, yyyy");
            dtpFinalInterviewDate.Text = applicant.final_interview_date;
        }
        public void setInitiallInterviewDate(DateTime f_i_d)
        {
            applicant.initial_interview_date = f_i_d.ToString("MMMM dd, yyyy");
            dtpInitialInterviewDate.Text = applicant.initial_interview_date;
        }

        private void btnScheduleInitiralInterview_Click(object sender, EventArgs e)
        {
            new SetDateDialog(initial_interview_date, setInitiallInterviewDate).Show();
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
    }
}
