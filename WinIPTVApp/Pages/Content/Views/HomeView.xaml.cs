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

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Customer"));
            menuRegister.Add(new SubItem("Providers"));
            menuRegister.Add(new SubItem("Employees"));
            menuRegister.Add(new SubItem("Products"));
            var item0 = new ItemMenu("Register", menuRegister, "register");

            var menuSchedule = new List<SubItem>();
            menuSchedule.Add(new SubItem("Services"));
            menuSchedule.Add(new SubItem("Meetings"));
            var item1 = new ItemMenu("Appointments", menuSchedule, "schedule");

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Customers"));
            menuReports.Add(new SubItem("Providers"));
            menuReports.Add(new SubItem("Products"));
            menuReports.Add(new SubItem("Stocks"));
            menuReports.Add(new SubItem("Sales"));
            var item2 = new ItemMenu("Reports", menuReports, "reports");

            var menuExpress = new List<SubItem>();
            menuExpress.Add(new SubItem("Customer"));
            menuExpress.Add(new SubItem("Providers"));
            menuExpress.Add(new SubItem("Employees"));
            menuExpress.Add(new SubItem("Products"));
            var item3 = new ItemMenu("Express", menuExpress, "register");

            var menuFinancial = new List<SubItem>();
            menuFinancial.Add(new SubItem("Cash Flow"));

            var item4 = new ItemMenu("Finanical", menuFinancial, "financial");

            var item5 = new ItemMenu("Dashboard", new UserControl(), "dashboard");

            Menu.Children.Add(new MenuItemUserControl(item0));
            Menu.Children.Add(new MenuItemUserControl(item1));
            Menu.Children.Add(new MenuItemUserControl(item2));
            Menu.Children.Add(new MenuItemUserControl(item3));
            Menu.Children.Add(new MenuItemUserControl(item4));
            Menu.Children.Add(new MenuItemUserControl(item5));

        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)sender;
            string nameListItem = (string)listViewItem.GetType().GetProperty("Name").GetValue(listViewItem, null);
            switch (nameListItem)
            {
                case "HomeListViewItem":
                    break;
                case "LiveListViewItem":
                    break;
                case "MovieListViewItem":
                    break;
                case "SerieListViewItem":
                    break;
                case "RadioListViewItem":
                    break;
                case "RecordingListViewItem":
                    break;
                case "FavoriteListViewItem":
                    break;
            }
        }

        private void ListViewItem_MouseLeave(object sender, MouseEventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)sender;
            string nameListViewItem = (string)listViewItem.GetType().GetProperty("Name").GetValue(listViewItem, null);

            switch (nameListViewItem)
            {
                case "HomeListViewItem":
                    break;
                case "LiveListViewItem":
                    break;
                case "MovieListViewItem":
                    break;
                case "SerieListViewItem":
                    break;
                case "RadioListViewItem":
                    break;
                case "RecordingListViewItem":
                    break;
                case "FavoriteListViewItem":
                    break;
            }
        }
    }
}
