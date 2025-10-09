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
    public partial class AdminTripForm : Form
    {
        int userid = -1;
        UserRepo userRepo;
        TripRepo tripRepo;
        public AdminTripForm()
        {
            InitializeComponent();
            userRepo = new UserRepo();
            tripRepo = new TripRepo();
            UpdateUserGridView();
        }

        public void UpdateUserGridView()
        {
            dgvTripList.DataSource = tripRepo.GetAllTrips();
        }

        private void dgvTripList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTripList.Rows[e.RowIndex];
                userid = Convert.ToInt32(row.Cells["trip_id"].Value);
                tbTripName.Text = row.Cells["trip_name"].Value.ToString();
                tbDestination.Text = row.Cells["destination"].Value.ToString();
                dtpStart.Value = Convert.ToDateTime(row.Cells["start_date"].Value);
                dtpEnd.Value = Convert.ToDateTime(row.Cells["end_date"].Value);
                tbDescription.Text = row.Cells["description"].Value.ToString();
                tbPrice.Text = row.Cells["Price"].Value.ToString();
                nudTotalSeats.Text = row.Cells["total_seat"].Value.ToString();
                nudAvailableSeats.Text = row.Cells["available_seat"].Value.ToString();
            }

        }

        private void btnUpdateTrip_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            if (string.IsNullOrWhiteSpace(tbTripName.Text) || string.IsNullOrWhiteSpace(tbDestination.Text) || string.IsNullOrWhiteSpace(tbPrice.Text) || string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            else if(userid == -1)
            {
                MessageBox.Show("Please select a trip to update.");
                return;
            }
            else
            {
                try
                {
                    trip.TripId = userid;
                    trip.TripName = tbTripName.Text;
                    trip.Destination = tbDestination.Text;
                    trip.StartDate = dtpStart.Value;
                    trip.EndDate = dtpEnd.Value;
                    trip.Description = tbDescription.Text;
                    trip.Price = Convert.ToDecimal(tbPrice.Text);
                    trip.TotalSeat = Convert.ToInt32(nudTotalSeats.Value);
                    trip.AvailableSeat = Convert.ToInt32(nudAvailableSeats.Value);
                    trip.OrganizerId = Convert.ToInt32(dgvTripList.CurrentRow.Cells["user_id"].Value);
                    int result = tripRepo.Update(trip);
                    if (trip.StartDate > trip.EndDate)
                    {
                        MessageBox.Show("Start date cannot be after end date.");
                        return;
                    }
                    else
                    {
                        if (result > 0)
                        {
                            MessageBox.Show("Trip updated successfully.");
                            UpdateUserGridView();
                            userid = -1;
                            tbTripName.Clear();
                            tbDestination.Clear();
                            tbDescription.Clear();
                            tbPrice.Clear();
                            nudTotalSeats.Value = 0;
                            nudAvailableSeats.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("Trip update failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
