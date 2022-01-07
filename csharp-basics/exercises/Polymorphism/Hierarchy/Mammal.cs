namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get { return _livingRegion; }
            set => _livingRegion = value;
        }
    }
}
