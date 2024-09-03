namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie Deadpool3;
            Deadpool3.title = "Deadpool & Wolverine";
            Deadpool3.releaseYear = 2024;
            Deadpool3.price = 19.99;
            Deadpool3.rating = MovieRating._15;

            Console.WriteLine(Deadpool3.title + " (" + Deadpool3.releaseYear + ") Rated " + Deadpool3.rating);

            Console.ReadKey();

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
