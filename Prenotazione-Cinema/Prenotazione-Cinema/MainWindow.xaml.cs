using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Prenotazione_Cinema
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            el1.Fill = System.Windows.Media.Brushes.Green;
            el2.Fill = System.Windows.Media.Brushes.Green;
            el3.Fill = System.Windows.Media.Brushes.Green;
            el4.Fill = System.Windows.Media.Brushes.Green;
            el5.Fill = System.Windows.Media.Brushes.Green;
            el6.Fill = System.Windows.Media.Brushes.Green;
            el7.Fill = System.Windows.Media.Brushes.Green;
            el8.Fill = System.Windows.Media.Brushes.Green;
        }

        private void btnSvuota_Click(object sender, RoutedEventArgs e)
        {
            el1.Fill = System.Windows.Media.Brushes.Green;
            el2.Fill = System.Windows.Media.Brushes.Green;
            el3.Fill = System.Windows.Media.Brushes.Green;
            el4.Fill = System.Windows.Media.Brushes.Green;
            el5.Fill = System.Windows.Media.Brushes.Green;
            el6.Fill = System.Windows.Media.Brushes.Green;
            el7.Fill = System.Windows.Media.Brushes.Green;
            el8.Fill = System.Windows.Media.Brushes.Green;
        }

    }
}
