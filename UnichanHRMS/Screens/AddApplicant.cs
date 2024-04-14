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
    public partial class AddApplicant : Form
    {
        Database database = new Database();
        Applicant applicant = new Applicant(); 
        DataGridView dataGridView = new DataGridView();
        public AddApplicant(ref DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool notFilled = false;
        
            if (cbGender.Text.Length <= 0)
            {
                errorProvider1.SetError(cbGender, "Please choose an item.");
                notFilled = true;
            }
            if (cbBatchNumber.Text.Length <= 0)
            {
                errorProvider1.SetError(cbBatchNumber, "Please choose an item.");
                notFilled = true;
            }
            if (tbContact.Text.Length <= 0)
            {
                errorProvider1.SetError(tbContact, "Please fill in this field");
                notFilled = true;
            }
            if (tbAge.Text.Length <= 0)
            {
                errorProvider1.SetError(tbAge, "Please fill in this field");
                notFilled = true;
            }
            if (tbLastName.Text.Length <= 0)
            {
                errorProvider1.SetError(tbLastName, "Please fill in this field");
                notFilled = true;
            }
            if (tbMiddleName.Text.Length <= 0)
            {
                errorProvider1.SetError(tbMiddleName, "Please fill in this field");
                notFilled = true;
            }
            if (tbFirstname.Text.Length <= 0)
            {
                errorProvider1.SetError(tbFirstname, "Please fill in this field");
                notFilled = true;
            }
            if (!notFilled)
            {
                
                applicant.final_interview_date = "NOT SET";
                applicant.initial_interview_date = "NOT SET";
                applicant.exam_date = dtpExamDate.Value;


               applicant.application_date = dtpApplicationDate.Value;
               applicant.contact = tbContact.Text;
               applicant.gender = cbGender.Text;
               applicant.age = tbAge.Text;
               applicant.birth_date = dtpBirthdate.Value;
               applicant.last_name = tbLastName.Text;
               applicant.middle_name = tbMiddleName.Text;
               applicant.application_status = "pending";
               applicant.first_name = tbFirstname.Text;
               applicant.batch_number = Convert.ToInt32(cbBatchNumber.Text);


                if (MessageBox.Show("Are you sure you want to save this information?","Adding new applicant",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                database.addApplicant(applicant);
                    database.fillApplicantsTable(ref dataGridView);
                    this.Close();
                }
            }
            }

        private void AddApplicant_Load(object sender, EventArgs e)
        {
            cbBatchNumber.Items.AddRange(database.getBatchNumbers().ToArray());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all input?", "Clear inputs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
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

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - dtpBirthdate.Value.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (dtpBirthdate.Value.Date > today.AddYears(-age)) age--;

            tbAge.Text = age.ToString();
        }
    }
}
