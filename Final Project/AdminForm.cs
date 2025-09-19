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
    }
}
