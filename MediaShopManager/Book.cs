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
    /// class Book is a class that is a child class of Media.
    /// it contains the author, genre, format and language of the book besides the properties of the media class.
    public class Book : Media
    {
        private string author { get; set; }
        private string genre { get; set; }
        private string format { get; set; }
        private string language { get; set; }

        /// Constructor for the book class.
        public Book(string name, int price, string author, string genre, string format, string language) : base(name, price)
        {
            this.author = author;
            this.genre = genre;
            this.format = format;
            this.language = language;
        }

        /// overrides the toString method to return the book details.
        public override string ToString()
        {
            return "Book: " + productNumber + " " + name + " " + price + " " + quantity + " " + author + " " + genre + " " + format + " " + language;
        }


    }
}
