using Data.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Repository
{
    public class TripRepo
    {
        MySqlDataAccess dataAccess;

        public TripRepo()
        {
            dataAccess = new MySqlDataAccess();
        }

        public List<Trip> GetByOrganizer(int organizerId)
        {
            List<Trip> trips = new List<Trip>();

            var sql = "SELECT * FROM Trip WHERE user_id = @UID";
            var cmd = dataAccess.GetCommand(sql);
            cmd.Parameters.AddWithValue("@UID", organizerId);

            DataTable dt = dataAccess.Execute(cmd);

            foreach (DataRow row in dt.Rows)
            {
                Trip t = new Trip();
                t.TripId = Convert.ToInt32(row["trip_id"]);
                t.TripName = row["trip_name"].ToString();
                t.StartDate = Convert.ToDateTime(row["start_date"]);
                t.EndDate = Convert.ToDateTime(row["end_date"]);
                t.Destination = row["destination"].ToString();
                t.TotalSeat = Convert.ToInt32(row["total_seat"]);
                t.AvailableSeat = Convert.ToInt32(row["available_seat"]);
                t.Price = Convert.ToDecimal(row["price"]);
                t.Description = row["description"].ToString();
                t.OrganizerId = Convert.ToInt32(row["user_id"]);
                trips.Add(t);
            }

            return trips;
        }

        public int Create(Trip t)
        {
            var sql = @"INSERT INTO Trip (trip_name, start_date, end_date, destination,
                        total_seat, available_seat, price, description, user_id)
                        VALUES (@name, @sd, @ed, @dest, @tot, @avail, @price, @desc, @uid)";

            var cmd = dataAccess.GetCommand(sql);
            cmd.Parameters.AddWithValue("@name", t.TripName);
            cmd.Parameters.AddWithValue("@sd", t.StartDate);
            cmd.Parameters.AddWithValue("@ed", t.EndDate);
            cmd.Parameters.AddWithValue("@dest", t.Destination);
            cmd.Parameters.AddWithValue("@tot", t.TotalSeat);
            cmd.Parameters.AddWithValue("@avail", t.AvailableSeat);
            cmd.Parameters.AddWithValue("@price", t.Price);
            cmd.Parameters.AddWithValue("@desc", t.Description ?? "");
            cmd.Parameters.AddWithValue("@uid", t.OrganizerId);

            return dataAccess.ExecuteNonQuery(cmd);
        }

        public int Update(Trip t)
        {
            var sql = @"UPDATE Trip
                        SET trip_name=@name, start_date=@sd, end_date=@ed, destination=@dest,
                            total_seat=@tot, available_seat=@avail, price=@price, description=@desc
                        WHERE trip_id=@id";

            var cmd = dataAccess.GetCommand(sql);
            cmd.Parameters.AddWithValue("@name", t.TripName);
            cmd.Parameters.AddWithValue("@sd", t.StartDate);
            cmd.Parameters.AddWithValue("@ed", t.EndDate);
            cmd.Parameters.AddWithValue("@dest", t.Destination);
            cmd.Parameters.AddWithValue("@tot", t.TotalSeat);
            cmd.Parameters.AddWithValue("@avail", t.AvailableSeat);
            cmd.Parameters.AddWithValue("@price", t.Price);
            cmd.Parameters.AddWithValue("@desc", t.Description ?? "");
            cmd.Parameters.AddWithValue("@id", t.TripId);

            return dataAccess.ExecuteNonQuery(cmd);
        }

        public int Delete(int tripId)
        {
            var sql = "DELETE FROM Trip WHERE trip_id=@id";
            var cmd = dataAccess.GetCommand(sql);
            cmd.Parameters.AddWithValue("@id", tripId);

            return dataAccess.ExecuteNonQuery(cmd);
        }
    }
}
