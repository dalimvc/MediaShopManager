using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    /// class Media is an class that is the parent class of Book, Movie and Game.
    /// it contains the product number, name, price and quantity of the media. <summary>
    /// other class properties of books, movies and gamnes are declared in their respective classes.
    public class Media
    {
        private static int totalMediaCount = 1;
        protected  int productNumber { get; set; }
        protected string name { get; set; }
        protected int price { get; set; }
        protected int quantity { get; set; }

        /// Constructor for the media class.
        public Media(string name, int price)
        {
            this.name = name;
            this.price = price;
            this.quantity = 0;
            this.productNumber = totalMediaCount++;
        }

        /// Returns the product number of the media.
        public int getProductNumber()
        {
            return productNumber;
        }

        /// Returns the quantity of the media.
        public int getQuantity()
        {
            return quantity;
        }

        /// Sets the quantity of the media.
        public int setQuantity(int quantity)
        {
            return this.quantity = quantity;
        }

    }
}
