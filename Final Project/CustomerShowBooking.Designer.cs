namespace Final_Project
{
    partial class CustomerShowBooking
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
            this.dgvShowBooking = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbBookingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowBooking
            // 
            this.dgvShowBooking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvShowBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBooking.Location = new System.Drawing.Point(38, 33);
            this.dgvShowBooking.Name = "dgvShowBooking";
            this.dgvShowBooking.RowHeadersWidth = 62;
            this.dgvShowBooking.RowTemplate.Height = 28;
            this.dgvShowBooking.Size = new System.Drawing.Size(458, 279);
            this.dgvShowBooking.TabIndex = 0;
            this.dgvShowBooking.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowBooking_CellContentDoubleClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(597, 227);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 29);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Slip";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbBookingId
            // 
            this.tbBookingId.Location = new System.Drawing.Point(648, 82);
            this.tbBookingId.Name = "tbBookingId";
            this.tbBookingId.Size = new System.Drawing.Size(100, 26);
            this.tbBookingId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Booking ID";
            // 
            // CustomerShowBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBookingId);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvShowBooking);
            this.Name = "CustomerShowBooking";
            this.Text = "CustomerShowBooking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowBooking;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox tbBookingId;
        private System.Windows.Forms.Label label1;
    }
}