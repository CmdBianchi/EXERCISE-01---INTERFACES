using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;
namespace Services {
    //-------------------------------- START -------------------------------//
    class RentalService {
        public double PricePerHour { get; private set; }
        public int PricePerDay { get; private set; }

        private ITaxService _taxService;
    //-------------------------------- CONST -------------------------------//
        public RentalService(double pricePerHour, int pricePerDay, ITaxService taxService) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
    //-------------------------------- MET -------------------------------//
        public void ProcessInvoice(CarRental carRental) {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPaymente = 0.0;

            if (duration.TotalHours <= 12.0) {
                basicPaymente = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else {
                basicPaymente = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPaymente);
            carRental.Invoice = new Invoice(basicPaymente, tax);
        }
    }
    //-------------------------------- END -------------------------------//
}
