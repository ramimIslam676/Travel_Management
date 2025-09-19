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
    public partial class CustomerForm : Form
    {
        Users CustomerUser;
        public CustomerForm(Users user)
        {
            InitializeComponent();
            CustomerUser = user;
            this.Text = $"Welcome {CustomerUser.UserName}";
        }
    }
}
