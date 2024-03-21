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
            // applicant.final_interview_date = dtpFinalInterviewDate.Value.ToString("MMMM dd, yyyy");
            // applicant.initial_interview_date = dtpInitialInterviewDate.Value.ToString("MMMM dd, yyyy");

            foreach (Control control in this.Controls) {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Text.Length <= 0)
                    {
                        errorProvider1.SetError(textBox, "Please fill in this field");
                        return;
                    }
                    else {
                        errorProvider1.Clear();
                    }
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Text.Length <= 0)
                    {
                        errorProvider1.SetError(comboBox, "Please choose an item.");
                        return;
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
            }

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
    }
}
