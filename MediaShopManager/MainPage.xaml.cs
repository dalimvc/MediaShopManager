using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MediaShopManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem item = args.SelectedItem as NavigationViewItem;
            if (item != null)
            {
                switch (item.Tag)
                {
                    case "Home":
                        Frame.Navigate(typeof(MainPage));
                        break;
                    case "Warehouse":
                        Frame.Navigate(typeof(WarehouseManagerPage));
                        break;
                    case "Cashier":
                        Frame.Navigate(typeof(CashierRegisterPage));
                        break;
                }
            }
        }

        public MainPage()
        {
            this.InitializeComponent();



            WarehouseManager warehouse = new WarehouseManager();
            CashRegisterManager cashRegister = new CashRegisterManager();

            warehouse.AddBook("Bello Gallico et Civili", 449, "Julius Caesar", "Historia", "Inbunden", "Latin");
            warehouse.AddBook("How to Read a Book", 149, "Mortimer J. Adler", "Kursliteratur", "Pocket");
            warehouse.AddBook("Moby Dick", 49, "Herman Melville", "Äventyr", "Pocket");
            warehouse.AddBook("Great Gatsby", 79, "F. Scott Fitzgerald", "Noir", "E-Bok");
            warehouse.AddBook("House of Leaves", 49, "Mark Z. Danielewski", "Skräck");

            warehouse.AddGame("Elden Ring", 599, "Playstation 5");
            warehouse.AddGame("Demon's Souls", 499, "Playstation 5");
            warehouse.AddGame("Microsoft Flight Simulator", 499, "PC");
            warehouse.AddGame("Planescape Torment", 99, "PC");
            warehouse.AddGame("Disco Elysium", 399, "PC");

            warehouse.AddMovie("Nyckeln till frihet", 99, "DVD", 142);
            warehouse.AddMovie("Gudfadern", 99, "DVD", 152);
            warehouse.AddMovie("Konungens återkomst", 199, "Blu-Ray", 154);
            warehouse.AddMovie("Pulp fiction", 199, "Blu-Ray");
            warehouse.AddMovie("Schindlers list", 99, "DVD");





            //warehouse.AddBook("The Hobbit", 20, "J.R.R. Tolkien", "Fantasy", "Paperback", "English");
            //warehouse.AddMovie("The Lord of the Rings", 30, "DVD", 120);
            //warehouse.AddGame("The Lord of the Rings", 40, "PC");
            //warehouse.AddBook("The Hobbit", 20, "J.R.R. Tolkien", "Fantasy", "Paperback", "English");
            //warehouse.AddBook("The Hobbit2", 20, "J.R.R. Tolkien", "Fantasy", "Paperback", "English");

            warehouse.setBookQuantity(1, 10);  
            cashRegister.sellProduct(warehouse, 1, 3);

            Debug.WriteLine(warehouse);
        }
    }
}
