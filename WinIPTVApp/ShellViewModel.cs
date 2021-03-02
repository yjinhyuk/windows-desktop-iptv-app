using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinIPTVApp
{
    public class ShellViewModel:Conductor<Screen>.Collection.OneActive
    {
        private readonly IEventAggregator _eventAggregator;
        

        public ShellViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        protected override void OnActivate()
        {
            base.OnActivate();

            _eventAggregator.Subscribe(this);
            
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
            _eventAggregator.Unsubscribe(this);
        }
    }
}
