namespace EDP_WinProject1
{
    partial class frmLogin
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
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.ForgotPassword = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LoginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBox.BackColor = System.Drawing.SystemColors.Control;
            this.LoginBox.Controls.Add(this.btnExit);
            this.LoginBox.Controls.Add(this.ForgotPassword);
            this.LoginBox.Controls.Add(this.passwordInput);
            this.LoginBox.Controls.Add(this.usernameInput);
            this.LoginBox.Controls.Add(this.Password);
            this.LoginBox.Controls.Add(this.Username);
            this.LoginBox.Controls.Add(this.LoginButton);
            this.LoginBox.Location = new System.Drawing.Point(8, 6);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBox.Size = new System.Drawing.Size(357, 208);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Enter Your Credentials";
            this.LoginBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ForgotPassword.Location = new System.Drawing.Point(39, 123);
            this.ForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(92, 13);
            this.ForgotPassword.TabIndex = 5;
            this.ForgotPassword.Text = "Forgot Password?";
            this.ForgotPassword.Click += new System.EventHandler(this.ForgotPassword_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(41, 93);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(263, 20);
            this.passwordInput.TabIndex = 4;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(41, 52);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(263, 20);
            this.usernameInput.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(39, 78);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(39, 37);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(58, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(134, 153);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(84, 24);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 224);
            this.Controls.Add(this.LoginBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label ForgotPassword;
        private System.Windows.Forms.Button btnExit;
    }
}

