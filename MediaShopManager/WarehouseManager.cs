using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    public class WarehouseManager
    {
        private static List<Book> books = new List<Book>();
        private static List<Movie> movies = new List<Movie>();
        private static List<Game> games = new List<Game>();

        public void AddBook(string name, int price, string author, string genre, string format, string language)
        {
            Book book = new Book(name, price, author, genre, format, language);
            books.Add(book);
        }

        public void AddMovie(string name, int price, string format, string duration)
        {
            Movie movie = new Movie(name, price, format, duration);
            movies.Add(movie);
        }

        public void AddGame(string name, int price, string platform)
        {
            Game game = new Game(name, price, platform);
            games.Add(game);
        }
        public void removeBook(string name)
        {
            foreach (Book book in books)
            {
                if (book.getBookName() == name)
                {
                    books.Remove(book);
                    break;
                }
            }
        }

        public void removeMovie(string name)
        {
            foreach (Movie movie in movies)
            {
                if (movie.getMovieName() == name)
                {
                    movies.Remove(movie);
                    break;
                }
            }
        }

        public void removeGame(string name)
        {
            foreach (Game game in games)
            {
                if (game.getGameName() == name)
                {
                    games.Remove(game);
                    break;
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (Book book in books)
            {
                result += book.ToString() + "\n";
            }
            foreach (Movie movie in movies)
            {
                result += movie.ToString() + "\n";
            }
            foreach (Game game in games)
            {
                result += game.ToString() + "\n";
            }
            return result;
        }
    }
}
