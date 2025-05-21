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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin myLogin = new frmLogin();
            myLogin.Show();
            this.Hide();
        }

        private void viewReceipt_Click(object sender, EventArgs e)
        {
            frmReceipt myReceipt = new frmReceipt();
            myReceipt.Show();
            this.Hide();
        }

        private void viewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer myCustomer= new frmCustomer();
            myCustomer.Show();
            this.Hide();
        }

        private void viewComaker_Click(object sender, EventArgs e)
        {
            frmComaker myComaker = new frmComaker();
            myComaker.Show();
            this.Hide();
        }

        private void viewEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee myEmployee = new frmEmployee();
            myEmployee.Show();
            this.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmAmount myAmount = new frmAmount();
            myAmount.Show();
            this.Hide();
        }

        private void logCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerLogs myCustomerlogs = new frmCustomerLogs();
            myCustomerlogs.Show();
            this.Hide();
        }

        private void viewBranch_Click(object sender, EventArgs e)
        {
            frmBranches frmBranch = new frmBranches();
            frmBranch.Show();
            this.Hide();
        }
    }
}
