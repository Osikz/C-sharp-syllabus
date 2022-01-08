using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Neeeeeigh...");
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Vegetable")
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }

            return FoodEaten;
        }

        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight:F1}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
