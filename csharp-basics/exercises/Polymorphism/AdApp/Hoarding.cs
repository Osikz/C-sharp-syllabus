namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        private int _numDays;
        private bool _primeLocation;

        public Hoarding(int fee, int rate, int numDays, bool primeLocation) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
            _primeLocation = primeLocation;
        }

        public override int Cost() 
        {
            if (_primeLocation)
            {
                return (int) ((base.Cost() + _rate * _numDays) / 0.5);
            }
            return base.Cost() + _rate * _numDays;
        }

        public override string ToString() 
        {
            return "\nHoarding cost: " + Cost();
        }
    }
}