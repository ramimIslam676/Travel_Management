using Data.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Repository
{
    public class BookingRepo
    {
        MySqlDataAccess dataAccess;
        public BookingRepo()
        {
            dataAccess = new MySqlDataAccess();
        }

        public DataTable GetAllBookings()
        {
            DataTable dataTable;
            var sql = "SELECT * FROM Booking";
            var cmd = dataAccess.GetCommand(sql);
            dataTable = dataAccess.Execute(cmd);
            return dataTable;
        }
    }
}
