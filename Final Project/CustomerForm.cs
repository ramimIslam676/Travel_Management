using Data.Layer.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class CustomerForm : Form
    {
        private Users CustomerUser;
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["travelmanagement"].ConnectionString;
        private LoginFrame login;

        public CustomerForm(LoginFrame login, Users user)
        {
            InitializeComponent();
            CustomerUser = user;
            this.login = login;
            LoadDataGridView("SELECT * FROM trip");
        }

        public CustomerForm(Users user, int totalseat)
        {
            InitializeComponent();
            this.CustomerUser = user;
        }


        private void LoadDataGridView(string query)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                con.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvShowTrip.DataSource = dt;
                }
            }
        }

        private void btnSearchByDestination_Click(object sender, EventArgs e)
        {
            string destination = txtSearchByDesnination.Text.Trim();
            string query = "SELECT * FROM trip WHERE destination LIKE @destination";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@destination", "%" + destination + "%");
                con.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvShowTrip.DataSource = dt;
                }
            }
        }

        private void dtSearchByDate_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = dtSearchByDate.Value.ToString("yyyy-MM-dd");
            string query = "SELECT * FROM trip WHERE start_date <= @date AND end_date >= @date";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@date", selectedDate);
                con.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvShowTrip.DataSource = dt;
                }
            }
        }

        private void UpDownSelectNumberOfSeat_ValueChanged(object sender, EventArgs e)
        {
            if (dgvShowTrip.CurrentRow == null) return;
            if (dgvShowTrip.CurrentRow.Cells["price"].Value == DBNull.Value) return;

            decimal price = Convert.ToDecimal(dgvShowTrip.CurrentRow.Cells["price"].Value);
            int seats = (int)UpDownSelectNumberOfSeat.Value;
            decimal totalAmount = price * seats;
            txtAmount.Text = totalAmount.ToString("F2");
        }

        private void btnBookTrip_Click(object sender, EventArgs e)
        {
            if (dgvShowTrip.CurrentRow == null)
            {
                MessageBox.Show("Please select a trip first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tripId = Convert.ToInt32(dgvShowTrip.CurrentRow.Cells["trip_id"].Value);
            int seatsToBook = (int)UpDownSelectNumberOfSeat.Value;
            int availableSeats = Convert.ToInt32(dgvShowTrip.CurrentRow.Cells["available_seat"].Value);

            if (seatsToBook > availableSeats || seatsToBook <= 0)
            {
                MessageBox.Show("Invalid number of seats.", "Seats Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount;
            if (!decimal.TryParse(txtAmount.Text, out totalAmount))
            {
                MessageBox.Show("Invalid amount calculated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Payment paymentForm = new Payment(totalAmount, this, tripId, seatsToBook);
            paymentForm.ShowDialog();
        }

        public void CompleteBookingWithMethod(int tripId, int seatsBooked, decimal amount, string paymentMethod)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string sqlBooking = @"INSERT INTO booking (booking_date, seats_booked, status, user_id, trip_id) 
                                  VALUES (@booking_date, @seats_booked, 'Confirmed', @user_id, @trip_id);
                                  SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdBooking = new MySqlCommand(sqlBooking, con);
                    cmdBooking.Parameters.AddWithValue("@booking_date", DateTime.Now);
                    cmdBooking.Parameters.AddWithValue("@seats_booked", seatsBooked);
                    cmdBooking.Parameters.AddWithValue("@user_id", CustomerUser.UserId);
                    cmdBooking.Parameters.AddWithValue("@trip_id", tripId);
                    int bookingId = Convert.ToInt32(cmdBooking.ExecuteScalar());

                    string sqlPayment = @"INSERT INTO payment (booking_id, amount, payment_date, method, status) 
                                  VALUES (@booking_id, @amount, @payment_date, @method, 'Completed')";
                    MySqlCommand cmdPayment = new MySqlCommand(sqlPayment, con);
                    cmdPayment.Parameters.AddWithValue("@booking_id", bookingId);
                    cmdPayment.Parameters.AddWithValue("@amount", amount);
                    cmdPayment.Parameters.AddWithValue("@payment_date", DateTime.Now);
                    cmdPayment.Parameters.AddWithValue("@method", paymentMethod);
                    cmdPayment.ExecuteNonQuery();

                    string sqlUpdateSeats = "UPDATE trip SET available_seat = available_seat - @seats WHERE trip_id = @trip_id";
                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdateSeats, con);
                    cmdUpdate.Parameters.AddWithValue("@seats", seatsBooked);
                    cmdUpdate.Parameters.AddWithValue("@trip_id", tripId);
                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Booking and payment completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView("SELECT * FROM trip");
                    UpDownSelectNumberOfSeat.Value = 0;
                    txtAmount.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadDataGridView("SELECT * FROM trip");
            UpDownSelectNumberOfSeat.Value = 0;
            txtAmount.Text = "";
        }

        private void btnShowBooking_Click(object sender, EventArgs e)
        {
            CustomerShowBooking bookingForm = new CustomerShowBooking(CustomerUser);
            bookingForm.Show();
        }
    }
}
