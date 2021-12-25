using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var casinoRoyale = new Movie("Casino Royale", "Eon Productions", "PG13");
            var glass = new Movie("Glass", "Buena Vista International", "PG13");
            var spiderMan = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");
            var ironMan = new Movie("Iron Man", "Columbia Pictures");
            var ironMan2 = new Movie("Iron Man", "Columbia Pictures", "PG13");

            var movies = new List<Movie>
            {
                casinoRoyale,
                glass,
                spiderMan,
                ironMan,
                ironMan2
            };

            var filtered = GetPg(movies.ToArray());

            foreach (var movie in filtered)
            {
                Console.WriteLine($"{movie.Display()}");
            }

            Console.ReadKey();
        }
        public static Movie[] GetPg(Movie[] movies)
        {
            return movies.Where(movie => movie.Rating == "PG").ToArray();
        }
    }
}
