using Carsharing.Classes;
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
    public class Client
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime LicenseIssuedDate { get; set; }


        public DataTable GetInfo (int idClient)
        {
            using (var db = new DBService())
            {
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter ("p_id_client", idClient)
                };

                return db.ExecuteQuery("SELECT * FROM get_client_info(@p_id_client)", parameters
                    );
            }
        }


        public DataTable GetAllClients()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT * FROM all_clients");
            }
        }


        public void UpdateProfile(int clientId, string lastName, string firstName, string patronymic, string phoneNumber)
        {
            using (var db = new DBService())
            {
                var parameters = new NpgsqlParameter[]
                {
            new NpgsqlParameter("p_id_client", clientId),
            new NpgsqlParameter("p_last_name", lastName),
            new NpgsqlParameter("p_first_name", firstName),
            new NpgsqlParameter("p_patronymic", (object)patronymic ?? DBNull.Value),
            new NpgsqlParameter("p_phone_number", phoneNumber),
                };

                db.ExecuteNonQuery(
                    "SELECT update_client(@p_id_client, @p_last_name, @p_first_name, @p_patronymic, @p_phone_number, NULL, NULL)",
                    parameters);
            }
        }
    }
}





