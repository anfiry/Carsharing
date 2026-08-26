using Carsharing.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.Services
{
    public class RegisterService
    {
        public int Register(string login, string password, string lastName, string firstName, string phoneNumber, DateTime birthDate, DateTime licenseIssuedDate, string patronymic)
        {
            using (var db = new DBService())
            {
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter ("p_login", login),
                    new NpgsqlParameter ("p_password", password),
                    new NpgsqlParameter ("p_last_name", lastName),
                    new NpgsqlParameter ("p_first_name", firstName),
                    new NpgsqlParameter ("p_phone_number", phoneNumber),
                    new NpgsqlParameter ("p_birth_date", birthDate),
                    new NpgsqlParameter ("p_license_issued_date", licenseIssuedDate),
                    new NpgsqlParameter ("p_patronymic", (object)patronymic ?? DBNull.Value)
                };

                return Convert.ToInt32(db.ExecuteFunction("add_client", parameters));
            }
        }
    }
}
