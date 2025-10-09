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
    public partial class AdminUserForm : Form
    {
        UserRepo userRepo;
        int selectedUserId = 0;
        MySqlDataAccess dataAccess = new MySqlDataAccess();
        public AdminUserForm()
        {
            InitializeComponent();
            populateCombobox();
            userRepo = new UserRepo();
            UpdateUserGridView();

        }

        public void populateCombobox()
        {
            comboBoxUser.Items.Add("Organizer");
            comboBoxUser.Items.Add("Customer");
            comboBoxUser.Items.Add("Admin");

            comboBoxUser.SelectedIndex = 0;
            comboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void UpdateUserGridView()
        {
             dgvUserList.DataSource = userRepo.GetAllUsers();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPhnNumber.Text) || string.IsNullOrWhiteSpace(tbAddress.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            else if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }
            else
            {
                Users user = new Users();
                user.UserId = selectedUserId;
                user.UserName = tbUserName.Text;
                user.UserEmail = tbEmail.Text;
                user.UserPhone = tbPhnNumber.Text;
                user.UserAddress = tbAddress.Text;
                user.UserPass = tbPassword.Text;
                if (comboBoxUser.SelectedIndex == 0)
                {
                    user.UserType = (int)UserTypeEnum.Organizer;
                }
                else if (comboBoxUser.SelectedIndex == 1)
                {
                    user.UserType = (int)UserTypeEnum.Customer;
                }
                else
                {
                    user.UserType = (int)UserTypeEnum.Admin;
                }

                var sqlEmailCheck = $"SELECT * FROM Users WHERE user_email = '{tbEmail.Text}' AND user_id <> {selectedUserId};";

                DataTable chkemail = dataAccess.Execute(sqlEmailCheck);
                int result1 = chkemail.Rows.Count;
                if (result1 > 0)
                {
                    MessageBox.Show("Email already exists. Use Different Email");
                    return;
                }

                var sqlPhnCheck = $"SELECT * FROM Users WHERE user_phn = '{tbPhnNumber.Text}' AND user_id <> {selectedUserId};";

                DataTable chkphn = dataAccess.Execute(sqlPhnCheck);
                int result2 = chkphn.Rows.Count;

                if (result2 > 0)
                {
                    MessageBox.Show("Phone number already exists. Use Different Number");
                    return;
                }

                if (userRepo.UpdateUser(user))
                {
                    MessageBox.Show("User updated successfully.");
                    UpdateUserGridView();
                    selectedUserId = 0;
                    tbUserName.Clear();
                    tbEmail.Clear();
                    tbPhnNumber.Clear();
                    tbAddress.Clear();
                    tbPassword.Clear();
                    comboBoxUser.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Failed to update user.");
                }
            }

        }

        private void dgvUserList_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUserList.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["user_id"].Value);
                tbUserName.Text = row.Cells["user_name"].Value.ToString();
                tbEmail.Text = row.Cells["user_email"].Value.ToString();
                tbPhnNumber.Text = row.Cells["user_phn"].Value.ToString();
                tbAddress.Text = row.Cells["user_address"].Value.ToString();
                tbPassword.Text = row.Cells["user_pass"].Value.ToString();
                string userType = row.Cells["user_type"].Value.ToString();
                if (userType == UserTypeEnum.Organizer.ToString())
                    comboBoxUser.SelectedIndex = 0;
                else if (userType == UserTypeEnum.Customer.ToString())
                    comboBoxUser.SelectedIndex = 1;
                else
                    comboBoxUser.SelectedIndex = 2;
            }

        }
    }
}
