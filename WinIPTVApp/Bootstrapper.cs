using Autofac;
using Caliburn.Micro.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WinIPTVApp
{
    public class Bootstrapper : AutofacBootstrapper<ShellViewModel>
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void ConfigureBootstrapper()
        {
            base.ConfigureBootstrapper();
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<ShellViewModel>().SingleInstance();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
