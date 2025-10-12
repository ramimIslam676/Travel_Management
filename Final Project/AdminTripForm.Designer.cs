namespace Final_Project
{
    partial class AdminTripForm
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
            this.dgvTripList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateTrip = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.nudTotalSeats = new System.Windows.Forms.NumericUpDown();
            this.nudAvailableSeats = new System.Windows.Forms.NumericUpDown();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbTripName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTripList
            // 
            this.dgvTripList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTripList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTripList.Location = new System.Drawing.Point(21, 18);
            this.dgvTripList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTripList.Name = "dgvTripList";
            this.dgvTripList.RowHeadersWidth = 62;
            this.dgvTripList.RowTemplate.Height = 28;
            this.dgvTripList.Size = new System.Drawing.Size(544, 326);
            this.dgvTripList.TabIndex = 0;
            this.dgvTripList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTripList_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateTrip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.nudTotalSeats);
            this.groupBox1.Controls.Add(this.nudAvailableSeats);
            this.groupBox1.Controls.Add(this.tbDestination);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbTripName);
            this.groupBox1.Location = new System.Drawing.Point(585, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(420, 445);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Update";
            // 
            // btnUpdateTrip
            // 
            this.btnUpdateTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTrip.Location = new System.Drawing.Point(175, 400);
            this.btnUpdateTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTrip.Name = "btnUpdateTrip";
            this.btnUpdateTrip.Size = new System.Drawing.Size(180, 28);
            this.btnUpdateTrip.TabIndex = 16;
            this.btnUpdateTrip.Text = "Update Trip";
            this.btnUpdateTrip.UseVisualStyleBackColor = false;
            this.btnUpdateTrip.Click += new System.EventHandler(this.btnUpdateTrip_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Available Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trip Name";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(152, 171);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(239, 22);
            this.dtpEnd.TabIndex = 7;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(152, 130);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(239, 22);
            this.dtpStart.TabIndex = 6;
            // 
            // nudTotalSeats
            // 
            this.nudTotalSeats.Location = new System.Drawing.Point(152, 212);
            this.nudTotalSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTotalSeats.Name = "nudTotalSeats";
            this.nudTotalSeats.Size = new System.Drawing.Size(238, 22);
            this.nudTotalSeats.TabIndex = 5;
            // 
            // nudAvailableSeats
            // 
            this.nudAvailableSeats.Location = new System.Drawing.Point(152, 249);
            this.nudAvailableSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAvailableSeats.Name = "nudAvailableSeats";
            this.nudAvailableSeats.Size = new System.Drawing.Size(238, 22);
            this.nudAvailableSeats.TabIndex = 4;
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(152, 79);
            this.tbDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(239, 22);
            this.tbDestination.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(152, 318);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(239, 64);
            this.tbDescription.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(152, 282);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(239, 22);
            this.tbPrice.TabIndex = 1;
            // 
            // tbTripName
            // 
            this.tbTripName.Location = new System.Drawing.Point(152, 34);
            this.tbTripName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTripName.Name = "tbTripName";
            this.tbTripName.Size = new System.Drawing.Size(239, 22);
            this.tbTripName.TabIndex = 0;
            // 
            // AdminTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1015, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTripList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminTripForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTripForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTripList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTripName;
        private System.Windows.Forms.NumericUpDown nudTotalSeats;
        private System.Windows.Forms.NumericUpDown nudAvailableSeats;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateTrip;
    }
}