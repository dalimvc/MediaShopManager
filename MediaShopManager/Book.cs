using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    public class Book : Media
    {
        private string author { get; set; }
        private string genre { get; set; }
        private string format { get; set; }
        private string language { get; set; }

        public Book(string name, int price, int quantity, string author, string genre, string format, string language) : base(name, price, quantity)
        {
            this.author = author;
            this.genre = genre;
            this.format = format;
            this.language = language;
        }






    }
}
