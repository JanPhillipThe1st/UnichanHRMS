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

namespace UnichanHRMS.Screens.Settings_Screens
{
    public partial class UserManagement : Form
    {
        Database database = new Database();
        User currentUser = new User();
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new AddUsers(ref dgvUsers).ShowDialog();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            database.fillUsersTable(ref dgvUsers,"hiring_manager");
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
                database.fillUsersTable(ref dgvUsers, "hiring_manager");
            }
        }
    }
}
