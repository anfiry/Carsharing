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
    internal class Fine
    {
        public int IdFine { get; set; }
        public int RentalId { get; set; }
        public int FineTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }



        public int AddFine(int rentalId, int fineTypeId, decimal amount, string description)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteFunction(
                    "add_fine",
                    new NpgsqlParameter("p_rental_id", rentalId),
                    new NpgsqlParameter("p_fine_type_id", fineTypeId),
                    new NpgsqlParameter("p_amount", amount),
                    new NpgsqlParameter("p_description", (object)description ?? DBNull.Value));

                return Convert.ToInt32(result);
            }
        }


        public DataTable GetClientFines(int clientId)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(
                    "SELECT * FROM get_client_fines(@p_client_id)",
                    new NpgsqlParameter("p_client_id", clientId));
            }
        }


        public DataTable GetAllFines()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT * FROM all_fines");
            }
        }


        /*public DataTable GetUnpaidFines()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT * FROM unpaid_fines");
            }
        }*/


        public DataTable GetUnpaidFinesByClient(int clientId)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(
                    "SELECT * FROM get_client_fines(@p_client_id) WHERE status = 'Не оплачен'",
                    new NpgsqlParameter("p_client_id", clientId));
            }
        }

        public void PayFine(int fineId)
        {
            using (var db = new DBService())
            {
                //создать 
                var paymentId = db.ExecuteFunction(
                    "create_payment_for_fine",
                    new NpgsqlParameter("p_fine_id", fineId));

                //поменять стат на оплачен
                db.ExecuteNonQuery(
                    "SELECT public.confirm_payment(@p_payment_id)",
                    new NpgsqlParameter("p_payment_id", Convert.ToInt32(paymentId)));
            }
        }



        public string GetFineTypeName(int fineTypeId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    "SELECT fine_type_name FROM fine_type WHERE id_fine_type = @p_fine_type_id",
                    new NpgsqlParameter("p_fine_type_id", fineTypeId));

                return result.Rows.Count > 0 ? result.Rows[0][0].ToString() : "Неизвестно";
            }
        }


        public DataTable GetAllFineTypes()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT id_fine_type, fine_type_name FROM fine_type ORDER BY fine_type_name");
            }
        }

    }
}
