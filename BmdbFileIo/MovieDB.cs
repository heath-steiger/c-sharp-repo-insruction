
namespace BmdbFileIo
{
    internal class MovieDB
    {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir + "Movie.txt";
        private const string Sep = "|";

        public static void SaveMovie(List<Movie> movies)
        {
            using StreamWriter writer = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (Movie movie in movies) {
                writer.Write(movie.ID + Sep);
                writer.Write(movie.Title + Sep);
                writer.Write(movie.Year + Sep);
                writer.Write(movie.Rating + Sep);
                writer.WriteLine(movie.Director);




            }

            
        }

        public static List<Movie> GetMovies()
        {
            using StreamReader reader = new(new FileStream(Path, FileMode.Open, FileAccess.Read));
            List<Movie> movies = new List<Movie>();
            while (reader.Peek() != -1) {
                string row = reader.ReadLine();
                string[] cols = row.Split(Sep);

                if (cols.Length == 5) {
                    string ID = cols[0];
                    string title = cols[1];
                    string year = (cols[2]);
                    string rating = (cols[3]);
                    string director = (cols[4]);
                    Movie m = new Movie(ID, title, year, rating, director);
                    movies.Add(m);
                }
            }
            return movies;
        }




    }
}
