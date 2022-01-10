namespace Exercise3
{
    internal class FuelGauge
    {
        private double _liters;

        public FuelGauge(double liters)
        {
            _liters = liters;
        }

        public double FuelAmount()
        {
            return _liters;
        }

        public void FillUp()
        {
            while (FuelAmount() < 70)
            {
                _liters++;
            }
        }

        public void FuelConsume()
        {
            if (FuelAmount() > 0)
            {
                _liters--;
            }
        }
    }
}
