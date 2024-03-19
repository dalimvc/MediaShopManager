using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    /// class Movie is a class that is a child class of Media.
    /// it contains the format and duration of the movie besides the properties of the media class.
    public class Movie : Media
    {
        private string format { get; set; }
        private int? duration { get; set; }

        /// constructor for the movie class.
        public Movie(string name, int price, string format, int? duration) : base(name, price)
        {
            this.format = format;
            this.duration = duration;
        }

        /// overrides the toString method to return the movie details.
        public override string ToString()
        {
            return "Movie: " + productNumber + " " + name + " " + price + " " + quantity + " " + format + " " + duration;
        }
    }
}
