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

        public int num1 { get; set; }

        public bool AnadirNumero { get; set; }

        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content = "";
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "1";
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "2";
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "3";
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "4";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_suma_Click(object sender, RoutedEventArgs e)
        {
            num1 = int.Parse(pantalla.Content.ToString());
            pantalla.Content = "";
            AnadirNumero = true;
            

        }

        private void btn_resta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_multi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_divison_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_sqrt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Igual_Click(object sender, RoutedEventArgs e)
        {
            var num2 = int.Parse(pantalla.Content.ToString());

            if (AnadirNumero) {
                var suma = num1 + num2;
                pantalla.Content = suma.ToString();
            }
        }

        private void Suma() 
        {
            var num1 = Int32.Parse(pantalla.Content.ToString());

        }
    }
}
