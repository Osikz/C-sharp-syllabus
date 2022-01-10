using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Blue");
            colors.Add("Cyan");
            colors.Add("Purple");
            colors.Add("Green");
            colors.Add("Red");

            foreach (var i in colors)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
