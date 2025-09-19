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
    public partial class LoginFrame : Form
    {
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserRepo userRepo = new UserRepo();
            if (!userRepo.IsUserValidForLogin(tbPhnNumber.Text, tbPassword.Text))
            {
                MessageBox.Show("Wrong User Name or Password!!!");
                return;
            }
            else
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
        }
    }
}
