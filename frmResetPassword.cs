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
    public partial class frmResetPassword : Form
    {
        private DBManager db = new DBManager();

        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmForgotPassword myFgtPass = new frmForgotPassword();
            myFgtPass.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string token = txtToken.Text.Trim();
            string newPass = txtNewPassword.Text;

            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Please provide both token and new password.");
                return;
            }

            // 1) validate token
            var userId = db.ValidateResetToken(token);
            if (userId == null)
            {
                MessageBox.Show("Invalid or expired token.");
                return;
            }

            // 2) reset password
            bool success = db.ResetPassword(userId.Value, newPass);
            if (success)
            {
                MessageBox.Show("Your password has been reset!");
                var login = new frmLogin();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating password. Please try again.");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            var login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
