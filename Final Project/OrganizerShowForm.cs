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
    public partial class OrganizerShowForm : Form
    {
        Users organizerUser;
        MySqlDataAccess db = new MySqlDataAccess();
        BookingRepo bookingRepo;
        public OrganizerShowForm(Users user)
        {
            InitializeComponent();
            organizerUser = user;
            db = new MySqlDataAccess();
            bookingRepo = new BookingRepo();
            UpdateBookingGridView();
         
        }

        
        public void UpdateBookingGridView()
        {
            dgvOrganizerShowForm.DataSource = bookingRepo.GetAllBookings();
        }
    }
}
