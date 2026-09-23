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
    internal class Payment
    {
        public int IdPayment { get; set; }
        public int? RentalId { get; set; }
        public int? FineId { get; set; }
        public int PaymentStatusId { get; set; }
        public int CardId { get; set; }
        public decimal Amount { get; set; }
        



        public int CreatePaymentForRental(int rentalId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteFunction(
                    "create_payment_for_rental",
                    new NpgsqlParameter("p_rental_id", rentalId));

                return Convert.ToInt32(result);
            }
        }



        public int CreatePaymentForFine(int fineId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteFunction(
                    "create_payment_for_fine",
                    new NpgsqlParameter("p_fine_id", fineId));

                return Convert.ToInt32(result);
            }
        }


        public DataTable GetPaymentInfo(int paymentId)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(
                    "SELECT * FROM get_payment_info(@p_payment_id)",
                    new NpgsqlParameter("p_payment_id", paymentId));
            }
        }


        public void ConfirmPayment(int paymentId)
        {
            using (var db = new DBService())
            {
                db.ExecuteNonQuery(
                    "SELECT public.confirm_payment(@p_payment_id)",
                    new NpgsqlParameter("p_payment_id", paymentId));
            }
        }



        public string GetPaymentStatus(int paymentId)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    @"SELECT ps.payment_status_name 
                      FROM payment p
                      JOIN payment_status ps ON p.payment_status_id = ps.id_payment_status
                      WHERE p.id_payment = @p_payment_id",
                    new NpgsqlParameter("p_payment_id", paymentId));

                return result.Rows.Count > 0 ? result.Rows[0][0].ToString() : "Неизвестно";
            }
        }

       
    }
}
