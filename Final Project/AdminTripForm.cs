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
    public partial class AdminTripForm : Form
    {
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
    }
}
