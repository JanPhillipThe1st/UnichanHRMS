using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnichanHRMS
{
    public partial class Login : Form
    {
        Utilities utilities = new Utilities();
        Database database = new Database();

        public Login()
        {
            InitializeComponent();
            utilities = new Utilities();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = utilities.defaultThemePrimaryColor;
            this.btnLogin.BackColor = utilities.defaultThemePrimaryColor;
            this.BackColor = utilities.defaultThemeBackgroundColor;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {

        }

        private void cbTogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTogglePassword.Checked)
            {
                cbTogglePassword.BackgroundImage = Properties.Resources.witness;
                tbPassword.PasswordChar = Char.MinValue;
            }
            else { 
                cbTogglePassword.BackgroundImage = Properties.Resources.hide;
                tbPassword.PasswordChar = '•';
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            captureE(e);
        }
        //Global method for capturing the keypress event for effortless tab switching
        void captureE(KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
        void login() {

            if (database.adminLogin(tbUsername.Text, tbPassword.Text))
            {
                new MainScreen().Show();
                tbPassword.Text = "";
                tbUsername.Text = "";
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {

            captureE(e);
        }
    }
}
