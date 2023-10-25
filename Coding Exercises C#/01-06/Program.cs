using System;
using System.Collections.Generic;

namespace movienight
{
    class MainClass
    {
        /*
         * Challenge:
         * - Write a function that adds a unique description to a class's ToString method.
         * 
         * Criteria:
         * - The custom description need to print out the movie's title, rating and review score.
         * - If the movie's review is higher than 75, the description also need to mention that the movie is "certified fresh".
        */
        public static void Main(string[] args)
        {
            // MARK: Setup
            List<Movie> movies = new List<Movie>()
            {
                new Movie("The Batman", "PG-13", 85),
                new Movie("Morbius", "PG-13", 17),
                new Movie("Spider-Man: No Way Home", "PG-13", 93)
            };

            Console.WriteLine("Hit ENTER for a list of superhero movies!");
            Console.ReadKey();

            // MARK: Result
            foreach(Movie movie in movies)
            {
                Console.WriteLine(movie.ToString() + "\n");
            }
            Console.ReadKey();
        }
    }
}