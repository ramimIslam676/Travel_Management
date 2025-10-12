namespace Final_Project
{
    partial class CustomerForm
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.pnlDgvShowTrip = new System.Windows.Forms.Panel();
            this.dgvShowTrip = new System.Windows.Forms.DataGridView();
            this.txtSearchByDesnination = new System.Windows.Forms.TextBox();
            this.lblSearchByDestination = new System.Windows.Forms.Label();
            this.btnSearchByDestination = new System.Windows.Forms.Button();
            this.dtSearchByDate = new System.Windows.Forms.DateTimePicker();
            this.lblSearchByDate = new System.Windows.Forms.Label();
            this.lblSelectSeat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowBooking = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBookTrip = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.UpDownSelectNumberOfSeat = new System.Windows.Forms.NumericUpDown();
            this.pnlDgvShowTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTrip)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSelectNumberOfSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // pnlDgvShowTrip
            // 
            this.pnlDgvShowTrip.Controls.Add(this.dgvShowTrip);
            this.pnlDgvShowTrip.Location = new System.Drawing.Point(352, 69);
            this.pnlDgvShowTrip.Name = "pnlDgvShowTrip";
            this.pnlDgvShowTrip.Size = new System.Drawing.Size(769, 341);
            this.pnlDgvShowTrip.TabIndex = 0;
            // 
            // dgvShowTrip
            // 
            this.dgvShowTrip.AllowUserToAddRows = false;
            this.dgvShowTrip.AllowUserToDeleteRows = false;
            this.dgvShowTrip.AllowUserToResizeColumns = false;
            this.dgvShowTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowTrip.Location = new System.Drawing.Point(0, 0);
            this.dgvShowTrip.Name = "dgvShowTrip";
            this.dgvShowTrip.ReadOnly = true;
            this.dgvShowTrip.RowHeadersWidth = 51;
            this.dgvShowTrip.RowTemplate.Height = 24;
            this.dgvShowTrip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowTrip.Size = new System.Drawing.Size(769, 341);
            this.dgvShowTrip.TabIndex = 0;
            // 
            // txtSearchByDesnination
            // 
            this.txtSearchByDesnination.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByDesnination.Location = new System.Drawing.Point(527, 33);
            this.txtSearchByDesnination.Name = "txtSearchByDesnination";
            this.txtSearchByDesnination.Size = new System.Drawing.Size(158, 30);
            this.txtSearchByDesnination.TabIndex = 1;
            // 
            // lblSearchByDestination
            // 
            this.lblSearchByDestination.AutoSize = true;
            this.lblSearchByDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSearchByDestination.Location = new System.Drawing.Point(524, 14);
            this.lblSearchByDestination.Name = "lblSearchByDestination";
            this.lblSearchByDestination.Size = new System.Drawing.Size(143, 16);
            this.lblSearchByDestination.TabIndex = 2;
            this.lblSearchByDestination.Text = "Search By Desnination";
            // 
            // btnSearchByDestination
            // 
            this.btnSearchByDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDestination.ForeColor = System.Drawing.Color.Red;
            this.btnSearchByDestination.Location = new System.Drawing.Point(691, 33);
            this.btnSearchByDestination.Name = "btnSearchByDestination";
            this.btnSearchByDestination.Size = new System.Drawing.Size(106, 30);
            this.btnSearchByDestination.TabIndex = 3;
            this.btnSearchByDestination.Text = "Search";
            this.btnSearchByDestination.UseVisualStyleBackColor = true;
            this.btnSearchByDestination.Click += new System.EventHandler(this.btnSearchByDestination_Click);
            // 
            // dtSearchByDate
            // 
            this.dtSearchByDate.Location = new System.Drawing.Point(909, 38);
            this.dtSearchByDate.Name = "dtSearchByDate";
            this.dtSearchByDate.Size = new System.Drawing.Size(200, 22);
            this.dtSearchByDate.TabIndex = 4;
            this.dtSearchByDate.ValueChanged += new System.EventHandler(this.dtSearchByDate_ValueChanged);
            // 
            // lblSearchByDate
            // 
            this.lblSearchByDate.AutoSize = true;
            this.lblSearchByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSearchByDate.Location = new System.Drawing.Point(906, 19);
            this.lblSearchByDate.Name = "lblSearchByDate";
            this.lblSearchByDate.Size = new System.Drawing.Size(101, 16);
            this.lblSearchByDate.TabIndex = 5;
            this.lblSearchByDate.Text = "Search By Date";
            // 
            // lblSelectSeat
            // 
            this.lblSelectSeat.AutoSize = true;
            this.lblSelectSeat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSeat.Location = new System.Drawing.Point(20, 100);
            this.lblSelectSeat.Name = "lblSelectSeat";
            this.lblSelectSeat.Size = new System.Drawing.Size(135, 25);
            this.lblSelectSeat.TabIndex = 6;
            this.lblSelectSeat.Text = "Select Seat: ";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnShowBooking);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnBookTrip);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.UpDownSelectNumberOfSeat);
            this.panel1.Controls.Add(this.lblSelectSeat);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 418);
            this.panel1.TabIndex = 6;
            // 
            // btnShowBooking
            // 
            this.btnShowBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBooking.Location = new System.Drawing.Point(190, 283);
            this.btnShowBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowBooking.Name = "btnShowBooking";
            this.btnShowBooking.Size = new System.Drawing.Size(116, 42);
            this.btnShowBooking.TabIndex = 13;
            this.btnShowBooking.Text = "Show Booking";
            this.btnShowBooking.UseVisualStyleBackColor = false;
            this.btnShowBooking.Click += new System.EventHandler(this.btnShowBooking_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(99, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 39);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(21, 15);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(130, 36);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBookTrip
            // 
            this.btnBookTrip.AutoSize = true;
            this.btnBookTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBookTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTrip.ForeColor = System.Drawing.Color.Black;
            this.btnBookTrip.Location = new System.Drawing.Point(21, 286);
            this.btnBookTrip.Name = "btnBookTrip";
            this.btnBookTrip.Size = new System.Drawing.Size(130, 39);
            this.btnBookTrip.TabIndex = 10;
            this.btnBookTrip.Text = "Book Trip";
            this.btnBookTrip.UseVisualStyleBackColor = false;
            this.btnBookTrip.Click += new System.EventHandler(this.btnBookTrip_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(157, 185);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(120, 30);
            this.txtAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(20, 185);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(131, 25);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount     :";
            // 
            // UpDownSelectNumberOfSeat
            // 
            this.UpDownSelectNumberOfSeat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDownSelectNumberOfSeat.Location = new System.Drawing.Point(161, 101);
            this.UpDownSelectNumberOfSeat.Name = "UpDownSelectNumberOfSeat";
            this.UpDownSelectNumberOfSeat.Size = new System.Drawing.Size(120, 30);
            this.UpDownSelectNumberOfSeat.TabIndex = 7;
            this.UpDownSelectNumberOfSeat.ValueChanged += new System.EventHandler(this.UpDownSelectNumberOfSeat_ValueChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1130, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearchByDate);
            this.Controls.Add(this.dtSearchByDate);
            this.Controls.Add(this.btnSearchByDestination);
            this.Controls.Add(this.lblSearchByDestination);
            this.Controls.Add(this.txtSearchByDesnination);
            this.Controls.Add(this.pnlDgvShowTrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.pnlDgvShowTrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTrip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSelectNumberOfSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Panel pnlDgvShowTrip;
        private System.Windows.Forms.DataGridView dgvShowTrip;
        private System.Windows.Forms.TextBox txtSearchByDesnination;
        private System.Windows.Forms.Label lblSearchByDestination;
        private System.Windows.Forms.Button btnSearchByDestination;
        private System.Windows.Forms.DateTimePicker dtSearchByDate;
        private System.Windows.Forms.Label lblSearchByDate;
        private System.Windows.Forms.Label lblSelectSeat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown UpDownSelectNumberOfSeat;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBookTrip;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowBooking;
    }
}