using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Wpf;

namespace DBApp
{
    public partial class Monitor : Window
    {
        class Counter
        {
            public Func<string, string> format;
            public PerformanceCounter counter;
            public Label label;
            public CartesianChart chart;
            public ChartValues<float> Collection;


            public void setup()
            {
                chart = new CartesianChart();
                chart.Height = 300;
                //chart.SeriesColors[0] = Color.FromRgb(255,0,0);
                var series = new SeriesCollection();
                Collection = new ChartValues<float>();
                series.Add(new LineSeries()
                {
                    Name = "d",
                    Values = Collection
                });
                chart.Series = series;
                Thread thread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(1000);
                        var i = counter.NextValue();
                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            Collection.Add(i);
                            label.Content = format.Invoke(i.ToString());
                        });
                    }
                });
                thread.Start();
            }

            public void update()
            {
                
            }
        }

        class Network
        {
            public NetworkInterface Interface;
            public Label labelSent;
            public Label labelRecieve;
            public StackPanel panel;
            public StackPanel panelRoot;
            public GroupBox border;
            public CartesianChart chart;

            public void setup()
            {
                panelRoot = new StackPanel();
                var border = new GroupBox();
                panelRoot.Children.Add(border);
                border.BorderThickness = new Thickness(1);
                border.BorderBrush = new SolidColorBrush(Colors.Black);
                border.Header = Interface.Name;
                panel = new StackPanel();
                border.Content = panel;
                labelSent = new Label();
                labelRecieve = new Label();
                panel.Orientation = Orientation.Vertical;
                panel.Children.Add(labelSent);
                panel.Children.Add(labelRecieve);
                chart = new CartesianChart();
            }

            public void update()
            {
                labelSent.Content = $" Отправлено: {Interface.GetIPv4Statistics().BytesSent} Байт";
                labelRecieve.Content = $" Принято: {Interface.GetIPv4Statistics().BytesReceived} Байт";
            }
        }
        
        private List<Counter> counters = new List<Counter>();
        private List<Network> networks = new List<Network>();
        
        public Monitor()
        {
            InitializeComponent();
        }

        void add(string title, string cat, string counName, string inst = null)
        {
            PerformanceCounter per = null;
            if (inst != null)
            {
                per = new PerformanceCounter(
                    cat,
                    counName,
                    inst,
                    true
                );   
            }
            else
            {
                per = new PerformanceCounter(
                    cat,
                    counName,
                    true
                );   
            }
            var counter = new Counter();
            counter.counter = per;
            counter.format = (a) =>  title.Replace("%val", a) ;
            var label = new Label();
            counter.label = label;
            counters.Add(counter);
            Cont.Children.Add(label);
            counter.setup();
            Cont.Children.Add(counter.chart);
        }
        
        private void Monitor_OnLoaded(object sender, RoutedEventArgs ee)
        {
            add("Процессор: %val %","Processor", "% Processor Time", "_Total");
            add("Память: %val Мбайт свободно","Memory", "Available MBytes");
            add("Запись - Диск: %val Мб","PhysicalDisk", "Disk Write Bytes/sec", "_Total");
            add("Чтение - Диск: %val Мб","PhysicalDisk", "Disk Read Bytes/sec", "_Total");
            add("Потоки: %val ","Process", "Thread Count", "_Total");
            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            NetworkInterface[] interfaces 
                = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface ni in interfaces)
            {
                var net = new Network();
                net.Interface = ni;
                net.setup();
                Cont.Children.Add(net.panelRoot);
                networks.Add(net);
            }
            
            //add("NET: %val %","PhysicalDisk", "% Disk Time", "_Total");
            /*cpuCounter = new PerformanceCounter(
                "Processor",
                "% Processor Time",
                "_Total",
                true
            );
            disk = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);
            */
            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromMilliseconds(1000);
            Timer.Tick += (e, args) =>
            {
                foreach (Counter co in counters)
                {
                    co.update();
                }

                foreach (Network net in networks)
                {
                    net.update();
                }
                //Date.Content = $"{DateTime.Now.ToShortDateString()}/{DateTime.Now.ToLongTimeString()}";
            };
            Timer.Start();
        }
        
    }
}