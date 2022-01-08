using System;

namespace Hierarchy
{
    public class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }

        public string Breed
        {
            get { return _breed; }
            set => _breed = value;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meooooow!");
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Meat" || food.ToString() == "Vegetable")
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
            return $"{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight:F1}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
