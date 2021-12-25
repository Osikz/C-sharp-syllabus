namespace Exercise3
{
    internal class Odometer
    {
        private int _mileage;
        private FuelGauge _liters;

        public Odometer(int mileage, FuelGauge liters)
        {
            _mileage = mileage;
            _liters = liters;
        }

        public int OdoReading()
        {
            return _mileage;
        }

        public void Drive()
        {
            if (OdoReading() < 1000000)
            {
                _mileage++;
            }
            else
            {
                _mileage = 0;
            }

            if (OdoReading() % 10 == 0)
            {
                _liters.FuelConsume();
            }
        }
    }
}
