
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;
            double fallingTime = 10.0;
            double finalPosition = Methods.FinalPositionCalculator(gravity, 0.0, 0.0, fallingTime);

            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
