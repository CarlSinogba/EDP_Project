using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_WinProject1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            bool isAuthenticated = dbManager.AuthenticateUser(usernameInput.Text, passwordInput.Text);

            if (isAuthenticated)
            {
                MessageBox.Show("Login Successful. Click OK to view Application's Dashboard", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed. Please check your username and password.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword myFgtPass = new frmForgotPassword();
            myFgtPass.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you want to close the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (answer == DialogResult.Yes)
            {
                // User chose Yes, close the application
                Application.Exit();

            }
        }
    }
}
