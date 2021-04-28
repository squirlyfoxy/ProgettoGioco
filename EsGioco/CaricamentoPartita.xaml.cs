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

namespace EsGioco
{
    /// <summary>
    /// Logica di interazione per CaricamentoPartita.xaml
    /// </summary>
    public partial class CaricamentoPartita : Window
    {
        public CaricamentoPartita()
        {
            InitializeComponent();
        }

        private void btnInizia_Click(object sender, RoutedEventArgs e)
        {
            Combattimento finestra = new Combattimento();
            finestra.Show();
            this.Close();
        }
    }
}
