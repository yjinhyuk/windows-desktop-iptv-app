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

namespace WinIPTVApp.Components.DropDownMenu
{
    /// <summary>
    /// Interaction logic for MenuItemUserControl.xaml
    /// </summary>
    public partial class MenuItemView : UserControl
    {
        private MenuItemViewModel itemMenu;
        public MenuItemView(MenuItemViewModel item_menu)
        {
            InitializeComponent();

            itemMenu = item_menu;

            //Set the Icon of List Header
            Icon.Source = new BitmapImage(new Uri($"pack://application:,,,/Resources/{itemMenu.Icon}.png"));

            //Set the DropDown Sublists
            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (itemMenu.Index != Globals.selected_menu_index)
            {
                Icon.Source = new BitmapImage(new Uri($"pack://application:,,,/Resources/{itemMenu.Icon}_active.png"));
            } 

            Globals.selected_menu_index = itemMenu.Index;
            
            
        }
    }
}
