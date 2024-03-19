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
    public partial class Manage_Employees : Form
    {
        Utilities utilities = new Utilities();
        Database database = new Database();
        Employee currentEmployee = new Employee();
        Applicant applicant = new Applicant();
        DataTable employeeDataTable = new DataTable();
        Dictionary<String,String> filterDictionary = new Dictionary<String,String>();   
        public Manage_Employees()
        {
            InitializeComponent();
            utilities = new Utilities();
        }

        private void Manage_Employees_Load(object sender, EventArgs e)
        {
            filterDictionary.Add("Employment Remarks","employment_remarks");
            filterDictionary.Add("Orientation Date","orientation_date");
            filterDictionary.Add("Batch Number","batch_number");
            cbFilter.Items.AddRange(filterDictionary.Keys.ToArray());
            this.panel1.BackColor = utilities.defaultThemePrimaryColor;
            //Populate the data table for employees
            employeeDataTable = database.fillEmployeesTable(ref dgvActiveEmployees,"ACTIVE");
            database.fillEmployeesTable(ref dgvResignedEmployees,"DESIGNED");
            lblCount.Text = "Current Active Employees: " + dgvActiveEmployees.RowCount;
            if (currentEmployee.employee_ID != 0)
            {
                btnEditEmployee.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            new AddApplicant(ref dgvActiveEmployees).Show();
        }

        private void cbBatchNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeDataTable = database.fillEmployeesTableByBatchNumber(ref dgvActiveEmployees,cbFilter.Text,"ACTIVE");
            database.fillEmployeesTableByBatchNumber(ref dgvResignedEmployees,cbFilter.Text,"RESIGNED");

            cbCriteria.Items.Clear();
            cbCriteria.Items.AddRange(database.getCriteria(filterDictionary[cbFilter.Text]).ToArray());
        }

        private void cbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeDataTable = database.filterEmployeesTable(ref dgvActiveEmployees, filterDictionary[cbFilter.Text],cbCriteria.Text);
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {

          employeeDataTable =   database.fillEmployeesTable(ref dgvActiveEmployees, "ACTIVE");
            database.fillEmployeesTable(ref dgvResignedEmployees, "RESIGNED");
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            database.filterEmployeesTableByName(ref dgvActiveEmployees, tbSearchEmployee.Text);
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            new EditEmployee(ref dgvActiveEmployees,currentEmployee).ShowDialog();
        }

        private void dgvActiveEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentEmployee = database.getEmployeeByID(dgvActiveEmployees.SelectedCells[0].Value.ToString());
            if (currentEmployee.employee_ID != 0)
            {
                applicant = database.getApplicantByID(currentEmployee.applicant_ID.ToString());
                btnEditEmployee.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        private void dgvResignedEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            currentEmployee = database.getEmployeeByID(dgvResignedEmployees.SelectedCells[0].Value.ToString());
            if (currentEmployee.employee_ID != 0)
            {
                applicant = database.getApplicantByID(currentEmployee.applicant_ID.ToString());
                btnEditEmployee.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            applicant = database.getApplicantByID(currentEmployee.applicant_ID.ToString());
            if (MessageBox.Show("Deleting "+applicant.first_name +" " + applicant.middle_name + " " + applicant.last_name +"'s data.\nAre you sure you want to delete this information?\nThis cannot be undone.", "Deleting employee information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.deleteEmployee(currentEmployee);
                database.deleteApplicant(applicant);
                employeeDataTable = database.fillEmployeesTable(ref dgvActiveEmployees,"ACTIVE");
            }
        }

        private void dgvActiveEmployees_KeyPress(object sender, KeyPressEventArgs e)
        {

       
        }

        private void dgvActiveEmployees_KeyDown(object sender, KeyEventArgs e)
        {

            currentEmployee = database.getEmployeeByID(dgvActiveEmployees.SelectedCells[0].Value.ToString());
            if (currentEmployee.employee_ID != 0)
            {
                applicant = database.getApplicantByID(currentEmployee.applicant_ID.ToString());
                btnEditEmployee.Enabled = true;
                btnDelete.Enabled = true;
                if (e.KeyCode == Keys.E || e.KeyCode == Keys.Enter)
                {
                    new EditEmployee(ref dgvActiveEmployees, currentEmployee).ShowDialog();
                }
                else if (e.KeyCode == Keys.D) {
                    applicant = database.getApplicantByID(currentEmployee.applicant_ID.ToString());
                    if (MessageBox.Show("Deleting " + applicant.first_name + " " + applicant.middle_name + " " + applicant.last_name + "'s data.\nAre you sure you want to delete this information?\nThis cannot be undone.", "Deleting employee information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        database.deleteEmployee(currentEmployee);
                        database.deleteApplicant(applicant);
                        employeeDataTable = database.fillEmployeesTable(ref dgvActiveEmployees, "ACTIVE");
                    }
                }
            }

        }

        private void gbEmployees_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

        }
    }
}
