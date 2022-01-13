using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cars = new List<ICar>() {new Audi(), new Bmw(), new Lexus(), new Tesla(), new Toyota(), new Volvo()};
            var fastest = 0;
            var index = 0;

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(car.StartEngine());
                    }
                    else if (i == 2)
                    {
                        if (car is IBoostable boostable)
                        {
                            boostable.UseNitrousOxideEngine();
                        }
                        else
                        {
                            car.SpeedUp();
                        }
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine($"{car.GetType().Name} current speed - {car.ShowCurrentSpeed()}km/h");
                    }

                    car.SpeedUp();
                }
            }

            foreach (var car in cars)
            {
                if (fastest < Convert.ToInt32(car.ShowCurrentSpeed()))
                {
                    fastest = Convert.ToInt32(car.ShowCurrentSpeed());
                    index = cars.IndexOf(car);
                }
            }

            Console.WriteLine($"The fastest car was {cars[index].GetType().Name} accumulating {fastest}km/h!");

            Console.ReadKey();
        }
    }
}