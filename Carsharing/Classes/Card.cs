using Carsharing.Services;
using Npgsql;
using System;
using System.Data;

namespace Carsharing.Classes
{
    public class Card
    {
        public int IdCard { get; set; }
        public int ClientId { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }

        public int SaveCard(int clientId, string cardNumber, string expiry, string cvv)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteFunction(
                    "save_card",
                    new NpgsqlParameter("p_client_id", clientId),
                    new NpgsqlParameter("p_card_number", cardNumber),
                    new NpgsqlParameter("p_expiry", expiry),
                    new NpgsqlParameter("p_cvv", cvv)
                );
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        public DataTable GetCardByClient(int clientId)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(
                    "SELECT * FROM get_card_by_client(@p_client_id)",
                    new NpgsqlParameter("p_client_id", clientId)
                );
            }
        }

        public void UpdateCard(int cardId, string cardNumber, string expiry, string cvv)
        {
            using (var db = new DBService())
            {
                db.ExecuteNonQuery(
                    "SELECT update_card(@p_card_id, @p_card_number, @p_expiry, @p_cvv)",
                    new NpgsqlParameter("p_card_id", cardId),
                    new NpgsqlParameter("p_card_number", cardNumber),
                    new NpgsqlParameter("p_expiry", expiry),
                    new NpgsqlParameter("p_cvv", cvv)
                );
            }
        }

        public void PayFineWithCard(int fineId, int cardId)
        {
            using (var db = new DBService())
            {
                db.ExecuteNonQuery(
                    "SELECT pay_fine_with_card(@p_fine_id, @p_card_id)",
                    new NpgsqlParameter("p_fine_id", fineId),
                    new NpgsqlParameter("p_card_id", cardId)
                );
            }
        }
    }
}