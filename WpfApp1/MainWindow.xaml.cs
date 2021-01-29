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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            jugar MiVentana = new jugar();
            this.Close();
            MiVentana.ShowDialog();
            

        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Creditos(object sender, RoutedEventArgs e)
        {
            creditos MiVentana = new creditos();
            this.Close();
            MiVentana.ShowDialog();
        }
    }
}
