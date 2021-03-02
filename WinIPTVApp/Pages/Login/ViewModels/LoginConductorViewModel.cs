using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinIPTVApp.Pages.Login.ViewModels
{
    public class LoginConductorViewModel:Conductor<Screen>.Collection.OneActive
    {
        private readonly IEventAggregator _eventAggregator;
        
        public LoginConductorViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            Items.AddRange(new Screen[] { });
        }

        protected override void OnActivate()
        {
            base.OnActivate();

            _eventAggregator.Subscribe(this);
            
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
        }
    }
}
