using Business.Layer.Repository;
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
        public AdminBookingForm()
        {
            InitializeComponent();
            bookingRepo = new BookingRepo();
            UpdateBookingGridView();

        }

        public void UpdateBookingGridView()
        {
            dgvBookingList.DataSource = bookingRepo.GetAllBookings();
        }
    }
}
