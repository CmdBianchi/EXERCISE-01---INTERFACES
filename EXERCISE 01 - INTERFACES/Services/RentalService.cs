using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace EXERCISE_01___INTERFACES.Services {
    //-------------------------------- START -------------------------------//
    class RentalService {
        public double PricePerHour { get; private set; }
        public int PricePerDay { get; private set; }

        public RentalService(double pricePerHour, int pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }
        public void ProcessInvoice(CarRental carRental) { 

        }
    }
    //-------------------------------- END -------------------------------//
}
