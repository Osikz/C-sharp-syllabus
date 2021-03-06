namespace Exercise4
{
    internal class Movie
    {
        private string _title;
        private string _studio;
        public string Rating { get; private set; }

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            Rating = "PG";
        }

        public string Display()
        {
            return $"Title - {_title}, Studio - {_studio}, Rating - {Rating}";
        }
    }
}
