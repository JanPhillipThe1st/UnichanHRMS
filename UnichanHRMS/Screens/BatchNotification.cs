using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UnichanHRMS.Screens
{
    public partial class BatchNotification : Form
    {
        Utilities utilities = new Utilities();
        Database database = new Database();
        DataTable applicantDataTable = new DataTable();
        Applicant applicant = new Applicant();
        private SerialPort _serialPort;
        public BatchNotification()
        {
            InitializeComponent();
            utilities = new Utilities();
        }

        private void Manage_Employees_Load(object sender, EventArgs e)
        {
            database.fillApplicantsTable(ref dgvApplicants);

            dgvApplicants.Columns.Remove("ID");
            dgvApplicants.Columns.Insert(0, new DataGridViewCheckBoxColumn() { Name = "Select"});

            cbPortList.Items.Clear();
            cbPortList.Items.AddRange(SerialPort.GetPortNames());

            cbNotificationType.SelectedIndexChanged += CbNotificationType_SelectedIndexChanged;

        }

        private void CbNotificationType_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if (MessageBox.Show("Are you sure you want to send this message to the recipients?", "Send batch SMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in dgvApplicants.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        String message = tbMessage.Text.Replace("<<recipient_name>>", row.Cells[1].ToString() + " " + row.Cells[3].ToString());
                        sendSMS(row.Cells[7].ToString(), tbMessage.Text);

                    }
                    else
                    {

                        MessageBox.Show("False");
                    }


                    MessageBox.Show("Messages sent successfully!");
                }
            }
        }
        void sendSMS(String contact_number, String message) {
            String port = cbPortList.Text;

            _serialPort = new SerialPort(port, 115200);


            MessageBox.Show(port);

            Thread.Sleep(1000);

            _serialPort.Open();
            Thread.Sleep(1000);

            _serialPort.Write("AT+CMGF=1\r");
            Thread.Sleep(1000);

            _serialPort.Write("AT+CMGS=\"" + contact_number + "\"\r\n");
            Thread.Sleep(1000);

            _serialPort.Write(message+ "\x1A");

            Thread.Sleep(1000);


            _serialPort.Close();
        }

        private void dgvApplicants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void tbSearchApplicant_TextChanged(object sender, EventArgs e)
        {
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
       
        }

        private void cbShowRejected_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void btnSMSNotification_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cbPortList.Items.Clear();
            cbPortList.Items.AddRange(SerialPort.GetPortNames());
        }

        private void cbNotificationType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            changeContent();
        }
        void changeContent() {
            if (cbNotificationType.SelectedIndex == 0)
            {
                String message = "Hello, <<recipient_name>>! This is from Unichan Incorporated Human Resources Department.\nWe would like to inform you that your INITIAL" +
                 "\nINTERVIEW has been scheduled on <<schedule>> . Please be there!";
               message = message.Replace("<<schedule>>", dtpSchedule.Value.ToString("MMMM dd, yyyy hh:mm tt"));
                tbMessage.Text = message;
            }
            else if (cbNotificationType.SelectedIndex == 1)
            {

                String message = "Hello, <<recipient_name>> ! This is from Unichan Incorporated Human Resources Department.\nWe would like to inform you that your FINAL" +
                     "\nINTERVIEW has been scheduled on <<schedule>> . Please be there!";
                message = message.Replace("<<schedule>>", dtpSchedule.Value.ToString("MMMM dd, yyyy hh:mm tt"));
                tbMessage.Text = message;
            }
            else if (cbNotificationType.SelectedIndex == 2)
            {

               String message = "Congratulations, <<recipient_name>> ! \r\n\r\nYou have successfully passed the final interview.\r\n\r\nPlease be here on <<schedule>> " +
                "for a briefing on the next steps of the hiring process. During the briefing, " +
                "you will receive a list of the requirements needed to complete your employment documents.\r\n\r\nOnce again, " +
                "congratulations and we look forward to having you as part of our team!";
                message = message.Replace("<<schedule>>", dtpSchedule.Value.ToString("MMMM dd, yyyy hh:mm tt"));
                tbMessage.Text = message;
            }
        }

        private void dtpSchedule_ValueChanged(object sender, EventArgs e)
        {

            changeContent();
        }
    }
}
