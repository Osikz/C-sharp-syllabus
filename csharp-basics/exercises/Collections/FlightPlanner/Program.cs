using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var cities = new HashSet<string>();
            var availableFlights = new List<string>();
            var listing = 1;

            Console.WriteLine("What would you like to do:\r\n" +
                              "To display list of available cities press '1'\r\n" +
                              "To exit program, press '#'");
            var menuChoice = Console.ReadKey();

            foreach (var s in readText)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '-')
                    {
                        cities.Add(s.Remove(i).Trim());
                    }
                }
            }
            
            switch (menuChoice.KeyChar)
            {
                case '1':
                    Console.WriteLine();
                    foreach (var c in cities)
                    {
                        Console.WriteLine($"{listing}. {c}");
                        listing++;
                    }
                    break;

                case '#':
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("\r\nTo select a city from which you want to start, press according number:");
            var cityChoice = Console.ReadKey();
            var startDestination = string.Empty;

            switch (cityChoice.KeyChar)
            {
                case '1':
                    startDestination = "San Jose";
                    break;
                case '2':
                    startDestination = "New York";
                    break;
                case '3':
                    startDestination = "Anchorage";
                    break;
                case '4':
                    startDestination = "Honolulu";
                    break;
                case '5':
                    startDestination = "Denver";
                    break;
                case '6':
                    startDestination = "San Francisco";
                    break;
            }

            listing = 1;
            Console.WriteLine("\r\nAvailable flights from chosen city:");
            foreach (var s in readText)
            {
                if (s.StartsWith(startDestination))
                {
                    Console.WriteLine($"{listing}. {s}");
                    listing++;
                    availableFlights.Add(s);
                }
            }

            Console.WriteLine("\r\nWhere would you like to fly?");
            cityChoice = Console.ReadKey();
            var cityChoiceNum = Convert.ToInt32(cityChoice.KeyChar) - 48;

            for (int i = cityChoiceNum - 1; i < cityChoiceNum; i++)
            {
                Console.WriteLine($"\r\nYour chosen round-trip route is: {availableFlights[i]} -> {startDestination}");
            }

            Console.ReadKey();
        }
    }
}
