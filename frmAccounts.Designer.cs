namespace EDP_WinProject1
{
    partial class frmAccounts
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
            this.labelReturn = new System.Windows.Forms.Label();
            this.modifyAccounts = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.DGusers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGusers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelReturn.Location = new System.Drawing.Point(24, 23);
            this.labelReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(141, 17);
            this.labelReturn.TabIndex = 5;
            this.labelReturn.Text = "Return to Dahsboard";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // modifyAccounts
            // 
            this.modifyAccounts.Location = new System.Drawing.Point(488, 21);
            this.modifyAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.modifyAccounts.Name = "modifyAccounts";
            this.modifyAccounts.Size = new System.Drawing.Size(101, 23);
            this.modifyAccounts.TabIndex = 17;
            this.modifyAccounts.Text = "Modify Accounts";
            this.modifyAccounts.UseVisualStyleBackColor = true;
            this.modifyAccounts.Click += new System.EventHandler(this.modifyAccounts_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(383, 21);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 23);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DGusers
            // 
            this.DGusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGusers.Location = new System.Drawing.Point(12, 49);
            this.DGusers.Name = "DGusers";
            this.DGusers.Size = new System.Drawing.Size(576, 305);
            this.DGusers.TabIndex = 0;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DGusers);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.modifyAccounts);
            this.Controls.Add(this.labelReturn);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Accounts";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Button modifyAccounts;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView DGusers;
    }
}