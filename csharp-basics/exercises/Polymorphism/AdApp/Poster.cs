namespace AdApp
{
    public class Poster : Advert
    {
        private int _rate;
        private int _copies;
        private int _col;
        private int _row;

        public Poster(int fee, int rate, int copies, int col, int row) : base(fee)
        {
            _rate = rate;
            _copies = copies;
            _col = col;
            _row = row;
        }

        public override int Cost()
        {
            return base.Cost() + _col + _row + _rate * _copies;
        }

        public override string ToString()
        {
            return "\nPoster cost: " + Cost();
        }
    }
}
