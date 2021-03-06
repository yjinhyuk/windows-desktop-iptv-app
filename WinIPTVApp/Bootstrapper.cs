﻿using Autofac;
using Caliburn.Micro.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WinIPTVApp.Pages.Content.ViewModels;
using WinIPTVApp.Pages.Login.ViewModels;

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
            builder.RegisterType<LoginConductorViewModel>().SingleInstance();
            builder.RegisterType<LoginFormViewModel>().SingleInstance();
            builder.RegisterType<SelectUserViewModel>().SingleInstance();
            builder.RegisterType<ContentConductorViewModel>().SingleInstance();
            builder.RegisterType<HomeViewModel>().SingleInstance();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
