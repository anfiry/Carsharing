using Carsharing.Services;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.Classes
{
    public class Account
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Rolename { get; set; }

        public string GetRole(int accountId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    "SELECT ar.account_role_name FROM account a JOIN account_role ar ON a.account_role_id = ar.id_account_role WHERE a.id_account = @p_account_id",
                    new NpgsqlParameter("p_account_id", accountId));

                return result.Rows.Count > 0 ? result.Rows[0][0].ToString() : "Неизвестно";
            }
        }

        public void UpdateInfo(int accountId, string newLogin, string newPassword)
        {
            using (var db = new DBService())
            {
                db.ExecuteNonQuery(
                    "SELECT public.update_account(@p_account_id, @p_login, @p_password)",
                    new NpgsqlParameter("p_account_id", accountId),
                    new NpgsqlParameter("p_login", (object)newLogin ?? DBNull.Value),
                    new NpgsqlParameter("p_password", (object)newPassword ?? DBNull.Value));
            }
        }

    }
}
