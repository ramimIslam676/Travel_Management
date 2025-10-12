using Business.Layer.Repository;
using Data.Layer.Entity;
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
    public partial class AdminPaymentForm : Form
    {
        PaymentRepo paymentRepo;
        MySqlDataAccess dataAccess;
        int paymentId;
        int bookingId;
        public AdminPaymentForm()
        {
            InitializeComponent();
            paymentRepo = new PaymentRepo();
            dataAccess = new MySqlDataAccess();
            UpdateBookingGridView();
        }

        public void UpdateBookingGridView()
        {
            dgvAdminPayment.DataSource = paymentRepo.GetAllPayments();
        }

        private void dgvAdminPayment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAdminPayment.Rows[e.RowIndex];
                paymentId = Convert.ToInt32(row.Cells["payment_id"].Value);
                bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);
                tbPaymentId.Text = paymentId.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(paymentId == 0)
            {
                MessageBox.Show("Please select a payment to delete.");
                return;
            }
            else
            {
                var deletePaymentSql = $"DELETE FROM `payment` WHERE `payment`.`payment_id` = {paymentId}";
                int result = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(deletePaymentSql));
                if(result > 0)
                {
                    var updateBookingSql = $"UPDATE `booking` SET `status` = 'Pending' WHERE `booking`.`booking_id` = {bookingId}";
                    int result2 = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(updateBookingSql));
                    if(result2 > 0)
                    {
                        MessageBox.Show("Payment record deleted and booking status updated to Pending.");
                        paymentId = 0;
                        bookingId = 0;
                        tbPaymentId.Text = "";
                        UpdateBookingGridView();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update booking status.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to delete payment record.");
                    return;


                }
                
            }
        }
    }
}
