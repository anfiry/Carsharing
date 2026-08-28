using Carsharing.Services;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.Classes
{
    internal class Rental
    {
        public int IdRental { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public int RentalStatusId { get; set; }
        public int StartParkingId { get; set; }
        public int? EndParkingId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? TotalCost { get; set; }



        public int StartRental(int clientId, int carId, int startParkingId)
        {
            using (var db = new DBService())
            {

                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("p_client_id", clientId),
                    new NpgsqlParameter("p_car_id", carId),
                    new NpgsqlParameter("p_start_parking_id", startParkingId)
            };
                var result = db.ExecuteFunction(
                    "start_rental", parameters);

                return Convert.ToInt32(result);
            }
        }


        public decimal EndRental(int rentalId, int endParkingId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteFunction(
                    "end_rental",
                    new NpgsqlParameter("p_rental_id", rentalId),
                    new NpgsqlParameter("p_end_parking_id", endParkingId));

                return Convert.ToDecimal(result);
            }
        }


        public DataTable GetClientRentals(int clientId)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(
                    "SELECT * FROM get_client_rentals(@p_client_id)",
                    new NpgsqlParameter("p_client_id", clientId));
            }
        }


        public DataTable GetActiveRentals()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT * FROM active_rentals");
            }
        }


        /*(public DataTable GetRentalInfo(int rentalId)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(@"
                    SELECT r.*, 
                           c.last_name || ' ' || c.first_name AS client_name,
                           car.brand || ' ' || car.model AS car_name,
                           rs.rental_status_name
                    FROM rental r
                    JOIN client c ON r.client_id = c.id_client
                    JOIN car ON r.car_id = car.id_car
                    JOIN rental_status rs ON r.rental_status_id = rs.id_rental_status
                    WHERE r.id_rental = @p_rental_id",
                    new NpgsqlParameter("p_rental_id", rentalId));
            }
        }*/


        public DataTable GetActiveRentalByClient(int clientId)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(
                    "SELECT * FROM get_client_rentals(@p_client_id) WHERE rental_status_name = 'Активна'",
                    new NpgsqlParameter("p_client_id", clientId));
            }
        }


        public string GetRentalStatusName(int statusId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    "SELECT rental_status_name FROM rental_status WHERE id_rental_status = @p_status_id",
                    new NpgsqlParameter("p_status_id", statusId));

                return result.Rows.Count > 0 ? result.Rows[0][0].ToString() : "Неизвестно";
            }
        }

    }
}
