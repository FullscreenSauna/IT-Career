﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___Parking
{
    class Program
    {
        static Parking parking = new Parking();

        static void Main(string[] args)
        {
            parking.AddCar("car");
            parking.AddCar("car1");
            parking.AddCar("car2");
            parking.AddFancyCar("fancyCar");

            parking.ReleaseCar(1);

            Console.WriteLine();

            //    string line;

            //    while ("END" != (line = Console.ReadLine()))
            //    {
            //        string[] cmdArgs = line.Split(' ');

            //        switch (cmdArgs[0])
            //        {
            //            case "Add":
            //                AddCar(cmdArgs[1]);
            //                break;
            //            case "AddFancy":
            //                AddFancyCar(cmdArgs[1]);
            //                break;
            //            case "Check":
            //                CheckCarIsPresent(cmdArgs[1]);
            //                break;
            //            case "Release":
            //                ReleaseCar(cmdArgs[1]);
            //                break;
            //            case "Count":
            //                CountCars();
            //                break;
            //            case "Info":
            //                ParkingInformation();
            //                break;
            //        }
            //    }
            //}

            //private static void CountCars()
            //{
            //    Console.WriteLine("Cars count: " + parking.Count);
            //}

            //private static void ParkingInformation()
            //{
            //    StringBuilder info = parking.ParkingInformation();
            //    Console.WriteLine(info.ToString().Trim());
            //}

            //private static void ReleaseCar(string arg)
            //{
            //    bool released;
            //    try
            //    {
            //        released = parking.ReleaseCar(int.Parse(arg));
            //    }
            //    catch (FormatException e)
            //    {
            //        released = parking.ReleaseCar(arg);
            //    }

            //    if (released)
            //    {
            //        Console.WriteLine("Released car");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Car not found");
            //    }
            //}

            //private static void CheckCarIsPresent(string carNumber)
            //{
            //    Car car = parking.CheckCarIsPresent(carNumber);

            //    Console.WriteLine(car != null ? $"{car} is present."
            //        : "Car is not present");
            //}

            //private static void AddFancyCar(string carNumber)
            //{
            //    parking.AddFancyCar(carNumber);
            //}

            //private static void AddCar(string carNumber)
            //{
            //    parking.AddCar(carNumber);
            //}
        }
    }
}
