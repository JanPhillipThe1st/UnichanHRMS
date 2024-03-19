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
    public partial class RejectApplicant : Form
    {
        Applicant applicant = new Applicant();

        DataGridView dgv = new DataGridView();
        Database database = new Database();

        public RejectApplicant(ref DataGridView dgv, Applicant applicant)
        {
            InitializeComponent();
            this.applicant = applicant;
            this.dgv = dgv;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            applicant.remarks = tbRemarks.Text;
            applicant.application_status = "rejected";
            database.updateApplicant(applicant);
            database.fillApplicantsTable(ref dgv);
            this.Close();
        }
    }
}
