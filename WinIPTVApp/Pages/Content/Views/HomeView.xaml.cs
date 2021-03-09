﻿using System;
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
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)sender;
            string nameListItem = (string)listViewItem.GetType().GetProperty("Name").GetValue(listViewItem, null);
            switch (nameListItem)
            {
                case "HomeListItem":
                    
                    break;
                case "LiveListItem":
                    
                    break;
                case "MovieListItem":
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
            }
        }
    }
}
