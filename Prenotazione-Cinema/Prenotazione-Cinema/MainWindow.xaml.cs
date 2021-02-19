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
        Thread t1;
        Thread t2;
        int prenotazione = 0;
        int prenotazione2 = 0;

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
            if (el1.Fill == System.Windows.Media.Brushes.Red || el2.Fill == System.Windows.Media.Brushes.Red || el3.Fill == System.Windows.Media.Brushes.Red || el4.Fill == System.Windows.Media.Brushes.Red || el5.Fill == System.Windows.Media.Brushes.Red || el6.Fill == System.Windows.Media.Brushes.Red || el7.Fill == System.Windows.Media.Brushes.Red || el8.Fill == System.Windows.Media.Brushes.Red)
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
            else
            {
                MessageBox.Show("Tutti i posti sono già liberi");
            }
        }

        public void Cassa1()
        {

            lock (x)
            {
                if (prenotazione == 1 || prenotazione == 2 || prenotazione == 3 || prenotazione == 4 || prenotazione == 5 || prenotazione == 6 || prenotazione == 7 || prenotazione == 8)
                {
                    if (prenotazione == 1)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 2)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 3)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 4)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 5)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 6)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 7)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 8)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
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

            lock (x)
            {
                if (prenotazione == 1 || prenotazione == 2 || prenotazione == 3 || prenotazione == 4 || prenotazione == 5 || prenotazione == 6 || prenotazione == 7 || prenotazione == 8)
                {
                    if (prenotazione == 1)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 2)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 3)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 4)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 5)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 6)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 7)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    }

                    if (prenotazione == 8)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
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
                        }));
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
            prenotazione = int.Parse(txt1.Text);
            t1 = new Thread(new ThreadStart(Cassa1));
            t1.Start();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            prenotazione = int.Parse(txt2.Text);
            t2 = new Thread(new ThreadStart(Cassa2));
            t2.Start();
        }
    }
}
