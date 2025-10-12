namespace Final_Project
{
    partial class AdminForm
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
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnTrips = new System.Windows.Forms.Button();
            this.btnShowBookings = new System.Windows.Forms.Button();
            this.btnShowPayment = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUserInfo.Location = new System.Drawing.Point(15, 29);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(162, 30);
            this.btnUserInfo.TabIndex = 0;
            this.btnUserInfo.Text = "Show Users";
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnTrips
            // 
            this.btnTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTrips.Location = new System.Drawing.Point(15, 114);
            this.btnTrips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrips.Name = "btnTrips";
            this.btnTrips.Size = new System.Drawing.Size(162, 30);
            this.btnTrips.TabIndex = 1;
            this.btnTrips.Text = "Show Trips";
            this.btnTrips.UseVisualStyleBackColor = false;
            this.btnTrips.Click += new System.EventHandler(this.btnTrips_Click);
            // 
            // btnShowBookings
            // 
            this.btnShowBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowBookings.Location = new System.Drawing.Point(15, 159);
            this.btnShowBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowBookings.Name = "btnShowBookings";
            this.btnShowBookings.Size = new System.Drawing.Size(162, 32);
            this.btnShowBookings.TabIndex = 2;
            this.btnShowBookings.Text = "Show Bookings";
            this.btnShowBookings.UseVisualStyleBackColor = false;
            this.btnShowBookings.Click += new System.EventHandler(this.btnShowBookings_Click);
            // 
            // btnShowPayment
            // 
            this.btnShowPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowPayment.Location = new System.Drawing.Point(15, 207);
            this.btnShowPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPayment.Name = "btnShowPayment";
            this.btnShowPayment.Size = new System.Drawing.Size(162, 30);
            this.btnShowPayment.TabIndex = 3;
            this.btnShowPayment.Text = "Show Payments";
            this.btnShowPayment.UseVisualStyleBackColor = false;
            this.btnShowPayment.Click += new System.EventHandler(this.btnShowPayment_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddAdmin.Location = new System.Drawing.Point(15, 70);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(162, 29);
            this.btnAddAdmin.TabIndex = 4;
            this.btnAddAdmin.Text = "Add Admins";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(323, 27);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(120, 71);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "label";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(59, 319);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 30);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUserInfo);
            this.groupBox1.Controls.Add(this.btnAddAdmin);
            this.groupBox1.Controls.Add(this.btnTrips);
            this.groupBox1.Controls.Add(this.btnShowPayment);
            this.groupBox1.Controls.Add(this.btnShowBookings);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(204, 266);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(731, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnTrips;
        private System.Windows.Forms.Button btnShowBookings;
        private System.Windows.Forms.Button btnShowPayment;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}