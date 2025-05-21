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
    public partial class frmForgotPassword : Form
    {
        private DBManager db = new DBManager();
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLogin myLogin = new frmLogin();
            myLogin.Show();
            this.Hide();
        }

        private void btnSendReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            // 1) generate token in DB
            var token = db.GenerateResetToken(email);
            if (token == null)
            {
                MessageBox.Show("Email not found.");
                return;
            }

            // 2) send email
            try
            {
                db.SendResetEmail(email, token);
                MessageBox.Show(
                    "A reset token has been sent to your email.\n" +
                    "Please check your inbox and use it in the next screen.");

                // 3) open reset form
                var resetForm = new frmResetPassword();
                resetForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }
    }
}
