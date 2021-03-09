using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinIPTVApp.Messages;
using WinIPTVApp.Pages.Content.ViewModels;
using WinIPTVApp.Pages.Login.ViewModels;

namespace WinIPTVApp
{
    public class ShellViewModel:Conductor<Screen>.Collection.OneActive, IHandle<LoadAccountSuccessMessage>
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly LoginConductorViewModel _loginConductorViewModel;
        private readonly ContentConductorViewModel _contentConductorViewModel;

        public ShellViewModel(IEventAggregator eventAggregator, LoginConductorViewModel loginConductorViewModel, ContentConductorViewModel contentConductorViewModel)
        {
            _eventAggregator = eventAggregator;
            _loginConductorViewModel = loginConductorViewModel;
            _contentConductorViewModel = contentConductorViewModel;

            Items.AddRange(new Screen[] { _loginConductorViewModel, _contentConductorViewModel });
        }

        public void Handle(LoadAccountSuccessMessage loadAccountMessage)
        {
            ActivateItem(_contentConductorViewModel);
        }

        protected override void OnActivate()
        {
            base.OnActivate(); 

            _eventAggregator.Subscribe(this);
            ActivateItem(_loginConductorViewModel);
            
        }



        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
            _eventAggregator.Unsubscribe(this);
        }
    }
}
