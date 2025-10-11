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
    public partial class AdminBookingForm : Form
    {
        BookingRepo bookingRepo;
        MySqlDataAccess dataAccess;
        int bookingId;
        string status;

        public AdminBookingForm()
        {
            InitializeComponent();
            dataAccess = new MySqlDataAccess();
            bookingRepo = new BookingRepo();
            tbBookingId.ReadOnly = true;
            UpdateBookingGridView();

        }

        public void UpdateBookingGridView()
        {
            dgvBookingList.DataSource = bookingRepo.GetAllBookings();
        }

        private void dgvBookingList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dgvBookingList.Rows[e.RowIndex];
                bookingId = Convert.ToInt32(selectedRow.Cells["booking_id"].Value);
                status = selectedRow.Cells["status"].Value.ToString();
                tbBookingId.Text = selectedRow.Cells["booking_id"].Value.ToString();

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bookingId == 0)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }
            else if (status == "Pending")
            {
                MessageBox.Show("This booking is already in pending.");
                bookingId = 0;
                tbBookingId.Text = "";
                return;
            }
            else
            {
                var sql = $"DELETE FROM `payment` WHERE `booking_id` = {bookingId}";
                int results = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(sql));
                if (results > 0)
                {



                    var sql2 = $"UPDATE `booking` SET `status` = 'Pending' WHERE `booking`.`booking_id` = {bookingId}";
                    int result = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(sql2));
                    if (result > 0)
                    {
                        MessageBox.Show("Booking has been cancelled and set to pending.");
                        bookingId = 0;
                        tbBookingId.Text = "";
                        UpdateBookingGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update booking status.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to delete associated payment.");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(bookingId == 0)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }
            else if(status == "Pending")
            {
                var sql3 = $"DELETE FROM `booking` WHERE `booking`.`booking_id` = {bookingId}";
                int result2 = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(sql3));
                if (result2 > 0)
                {
                    MessageBox.Show("Booking has been deleted.");
                    bookingId = 0;
                    tbBookingId.Text = "";
                    UpdateBookingGridView();
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to delete booking for pending.");
                    return;
                }
            }
            else
            {
                var sql2 = $"DELETE FROM `payment` WHERE `booking_id` = {bookingId}";
                int result = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(sql2));
                if (result > 0)
                {
                    var sql3 = $"DELETE FROM `booking` WHERE `booking`.`booking_id` = {bookingId}";
                    int result3 = dataAccess.ExecuteNonQuery(dataAccess.GetCommand(sql3));
                    if (result3 > 0)
                    {
                        MessageBox.Show("Booking and associated payment have been deleted.");
                        bookingId = 0;
                        tbBookingId.Text = "";
                        UpdateBookingGridView();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete booking for not pending.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to delete booking.");
                }
            }
        }
    }
}
