using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShopManager
{
    internal class CashRegisterManager
    {
        /// This method is used to sell a product from the warehouse. It takes the warehouse manager, the product number and the quantity as parameters.
        public void sellProduct(WarehouseManager warehouseManager, int productNumber, int quantity) 
        {
            foreach (Book book in warehouseManager.GetAllBooks()) 
            {
                if(book.getProductNumber() == productNumber)
                {
                    int newQuantity = book.getQuantity() - quantity;
                    book.setQuantity(newQuantity);
                }
            }
            foreach (Movie movie in warehouseManager.GetAllMovies())
            {
                if(movie.getProductNumber() == productNumber)
                {
                    int newQuantity = movie.getQuantity() - quantity;
                    movie.setQuantity(newQuantity);
                }
            }
            foreach (Game game in warehouseManager.GetAllGames())
            {
                if(game.getProductNumber() == productNumber)
                {
                    int newQuantity = game.getQuantity() - quantity;
                    game.setQuantity(newQuantity);
                }
            }

        }
    }
}
