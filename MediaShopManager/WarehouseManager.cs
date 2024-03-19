using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    /// <summary>
    /// The warehouse manager class is responsible for managing the warehouse. It contains a list of all the books, movies and games in the warehouse.
    /// </summary>
    public class WarehouseManager
    {
        private static List<Book> books = new List<Book>();
        private static List<Movie> movies = new List<Movie>();
        private static List<Game> games = new List<Game>();

        /// Returns a list of all the books in the warehouse.
        public List<Book> GetAllBooks()
        {
            return books;
        }

        /// returns a list of all the movies in the warehouse.
        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        /// returns a list of all the games in the warehouse.
        public List<Game> GetAllGames()
        {
            return games;
        }

        /// adds a book to the warehouse.
        public void AddBook(string name, int price, string author="", string genre = "", string format ="", string language="")
        {
            Book book = new Book(name, price, author, genre, format, language);
            books.Add(book);
        }

        /// adds a movie to the warehouse.
        public void AddMovie(string name, int price, string format="", int? duration= null)
        {
            Movie movie = new Movie(name, price, format, duration);
            movies.Add(movie);
        }

        /// adds a game to the warehouse.
        public void AddGame(string name, int price, string platform = "")
        {
            Game game = new Game(name, price, platform);
            games.Add(game);
        }

        /// removes a book from the warehouse using productnumber.
        public void removeBook(int productNumber)
        {
            foreach (Book book in books)
            {
                if (book.getProductNumber() == productNumber)
                {
                    books.Remove(book);
                    break;
                }
            }
        }

        /// removes a movie from the warehouse using productnumber.
          public void removeMovie(int productNumber)
        {
                foreach (Movie movie in movies)
            {
                 if (movie.getProductNumber() == productNumber)
                {
                      movies.Remove(movie);
                      break;
                 }
                }
          }

        /// removes a game from the warehouse using productnumber.
        public void removeGame(int productNumber)
        {
            foreach (Game game in games)
            {
                if (game.getProductNumber() == productNumber)
                {
                    games.Remove(game);
                    break;
                }
            }
        }

        /// sets the quantity of a book in the warehouse using productnumber and quantity. when book is added to the warehouse, the quantity is set to 0.
        public void setBookQuantity(int productNumber, int quantity)
        {
            foreach (Book book in books)
            {
                if (book.getProductNumber() == productNumber)
                {
                    book.setQuantity(quantity);
                    break;
                }
            }
        }

        /// returns a string representation of the warehouse manager.
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
