using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    public class Game : Media
    {

        private string platform { get; set; }


        public Game(string name, int price, string platform) : base(name, price)
        {

            this.platform = platform;
        }

        public string getGameName()
        {
            return name;
        }

        public override string ToString()
        {
            return "Game: " + productNumber + " " + name + " " + price + " " + quantity + " " + platform;
        }
    }
}
