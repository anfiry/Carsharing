using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsharing.Classes;
using System.Data;
using Npgsql;

namespace Carsharing.Services
{
    public class AuthService
    {
        public Account Login(string login, string password)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    "SELECT a.id_account, a.login, a.pass, a.account_role_id, ar.account_role_name FROM Account a JOIN Account_role ar ON a.account_role_id = ar.id_account_role WHERE a.login = @p_login",
                    new NpgsqlParameter("p_login", login)
                    );

                if (result.Rows.Count == 0)
                    throw new Exception("Пользователь не найден");


                var row = result.Rows[0];
                if (row["pass"].ToString() != password)
                    throw new Exception("Неверный пароль");

                return new Account
                {
                    Id = Convert.ToInt32(row["id_account"]),
                    Login = row["login"].ToString(),
                    RoleId = Convert.ToInt32(row["account_role_id"]),
                    Rolename = row["account_role_name"].ToString()
                };


            }
        }


        public Account GetUserByLogin(string login)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    "SELECT a.id_account, a.login, a.account_role_id, ar.account_role_name FROM Account a JOIN Account_role ar ON a.account_role_id = ar.id_account_role WHERE a.login = @p_login",
                    new NpgsqlParameter("p_login", login)
                    );

                if (result.Rows.Count == 0)
                    return null;

                var row = result.Rows[0];

                return new Account
                {
                    Id = Convert.ToInt32(row["id_account"]),
                    Login = row["login"].ToString(),
                    RoleId = Convert.ToInt32(row["account_role_id"]),
                    Rolename = row["account_role_name"].ToString()
                };

            }
        }

    }
}
