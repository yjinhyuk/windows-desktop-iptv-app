using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinIPTVApp.Pages.Login.ViewModels
{
    public class SelectUserViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public SelectUserViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }
    }
}
