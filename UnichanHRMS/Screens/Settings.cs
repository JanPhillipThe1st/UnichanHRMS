using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnichanHRMS.Screens.Settings_Screens;

namespace UnichanHRMS.Screens
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnManageBatchNumbers_Click(object sender, EventArgs e)
        {
            BatchNumbers batchNumbers = new BatchNumbers();
            batchNumbers.Dock = DockStyle.Fill;
            batchNumbers.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(batchNumbers);
            batchNumbers.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserType != "admin")
            {
                MessageBox.Show("You are not allowed to access this setting.");
                return;
            }
            Form panelForm = new UserManagement();
            panelForm.Dock = DockStyle.Fill;
            panelForm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelForm);
            panelForm.Show();
        }
    }
}
