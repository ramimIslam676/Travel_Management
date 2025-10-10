namespace Final_Project
{
    partial class CreateTripForm
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
            this.components = new System.ComponentModel.Container();
            this.lbTripName = new System.Windows.Forms.Label();
            this.txtTripName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbDestination = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.lbavailable = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.numAvailable = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTripName
            // 
            this.lbTripName.AutoSize = true;
            this.lbTripName.Location = new System.Drawing.Point(12, 54);
            this.lbTripName.Name = "lbTripName";
            this.lbTripName.Size = new System.Drawing.Size(71, 16);
            this.lbTripName.TabIndex = 0;
            this.lbTripName.Text = "Trip Name";
            // 
            // txtTripName
            // 
            this.txtTripName.Location = new System.Drawing.Point(125, 48);
            this.txtTripName.Name = "txtTripName";
            this.txtTripName.Size = new System.Drawing.Size(293, 22);
            this.txtTripName.TabIndex = 0;
            this.txtTripName.TextChanged += new System.EventHandler(this.txtTripName_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Location = new System.Drawing.Point(12, 89);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(74, 16);
            this.lbDestination.TabIndex = 3;
            this.lbDestination.Text = "Destination";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(12, 130);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(66, 16);
            this.lbStart.TabIndex = 4;
            this.lbStart.Text = "Start Date";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(12, 178);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(63, 16);
            this.lbEnd.TabIndex = 5;
            this.lbEnd.Text = "End Date";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(125, 83);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(293, 22);
            this.txtDestination.TabIndex = 1;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Location = new System.Drawing.Point(7, 226);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(76, 16);
            this.lbtotal.TabIndex = 9;
            this.lbtotal.Text = "Total Seats";
            // 
            // lbavailable
            // 
            this.lbavailable.AutoSize = true;
            this.lbavailable.Location = new System.Drawing.Point(7, 268);
            this.lbavailable.Name = "lbavailable";
            this.lbavailable.Size = new System.Drawing.Size(102, 16);
            this.lbavailable.TabIndex = 10;
            this.lbavailable.Text = "Available Seats";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(12, 312);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(38, 16);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Price";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(480, 48);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(75, 16);
            this.lbDescription.TabIndex = 12;
            this.lbDescription.Text = "Description";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(125, 124);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(293, 22);
            this.dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(125, 172);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(293, 22);
            this.dtpEnd.TabIndex = 3;
            // 
            // numTotal
            // 
            this.numTotal.Location = new System.Drawing.Point(125, 220);
            this.numTotal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTotal.Name = "numTotal";
            this.numTotal.Size = new System.Drawing.Size(293, 22);
            this.numTotal.TabIndex = 4;
            this.numTotal.ValueChanged += new System.EventHandler(this.numTotal_ValueChanged);
            // 
            // numAvailable
            // 
            this.numAvailable.Location = new System.Drawing.Point(125, 262);
            this.numAvailable.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAvailable.Name = "numAvailable";
            this.numAvailable.Size = new System.Drawing.Size(293, 22);
            this.numAvailable.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(125, 306);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(293, 22);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(483, 83);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(283, 111);
            this.txtDescription.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(516, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(662, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.numAvailable);
            this.Controls.Add(this.numTotal);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbavailable);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.lbDestination);
            this.Controls.Add(this.txtTripName);
            this.Controls.Add(this.lbTripName);
            this.Name = "CreateTripForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTripForm";
            this.Load += new System.EventHandler(this.CreateTripForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTripName;
        private System.Windows.Forms.TextBox txtTripName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label lbavailable;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.NumericUpDown numAvailable;
        private System.Windows.Forms.TextBox txtPrice;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}