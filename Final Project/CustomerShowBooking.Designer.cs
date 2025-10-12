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
            this.dgvShowBooking.Location = new System.Drawing.Point(34, 26);
            this.dgvShowBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowBooking.Name = "dgvShowBooking";
            this.dgvShowBooking.RowHeadersWidth = 62;
            this.dgvShowBooking.RowTemplate.Height = 28;
            this.dgvShowBooking.Size = new System.Drawing.Size(407, 223);
            this.dgvShowBooking.TabIndex = 0;
            this.dgvShowBooking.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowBooking_CellContentDoubleClick);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(542, 145);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 38);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Slip";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbBookingId
            // 
            this.tbBookingId.Location = new System.Drawing.Point(576, 66);
            this.tbBookingId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBookingId.Name = "tbBookingId";
            this.tbBookingId.Size = new System.Drawing.Size(89, 22);
            this.tbBookingId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Booking ID";
            // 
            // CustomerShowBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBookingId);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvShowBooking);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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