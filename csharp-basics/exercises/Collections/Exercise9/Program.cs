using System;
using System.Collections.Generic;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<string>();

            hashSet.Add("Some string");
            hashSet.Add("Plain Text");
            hashSet.Add("Hello World!");
            hashSet.Add("Collections");
            hashSet.Add("HashSet");

            foreach (var i in hashSet)
            {
                Console.WriteLine(i);
            }

            hashSet.Clear();

            hashSet.Add("Duplicate");
            hashSet.Add("Duplicate");
            hashSet.Add("Duplicate");

            foreach (var i in hashSet)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
