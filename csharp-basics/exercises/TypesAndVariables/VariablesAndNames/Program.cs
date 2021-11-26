using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars;
            int drivers;
            int passengers;
            int carsNotDriven;
            int carsDriven;
            int seatsInACar;

            double carpoolCapacity;
            double averagePassengersPerCar;

            cars = 100;
            seatsInACar = 4;
            drivers = 28;
            passengers = 90;
            carsNotDriven = cars - drivers;
            carpoolCapacity = drivers * seatsInACar;
            averagePassengersPerCar = carpoolCapacity / passengers;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar.ToString("F") + " in each car.");
            Console.ReadKey();
        }
    }
}