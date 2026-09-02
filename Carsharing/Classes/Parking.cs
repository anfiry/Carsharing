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
    internal class Parking
    {
        public int IdParking { get; set; }
        public int AddressId { get; set; }
        public string Description { get; set; }


        public DataTable GetAllParkings()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(@"
                    SELECT p.id_parking, 
                           a.city || ', ' || a.street || ', ' || a.house AS address,
                           p.description
                    FROM parking p
                    JOIN address a ON p.address_id = a.id_address
                    ORDER BY address");
            }
        }


        public DataTable GetParkingInfo(int parkingId)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(
                    "SELECT * FROM get_parking_info(@p_parking_id)",
                    new NpgsqlParameter("p_parking_id", parkingId));
            }
        }


        public bool IsParkingExists(int parkingId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    "SELECT COUNT(*) FROM parking WHERE id_parking = @p_parking_id",
                    new NpgsqlParameter("p_parking_id", parkingId));

                int count = Convert.ToInt32(result.Rows[0][0]);
                return count > 0;
            }
        }

        public int AddParking(string city, string street, string house, string entrance = null)
        {
            using (var db = new DBService())
            {
                int addressId = Convert.ToInt32(db.ExecuteFunction(
                    "add_address",
                    new NpgsqlParameter("p_city", city),
                    new NpgsqlParameter("p_street", street),
                    new NpgsqlParameter("p_house", house),
                    new NpgsqlParameter("p_entrance", (object)entrance ?? DBNull.Value)));

                // Создаём парковку
                return Convert.ToInt32(db.ExecuteFunction(
                    "add_parking",
                    new NpgsqlParameter("p_address_id", addressId),
                    new NpgsqlParameter("p_description", "Новая парковка")));
            }
        }

        public string GetParkingAddress(int parkingId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    @"SELECT a.city || ', ' || a.street || ', ' || a.house AS address 
              FROM parking p
              JOIN address a ON p.address_id = a.id_address
              WHERE p.id_parking = @p_parking_id",
                    new NpgsqlParameter("p_parking_id", parkingId));

                return result.Rows.Count > 0 ? result.Rows[0][0].ToString() : "Адрес не найден";
            }
        }

    }
}
