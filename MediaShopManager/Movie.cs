using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    internal class Movie : Media
    {
        private string format { get; set; }
        private string duration { get; set; }





        public Movie(string name, int price, int quantity, string format, string duration) : base(name, price, quantity)
        {
            this.format = format;
            this.duration = duration;
        }
    }
}
