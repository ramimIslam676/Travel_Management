using Business.Layer.Repository;
using Data.Layer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Project
{
    public partial class CustomerShowBooking : Form
    {
        Users customerBooking;
        MySqlDataAccess db = new MySqlDataAccess();
        BookingRepo bookingRepo;
        int bookingId = 0;
        float payment;
        string date;
        public CustomerShowBooking(Users user)
        {
            InitializeComponent();
            customerBooking = user;
            db = new MySqlDataAccess();
            bookingRepo = new BookingRepo();
            tbBookingId.ReadOnly = true;
            UpdateBookingGridView();
        }

        public DataTable GetAllBookingsForUser()
        {
            DataTable dataTable;
            var sql = $"SELECT booking.booking_id, payment.amount, payment.payment_date " +
                        $"FROM booking " +
                        $"LEFT JOIN payment " +
                        $"ON booking.booking_id = payment.booking_id and booking.user_id = {customerBooking.UserId};";


            var cmd = db.GetCommand(sql);
            dataTable = db.Execute(cmd);
            return dataTable;
        }

        public void UpdateBookingGridView()
        {
            
            dgvShowBooking.DataSource = GetAllBookingsForUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookingId == 0)
            {
                MessageBox.Show("Please select a booking to print the payment slip.");
                return;
            }
            else
            {
                string folderPath = @"C:\Users\RAMIM\Desktop\Doc";
                Directory.CreateDirectory(folderPath); // make sure folder exists

                string filePath = Path.Combine(folderPath, $"PaymentSlip_{customerBooking.UserName}_{DateTime.Now:yyyyMMddHHmmss}.txt");


                // Save to a file
                string content = $"Payment Slip\n" +
                                 $"------------------\n" +
                                 $"Name: {customerBooking.UserName}\n" +
                                 $"Amount: {payment}\n" +
                                 $"Date: {date}\n";

                File.WriteAllText(filePath, content);

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (s, ev) =>
                {
                    ev.Graphics.DrawString(content, new Font("Arial", 12), Brushes.Black, 100, 100);
                };
                pd.Print();
                tbBookingId.Text = "";
                bookingId = 0;

            }

            
        }

        private void dgvShowBooking_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvShowBooking.Rows[e.RowIndex];
                bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);
                payment = float.Parse(row.Cells["amount"].Value.ToString());
                date = row.Cells["payment_date"].Value.ToString();
                tbBookingId.Text = bookingId.ToString();
            }

        }
    }
}
