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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content = "";
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "7";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "6";
        }

        private void btn_Igual_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
