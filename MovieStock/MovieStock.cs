using System.Security.Cryptography.X509Certificates;

namespace Movie
{
    public class MovieStock
    {
        public string? Title{get; set;}
        public string? Artist{get; set;}
        public string? Genre{get; set;}
        public int Ratings{get; set;}

        public MovieStock()
        {
    
        }
        // public MovieStock(string Title, string Artist, string Genre, int Ratings)
        // {
        //     this.Title = Title;
        //     this.Artist = Artist;
        //     this.Genre = Genre;
        //     this.Ratings = Ratings;
        // }
        // split
        // Trim
        public static List<MovieStock> movieStocks = new List<MovieStock>();
        public void AddMovie(string MovieList)
        {
             string[] parts = MovieList.Split(",");
             MovieStock movie = new MovieStock{
                Title = parts[0].Trim(),
                Artist = parts[1].Trim(),
                Genre = parts[2].Trim(),
                Ratings = int.Parse(parts[3].Trim())
             };
            // MovieStock movie = new MovieStock();
            //     movie.Title = parts[0].Trim();
            //     movie.Artist = parts[1].Trim();
            //     movie.Genre = parts[2].Trim();
            //     movie.Ratings = int.Parse(parts[3].Trim());
            //  movieStocks.Add(movie);
        }
        public List<MovieStock> ViewMoviesByGenre(string genre)
        {
            var movieByGenere = movieStocks
                                .Where(s => s.Genre.Equals(genre))
                                .ToList();
            return movieByGenere;
        }
        public List<MovieStock> ViewMoviesByRatings()
        {
            var movieByRatings = movieStocks
                                 .OrderBy(s => s.Ratings)
                                 .ToList();
            return movieByRatings;
        }
    }
}