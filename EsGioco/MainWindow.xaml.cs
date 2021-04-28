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
using System.Threading;
using System.IO;

namespace EsGioco
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Videogioco Videogioco { get; set; }

        private Thread t1;

        public MainWindow()
        {
            InitializeComponent();

            //Grafica
            btnGioca.Visibility = Visibility.Hidden;

            //Thread caricamento
            t1 = new Thread(new ThreadStart(Caricamento));
            t1.Start();
        }

        private void Caricamento()
        {
            string[] arr = File.ReadAllLines("frasi.txt");
            double toAdd = 1;

            Dispatcher.BeginInvoke((Action)(() =>
            {
                progress.Maximum = arr.Length;
            }));

            try
            {

                Videogioco = new Videogioco();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (string s in arr)
            {
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    lbl.Content = "Caricamento di: " + s;
                    progress.Value += toAdd;
                }));

                Thread.Sleep(1000);
            }
        }

        private void btnGioca_Click(object sender, RoutedEventArgs e)
        {

        }

        private void progress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(progress.Value == progress.Maximum)
            {
                btnGioca.Visibility = Visibility.Visible;
            }
        }
    }
}
