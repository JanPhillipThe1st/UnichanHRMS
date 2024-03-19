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
    public partial class EditEmployee : Form
    {
        Database database = new Database();
        Applicant applicant = new Applicant();
        Employee employee = new Employee(); 
        DateTime final_inverview_date = DateTime.Now;
        DateTime initial_interview_date = DateTime.Now;
        DataGridView dgv = new DataGridView();
        public EditEmployee(ref DataGridView dgv,Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.dgv = dgv;
            this.applicant = database.getApplicantByID(employee.applicant_ID.ToString());
        }
        private void AddApplicant_Load(object sender, EventArgs e)
        {
            dtpFinalInterviewDate.Value = DateTime.Parse(applicant.final_interview_date);
            dtpInitialInterviewDate.Value = DateTime.Parse(applicant.initial_interview_date);
            dtpExamDate.Value = applicant.exam_date;
            dtpApplicationDate.Value = applicant.application_date;
            tbContact.Text = applicant.contact;
            tbGender.Text = applicant.gender;
            tbAge.Text = applicant.age;
            tbLastName.Text = applicant.last_name;
            tbMiddleName.Text = applicant.middle_name;
            tbFirstname.Text = applicant.first_name;


            applicant.applicant_ID = employee.applicant_ID;
            applicant.batch_number = employee.batch_number;
            mtbSSS.Text = employee.sss_number;
            mtbPhilHealth.Text = employee.philhealth_number;
            mtbPagIbig.Text = employee.pag_ibig_number;
            mtbTIN.Text = employee.TIN_number;
            dtpOrientationDate.Value = employee.orientation_date;

            cbEmployeeStatus.Text = employee.employment_remarks;
            tbEmployeeRemarks.Text = employee.employment_status;


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
            applicant.contact = tbContact.Text;
            applicant.gender = tbGender.Text;
            applicant.age = tbAge.Text;
            applicant.last_name = tbLastName.Text;
            applicant.birth_date = dtpBirthdate.Value;
            applicant.middle_name = tbMiddleName.Text;
            applicant.first_name = tbFirstname.Text;


            employee.applicant_ID = applicant.applicant_ID;
            employee.batch_number = applicant.batch_number;
            employee.sss_number = mtbSSS.Text;
            employee.philhealth_number = mtbPhilHealth.Text;
            employee.pag_ibig_number = mtbPagIbig.Text;
            employee.TIN_number = mtbTIN.Text;
            employee.orientation_date = dtpOrientationDate.Value;
            employee.employment_remarks = cbEmployeeStatus.Text;
            employee.employment_status = tbEmployeeRemarks.Text;

            if (MessageBox.Show("Are you sure you want to save this information?", "Updating employee information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.updateApplicant(applicant);
                database.updateEmployee(employee);
                database.fillEmployeesTable(ref dgv, "ACTIVE");
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this information?\nThis cannot be undone.", "Deleting employee information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.deleteEmployee(employee);
                database.deleteApplicant(applicant);
                database.fillEmployeesTable(ref dgv,"ACTIVE");
            }
        }

        private void btnScheduleFinalinterview_Click(object sender, EventArgs e)
        {

        }
        public void setFinalInterviewDate(DateTime f_i_d)
        {
          
        }
        public void setInitiallInterviewDate(DateTime f_i_d)
        {
         
        }

        private void btnScheduleInitiralInterview_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
           
        }
    }
}
