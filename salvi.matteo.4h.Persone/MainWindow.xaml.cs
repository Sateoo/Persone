using salvi.matteo._4h.Persone.Models;
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

namespace salvi.matteo._4h.Persone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ATA a = new ATA();
            Console.WriteLine(a);
        }
        private void PulsanteApri(object sender, RoutedEventArgs e)
        {
            ATA a= new ATA();
            Console.WriteLine("Sono io :"+a);
            /*try
            {
                dgDati.ItemsSource = new Utenti("utenti.csv");
            }
            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }*/
        }
        private void dgDati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            /*try
            {
                if (e != null && e.Row != null)
                {
                    Persona u = e.Row.Item as Persona;
                    if (u != null)
                    {
                        if (u.Tipo == "Alunno")
                        {
                            e.Row.Background = Brushes.LightGreen;
                            e.Row.Foreground = Brushes.Black;
                        }
                        else if (u.Tipo == "Docente")
                        {
                            e.Row.Background= Brushes.LightBlue;
                            e.Row.Foreground = Brushes.Black;
                        }
                    }
                }
            }
            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }*/
        }
    }
}
