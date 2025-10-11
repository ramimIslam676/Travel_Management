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
        MySqlDataAccess dataAccess = new MySqlDataAccess();
        int paymentId;
        int bookingId;
        public AdminPaymentForm()
        {
            InitializeComponent();
            paymentRepo = new PaymentRepo();
            dataAccess = new MySqlDataAccess();
            tbPaymentId.ReadOnly = true;
            UpdatePaymentGridView();
        }

        public void UpdatePaymentGridView()
        {
            dgvPaymentList.DataSource = paymentRepo.GetAllPayments();
        }

        private void dgvPaymentList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPaymentList.Rows[e.RowIndex];
                paymentId = Convert.ToInt32(selectedRow.Cells["payment_id"].Value);
                bookingId = Convert.ToInt32(selectedRow.Cells["booking_id"].Value);
                tbPaymentId.Text = selectedRow.Cells["payment_id"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (paymentId == 0)
            {
                MessageBox.Show("Please select a payment to delete.");
                return;
            }
            else
            {
                var sql = $"UPDATE `booking` SET `status` = 'Pending' WHERE `booking`.`booking_id` = {bookingId}";
                int result1 = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(sql));
                if (result1 > 0)
                {
                    var sql2 = $"DELETE FROM `payment` WHERE `payment`.`payment_id` = {paymentId}";
                    int result = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(sql2));
                    if (result > 0)
                    {
                        MessageBox.Show("Payment has been deleted.");
                        paymentId = 0;
                        tbPaymentId.Text = "";
                        UpdatePaymentGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete payment.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to update associated booking status.");
                    return;
                }

                
            }
        }
    }
}
