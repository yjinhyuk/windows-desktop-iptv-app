using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WinIPTVApp.Pages.Content.ViewModels
{
    public class ItemMenu
    {
        public ItemMenu(string header, List<SubItem> subItems, string icon, int index)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;
            Index = index;
        }

        public ItemMenu(string header, UserControl screen, string icon, int index)
        {
            Header = header;
            Screen = screen;
            Icon = icon;
            Index = index;
        }

        public string Header { get; private set; }
        public string Icon { get; private set; }
        public List<SubItem> SubItems { get; private set; }
        public int Index { get; private set; }
        public UserControl Screen { get; private set; }
    }
}
