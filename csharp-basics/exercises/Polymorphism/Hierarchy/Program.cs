using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>();
            var index = 0;
            var end = string.Empty;

            while (end != "End")
            {
                Console.WriteLine("To add an animal to the list, please use this form :" +
                                  "\n [Type] [Name] [Weight] [Living Region] [Breed]." +
                                  "\nNote: Add Breed, only if it's a cat.");
                string[] input = Console.ReadLine().Split(' ');
                string animalType = input[0];
                string animalName = input[1];
                double animalWeight = Convert.ToDouble(input[2]);
                string animalLivingRegion = input[3];
                string catBreed = string.Empty;
                if (input.Length == 5)
                {
                    catBreed = input[4];
                }

                switch (animalType.ToLower())
                {
                    case "zebra":
                        animalList.Add(new Zebra(animalName, animalType, animalWeight, 0, animalLivingRegion));
                        break;
                    case "mouse":
                        animalList.Add(new Mouse(animalName, animalType, animalWeight, 0, animalLivingRegion));
                        break;
                    case "cat":
                        animalList.Add(new Cat(animalName, animalType, animalWeight, 0, animalLivingRegion, catBreed));
                        break;
                    case "tiger":
                        animalList.Add(new Tiger(animalName, animalType, animalWeight, 0, animalLivingRegion));
                        break;
                    default:
                        Console.WriteLine("Please enter correct type");
                        return;
                }

                input = Console.ReadLine().Split(' ');
                var foodType = input[0];
                var foodQuantity = Convert.ToInt32(input[1]);

                switch (input[0].ToLower())
                {
                    case "vegetable":
                        Feed(foodType, foodQuantity, index, animalList);
                        break;
                    case "meat":
                        Feed(foodType, foodQuantity, index, animalList);
                        break;
                    default:
                        Console.WriteLine("Incorrect type of food");
                        return;

                }

                Console.WriteLine(animalList[index].MakeSound());

                index++;

                Console.WriteLine("If you want to stop adding animals, type 'End'. Enter anything else, if you want to continue.");
                end = Console.ReadLine();
            }

            animalList.ForEach(x => Console.WriteLine(x.ToString()));

            Console.ReadKey();
        }
        public static void Feed(string foodType, int quantity, int index, List<Animal> animalList)
        {
            if (foodType.ToLower() == "vegetable")
            {
                animalList[index].Eat(new Vegetable(quantity));
            }
            else if (foodType.ToLower() == "meat")
            {
                animalList[index].Eat(new Meat(quantity));
            }

            Console.WriteLine(animalList[index].ToString());
        }
    }
}