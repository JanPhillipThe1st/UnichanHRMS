using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnichanHRMS.Models;

namespace UnichanHRMS.Screens
{
    public partial class VisitorsLog : Form
    {
        Utilities utilities = new Utilities();
        Visitor visitor = new Visitor();
        Database database = new Database();
        DataTable dataTable = new DataTable();

        public VisitorsLog()
        {
            InitializeComponent();
            utilities = new Utilities();
        }

        private void Manage_Employees_Load(object sender, EventArgs e)
        {
           dataTable =  database.fillVisitorsTable(ref dgvVisitorsLog);
            AutoCompleteStringCollection companySource = new AutoCompleteStringCollection();
            AutoCompleteStringCollection nameSource = new AutoCompleteStringCollection();
            companySource.AddRange(database.getVisitors().Values.ToArray());
            nameSource.AddRange(database.getVisitors().Keys.ToArray());
            tbName.AutoCompleteCustomSource = nameSource;
            tbCompany.AutoCompleteCustomSource = companySource;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
        }

        private void btnAddApplicant_Click(object sender, EventArgs e)
        {
        }

        private void dgvApplicants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool notFilled = false;
            if (tbPurpose.Text.Length <= 0)
            {
                errorProvider1.SetError(tbPurpose, "Please fill in this field");
                notFilled = true;
            }
            if (tbCompany.Text.Length <= 0)
            {
                errorProvider1.SetError(tbCompany, "Please fill in this field");
                notFilled = true;
            }
            if (tbName.Text.Length <= 0)
            {
                errorProvider1.SetError(tbName, "Please fill in this field");
                notFilled = true;
            }
            if (!notFilled)
            {
            visitor.name = tbName.Text;
            visitor.purpose = tbPurpose.Text;
            visitor.company = tbCompany.Text;
            visitor.time_in = dtpTimeIn.Value;
            visitor.time_out = dtpTimeOut.Value;
            visitor.date_of_visit = dtpDateOfVisit.Value;
            if(MessageBox.Show("Are you sure you want to add this information?","Adding visitor entry",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
                database.addVisitor(visitor);
                dataTable = database.fillVisitorsTable(ref dgvVisitorsLog);
            }
            }

        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?","Delete log",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                database.deleteLog(dgvVisitorsLog.SelectedCells[0].Value.ToString());
                dataTable = database.fillVisitorsTable(ref dgvVisitorsLog);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new VisitorsLogReport(dataTable).ShowDialog();
        }
    }
}
