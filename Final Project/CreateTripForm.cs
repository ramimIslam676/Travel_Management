using Data.Layer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Business.Layer.Repository;

namespace Final_Project
{
    public partial class CreateTripForm : Form
    {
        Users OrganizerUser;
        Trip EditingTrip;  
        TripRepo tripRepo = new TripRepo();
        public CreateTripForm(Users user)
        {

            InitializeComponent();
            OrganizerUser = user;
            this.Text = "Create Trip";
        }
        public CreateTripForm(Users user, Trip trip)
        {
            InitializeComponent();
            OrganizerUser = user;
            EditingTrip = trip;
            this.Text = "Edit Trip";
            FillFields();
        }
        private void FillFields()
        {
            if (EditingTrip == null) return;

            txtTripName.Text = EditingTrip.TripName;
            txtDestination.Text = EditingTrip.Destination;
            dtpStart.Value = EditingTrip.StartDate;
            dtpEnd.Value = EditingTrip.EndDate;
            numTotal.Value = EditingTrip.TotalSeat;
            numAvailable.Value = EditingTrip.AvailableSeat;
            txtPrice.Text = EditingTrip.Price.ToString(CultureInfo.InvariantCulture);
            txtDescription.Text = EditingTrip.Description;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTripName.Text) ||
               string.IsNullOrWhiteSpace(txtDestination.Text) ||
               string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            if (dtpEnd.Value.Date < dtpStart.Value.Date)
            {
                MessageBox.Show("End Date must be after Start Date.");
                return;
            }

            try
            {
                if (EditingTrip == null) 
                {
                    Trip t = new Trip();
                    t.TripName = txtTripName.Text.Trim();
                    t.Destination = txtDestination.Text.Trim();
                    t.StartDate = dtpStart.Value.Date;
                    t.EndDate = dtpEnd.Value.Date;
                    t.TotalSeat = (int)numTotal.Value;
                    t.AvailableSeat = (int)numAvailable.Value;
                    t.Price = price;
                    t.Description = txtDescription.Text.Trim();
                    t.OrganizerId = OrganizerUser.UserId;

                    tripRepo.Create(t);
                    MessageBox.Show("Trip Created!");
                }
                else 
                {
                    EditingTrip.TripName = txtTripName.Text.Trim();
                    EditingTrip.Destination = txtDestination.Text.Trim();
                    EditingTrip.StartDate = dtpStart.Value.Date;
                    EditingTrip.EndDate = dtpEnd.Value.Date;
                    EditingTrip.TotalSeat = (int)numTotal.Value;

                    if (EditingTrip.AvailableSeat > EditingTrip.TotalSeat)
                        EditingTrip.AvailableSeat = EditingTrip.TotalSeat;
                    else
                        EditingTrip.AvailableSeat = (int)numAvailable.Value;

                    EditingTrip.Price = price;
                    EditingTrip.Description = txtDescription.Text.Trim();
                    EditingTrip.OrganizerId = OrganizerUser.UserId;

                    tripRepo.Update(EditingTrip);
                    MessageBox.Show("Trip Updated!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
