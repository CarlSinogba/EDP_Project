namespace EDP_WinProject1
{
    partial class frmEmployee
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
            this.DGemployee = new System.Windows.Forms.DataGridView();
            this.modifyEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGemployee)).BeginInit();
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
            this.labelReturn.TabIndex = 3;
            this.labelReturn.Text = "Return to Dahsboard";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // DGemployee
            // 
            this.DGemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGemployee.Location = new System.Drawing.Point(13, 49);
            this.DGemployee.Name = "DGemployee";
            this.DGemployee.Size = new System.Drawing.Size(575, 305);
            this.DGemployee.TabIndex = 4;
            // 
            // modifyEmployees
            // 
            this.modifyEmployees.Location = new System.Drawing.Point(487, 21);
            this.modifyEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.modifyEmployees.Name = "modifyEmployees";
            this.modifyEmployees.Size = new System.Drawing.Size(101, 23);
            this.modifyEmployees.TabIndex = 18;
            this.modifyEmployees.Text = "Modify Employees";
            this.modifyEmployees.UseVisualStyleBackColor = true;
            this.modifyEmployees.Click += new System.EventHandler(this.modifyEmployees_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.modifyEmployees);
            this.Controls.Add(this.DGemployee);
            this.Controls.Add(this.labelReturn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGemployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.DataGridView DGemployee;
        private System.Windows.Forms.Button modifyEmployees;
    }
}