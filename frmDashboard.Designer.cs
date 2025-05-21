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
            this.viewAmount = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.logCustomer = new System.Windows.Forms.Button();
            this.viewEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewComaker = new System.Windows.Forms.Button();
            this.labelComaker = new System.Windows.Forms.Label();
            this.viewCustomer = new System.Windows.Forms.Button();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.viewReceipt = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelReceipt = new System.Windows.Forms.Label();
            this.viewBranch = new System.Windows.Forms.Button();
            this.labelBranches = new System.Windows.Forms.Label();
            this.DashboardView.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardView
            // 
            this.DashboardView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DashboardView.Controls.Add(this.viewBranch);
            this.DashboardView.Controls.Add(this.labelBranches);
            this.DashboardView.Controls.Add(this.viewAmount);
            this.DashboardView.Controls.Add(this.labelAmount);
            this.DashboardView.Controls.Add(this.logCustomer);
            this.DashboardView.Controls.Add(this.viewEmployee);
            this.DashboardView.Controls.Add(this.label1);
            this.DashboardView.Controls.Add(this.viewComaker);
            this.DashboardView.Controls.Add(this.labelComaker);
            this.DashboardView.Controls.Add(this.viewCustomer);
            this.DashboardView.Controls.Add(this.labelCustomer);
            this.DashboardView.Controls.Add(this.viewReceipt);
            this.DashboardView.Controls.Add(this.btnLogout);
            this.DashboardView.Controls.Add(this.labelReceipt);
            this.DashboardView.Location = new System.Drawing.Point(12, 12);
            this.DashboardView.Name = "DashboardView";
            this.DashboardView.Size = new System.Drawing.Size(737, 365);
            this.DashboardView.TabIndex = 0;
            this.DashboardView.TabStop = false;
            // 
            // viewAmount
            // 
            this.viewAmount.Location = new System.Drawing.Point(283, 66);
            this.viewAmount.Name = "viewAmount";
            this.viewAmount.Size = new System.Drawing.Size(80, 28);
            this.viewAmount.TabIndex = 11;
            this.viewAmount.Text = "View List";
            this.viewAmount.UseVisualStyleBackColor = true;
            this.viewAmount.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(279, 41);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 22);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount";
            // 
            // logCustomer
            // 
            this.logCustomer.Location = new System.Drawing.Point(136, 130);
            this.logCustomer.Name = "logCustomer";
            this.logCustomer.Size = new System.Drawing.Size(80, 28);
            this.logCustomer.TabIndex = 9;
            this.logCustomer.Text = "View Log";
            this.logCustomer.UseVisualStyleBackColor = true;
            this.logCustomer.Click += new System.EventHandler(this.logCustomer_Click);
            // 
            // viewEmployee
            // 
            this.viewEmployee.Location = new System.Drawing.Point(50, 265);
            this.viewEmployee.Name = "viewEmployee";
            this.viewEmployee.Size = new System.Drawing.Size(80, 28);
            this.viewEmployee.TabIndex = 8;
            this.viewEmployee.Text = "View List";
            this.viewEmployee.UseVisualStyleBackColor = true;
            this.viewEmployee.Click += new System.EventHandler(this.viewEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee";
            // 
            // viewComaker
            // 
            this.viewComaker.Location = new System.Drawing.Point(50, 197);
            this.viewComaker.Name = "viewComaker";
            this.viewComaker.Size = new System.Drawing.Size(80, 28);
            this.viewComaker.TabIndex = 6;
            this.viewComaker.Text = "View List";
            this.viewComaker.UseVisualStyleBackColor = true;
            this.viewComaker.Click += new System.EventHandler(this.viewComaker_Click);
            // 
            // labelComaker
            // 
            this.labelComaker.AutoSize = true;
            this.labelComaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComaker.Location = new System.Drawing.Point(46, 172);
            this.labelComaker.Name = "labelComaker";
            this.labelComaker.Size = new System.Drawing.Size(82, 22);
            this.labelComaker.TabIndex = 5;
            this.labelComaker.Text = "Comaker";
            // 
            // viewCustomer
            // 
            this.viewCustomer.Location = new System.Drawing.Point(50, 130);
            this.viewCustomer.Name = "viewCustomer";
            this.viewCustomer.Size = new System.Drawing.Size(80, 28);
            this.viewCustomer.TabIndex = 4;
            this.viewCustomer.Text = "View List";
            this.viewCustomer.UseVisualStyleBackColor = true;
            this.viewCustomer.Click += new System.EventHandler(this.viewCustomer_Click);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(46, 105);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(87, 22);
            this.labelCustomer.TabIndex = 3;
            this.labelCustomer.Text = "Customer";
            // 
            // viewReceipt
            // 
            this.viewReceipt.Location = new System.Drawing.Point(50, 66);
            this.viewReceipt.Name = "viewReceipt";
            this.viewReceipt.Size = new System.Drawing.Size(80, 28);
            this.viewReceipt.TabIndex = 2;
            this.viewReceipt.Text = "View List";
            this.viewReceipt.UseVisualStyleBackColor = true;
            this.viewReceipt.Click += new System.EventHandler(this.viewReceipt_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(609, 313);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 46);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelReceipt
            // 
            this.labelReceipt.AutoSize = true;
            this.labelReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceipt.Location = new System.Drawing.Point(46, 41);
            this.labelReceipt.Name = "labelReceipt";
            this.labelReceipt.Size = new System.Drawing.Size(61, 22);
            this.labelReceipt.TabIndex = 0;
            this.labelReceipt.Text = "Receit";
            // 
            // viewBranch
            // 
            this.viewBranch.Location = new System.Drawing.Point(283, 130);
            this.viewBranch.Name = "viewBranch";
            this.viewBranch.Size = new System.Drawing.Size(80, 28);
            this.viewBranch.TabIndex = 13;
            this.viewBranch.Text = "View List";
            this.viewBranch.UseVisualStyleBackColor = true;
            this.viewBranch.Click += new System.EventHandler(this.viewBranch_Click);
            // 
            // labelBranches
            // 
            this.labelBranches.AutoSize = true;
            this.labelBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranches.Location = new System.Drawing.Point(279, 105);
            this.labelBranches.Name = "labelBranches";
            this.labelBranches.Size = new System.Drawing.Size(159, 22);
            this.labelBranches.TabIndex = 12;
            this.labelBranches.Text = "Branches Location";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 389);
            this.Controls.Add(this.DashboardView);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logCustomer;
        private System.Windows.Forms.Button viewAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button viewBranch;
        private System.Windows.Forms.Label labelBranches;
    }
}