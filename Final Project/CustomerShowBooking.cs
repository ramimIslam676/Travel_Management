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
        int bookingId;
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
            var sql = $"SELECT * FROM booking WHERE user_id = {customerBooking.UserId}";
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
            string folderPath = @"C:\Users\RAMIM\Desktop\Doc";
            Directory.CreateDirectory(folderPath); // make sure folder exists

            string filePath = Path.Combine(folderPath, $"PaymentSlip_{customerBooking.UserName}_{DateTime.Now:yyyyMMddHHmmss}.txt");

            // Save to a file
            string content = $"Payment Slip\n" +
                             $"------------------\n" +
                             $"Name: {customerBooking.UserName}\n"; 
                             //$"Amount: {amount}\n" +
                             //$"Date: {date}\n";

            File.WriteAllText(filePath, content);

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(content, new Font("Arial", 12), Brushes.Black, 100, 100);
                //ev.Graphics.DrawString("Payment Slip", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 100, 100);
                //ev.Graphics.DrawString($"Name: {customerBooking.UserName}", new Font("Arial", 12), Brushes.Black, 100, 150);
                //ev.Graphics.DrawString($"Amount: {amount}", new Font("Arial", 12), Brushes.Black, 100, 180);
                //ev.Graphics.DrawString($"Date: {date}", new Font("Arial", 12), Brushes.Black, 100, 210);
            };
            pd.Print();
        }

        private void dgvShowBooking_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvShowBooking.Rows[e.RowIndex];
                bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);
                tbBookingId.Text = bookingId.ToString();
            }

        }
    }
}
