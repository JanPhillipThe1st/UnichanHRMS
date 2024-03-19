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
    public partial class AddUsers : Form
    {
        Database database = new Database();
        User user = new User();
        DataGridView dataGridView = new DataGridView();
        public AddUsers(ref DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

       

            user.username = tbUsername.Text;
            user.address = tbAddress.Text;
            user.contact = tbContact.Text;
            user.access = "hiring_manager";
            user.password = database.encryptPassword(tbConfirmPassword.Text,"yamato");
            user.fullName = tbFirstname.Text + " " + tbMiddleName.Text + " " + tbLastName.Text+ " ";
            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Cannot proceed");
            }
            else { 
                    if (MessageBox.Show("Are you sure you want to save this information?","Adding new user",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    database.addUser(user);
                        database.fillUsersTable(ref dataGridView,"hiring_manager");
                    }
            }
        }

        private void AddApplicant_Load(object sender, EventArgs e)
        {
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                tbConfirmPassword.ForeColor = Color.Red; 
            }
            else
            {
                pbPasswordStrength.Value =(database.passwordStrengthChecker(tbConfirmPassword.Text));
                tbConfirmPassword.ForeColor = Color.Black; 
                
            }
        }
    }
}
