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
        public MainPage()
        {
            this.InitializeComponent();

            WarehouseManager warehouse = new WarehouseManager();
            warehouse.AddBook("The Hobbit", 20, "J.R.R. Tolkien", "Fantasy", "Paperback", "English");

            warehouse.AddMovie("The Lord of the Rings", 30, "DVD", "3 hours");
            warehouse.AddGame("The Lord of the Rings", 40, "PC");
            warehouse.AddBook("The Hobbit", 20, "J.R.R. Tolkien", "Fantasy", "Paperback", "English");
            warehouse.AddBook("The Hobbit2", 20, "J.R.R. Tolkien", "Fantasy", "Paperback", "English");


            warehouse.removeBook("The Hobbit2");

            Debug.WriteLine(warehouse);
        }
    }
}
