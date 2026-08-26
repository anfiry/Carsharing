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
    public class Operator
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }



        public DataTable GetInfo(int idOperator)
        {
            using (var db = new DBService())
            {
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter ("p_id_operator", idOperator)
                };

                return db.ExecuteQuery("SELECT * FROM get_operator_info(@p_id_operator)", parameters
                    );
            }
        }




        public void UpdateProfile(int idOperator, string firstName, string lastName, string patronymic, string phoneNumber)
        {
            using (var db = new DBService())
            {
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter ("p_id_operator", idOperator),
                    new NpgsqlParameter ("p_first_name", firstName),
                    new NpgsqlParameter ("p_last_name", lastName),
                    new NpgsqlParameter ("p_patronymic", (object)patronymic ?? DBNull.Value),
                    new NpgsqlParameter ("p_phone_number", phoneNumber),
                };

                db.ExecuteNonQuery(
                   "SELECT update_operator(@p_id_operator, @p_last_name, @p_first_name, @p_patronymic, @p_phone_number)", parameters);

            }
        }



    }
}
