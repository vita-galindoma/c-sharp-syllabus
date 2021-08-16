using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie movie2 = new Movie("Glass", "Buena Vista International", "PG13");
            Movie movie3 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Movie[] moviesArray = {movie1, movie2, movie3};

            var pgMovies = Movie.GetPG(moviesArray);

            foreach (var item in pgMovies)
            {
                Console.WriteLine(item.title + " has a rating PG.");
            }

            Console.ReadKey();
        }
    }
}
