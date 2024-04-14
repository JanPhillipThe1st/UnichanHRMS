using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UnichanHRMS.Models;

namespace UnichanHRMS.Screens
{
    public partial class VisitorsLogReport : Form
    {
        DataTable dataTable = new DataTable();
        Database database = new Database();
        public VisitorsLogReport(DataTable dataTable)
        {
            InitializeComponent();
            this.dataTable = dataTable;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void AddApplicant_Load(object sender, EventArgs e)
        {
            loadReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
         
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            loadReport();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            loadReport();
        }
        void loadReport() {

            dataTable = database.fillVisitorsTable(dtpFrom.Value, dtpTo.Value);
            this.VisitorReport.RefreshReport();
            this.VisitorReport.LocalReport.DataSources.Clear();
            this.VisitorReport.LocalReport.SetParameters(new ReportParameter("date_from",dtpFrom.Value.ToShortDateString()));
            this.VisitorReport.LocalReport.SetParameters(new ReportParameter("date_to",dtpTo.Value.ToShortDateString()));
            VisitorReport.LocalReport.DataSources.Add(new ReportDataSource("VisitorsLog", dataTable));
            this.VisitorReport.RefreshReport();
        }
    }
}
