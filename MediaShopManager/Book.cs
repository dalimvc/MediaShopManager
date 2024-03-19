using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Globalization;

namespace MediaShopManager
{
    public class Book : Media
    {
        private string author { get; set; }
        private string genre { get; set; }
        private string format { get; set; }
        private string language { get; set; }

        public Book(string name, int price, string author, string genre, string format, string language) : base(name, price)
        {
            this.author = author;
            this.genre = genre;
            this.format = format;
            this.language = language;
        }

        public string getBookName()
        {
            return name;
        }

        public override string ToString()
        {
            return "Book: " + productNumber + " " + name + " " + price + " " + quantity + " " + author + " " + genre + " " + format + " " + language;
        }


    }
}
