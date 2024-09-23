/* *************************************************************************** *
 * *************************************************************************** *
 *       __  ___           __       ____                   _                   *
 *      /  |/  /___ ______/ /__    / __ )___  ____  ____  (_)________  ____    *
 *     / /|_/ / __ `/ ___/ //_/   / __  / _ \/ __ \/ __ \/ / ___/ __ \/ __ \   *
 *    / /  / / /_/ / /  / ,<     / /_/ /  __/ / / / / / / (__  ) /_/ / / / /   *
 *   /_/  /_/\__,_/_/  /_/|_|   /_____/\___/_/ /_/_/ /_/_/____/\____/_/ /_/    *
 *                                                                             *
 * *************************************************************************** *
 * *************************************************************************** */

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
