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
    public partial class AdminUserForm : Form
    {
        UserRepo userRepo;
        public AdminUserForm()
        {
            InitializeComponent();
            userRepo = new UserRepo();
            UpdateUserGridView();
            
        }

        public void UpdateUserGridView()
        {
             dgvUserList.DataSource = userRepo.GetAllUsers();
        }
    }
}
