namespace EDP_WinProject1
{
    partial class frmModifyEmployee
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
            this.labelEmployee = new System.Windows.Forms.Label();
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.labelReturn = new System.Windows.Forms.Label();
            this.txtBranchID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDeleteUser = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtDeleteSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.txtEmailUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateUserProfile = new System.Windows.Forms.Button();
            this.txtUsernameUpdate = new System.Windows.Forms.TextBox();
            this.tabControlUser.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.tabDeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEmployee.Location = new System.Drawing.Point(11, 9);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(133, 17);
            this.labelEmployee.TabIndex = 8;
            this.labelEmployee.Text = "Return to Employee";
            this.labelEmployee.Click += new System.EventHandler(this.labelEmployee_Click);
            // 
            // tabControlUser
            // 
            this.tabControlUser.Controls.Add(this.tabAddUser);
            this.tabControlUser.Controls.Add(this.tabDeleteUser);
            this.tabControlUser.Location = new System.Drawing.Point(12, 39);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(442, 261);
            this.tabControlUser.TabIndex = 7;
            // 
            // tabAddUser
            // 
            this.tabAddUser.BackColor = System.Drawing.Color.Silver;
            this.tabAddUser.Controls.Add(this.labelReturn);
            this.tabAddUser.Controls.Add(this.txtBranchID);
            this.tabAddUser.Controls.Add(this.label3);
            this.tabAddUser.Controls.Add(this.btnAddUser);
            this.tabAddUser.Controls.Add(this.txtLastName);
            this.tabAddUser.Controls.Add(this.label2);
            this.tabAddUser.Controls.Add(this.txtFirstName);
            this.tabAddUser.Controls.Add(this.label1);
            this.tabAddUser.Location = new System.Drawing.Point(4, 22);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(434, 235);
            this.tabAddUser.TabIndex = 0;
            this.tabAddUser.Text = "Add User";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelReturn.Location = new System.Drawing.Point(21, 3);
            this.labelReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(0, 17);
            this.labelReturn.TabIndex = 7;
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(133, 118);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(232, 20);
            this.txtBranchID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Branch ID:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(98, 187);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(207, 42);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Save Account";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(133, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(232, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(133, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(232, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // tabDeleteUser
            // 
            this.tabDeleteUser.BackColor = System.Drawing.Color.Gray;
            this.tabDeleteUser.Controls.Add(this.btnDeleteUser);
            this.tabDeleteUser.Controls.Add(this.txtDeleteSearch);
            this.tabDeleteUser.Controls.Add(this.label5);
            this.tabDeleteUser.Location = new System.Drawing.Point(4, 22);
            this.tabDeleteUser.Name = "tabDeleteUser";
            this.tabDeleteUser.Size = new System.Drawing.Size(434, 235);
            this.tabDeleteUser.TabIndex = 2;
            this.tabDeleteUser.Text = "Delete User";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(96, 172);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(242, 60);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete Account";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtDeleteSearch
            // 
            this.txtDeleteSearch.Location = new System.Drawing.Point(206, 27);
            this.txtDeleteSearch.Name = "txtDeleteSearch";
            this.txtDeleteSearch.Size = new System.Drawing.Size(183, 20);
            this.txtDeleteSearch.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search by Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Location = new System.Drawing.Point(117, 60);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(237, 20);
            this.txtPasswordUpdate.TabIndex = 15;
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Location = new System.Drawing.Point(117, 97);
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(237, 20);
            this.txtEmailUpdate.TabIndex = 16;
            // 
            // btnUpdateUserProfile
            // 
            this.btnUpdateUserProfile.Location = new System.Drawing.Point(62, 131);
            this.btnUpdateUserProfile.Name = "btnUpdateUserProfile";
            this.btnUpdateUserProfile.Size = new System.Drawing.Size(234, 43);
            this.btnUpdateUserProfile.TabIndex = 17;
            this.btnUpdateUserProfile.Text = "Update Account Profile";
            this.btnUpdateUserProfile.UseVisualStyleBackColor = true;
            // 
            // txtUsernameUpdate
            // 
            this.txtUsernameUpdate.Enabled = false;
            this.txtUsernameUpdate.Location = new System.Drawing.Point(119, 13);
            this.txtUsernameUpdate.Name = "txtUsernameUpdate";
            this.txtUsernameUpdate.Size = new System.Drawing.Size(235, 20);
            this.txtUsernameUpdate.TabIndex = 18;
            // 
            // frmModifyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 312);
            this.ControlBox = false;
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.tabControlUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifyEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifyEmployee";
            this.tabControlUser.ResumeLayout(false);
            this.tabAddUser.ResumeLayout(false);
            this.tabAddUser.PerformLayout();
            this.tabDeleteUser.ResumeLayout(false);
            this.tabDeleteUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.TextBox txtBranchID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtDeleteSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.TextBox txtEmailUpdate;
        private System.Windows.Forms.Button btnUpdateUserProfile;
        private System.Windows.Forms.TextBox txtUsernameUpdate;
    }
}