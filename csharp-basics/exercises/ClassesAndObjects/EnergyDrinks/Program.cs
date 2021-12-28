using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        { 
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + Math.Round(CalculateEnergyDrinkers(NumberedSurveyed))  + " bought at least one energy drink"); 
            Console.WriteLine(Math.Round(CalculatePreferCitrus(NumberedSurveyed)) + " of those " + "prefer citrus flavored energy drinks.");

            Console.ReadKey();
        }

        static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return (double)numberSurveyed * PurchasedEnergyDrinks;
        }

        static double CalculatePreferCitrus(int numberSurveyed)
        {
            return CalculateEnergyDrinkers(numberSurveyed) * PreferCitrusDrinks;
        }
    }
}
