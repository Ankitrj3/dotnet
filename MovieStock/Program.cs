namespace Movie;
public class Program
{
    public static void Main()
    {
        MovieStock ms = new MovieStock();
        Console.WriteLine("Enter the number of Movies you want to Enter");
        string NumberOfMovies = Console.ReadLine();
        int n = int.Parse(NumberOfMovies);

        for(int i=0;i<n;i++){
            Console.WriteLine("Enter MovieList");
            string? MovieList = Console.ReadLine();
            ms.AddMovie(MovieList);
        }

        Console.Write("Enter genre to search: ");
        string genre = Console.ReadLine();

        var genreMovie = ms.ViewMoviesByGenre(genre);
        if(genreMovie.Count() == 0)
        {
            Console.WriteLine($"No Movies found in genre {genre}");
        }
        Console.WriteLine("Genre movies");
        foreach (var item in genreMovie)
        {
            Console.WriteLine($"Title = {item.Title} Artist = {item.Artist} Genre = {item.Genre} Rating = {item.Ratings}");
        }
        var Rating = ms.ViewMoviesByRatings();
        Console.WriteLine("Rated Movies");
        foreach (var item in Rating)
        {
            Console.WriteLine($"Title = {item.Title} Artist = {item.Artist} Genre = {item.Genre} Rating = {item.Ratings}");
        }
    }
}