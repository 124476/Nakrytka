using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Nakrytka.Windows
{
    /// <summary>
    /// Логика взаимодействия для OknoNack.xaml
    /// </summary>
    public partial class OknoNack : Window
    {
        DispatcherTimer dispatcherTimer;
        public OknoNack(string srl, int time)
        {
            InitializeComponent();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(time);
            dispatcherTimer.Tick += SetTime;
            WebW.Source = new Uri(srl);
        }

        private void SetTime(object sender, EventArgs e)
        {
            dispatcherTimer.Stop();
            WebW.Source = new Uri("https://google.com");
        }
    }
}
