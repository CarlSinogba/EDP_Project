﻿using System;
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
    public partial class frmAmount : Form
    {
        public frmAmount()
        {
            InitializeComponent();
        }

        private void labelReturn_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
        }
        private void frmAmount_Load(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            DGamount.DataSource = dbManager.GetAmountInfo();
            DGtotal.DataSource = dbManager.GetAmountTotalInfo();
        }
    }
}
