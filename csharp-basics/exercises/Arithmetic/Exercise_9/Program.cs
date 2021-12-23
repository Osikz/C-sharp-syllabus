using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weight in kgs:");
            double.TryParse(Console.ReadLine(), out double weight);
            Console.WriteLine("Please enter your height in cms");
            double.TryParse(Console.ReadLine(), out double heightCm);

            var heightInMeters = heightCm / 100;
            var calculatedBmi = Math.Round(weight / Math.Pow(heightInMeters, 2), 1);

            if (calculatedBmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {calculatedBmi}. You are underweight!");
            }
            else if (calculatedBmi >= 18.5 && calculatedBmi <= 25)
            {
                Console.WriteLine($"Your BMI is {calculatedBmi}. You are optimal weight!");
            }
            else
            {
                Console.WriteLine($"Your BMI is {calculatedBmi}. You are overweight!");
            }

            Console.ReadKey();
        }
    }
}
