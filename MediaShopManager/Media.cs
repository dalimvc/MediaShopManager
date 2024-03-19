using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    public abstract class Media
    {
        private static int totalMediaCount = 1;
        protected  int productNumber;
        protected string name { get; set; }
        protected int price { get; set; }
        protected int quantity { get; set; }



        public Media(string name, int price)
        {
            this.name = name;
            this.price = price;
            this.quantity = 0;
            this.productNumber = totalMediaCount++;
        }



    }
}
