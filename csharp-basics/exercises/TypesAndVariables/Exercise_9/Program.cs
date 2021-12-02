using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To calculate your average speed please enter distance in meters:");
            var inputMeters = Console.ReadLine();
            Console.WriteLine("Please enter time spent for the distance in hours:");
            var inputHours = Console.ReadLine();
            Console.WriteLine("Please enter time spent for the distance in minutes:");
            var inputMinutes = Console.ReadLine();
            Console.WriteLine("Please enter time spent for the distance in seconds:");
            var inputSeconds = Console.ReadLine();
            long totalSeconds = Convert.ToInt64(inputHours) * 3600 + 
                                Convert.ToInt64(inputMinutes) * 60 + 
                                Convert.ToInt64(inputSeconds);

            double metersPerSec = double.Parse(inputMeters) / totalSeconds;
            double kmPerHour = metersPerSec * 3.6;
            double milesPerHour = kmPerHour / 1.609344;

            Console.WriteLine($"Your speed in meters / second is {Math.Round(metersPerSec, 8)} \r\n" +
                              $"Your speed in km / h is {Math.Round(kmPerHour, 8)} \r\n" +
                              $"Your speed in miles / h is {Math.Round(milesPerHour, 8)}");

            Console.ReadKey();
        }
    }
}
