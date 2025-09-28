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
    public partial class AdminForm : Form
    {
        Users AdminUser;
        public AdminForm(Users user)
        {
            InitializeComponent();
            AdminUser = user;
            this.Text = $"Welcome {AdminUser.UserName}";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Welcome, {AdminUser.UserName}!";
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            AdminUserForm userForm = new AdminUserForm();
            userForm.Show();
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            AdminTripForm tripForm = new AdminTripForm();
            tripForm.Show();
        }

        private void btnShowBookings_Click(object sender, EventArgs e)
        {
            AdminBookingForm bookingForm = new AdminBookingForm();
            bookingForm.Show();
        }

        private void btnShowPayment_Click(object sender, EventArgs e)
        {
            AdminPaymentForm paymentForm = new AdminPaymentForm();
            paymentForm.Show();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AdminAddAdminForm addAdminForm = new AdminAddAdminForm();
            addAdminForm.Show();
        }
    }
}
