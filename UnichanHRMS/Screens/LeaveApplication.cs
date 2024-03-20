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
    public partial class LeaveApplication : Form
    {
        Database database = new Database();
        Employee employee = new Employee();
        public LeaveApplication(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDateDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this record?","Leave",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.grantLeave(employee);
                this.Close();
            }
        }
    }
}
