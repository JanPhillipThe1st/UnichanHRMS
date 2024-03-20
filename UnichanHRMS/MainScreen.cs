using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnichanHRMS.Screens;

namespace UnichanHRMS
{
    public partial class MainScreen : Form
    {

        Utilities utilities = new Utilities();
        Database database = new Database();

        public MainScreen()
        {
            InitializeComponent();
            utilities = new Utilities();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            this.BackColor = utilities.defaultThemeBackgroundColor;
            this.panelBanner.BackColor = utilities.defaultThemePrimaryColor;
            this.btnEmployees.BackColor = utilities.defaultThemePrimaryColor;
            this.btnManageApplicants.BackColor = utilities.defaultThemePrimaryColor;
            this.btnVisitorsLog.BackColor = utilities.defaultThemePrimaryColor;
            this.btnLogout.BackColor = utilities.defaultThemePrimaryColor;
            timer1.Start();
            lblWelcome.Text = Properties.Settings.Default.UserStates;



        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Manage_Employees manage_employees = new Manage_Employees();
            manage_employees.Dock = DockStyle.Fill;
            manage_employees.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(manage_employees);
            manage_employees.Show();
        }

        private void btnManageApplicants_Click(object sender, EventArgs e)
        {
            Manage_Applicants manage_applicants = new Manage_Applicants();
            manage_applicants.Dock = DockStyle.Fill;
            manage_applicants.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(manage_applicants);
            manage_applicants.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnVisitorsLog_Click(object sender, EventArgs e)
        {
            VisitorsLog form = new VisitorsLog();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy HH:mm:ss");
        }
    }
}
