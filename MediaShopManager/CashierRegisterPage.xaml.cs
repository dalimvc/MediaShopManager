using System;
using System.Collections.Generic;
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



namespace MediaShopManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CashierRegisterPage : Page
    {
        public CashierRegisterPage()
        {
            this.InitializeComponent();
        }

        //private void View1Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(WarehouseManagerPage));
        //}

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
    }
}
