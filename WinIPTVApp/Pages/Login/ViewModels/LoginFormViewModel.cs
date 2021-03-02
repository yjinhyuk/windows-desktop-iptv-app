using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinIPTVApp.Pages.Login.ViewModels
{
    public class LoginFormViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public string Username { get; set; } = "Username";
        public string Password { get; set; } = "Password";

        public LoginFormViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void Login()
        {
            if(Username.Equals("Username") || Password.Equals("Password"))
            {
                return;
            } else
            {
                return;
            }
        }
    }
}
