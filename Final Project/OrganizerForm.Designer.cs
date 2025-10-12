namespace Final_Project
{
    partial class OrganizerForm
    {
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnShowBooking = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.btnShowBooking);
            this.panelCard.Controls.Add(this.btnDelete);
            this.panelCard.Controls.Add(this.btnEdit);
            this.panelCard.Controls.Add(this.btnCreate);
            this.panelCard.Controls.Add(this.dgvTrips);
            this.panelCard.Controls.Add(this.lnkLogout);
            this.panelCard.Controls.Add(this.lbTitle);
            this.panelCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCard.Location = new System.Drawing.Point(42, 28);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(24);
            this.panelCard.Size = new System.Drawing.Size(834, 473);
            this.panelCard.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(629, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Trip";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(241, 378);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(176, 46);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Trip";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(21, 378);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(185, 46);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Trip";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvTrips
            // 
            this.dgvTrips.AllowUserToAddRows = false;
            this.dgvTrips.AllowUserToDeleteRows = false;
            this.dgvTrips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrips.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Location = new System.Drawing.Point(22, 83);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersVisible = false;
            this.dgvTrips.RowHeadersWidth = 51;
            this.dgvTrips.RowTemplate.Height = 24;
            this.dgvTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrips.Size = new System.Drawing.Size(784, 280);
            this.dgvTrips.TabIndex = 2;
            this.dgvTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrips_CellContentClick);
            // 
            // lnkLogout
            // 
            this.lnkLogout.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lnkLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.BackColor = System.Drawing.Color.Red;
            this.lnkLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkLogout.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lnkLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogout.LinkColor = System.Drawing.Color.Black;
            this.lnkLogout.Location = new System.Drawing.Point(730, 33);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(61, 22);
            this.lnkLogout.TabIndex = 4;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkLogout.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(13, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(349, 45);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Organizer Dashboard";
            // 
            // btnShowBooking
            // 
            this.btnShowBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowBooking.Location = new System.Drawing.Point(454, 380);
            this.btnShowBooking.Name = "btnShowBooking";
            this.btnShowBooking.Size = new System.Drawing.Size(147, 44);
            this.btnShowBooking.TabIndex = 5;
            this.btnShowBooking.Text = "Show Booking";
            this.btnShowBooking.UseVisualStyleBackColor = false;
            this.btnShowBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrganizerForm
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(902, 513);
            this.Controls.Add(this.panelCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OrganizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowBooking;
    }
}
