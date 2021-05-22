using System;
using Entities;
using System.Globalization;
namespace EXERCISE_01___INTERFACES {
    //-----> START
    ///////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("PickUP (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
