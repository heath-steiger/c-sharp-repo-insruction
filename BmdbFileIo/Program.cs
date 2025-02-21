using ConsoleLibrary;
namespace BmdbFileIo
{
    internal class Program
    {

        static List<Movie> movies = new List<Movie>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to BMDB File IO");
            movies = MovieDB.GetMovies();

            int command = 9;
            while (command != 0) {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command) {
                    case 1:
                        ListMovies();
                        break;
                    case 2:
                        AddMovie();
                        break;
                    case 3:
                        GetMovieByID();
                        break;
                    case 4:
                        RemoveMovieByID();
                        break;
                    case 0:
                        break;
                    default:
                        MyConsole.PrintLine("Invalid Command. Try again.");
                        break;
                }
            }

            MyConsole.PrintLine("bye");
        }

        private static void AddMovie()
        {
            MyConsole.PrintLine("\nAdd Movie:");
            MyConsole.PrintLine("=================================");
            string ID = MyConsole.PromptString("ID: ");
            string title = MyConsole.PromptString("Title: ");
            string year = MyConsole.PromptString("Year: ");
            string rating = MyConsole.PromptString("Rating: ");
            string director = MyConsole.PromptString("Director: ");
            Movie m = new Movie(ID, title, year, rating, director);
            movies.Add(m);
            MovieDB.SaveMovie(movies);
            MyConsole.PrintLine("Movie added.");
        }

        private static void ListMovies()
        {
            MyConsole.PrintLine("\nList Movies:");
            MyConsole.PrintLine("=================================");
            foreach (Movie m in movies) {
                MyConsole.PrintLine(m.ToString());
            }
        }

        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCOMMAND MENU:");
            MyConsole.PrintLine("1) List Movies");
            MyConsole.PrintLine("2) Add Movie");
            MyConsole.PrintLine("3) Get Movie By ID");
            MyConsole.PrintLine("4) Remove Movie By ID");
            MyConsole.PrintLine("0) Exit");
        }
        static void GetMovieByID()
        {
            string id = MyConsole.PromptString("Enter Movie ID: ");
            foreach (Movie m in movies) {
                if (m.ID == id) {
                    MyConsole.PrintLine("Movie: " + m.ToString());
                }
            }

        }
        static void RemoveMovieByID()
        {
            string id = MyConsole.PromptString("Enter Movie ID: ");
            for (int i = 0; i < movies.Count; i++) {
                if (movies[i].ID == id) {
                    MyConsole.PrintLine("Removed: " + movies[i].ToString());
                    movies.RemoveAt(i);
                    MovieDB.SaveMovie(movies);
                    return; 
                }
            }

        }
    }
}
