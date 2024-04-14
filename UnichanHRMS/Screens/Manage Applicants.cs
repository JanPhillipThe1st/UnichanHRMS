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
    public partial class Manage_Applicants : Form
    {
        Utilities utilities = new Utilities();
        Database database = new Database();
        Applicant applicant = new Applicant();
        public Manage_Applicants()
        {
            InitializeComponent();
            utilities = new Utilities();
        }

        private void Manage_Employees_Load(object sender, EventArgs e)
        {
            database.fillApplicantsTable(ref dgvApplicants);
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
        }

        private void cbBatchNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAddApplicant_Click(object sender, EventArgs e)
        {
            new AddApplicant(ref dgvApplicants).ShowDialog();
        }

        private void dgvApplicants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new EditApplicant(ref dgvApplicants,database.getApplicantByID(dgvApplicants.Rows[e.RowIndex].Cells[0].Value.ToString())).Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void tbSearchApplicant_TextChanged(object sender, EventArgs e)
        {
            database.filterApplicantsTable(ref dgvApplicants, tbSearchApplicant.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting " + applicant.first_name + " " + applicant.middle_name + " " + applicant.last_name + "'s data.\nAre you sure you want to delete this information?\nThis cannot be undone.", "Deleting employee information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.deleteEmployee(applicant.applicant_ID.ToString());
                database.deleteApplicant(applicant);
                database.fillApplicantsTable(ref dgvApplicants);
            }
        }

        private void dgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            applicant = database.getApplicantByID(dgvApplicants.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (applicant.applicant_ID == 0)
            {
                btnDelete.Enabled = false;   
            }
            else
            {
                btnDelete.Enabled = true;   
            }
        }

        private void cbShowRejected_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowRejected.Checked)
            {
                database.fillApplicantsTableWithRejected(ref dgvApplicants);
            }
            else {
                database.fillApplicantsTable(ref dgvApplicants);
            }
        }

        private void btnSMSNotification_Click(object sender, EventArgs e)
        {
            new BatchNotification().ShowDialog();
        }
    }
}
