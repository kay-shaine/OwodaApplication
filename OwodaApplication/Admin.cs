using System;
using System.Collections.Generic;
using System.Text;

namespace OwodaApplication
{
    class Admin
    {
            public double ticketAmountForCar = 300;
            public double ticketAmountForBus = 400;
            public double ticketAmountForMotorcycle = 200;
            public double ticketAmountForTricycle = 100;
            public double totalAmountforTenDrivers = 0;
            public double totalAmountPerCarDriver = 0;
            public double totalAmountPerMotorCycleDriver = 0;
            public double totalAmountPerBusDriver = 0;
            public double totalAmountPerTricycleDriver = 0;

            public double drivers = 10;
            public double ticketAmountForCarMember = 300 * 0.7;
            public double ticketAmountForBusMember = 400 * 0.7;
            public double ticketAmountForMotorcycleMember = 200 * 0.7;
            public double ticketAmountForTricycleMember = 100 * 0.7;
            public double ticketAmountForEachDriver = 0;

            public void TotalAmountForTenDrivers()
            {
                string[] Drivers = { "Driver1", "Driver2", "Driver3", "Driver4", "Driver5", "Driver6", "Driver7", "Driver8", "Driver9", "Driver10" };


                for (int i = 0; i < drivers; i++)
                {
                    Console.WriteLine($"Below computes total toll for {Drivers[i]}");
                    Console.WriteLine("Enter 1 if driver is a member and 2 for non-member");
                    int memberStatus = Convert.ToInt32(Console.ReadLine());
                    if (memberStatus == 1)
                    {
                        Console.WriteLine($"Enter number of trips for {Drivers[i]}");
                        int tripNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter 1 for Bus, 2 for Car, 3 for motorcycle and 4 for tricycle");
                        int vehicleType = Convert.ToInt32(Console.ReadLine());
                        if (vehicleType == 1) ticketAmountForEachDriver = ticketAmountForBusMember * tripNumber;
                        else if (vehicleType == 2) ticketAmountForEachDriver = ticketAmountForCarMember * tripNumber;
                        else if (vehicleType == 3) ticketAmountForEachDriver = ticketAmountForMotorcycleMember * tripNumber;
                        else if (vehicleType == 4) ticketAmountForEachDriver = ticketAmountForTricycleMember * tripNumber;

                        Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips by {Drivers[i]} is {ticketAmountForEachDriver}");
                        Console.WriteLine();
                    }
                    else if (memberStatus == 2)
                    {
                        Console.WriteLine($"Enter number of trips for {Drivers[i]}");
                        int tripNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter 1 for Bus, 2 for Car, 3 for motorcycle and 4 for tricycle");
                        int vehicleType = Convert.ToInt32(Console.ReadLine());
                        if (vehicleType == 1) ticketAmountForEachDriver = ticketAmountForBus * tripNumber;
                        else if (vehicleType == 2) ticketAmountForEachDriver = ticketAmountForCar * tripNumber;
                        else if (vehicleType == 3) ticketAmountForEachDriver = ticketAmountForMotorcycle * tripNumber;
                        else if (vehicleType == 4) ticketAmountForEachDriver = ticketAmountForTricycle * tripNumber;

                        Console.WriteLine($"Total Toll to be Paid for {tripNumber} trips is {ticketAmountForEachDriver}");
                        Console.WriteLine();
                    }
                    else Console.WriteLine("Invalid Input!!! Enter a valid number");

                    totalAmountforTenDrivers += ticketAmountForEachDriver;
                }

                Console.WriteLine($"Total Amount Collected For Ten Random Drivers is {totalAmountforTenDrivers}");
            }
        }
    }

