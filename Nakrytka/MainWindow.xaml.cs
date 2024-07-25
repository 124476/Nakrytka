using Nakrytka.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nakrytka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int kol = Int32.Parse(KolText.Text);
                for (int i = 0; i < kol; i++)
                {
                    var dialog = new OknoNack(SrlText.Text, Int32.Parse(TimeText.Text));
                    dialog.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
