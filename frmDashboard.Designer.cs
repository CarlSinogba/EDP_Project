namespace EDP_WinProject1
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashboardView = new System.Windows.Forms.GroupBox();
            this.viewAccounts = new System.Windows.Forms.Button();
            this.labelAccounts = new System.Windows.Forms.Label();
            this.viewBranch = new System.Windows.Forms.Button();
            this.labelBranches = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.logCustomer = new System.Windows.Forms.Button();
            this.viewEmployee = new System.Windows.Forms.Button();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.viewComaker = new System.Windows.Forms.Button();
            this.labelComaker = new System.Windows.Forms.Label();
            this.viewCustomer = new System.Windows.Forms.Button();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.viewReceipt = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelReceipt = new System.Windows.Forms.Label();
            this.viewAmount = new System.Windows.Forms.Button();
            this.DashboardView.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardView
            // 
            this.DashboardView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DashboardView.Controls.Add(this.viewAmount);
            this.DashboardView.Controls.Add(this.viewAccounts);
            this.DashboardView.Controls.Add(this.labelAccounts);
            this.DashboardView.Controls.Add(this.viewBranch);
            this.DashboardView.Controls.Add(this.labelBranches);
            this.DashboardView.Controls.Add(this.labelAmount);
            this.DashboardView.Controls.Add(this.logCustomer);
            this.DashboardView.Controls.Add(this.viewEmployee);
            this.DashboardView.Controls.Add(this.labelEmployee);
            this.DashboardView.Controls.Add(this.viewComaker);
            this.DashboardView.Controls.Add(this.labelComaker);
            this.DashboardView.Controls.Add(this.viewCustomer);
            this.DashboardView.Controls.Add(this.labelCustomer);
            this.DashboardView.Controls.Add(this.viewReceipt);
            this.DashboardView.Controls.Add(this.btnLogout);
            this.DashboardView.Controls.Add(this.labelReceipt);
            this.DashboardView.Location = new System.Drawing.Point(9, 10);
            this.DashboardView.Margin = new System.Windows.Forms.Padding(2);
            this.DashboardView.Name = "DashboardView";
            this.DashboardView.Padding = new System.Windows.Forms.Padding(2);
            this.DashboardView.Size = new System.Drawing.Size(553, 297);
            this.DashboardView.TabIndex = 0;
            this.DashboardView.TabStop = false;
            // 
            // viewAccounts
            // 
            this.viewAccounts.Location = new System.Drawing.Point(212, 160);
            this.viewAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.viewAccounts.Name = "viewAccounts";
            this.viewAccounts.Size = new System.Drawing.Size(60, 23);
            this.viewAccounts.TabIndex = 15;
            this.viewAccounts.Text = "View List";
            this.viewAccounts.UseVisualStyleBackColor = true;
            this.viewAccounts.Click += new System.EventHandler(this.viewAccounts_Click);
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccounts.Location = new System.Drawing.Point(209, 140);
            this.labelAccounts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(70, 18);
            this.labelAccounts.TabIndex = 14;
            this.labelAccounts.Text = "Accounts";
            // 
            // viewBranch
            // 
            this.viewBranch.Location = new System.Drawing.Point(212, 106);
            this.viewBranch.Margin = new System.Windows.Forms.Padding(2);
            this.viewBranch.Name = "viewBranch";
            this.viewBranch.Size = new System.Drawing.Size(60, 23);
            this.viewBranch.TabIndex = 13;
            this.viewBranch.Text = "View List";
            this.viewBranch.UseVisualStyleBackColor = true;
            this.viewBranch.Click += new System.EventHandler(this.viewBranch_Click);
            // 
            // labelBranches
            // 
            this.labelBranches.AutoSize = true;
            this.labelBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranches.Location = new System.Drawing.Point(209, 85);
            this.labelBranches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBranches.Name = "labelBranches";
            this.labelBranches.Size = new System.Drawing.Size(132, 18);
            this.labelBranches.TabIndex = 12;
            this.labelBranches.Text = "Branches Location";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(209, 33);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(59, 18);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount";
            // 
            // logCustomer
            // 
            this.logCustomer.Location = new System.Drawing.Point(102, 106);
            this.logCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.logCustomer.Name = "logCustomer";
            this.logCustomer.Size = new System.Drawing.Size(60, 23);
            this.logCustomer.TabIndex = 9;
            this.logCustomer.Text = "View Log";
            this.logCustomer.UseVisualStyleBackColor = true;
            this.logCustomer.Click += new System.EventHandler(this.logCustomer_Click);
            // 
            // viewEmployee
            // 
            this.viewEmployee.Location = new System.Drawing.Point(38, 215);
            this.viewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.viewEmployee.Name = "viewEmployee";
            this.viewEmployee.Size = new System.Drawing.Size(60, 23);
            this.viewEmployee.TabIndex = 8;
            this.viewEmployee.Text = "View List";
            this.viewEmployee.UseVisualStyleBackColor = true;
            this.viewEmployee.Click += new System.EventHandler(this.viewEmployee_Click);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.Location = new System.Drawing.Point(34, 195);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(74, 18);
            this.labelEmployee.TabIndex = 7;
            this.labelEmployee.Text = "Employee";
            // 
            // viewComaker
            // 
            this.viewComaker.Location = new System.Drawing.Point(38, 160);
            this.viewComaker.Margin = new System.Windows.Forms.Padding(2);
            this.viewComaker.Name = "viewComaker";
            this.viewComaker.Size = new System.Drawing.Size(60, 23);
            this.viewComaker.TabIndex = 6;
            this.viewComaker.Text = "View List";
            this.viewComaker.UseVisualStyleBackColor = true;
            this.viewComaker.Click += new System.EventHandler(this.viewComaker_Click);
            // 
            // labelComaker
            // 
            this.labelComaker.AutoSize = true;
            this.labelComaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComaker.Location = new System.Drawing.Point(34, 140);
            this.labelComaker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComaker.Name = "labelComaker";
            this.labelComaker.Size = new System.Drawing.Size(70, 18);
            this.labelComaker.TabIndex = 5;
            this.labelComaker.Text = "Comaker";
            // 
            // viewCustomer
            // 
            this.viewCustomer.Location = new System.Drawing.Point(38, 106);
            this.viewCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.viewCustomer.Name = "viewCustomer";
            this.viewCustomer.Size = new System.Drawing.Size(60, 23);
            this.viewCustomer.TabIndex = 4;
            this.viewCustomer.Text = "View List";
            this.viewCustomer.UseVisualStyleBackColor = true;
            this.viewCustomer.Click += new System.EventHandler(this.viewCustomer_Click);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(34, 85);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(74, 18);
            this.labelCustomer.TabIndex = 3;
            this.labelCustomer.Text = "Customer";
            // 
            // viewReceipt
            // 
            this.viewReceipt.Location = new System.Drawing.Point(38, 54);
            this.viewReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.viewReceipt.Name = "viewReceipt";
            this.viewReceipt.Size = new System.Drawing.Size(60, 23);
            this.viewReceipt.TabIndex = 2;
            this.viewReceipt.Text = "View List";
            this.viewReceipt.UseVisualStyleBackColor = true;
            this.viewReceipt.Click += new System.EventHandler(this.viewReceipt_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(457, 254);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 37);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelReceipt
            // 
            this.labelReceipt.AutoSize = true;
            this.labelReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceipt.Location = new System.Drawing.Point(34, 33);
            this.labelReceipt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceipt.Name = "labelReceipt";
            this.labelReceipt.Size = new System.Drawing.Size(50, 18);
            this.labelReceipt.TabIndex = 0;
            this.labelReceipt.Text = "Receit";
            // 
            // viewAmount
            // 
            this.viewAmount.Location = new System.Drawing.Point(212, 54);
            this.viewAmount.Margin = new System.Windows.Forms.Padding(2);
            this.viewAmount.Name = "viewAmount";
            this.viewAmount.Size = new System.Drawing.Size(60, 23);
            this.viewAmount.TabIndex = 16;
            this.viewAmount.Text = "View List";
            this.viewAmount.UseVisualStyleBackColor = true;
            this.viewAmount.Click += new System.EventHandler(this.viewAmount_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 316);
            this.Controls.Add(this.DashboardView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.DashboardView.ResumeLayout(false);
            this.DashboardView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DashboardView;
        private System.Windows.Forms.Label labelReceipt;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button viewReceipt;
        private System.Windows.Forms.Button viewCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Button viewComaker;
        private System.Windows.Forms.Label labelComaker;
        private System.Windows.Forms.Button viewEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Button logCustomer;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button viewBranch;
        private System.Windows.Forms.Label labelBranches;
        private System.Windows.Forms.Label labelAccounts;
        private System.Windows.Forms.Button viewAccounts;
        private System.Windows.Forms.Button viewAmount;
    }
}