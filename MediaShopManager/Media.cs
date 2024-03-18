using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    public abstract class Media
    {
        private static int productNumber = 0;
        private string name { get; set; }
        private int price { get; set; }
        private int quantity { get; set; }

        private static List<Book> books = new List<Book>();
        private static List<Movie> movies = new List<Movie>();
        private static List<Game> games = new List<Game>();

        public Media(string name, int price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            productNumber++;
        }

    }
}
