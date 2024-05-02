using Estacionamento.Entities;
using Estacionamento.Services;
using System.Globalization;

namespace Estacionamento
{
    class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start =  DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) ;
            Console.WriteLine("Return (dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish , new Vehicle(model));
            
            RentalService rentalService = new RentalService(hour, day );

            rentalService.processInvouce(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);

        }
    
          
    }


}