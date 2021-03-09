using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinIPTVApp.Messages;

namespace WinIPTVApp.Pages.Login.Views
{
    /// <summary>
    /// Interaction logic for LoadingAccountInfoView.xaml
    /// </summary>
    public partial class LoadAccountInfoView : UserControl
    {
        private readonly IEventAggregator _eventAggregator;
        public LoadAccountInfoView(IEventAggregator eventAggregator)
        {
            InitializeComponent();

            _eventAggregator = eventAggregator;

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.RunWorkerCompleted += worker_RunWorkCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += worker_DoWork;
            backgroundWorker.ProgressChanged += worker_ProgressChanged;
            backgroundWorker.RunWorkerAsync();
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LoadAccountProgressBar.Value = e.ProgressPercentage;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            worker.ReportProgress(0, string.Format("Processing Iteration 1"));
            int reportProgress = 0;
            
            for(int i = 0; i < 200; i++)
            {
                Thread.Sleep(80);
                reportProgress += (int)GetRandomDouble(0.0f, 2.0f);
                if(reportProgress > 93)
                {
                    reportProgress = 99;
                } else if (reportProgress > 100)
                {
                    break;
                }
                worker.ReportProgress(reportProgress);
            }
            worker.ReportProgress(100, "Done Processing");
            _eventAggregator.PublishOnUIThread(new LoadAccountSuccessMessage());
        }

        private void worker_RunWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadAccountProgressBar.Value = 100;
        }

        private double GetRandomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
    }
}
