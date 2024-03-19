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

        public VisitorsLog()
        {
            InitializeComponent();
            utilities = new Utilities();
        }

        private void Manage_Employees_Load(object sender, EventArgs e)
        {
            database.fillVisitorsTable(ref dgvVisitorsLog);
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
            visitor.name = tbName.Text;
            visitor.purpose = tbPurpose.Text;
            visitor.company = tbCompany.Text;
            visitor.time_in = dtpTimeIn.Value;
            visitor.time_out = dtpTimeOut.Value;
            visitor.date_of_visit = dtpDateOfVisit.Value;
            if(MessageBox.Show("Are you sure you want to add this information?","Adding visitor entry",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
                database.addVisitor(visitor);
                database.fillVisitorsTable(ref dgvVisitorsLog);
            }

        }
    }
}
