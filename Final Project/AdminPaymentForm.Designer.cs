﻿namespace Final_Project
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
            this.dgvPaymentList = new System.Windows.Forms.DataGridView();
            this.tbPaymentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentList
            // 
            this.dgvPaymentList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentList.Location = new System.Drawing.Point(30, 32);
            this.dgvPaymentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPaymentList.Name = "dgvPaymentList";
            this.dgvPaymentList.RowHeadersWidth = 62;
            this.dgvPaymentList.RowTemplate.Height = 28;
            this.dgvPaymentList.Size = new System.Drawing.Size(499, 269);
            this.dgvPaymentList.TabIndex = 0;
            this.dgvPaymentList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentList_CellContentDoubleClick);
            // 
            // tbPaymentId
            // 
            this.tbPaymentId.Location = new System.Drawing.Point(750, 79);
            this.tbPaymentId.Name = "tbPaymentId";
            this.tbPaymentId.Size = new System.Drawing.Size(129, 26);
            this.tbPaymentId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payment ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(696, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(711, 360);
=======
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(906, 477);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPaymentId);
=======
            this.ClientSize = new System.Drawing.Size(711, 360);
>>>>>>> d1f25c33b922c1496b30a5fd341a8693a2347b67
>>>>>>> Stashed changes
            this.Controls.Add(this.dgvPaymentList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaymentList;
        private System.Windows.Forms.TextBox tbPaymentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}