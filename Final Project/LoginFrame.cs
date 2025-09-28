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
    public partial class LoginFrame : Form
    {
        MySqlDataAccess dataAccess;
        Users users;
        int trip_id;
        public LoginFrame()
        {
            InitializeComponent();
            dataAccess = new MySqlDataAccess();
            users = new Users();
             
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
                var sql = $"SELECT * FROM Users WHERE user_phn = '{tbPhnNumber.Text}' AND user_pass = '{tbPassword.Text}'";
                DataTable userType = dataAccess.Execute(sql);
                string type = userType.Rows[0]["user_type"].ToString();
                if (type == UserTypeEnum.Admin.ToString())
                {
                    users.UserId = Convert.ToInt32(userType.Rows[0]["user_id"]);
                    users.UserEmail = userType.Rows[0]["user_email"].ToString();
                    users.UserName = userType.Rows[0]["user_name"].ToString();
                    users.UserPhone = userType.Rows[0]["user_phn"].ToString();
                    users.UserAddress = userType.Rows[0]["user_address"].ToString();
                    users.UserType = Convert.ToInt32(UserTypeEnum.Admin);
                    users.UserPass = userType.Rows[0]["user_pass"].ToString();

                    AdminForm adminForm = new AdminForm(users);
                    this.Hide();
                    adminForm.Show();
                }
                else if (type == UserTypeEnum.Organizer.ToString())
                {
                    users.UserId = Convert.ToInt32(userType.Rows[0]["user_id"]);
                    users.UserEmail = userType.Rows[0]["user_email"].ToString();
                    users.UserName = userType.Rows[0]["user_name"].ToString();
                    users.UserPhone = userType.Rows[0]["user_phn"].ToString();
                    users.UserAddress = userType.Rows[0]["user_address"].ToString();
                    users.UserType = Convert.ToInt32(UserTypeEnum.Organizer);
                    users.UserPass = userType.Rows[0]["user_pass"].ToString();

                    OrganizerForm organizerFrame = new OrganizerForm(users);
                    this.Hide();
                    organizerFrame.Show();
                }
                else if (type == UserTypeEnum.Customer.ToString())
                {
                    users.UserId = Convert.ToInt32(userType.Rows[0]["user_id"]);
                    users.UserEmail = userType.Rows[0]["user_email"].ToString();
                    users.UserName = userType.Rows[0]["user_name"].ToString();
                    users.UserPhone = userType.Rows[0]["user_phn"].ToString();
                    users.UserAddress = userType.Rows[0]["user_address"].ToString();
                    users.UserType = Convert.ToInt32(UserTypeEnum.Customer);
                    users.UserPass = userType.Rows[0]["user_pass"].ToString();

                    CustomerForm cf = new CustomerForm(this, users);
                    this.Hide();
                    cf.Show();
                }

            }
        }
    }
}
