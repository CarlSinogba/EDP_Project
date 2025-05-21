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
    public partial class frmComaker : Form
    {
        public frmComaker()
        {
            InitializeComponent();
        }

        private void labelReturn_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
        }
        private void frmComaker_Load(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            DGcomaker.DataSource = dbManager.GetComakerInfo();
        }
    }
}
