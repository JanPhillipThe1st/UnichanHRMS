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
    public partial class Employee_Report : Form
    {
        DataTable dataTable = new DataTable();
        public Employee_Report(DataTable dataTable)
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
         
            this.EmployeeReport.RefreshReport();
            this.EmployeeReport.LocalReport.DataSources.Clear();
            EmployeeReport.LocalReport.DataSources.Add(new ReportDataSource("EmployeeReportDatasource",dataTable));
            this.EmployeeReport.RefreshReport();
        }
    }
}
