namespace EDP_WinProject1
{
    partial class frmAmount
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
            this.DGamount = new System.Windows.Forms.DataGridView();
            this.DGtotal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGtotal)).BeginInit();
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
            // DGamount
            // 
            this.DGamount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGamount.Location = new System.Drawing.Point(12, 44);
            this.DGamount.Name = "DGamount";
            this.DGamount.Size = new System.Drawing.Size(368, 310);
            this.DGamount.TabIndex = 4;
            // 
            // DGtotal
            // 
            this.DGtotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGtotal.Location = new System.Drawing.Point(386, 44);
            this.DGtotal.Name = "DGtotal";
            this.DGtotal.Size = new System.Drawing.Size(202, 84);
            this.DGtotal.TabIndex = 5;
            // 
            // frmAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DGtotal);
            this.Controls.Add(this.DGamount);
            this.Controls.Add(this.labelReturn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amount List";
            this.Load += new System.EventHandler(this.frmAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGtotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.DataGridView DGamount;
        private System.Windows.Forms.DataGridView DGtotal;
    }
}