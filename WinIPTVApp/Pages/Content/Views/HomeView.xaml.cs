using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinIPTVApp.Components.DropDownMenu;
using WinIPTVApp.Pages.Content.ViewModels;

namespace WinIPTVApp.Pages.Content.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();

            var homeMenuHeader = new List<SubItem>();
            homeMenuHeader.Add(new SubItem("Customer"));
            homeMenuHeader.Add(new SubItem("Providers"));
            homeMenuHeader.Add(new SubItem("Employees"));
            homeMenuHeader.Add(new SubItem("Products"));
            var item0 = new MenuItemViewModel("Home", homeMenuHeader, "home", 0);

            var liveMenuHeader = new List<SubItem>();
            liveMenuHeader.Add(new SubItem("Services"));
            liveMenuHeader.Add(new SubItem("Meetings"));
            var item1 = new MenuItemViewModel("live TV", liveMenuHeader, "monitor", 1);

            var movieMenuHeader = new List<SubItem>();
            movieMenuHeader.Add(new SubItem("Customers"));
            movieMenuHeader.Add(new SubItem("Providers"));
            movieMenuHeader.Add(new SubItem("Products"));
            movieMenuHeader.Add(new SubItem("Stocks"));
            movieMenuHeader.Add(new SubItem("Sales"));
            var item2 = new MenuItemViewModel("movies", movieMenuHeader, "movie", 2);

            var serieMenuHeader = new List<SubItem>();
            serieMenuHeader.Add(new SubItem("Customer"));
            serieMenuHeader.Add(new SubItem("Providers"));
            serieMenuHeader.Add(new SubItem("Employees"));
            serieMenuHeader.Add(new SubItem("Products"));
            var item3 = new MenuItemViewModel("tv_series", serieMenuHeader, "tv_series", 3);

            var radioMenuHeader = new List<SubItem>();
            radioMenuHeader.Add(new SubItem("Cash Flow"));
            var item4 = new MenuItemViewModel("radio", radioMenuHeader, "radio", 4);

            var item5 = new MenuItemViewModel("Recordings", new UserControl(), "record", 5);

            var item6 = new MenuItemViewModel("Favorite", new UserControl(), "favorite", 6);

            Menus.Children.Add(new MenuItemView(item0));
            Menus.Children.Add(new MenuItemView(item1));
            Menus.Children.Add(new MenuItemView(item2));
            Menus.Children.Add(new MenuItemView(item3));
            Menus.Children.Add(new MenuItemView(item4));
            Menus.Children.Add(new MenuItemView(item5));
            Menus.Children.Add(new MenuItemView(item6));
        }

        public void setDefault(int pre_selected_index)
        {

        }
    }
}
