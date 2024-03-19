using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    /// class Game is a class that is a child class of Media.
    /// it contains the platform of the game besides the properties of the media class.
    public class Game : Media
    {
        private string platform { get; set; }

        /// constructor for the game class.
        public Game(string name, int price, string platform) : base(name, price)
        {

            this.platform = platform;
        }

        /// overrides the toString method to return the game details.
        public override string ToString()
        {
            return "Game: " + productNumber + " " + name + " " + price + " " + quantity + " " + platform;
        }
    }
}
