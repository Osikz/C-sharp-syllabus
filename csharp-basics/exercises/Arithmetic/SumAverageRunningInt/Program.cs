using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var counter = 0;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
                counter++;
            }

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}" +
                              $"\r\nThe average is {Math.Round((double)sum / (double)counter, 2)}");
            Console.ReadKey();
        }
    }
}