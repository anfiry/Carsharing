using Carsharing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.Services
{
    public class RentalService
    {
        private readonly Rental _rental;
        private readonly Payment _payment;
        private readonly Car _car;
        private readonly Blocklist _blocklist;

        public RentalService()
        {
            _rental = new Rental();
            _payment = new Payment();
            _car = new Car();
            _blocklist = new Blocklist();
        }


        public int StartRental(int clientId, int carId, int startParkingId)
        {
            if (_blocklist.IsClientBlocked(clientId))
            {
                throw new Exception("Клиент заблокирован!");
            }

            var carInfo = _car.GetCarInfo(carId);
            if (carInfo.Rows.Count == 0)
            {
                throw new Exception("Машина не найдена!");
            }

            return _rental.StartRental(clientId, carId, startParkingId);
        }

        public decimal EndRental(int rentalId, int endParkingId)
        {
            decimal totalCost = _rental.EndRental(rentalId, endParkingId);

            int paymentId = _payment.CreatePaymentForRental(rentalId);
            _payment.ConfirmPayment(paymentId);

            return totalCost;
        }
    }
}
