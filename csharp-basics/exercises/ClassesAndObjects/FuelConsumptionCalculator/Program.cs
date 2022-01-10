using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            double liters;
            int endKilometers;
            
            Console.WriteLine();

            Console.Write("Enter first car start reading: ");
            startKilometers = Convert.ToInt32(Console.ReadLine());
            var car = new Car(startKilometers);

            Console.Write("Enter second car start reading: ");
            startKilometers = Convert.ToInt32(Console.ReadLine());
            var car1 = new Car(startKilometers);

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter first car liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter first car end reading: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                car.FillUp(endKilometers, liters);
                Console.WriteLine("\r\nCar Kilometers per liter are " + Math.Round(car.CalculateConsumption(), 2) + " gasHog: " + car.GasHog());

                Console.Write("Enter second car liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second car end reading: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(endKilometers, liters);
                Console.WriteLine("\r\nCar1 Kilometers per liter are " + Math.Round(car1.CalculateConsumption(), 2) + " economyCar: " + car1.EconomyCar());
            }

            Console.ReadKey();
        }
    }
}
