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
using Business.Layer.Repository;

namespace Final_Project
{
    public partial class OrganizerForm : Form
    {
        Users OrganizerUser;
        TripRepo tripRepo = new TripRepo();
        public OrganizerForm(Users user)
        {
            InitializeComponent();
            OrganizerUser = user;
            this.Text = $"Welcome {OrganizerUser.UserName}";
            this.Load += OrganizerForm_Load;

        }
        private void OrganizerForm_Load(object sender, EventArgs e)
        {
            LoadTrips();
        }

        private void LoadTrips()
        {
            List<Trip> trips = new List<Trip>();

            try
            {

                trips = tripRepo.GetByOrganizer(OrganizerUser.UserId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erorr: " + ex.Message);
            }

            dgvTrips.DataSource = null;

            dgvTrips.AutoGenerateColumns = true;

            dgvTrips.DataSource = trips;
        }

        private Trip SelectedTrip()
        {
            if (dgvTrips.CurrentRow == null)
            {
                MessageBox.Show("Please select a trip first.");
                return null;
            }


            Trip t = dgvTrips.CurrentRow.DataBoundItem as Trip;

            if (t == null)
            {
                MessageBox.Show("Selected row is not a valid Trip.");
                return null;
            }

            return t;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new CreateTripForm(OrganizerUser);
            if (form.ShowDialog() == DialogResult.OK)
                LoadTrips();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var trip = SelectedTrip();
            if (trip == null) { MessageBox.Show("Please select a trip first."); return; }

            var form = new CreateTripForm(OrganizerUser, trip);
            if (form.ShowDialog() == DialogResult.OK)
                LoadTrips();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var trip = SelectedTrip();
            if (trip == null) { MessageBox.Show("Please select a trip first."); return; }

            if (MessageBox.Show($"Delete {trip.TripName} ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    tripRepo.Delete(trip.TripId);
                    LoadTrips();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message);
                }
            }
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginFrame().Show();
        }
    }
}
