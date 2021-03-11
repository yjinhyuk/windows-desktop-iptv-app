using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinIPTVApp.Pages.Content.ViewModels
{
    public class HomeViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;


        public HomeViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        protected override void OnActivate()
        {
            base.OnActivate();
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
        }
    }
}
