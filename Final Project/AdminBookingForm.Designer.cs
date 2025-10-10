namespace Final_Project
{
    partial class AdminBookingForm
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
            this.dgvBookingList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookingList
            // 
            this.dgvBookingList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBookingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingList.Location = new System.Drawing.Point(30, 21);
            this.dgvBookingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBookingList.Name = "dgvBookingList";
            this.dgvBookingList.RowHeadersWidth = 62;
            this.dgvBookingList.RowTemplate.Height = 28;
            this.dgvBookingList.Size = new System.Drawing.Size(447, 265);
            this.dgvBookingList.TabIndex = 0;
            // 
            // AdminBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 386);
            this.Controls.Add(this.dgvBookingList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookingList;
    }
}