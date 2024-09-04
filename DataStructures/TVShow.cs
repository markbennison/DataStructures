using static DataStructures.Program;

namespace DataStructures
{
    internal class TVShow
    {
        public string title = "Untitled";
        public int releaseYear;
        public double price;
        public MovieRating rating;

        public TVShow(string title, int releaseYear, double price, MovieRating rating)
        {
            this.title = title;
            this.releaseYear = releaseYear;
            this.price = price;
            this.rating = rating;

        }

        public override string ToString()
        {
            return title + " (" + releaseYear + ") Rated " + rating + " ... £" + price.ToString("0.00");
        }
    }
}
