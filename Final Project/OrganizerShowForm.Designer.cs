namespace Final_Project
{
    partial class OrganizerShowForm
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
            this.dgvOrganizerShowForm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizerShowForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizerShowForm
            // 
            this.dgvOrganizerShowForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizerShowForm.Location = new System.Drawing.Point(12, 32);
            this.dgvOrganizerShowForm.Name = "dgvOrganizerShowForm";
            this.dgvOrganizerShowForm.RowHeadersWidth = 51;
            this.dgvOrganizerShowForm.RowTemplate.Height = 24;
            this.dgvOrganizerShowForm.Size = new System.Drawing.Size(755, 347);
            this.dgvOrganizerShowForm.TabIndex = 0;
            // 
            // OrganizerShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOrganizerShowForm);
            this.Name = "OrganizerShowForm";
            this.Text = "OrganizerShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizerShowForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizerShowForm;
    }
}