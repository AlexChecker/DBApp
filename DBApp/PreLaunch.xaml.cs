using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace DBApp
{
    public partial class PreLaunch : Window
    {
        public PreLaunch()
        {
            InitializeComponent();
        }

            DispatcherTimer tm = new DispatcherTimer();
        private void PreLaunch_OnLoaded(object sender, RoutedEventArgs e)
        {
            tm.Interval = new TimeSpan(0,0,0,10);
            tm.Tick += launch;
            tm.Start();
            //TimerCallback tm = new TimerCallback(launch);
            //Timer timer = new Timer(tm, 0, 1000, 3000);
        }

        void launch(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Auth a = new Auth();
                a.Show();
                this.Close();
                tm.Stop();
            });

        }
    }
}