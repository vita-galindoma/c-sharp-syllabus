using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        public string title;
        public string studio;
        public string rating;

        public Movie(string title, string studio, string rating)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }

        public Movie(string title, string studio)
        {
            this.title = title;
            this.studio = studio;
            this.rating = "PG";
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            var result = movies.Where(movie => movie.rating == "PG").ToArray();
            return result;
        }
    }
}
