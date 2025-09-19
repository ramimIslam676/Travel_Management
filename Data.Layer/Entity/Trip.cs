using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Entity
{
    public class Trip
    {
        public int TripId { get; set; }
        public string TripName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public int TotalSeat { get; set; }
        public int AvailableSeat { get; set; }
        public string Description { get; set; }
        public int OrganizerId { get; set; }
    }
}
