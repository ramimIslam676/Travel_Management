using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Payment : Form
    {
        private decimal amount;
        private CustomerForm callerForm;
        private int tripId;
        private int seatsBooked;

        public Payment(decimal amount, CustomerForm callerForm, int tripId, int seatsBooked)
        {
            InitializeComponent();
            this.amount = amount;
            this.callerForm = callerForm;
            this.tripId = tripId;
            this.seatsBooked = seatsBooked;

            txtAmmount.Text = amount.ToString("F2");
            cmbMethod.SelectedIndex = 0; // default selection


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a payment method.", "Payment Method Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMethod = cmbMethod.SelectedItem.ToString();

            // Pass selected payment method to CustomerForm's CompleteBooking
            callerForm.CompleteBookingWithMethod(tripId, seatsBooked, amount, selectedMethod);

            callerForm.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            callerForm.Show();
            this.Close();
        }
    }
}
