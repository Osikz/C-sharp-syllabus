using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class Methods
    {
        public static HashSet<string> AvailableCities(string[] textList)
        {
            var cities = new HashSet<string>();
            foreach (var s in textList)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '-')
                    {
                        cities.Add(s.Remove(i).Trim());
                    }
                }
            }

            return cities;
        }

        public static List<string> AvailableFlights(string[] textList, string startDestination)
        {
            var availableFlights = new List<string>();
            var listing = 1;
            foreach (var s in textList)
            {
                if (s.StartsWith(startDestination))
                {
                    Console.WriteLine($"{listing}. {s}");
                    listing++;
                    availableFlights.Add(s);
                }
            }

            return availableFlights;
        }
    }
}
