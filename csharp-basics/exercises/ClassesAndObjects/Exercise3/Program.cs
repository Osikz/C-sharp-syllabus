using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fuel = new FuelGauge(0);
            var odo = new Odometer(0, fuel);

            fuel.FillUp();

            while (fuel.FuelAmount() > 0)
            {
                odo.Drive();
                Console.WriteLine($"Current Odometer Reading: {odo.OdoReading()}km " +
                                  $"\r\nFuel remaining: {fuel.FuelAmount()}l\r\n");

            }

            Console.ReadKey();
        }
    }
}
