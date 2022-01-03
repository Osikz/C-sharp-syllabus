using System;
using System.Collections.Generic;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uniqueItems = new HashSet<string>();

            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();

            while (name != string.Empty)
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                uniqueItems.Add(name);
            }

            Console.WriteLine("Unique names:");

            foreach (var i in uniqueItems)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
