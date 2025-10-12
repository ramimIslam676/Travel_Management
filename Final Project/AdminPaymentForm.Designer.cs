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
            this.dgvAdminPayment = new System.Windows.Forms.DataGridView();
            this.tbPaymentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminPayment
            // 
            this.dgvAdminPayment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAdminPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminPayment.Location = new System.Drawing.Point(11, 10);
            this.dgvAdminPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdminPayment.Name = "dgvAdminPayment";
            this.dgvAdminPayment.RowHeadersWidth = 62;
            this.dgvAdminPayment.RowTemplate.Height = 28;
            this.dgvAdminPayment.Size = new System.Drawing.Size(384, 226);
            this.dgvAdminPayment.TabIndex = 0;
            this.dgvAdminPayment.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminPayment_CellContentDoubleClick);
            // 
            // tbPaymentId
            // 
            this.tbPaymentId.Location = new System.Drawing.Point(582, 39);
            this.tbPaymentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPaymentId.Name = "tbPaymentId";
            this.tbPaymentId.Size = new System.Drawing.Size(89, 22);
            this.tbPaymentId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payment ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(508, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPaymentId);
            this.Controls.Add(this.dgvAdminPayment);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPaymentForm";
            this.Text = "AdminPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminPayment;
        private System.Windows.Forms.TextBox tbPaymentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}