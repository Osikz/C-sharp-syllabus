namespace AdApp
{
    public class TVAd: Advert
    {
        private bool _peakTime;
        private int _duration;
        private int _rate;

        public TVAd(int fee, int duration, int rate, bool peakTime) : base(fee)
        {
            _duration = duration;
            _rate = rate;
            _peakTime = peakTime;
        }
        
        public override int Cost() 
        {
            if (_peakTime)
            {
                return (base.Cost() + _duration * _rate) * 2;
            }
            return base.Cost();
        }

        public override string ToString() 
        {
            return "\nTelevision Ad cost: " + Cost();
        }
    }
}