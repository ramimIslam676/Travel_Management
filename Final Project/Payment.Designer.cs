namespace Final_Project
{
    partial class Payment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.txtAmmount = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPayment
            // 
            this.pnlPayment.AutoSize = true;
            this.pnlPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPayment.Controls.Add(this.btnCancel);
            this.pnlPayment.Controls.Add(this.btnConfirm);
            this.pnlPayment.Controls.Add(this.cmbMethod);
            this.pnlPayment.Controls.Add(this.txtAmmount);
            this.pnlPayment.Controls.Add(this.lblMethod);
            this.pnlPayment.Controls.Add(this.lblAmount);
            this.pnlPayment.Location = new System.Drawing.Point(14, 15);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(584, 319);
            this.pnlPayment.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnCancel.Location = new System.Drawing.Point(382, 230);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 54);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnConfirm.Location = new System.Drawing.Point(89, 230);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 54);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Cash",
            "Bkash",
            "Nagad",
            "Credit Card"});
            this.cmbMethod.Location = new System.Drawing.Point(250, 144);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(216, 28);
            this.cmbMethod.TabIndex = 3;
            // 
            // txtAmmount
            // 
            this.txtAmmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtAmmount.Location = new System.Drawing.Point(250, 74);
            this.txtAmmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmmount.Name = "txtAmmount";
            this.txtAmmount.ReadOnly = true;
            this.txtAmmount.Size = new System.Drawing.Size(216, 35);
            this.txtAmmount.TabIndex = 2;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblMethod.Location = new System.Drawing.Point(84, 144);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(144, 32);
            this.lblMethod.TabIndex = 1;
            this.lblMethod.Text = "Method   : ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(84, 74);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(148, 32);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount   : ";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 436);
            this.Controls.Add(this.pnlPayment);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.TextBox txtAmmount;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}
