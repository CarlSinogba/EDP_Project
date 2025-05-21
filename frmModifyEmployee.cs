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
    public partial class frmModifyEmployee : Form
    {
        public frmModifyEmployee()
        {
            InitializeComponent();
        }
        private void labelEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee myEmployee = new frmEmployee();
            myEmployee.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            dbManager.InsertEmployee(txtFirstName.Text, txtLastName.Text, txtBranchID.Text);

            MessageBox.Show("User inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtBranchID.Clear();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDeleteSearch.Text))
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    var dbManager = new DBManager();
                    dbManager.DeleteEmployee(txtDeleteSearch.Text.Trim());

                    MessageBox.Show("Employee deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDeleteSearch.Clear();
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtBranchID.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please search for a user to delete.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
       