using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinIPTVApp.Pages.Content.ViewModels
{
    public class ContentConductorViewModel : Conductor<Screen>.Collection.OneActive
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly HomeViewModel _homeViewModel;

        public ContentConductorViewModel()
        {

        }

        public ContentConductorViewModel(IEventAggregator eventAggregator, HomeViewModel homeViewModel)
        {
            _eventAggregator = eventAggregator;

            _homeViewModel = homeViewModel;

            Items.AddRange(new Screen[] { _homeViewModel });
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            _eventAggregator.Subscribe(this);

            ActivateItem(_homeViewModel);
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
        }
    }
}
