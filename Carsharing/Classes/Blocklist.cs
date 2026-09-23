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
    public class Blocklist
    {
        public int IdBlock { get; set; }
        public int AccountId { get; set; }
        public DateTime BlockDate { get; set; }
        public DateTime? UnblockDate { get; set; }
        public string Reason { get; set; }



        public bool IsClientBlocked(int idClient)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteScalar("SELECT is_client_blocked (@p_client_id)",
                    new NpgsqlParameter("p_client_id", idClient));

                return Convert.ToBoolean(result);
            }
        }


        public void BlockClient(int clientId, string reason)
        {
            using (var db = new DBService())
            {
                db.ExecuteNonQuery(
                    "SELECT public.block_client(@p_client_id, @p_reason)",
                    new NpgsqlParameter("p_client_id", clientId),
                    new NpgsqlParameter("p_reason", reason));
            }
        }


        public void UnblockClient(int clientId)
        {
            using (var db = new DBService())
            {
                db.ExecuteNonQuery(
                    "SELECT public.unblock_client(@p_client_id)",
                    new NpgsqlParameter("p_client_id", clientId));
            }
        }


        /*public DataTable GetActiveBlocks()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(@"
            SELECT b.id_block, a.login, c.last_name || ' ' || c.first_name AS client_name,
                   b.block_date, b.reason
            FROM blocklist b
            JOIN account a ON b.account_id = a.id_account
            JOIN client c ON a.id_account = c.account_id
            WHERE b.unblock_date IS NULL");
            }
        }*/


    }
}
