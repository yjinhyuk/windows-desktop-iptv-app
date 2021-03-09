using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinIPTVApp.Messages;
using WinIPTVApp.Services.XCService;
using Screen = Caliburn.Micro.Screen;

namespace WinIPTVApp.Pages.Login.ViewModels
{
    public class LoadAccountInfoViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        private int loadAccountProgressBar;

        public int LoadAccountProgressBar
        {
            get { return loadAccountProgressBar; }
            set
            {
                if(loadAccountProgressBar == value)
                {
                    return;
                }

                loadAccountProgressBar = value;
                NotifyOfPropertyChange(() => LoadAccountProgressBar);
            }
        }

        public LoadAccountInfoViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        protected override void OnActivate()
        {
            base.OnActivate();


            /*_eventAggregator.PublishOnUIThread(new LoadAccountSuccessMessage());*/
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
        }

    }
}
