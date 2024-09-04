﻿using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

            Console.ReadKey();
        }

        private static void ListMovies()
        {
            // I haven't created a list so will just output the one
            Movie deadpool3;
            deadpool3.title = "Deadpool & Wolverine";
            deadpool3.releaseYear = 2024;
            deadpool3.price = 19.99;
            deadpool3.rating = MovieRating._15;

            Console.Clear();
            Console.WriteLine(deadpool3.title + " (" + deadpool3.releaseYear + ") Rated " + deadpool3.rating);
        }

        private static void ListShows()
        {
            List<TVShow> shows = new List<TVShow>();
            shows.Add(new TVShow("The Lord of the Rings: The Rings of Power", 2022, 0, MovieRating._15));
            shows.Add(new TVShow("The Boys", 2019, 7.99, MovieRating._18));
            shows.Add(new TVShow("Ben and Holly's Little Kingdom", 2009, 12.45, MovieRating._U));

            Console.Clear();
            for (int i = 0; i < shows.Count; i++)
            {
                Console.WriteLine(shows[i].ToString());
            }
        }

        private static void MainMenu()
        {
            // Infinite loop (until application exited)
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose from the following options: \n");
                Console.WriteLine("(1) List Movies");
                Console.WriteLine("(2) List TVShows");
                Console.WriteLine("\n");
                Console.WriteLine("(0) Exit Application");
                Console.WriteLine("\n");


                string userInput = Console.ReadLine();

                // Has the user entered an integer value?
                if(int.TryParse(userInput, out int integerInput))
                {
                    switch (integerInput)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            ListMovies();
                            Console.ReadKey();
                            break;
                        case 2:
                            ListShows();
                            Console.ReadKey();
                            break;
                    }
                }
            }

        }

        public enum MovieRating
        {
            _U,
            _12A,
            _12,
            _15,
            _18
        }

        public struct Movie
        {
            public string title;
            public int releaseYear;
            public double price;
            public MovieRating rating;

        }

    }
}
