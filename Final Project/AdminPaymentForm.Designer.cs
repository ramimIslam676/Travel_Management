namespace Final_Project
{
    partial class AdminPaymentForm
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
            this.dgvPaymentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentList
            // 
            this.dgvPaymentList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentList.Location = new System.Drawing.Point(30, 32);
            this.dgvPaymentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPaymentList.Name = "dgvPaymentList";
            this.dgvPaymentList.RowHeadersWidth = 62;
            this.dgvPaymentList.RowTemplate.Height = 28;
            this.dgvPaymentList.Size = new System.Drawing.Size(499, 269);
            this.dgvPaymentList.TabIndex = 0;
            // 
            // AdminPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.dgvPaymentList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaymentList;
    }
}