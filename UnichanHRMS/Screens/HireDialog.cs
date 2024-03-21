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
    public partial class HireDialog : Form
    {
        Database database = new Database();
        Employee employee = new Employee();
        Applicant applicant = new Applicant(); 
        DataGridView dgv = new DataGridView();
        public HireDialog(ref DataGridView dgv, ref Applicant applicant)
        {
            InitializeComponent();
            this.applicant = applicant; 
            this.dgv = dgv;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to hire " + applicant.first_name + " " + applicant.last_name + " as an employee?" , "Hiring Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                employee.applicant_ID = applicant.applicant_ID;
                employee.batch_number = applicant.batch_number;
                employee.sss_number = mtbSSS.Text;
                employee.philhealth_number = mtbPhilHealth.Text;
                employee.pag_ibig_number = mtbPagIbig.Text;
                employee.TIN_number = mtbTIN.Text;
                employee.orientation_date = dtpOrientationDate.Value;
                employee.generated_ID = (DateTime.Now.Year + "-"+ String.Format("{0000}",database.getNextEmployeeID()));
                MessageBox.Show(employee.generated_ID);
                applicant.application_status = "hired";
                database.updateApplicant(applicant);

                database.addEmployee(employee);
                database.checkForRegulars();
                database.fillApplicantsTable(ref dgv);
                this.Close();
            }
        }

        private void AddApplicant_Load(object sender, EventArgs e)
        {
            cbBatchNumber.Items.AddRange(database.getBatchNumbers().ToArray());

            //Notify the user that he will now hire an applicant as an employee
            lblHiringMessage.Text = "Important message: You are now hiring "+ applicant.first_name + " " + applicant.last_name + " as an employee. \nPlease complete his/her details.";
            //We already know the batch number from the applicant.
            //So we disable the cbBatchNumber control
            cbBatchNumber.Text = applicant.batch_number.ToString();
            cbBatchNumber.Enabled = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all input?","Clear inputs",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
            foreach (Control control in this.Controls)
            {
                    if (control is TextBox) {
                        TextBox textBox = (TextBox)control;
                        textBox.Clear();
                    }
                    if (control is MaskedTextBox)
                    {
                        MaskedTextBox textBox = (MaskedTextBox)control;
                        textBox.Clear();
                    }
                }
                
            }
        }
    }
}
