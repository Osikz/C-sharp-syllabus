namespace Hierarchy
{
    public abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public string AnimalName
        {
            get { return _animalName; }
            set => _animalName = value;
        }

        public string AnimalType
        {
            get { return _animalType; }
            set => _animalType = value;
        }

        public double AnimalWeight
        {
            get { return _animalWeight; }
            set => _animalWeight = value;
        }

        public int FoodEaten
        {
            get { return _foodEaten; }
            set => _foodEaten = value;
        }

        public abstract string MakeSound();

        public abstract int Eat(Food food);
    }
}
