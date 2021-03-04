using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinIPTVApp.Messages;

namespace WinIPTVApp.Pages.Login.ViewModels
{
    public class LoginConductorViewModel:Conductor<Screen>.Collection.OneActive, IHandle<AuthenticateSuccessMessage>
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly LoginFormViewModel _loginFormViewModel;
        private readonly LoadAccountInfoViewModel _loadAccountInfoViewModel;
        
        public LoginConductorViewModel(IEventAggregator eventAggregator, LoginFormViewModel loginFormViewModel, LoadAccountInfoViewModel loadAccountInfoViewModel)
        {
            _eventAggregator = eventAggregator;
            _loginFormViewModel = loginFormViewModel;
            _loadAccountInfoViewModel = loadAccountInfoViewModel;


            Items.AddRange(new Screen[] { _loginFormViewModel, _loadAccountInfoViewModel });
        }

        public void Handle(AuthenticateSuccessMessage message)
        {
            ActivateItem(_loadAccountInfoViewModel);
        }

        protected override void OnActivate()
        {
            base.OnActivate();

            _eventAggregator.Subscribe(this);
            ActivateItem(_loginFormViewModel);
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
        }
    }
}
