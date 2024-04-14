using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnichanHRMS.Models ;
using UserModel = UnichanHRMS.Models.User;

namespace UnichanHRMS.Screens.Settings_Screens
{
    public partial class UserManagement : Form
    {
        Database database = new Database();
        UserModel currentUser = new UserModel();
        UserModel admin = new UserModel();
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            admin = database.getAdmin();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new AddUsers(ref dgvUsers, "hiring_assistant").ShowDialog();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            database.fillUsersTable(ref dgvUsers, "hiring_assistant");
            database.fillUsersTable(ref dgvHiringManagers,"admin");
        }
        
        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           currentUser =  database.getUserByID(dgvUsers.SelectedCells[0].Value.ToString());
            new EditUser(ref dgvUsers,currentUser).ShowDialog();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentUser = database.getUserByID(dgvUsers.SelectedCells[0].Value.ToString());
            if (currentUser.id == 0)
            {
                btnDelete.Enabled = false;
            }
            else { 
            btnDelete.Enabled=true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + currentUser.username + "'s account?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.deleteUser(currentUser);
                database.fillUsersTable(ref dgvUsers, "hiring_assistant");
                database.fillUsersTable(ref dgvHiringManagers, "admin");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewHiringManager_Click(object sender, EventArgs e)
        {

            new AddHiringManager(ref dgvHiringManagers).ShowDialog();
     
        }

        private void btnDeleteHiringManager_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + currentUser.username + "'s account?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.deleteUser(currentUser);
                database.fillUsersTable(ref dgvUsers, "hiring_assistant");
                database.fillUsersTable(ref dgvHiringManagers, "admin");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
