using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Piiipiipipi..";
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
