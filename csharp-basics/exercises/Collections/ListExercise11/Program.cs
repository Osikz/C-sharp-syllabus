using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>
            {
                "First",
                "Second",
                "Third",
                "Fourth",
                "Fifth",
                "Sixth",
                "Seventh",
                "Eighth",
                "Ninth",
                "Tenth"
            };

            myList[4] = "Eleventh";
            myList[myList.Count - 1] = "Twelfth";
            myList.Sort();

            Console.WriteLine($"Contains foobar: {myList.Contains("Foobar")}");

            foreach (var i in myList)
            {
                Console.WriteLine(i);   
            }

            Console.ReadKey();
        }
    }
}
