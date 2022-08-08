using System;
using System.Collections.Generic;
using System.Text;

namespace OwodaApplication
{
    class OwodaApp
    {
        public double ticketAmountForCar = 300;
        public double ticketAmountForBus = 400;
        public double ticketAmountForMotorcycle = 200;
        public double ticketAmountForTricycle = 100;
        public void PricePerTrip()
        {
            Console.WriteLine("Enter 1 if you are a member and 2 for non-member");
            int status = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your total number of trips");
            int tripNumber = Convert.ToInt32(Console.ReadLine());
            if (status == 1)
            {
                Console.WriteLine("Enter 1 for Bus, 2 for Car, 3 for motorcycle and 4 for tricycle");
                int vehicleType = Convert.ToInt32(Console.ReadLine());
                if (vehicleType == 1)
                {
                    double ticketPrice = ticketAmountForBus * 0.7;
                    Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketPrice * tripNumber}");
                }
                else if (vehicleType == 2)
                {
                    double ticketPrice = ticketAmountForCar * 0.7;
                    Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketPrice * tripNumber}");
                }
                else if (vehicleType == 3)
                {
                    double ticketPrice = ticketAmountForMotorcycle * 0.7;
                    Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketPrice * tripNumber}");
                }
                else if (vehicleType == 4)
                {

                    double ticketPrice = ticketAmountForTricycle * 0.7;
                    Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketPrice * tripNumber}");
                }
                else Console.WriteLine("Invalid Input!!! Enter a valid number");
            }
            else if (status == 2)
            {
                Console.WriteLine("Enter 1 for Bus, 2 for Car, 3 for motorcycle and 4 for tricycle");
                int vehicleType = Convert.ToInt32(Console.ReadLine());
                if (vehicleType == 1)
                {
                    Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketAmountForBus * tripNumber}");
                }
                else if (vehicleType == 2)
                {
                    Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketAmountForCar * tripNumber}");
                }
                else if (vehicleType == 3)
                {
                    Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketAmountForMotorcycle * tripNumber}");
                }
                else if (vehicleType == 4)
                {
                    Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketAmountForTricycle * tripNumber}");
                }
                else Console.WriteLine("Invalid Input!!! Enter a valid number");
            }
            else Console.WriteLine("Invalid Input!!! Enter a valid number");
        }
    }
}
