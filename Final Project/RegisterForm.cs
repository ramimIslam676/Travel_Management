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
    public partial class RegisterForm : Form
    {
        MySqlDataAccess dataAccess;
        public RegisterForm()
        {
            InitializeComponent();
            populateCombobox();
            dataAccess = new MySqlDataAccess();
        }

        public void populateCombobox()
        {
            comboBoxUser.Items.Add("Customer");
            comboBoxUser.Items.Add("Organizer");

            comboBoxUser.SelectedIndex = 0;

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text))
            {
                MessageBox.Show("Please Give an user name");
                return;
            }
            else if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Please Give an user email");
                return;
            }
            else if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please Give an user password");
                return;
            }
            else if (string.IsNullOrEmpty(tbPhnNumber.Text))
            {
                MessageBox.Show("Please Give an user phone number");
                return;
            }
            else if (string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("Please Give an user address");
                return;
            }
            else if (!radioButtonTerms.Checked)
            {
                MessageBox.Show("Please agree to the terms and conditions");
                return;
            }

            var sql = $"INSERT INTO Users (user_name, user_email," +
                $"user_pass, user_address, user_phn, user_type) VALUES " +
                $"('{tbUserName.Text}', '{tbEmail.Text}', '{tbPassword.Text}', " +
                $"'{tbAddress.Text}', '{tbPhnNumber.Text}', '{comboBoxUser.SelectedItem.ToString()}')";

            int results = dataAccess.ExecuteNonQuery(sql);

            if (results > 0)
            {
                MessageBox.Show($"Registration Successful as {comboBoxUser.SelectedItem.ToString()}");
                this.Hide();
                LoginFrame loginFrame = new LoginFrame();
                loginFrame.Show();
            }
            else
            {
                MessageBox.Show("Registration Failed");
                return;
            }
        }
    }
}
