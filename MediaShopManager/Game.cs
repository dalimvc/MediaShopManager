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


        public Game(string name, int price, int quantity, string platform) : base(name, price, quantity)
        {

            this.platform = platform;
        }
    }
}
