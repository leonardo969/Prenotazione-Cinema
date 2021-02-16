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

namespace Prenotazione_Cinema
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static object x = new object();

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

        public void Cassa1()
        {
            int prenotazione = int.Parse(txt1.Text);

            lock (x)
            {
                if (prenotazione == 1 || prenotazione == 2 || prenotazione == 3 || prenotazione == 4 || prenotazione == 5 || prenotazione == 6 || prenotazione == 7 || prenotazione == 8)
                {
                    if (prenotazione == 1)
                    {
                        if (el1.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el1.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt1.Clear();
                        }
                        else if (el1.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt1.Clear();
                        }
                    }

                    if (prenotazione == 2)
                    {
                        if (el2.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el2.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt1.Clear();
                        }
                        else if (el2.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt1.Clear();
                        }
                    }

                    if (prenotazione == 3)
                    {
                        if (el3.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el3.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt1.Clear();
                        }
                        else if (el3.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt1.Clear();
                        }
                    }

                    if (prenotazione == 4)
                    {
                        if (el4.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el4.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt1.Clear();
                        }
                        else if (el4.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt1.Clear();
                        }
                    }

                    if (prenotazione == 5)
                    {
                        if (el5.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el5.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt1.Clear();
                        }
                        else if (el5.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt1.Clear();
                        }
                    }

                    if (prenotazione == 6)
                    {
                        if (el6.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el6.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt1.Clear();
                        }
                        else if (el6.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt1.Clear();
                        }
                    }

                    if (prenotazione == 7)
                    {
                        if (el7.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el7.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt1.Clear();
                        }
                        else if (el7.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt1.Clear();

                        }
                    }

                    if (prenotazione == 8)
                    {
                        if (el8.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el8.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt1.Clear();
                        }
                        else if (el8.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt1.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Inserire un numero da 1 a 8 compresi");
                    txt1.Clear();
                }
            }
            
        }

        public void Cassa2()
        {
            int prenotazione = int.Parse(txt2.Text);

            lock (x)
            {
                if (prenotazione == 1 || prenotazione == 2 || prenotazione == 3 || prenotazione == 4 || prenotazione == 5 || prenotazione == 6 || prenotazione == 7 || prenotazione == 8)
                {
                    if (prenotazione == 1)
                    {
                        if (el1.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el1.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt2.Clear();
                        }
                        else if (el1.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt2.Clear();
                        }
                    }

                    if (prenotazione == 2)
                    {
                        if (el2.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el2.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt2.Clear();
                        }
                        else if (el2.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt2.Clear();
                        }
                    }

                    if (prenotazione == 3)
                    {
                        if (el3.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el3.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt2.Clear();
                        }
                        else if (el3.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt2.Clear();
                        }
                    }

                    if (prenotazione == 4)
                    {
                        if (el4.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el4.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt2.Clear();
                        }
                        else if (el4.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt2.Clear();
                        }
                    }

                    if (prenotazione == 5)
                    {
                        if (el5.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el5.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt2.Clear();
                        }
                        else if (el5.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt2.Clear();
                        }
                    }

                    if (prenotazione == 6)
                    {
                        if (el6.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el6.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt2.Clear();
                        }
                        else if (el6.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt2.Clear();
                        }
                    }

                    if (prenotazione == 7)
                    {
                        if (el7.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el7.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt2.Clear();
                        }
                        else if (el7.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt2.Clear();
                        }
                    }

                    if (prenotazione == 8)
                    {
                        if (el8.Fill == System.Windows.Media.Brushes.Green)
                        {
                            el8.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Ora il posto è tuo");
                            txt2.Clear();
                        }
                        else if (el8.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è già occupato");
                            txt2.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Inserire un numero da 1 a 8 compresi");
                    txt2.Clear();
                }
            }
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Cassa1();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Cassa2();
        }
    }
}
