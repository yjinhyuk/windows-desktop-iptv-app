using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Screen = Caliburn.Micro.Screen;

namespace WinIPTVApp.Pages.Login.ViewModels
{
    public class LoadAccountInfoViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public LoadAccountInfoViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

    }
}
