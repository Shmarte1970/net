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



        public float num1 { get; set; }

        public bool Sumar { get; set; }
        public bool Restar { get; set; }
        public bool Multi { get; set; }
        public bool Dividir { get; set; }
        public bool Raiz { get; set; }
        


        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content = "";
            pantallaOper.Content = "";
            pantallaOperNum1.Content = "";
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
            pantalla.Content += "5";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "6";
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "7";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "8";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += "9";
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content +="0";
        }

        private void btn_Decimal_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Content += ".";
        }

        private void btn_suma_Click(object sender, RoutedEventArgs e)
        {
            pantallaOperNum1.Content = pantalla.Content;
            num1 = float.Parse(pantalla.Content.ToString());            
            pantalla.Content = "";
            pantallaOper.Content = "+";            
            Sumar = true;
 
        }

        private void btn_resta_Click(object sender, RoutedEventArgs e)
        {
            pantallaOperNum1.Content = pantalla.Content;
            num1 = float.Parse(pantalla.Content.ToString());
            pantalla.Content = "";
            pantallaOper.Content = "-";
            Restar = true;            
         
        }

        private void btn_multi_Click(object sender, RoutedEventArgs e)
        {
            pantallaOperNum1.Content = pantalla.Content;
            num1 = float.Parse(pantalla.Content.ToString());
            pantalla.Content = "";
            pantallaOper.Content = "*";
            Multi = true;
        }

        private void btn_divison_Click(object sender, RoutedEventArgs e)
        {
            pantallaOperNum1.Content = pantalla.Content;
            num1 = float.Parse(pantalla.Content.ToString());
            pantalla.Content = "";
            pantallaOper.Content = "/";
            Dividir = true;
        }

        private void btn_sqrt_Click(object sender, RoutedEventArgs e)
        {
            pantallaOperNum1.Content = pantalla.Content;
            num1 = float.Parse(pantalla.Content.ToString());
            pantalla.Content = "";
            pantallaOper.Content = "sqrt";
            Raiz = true;
        
        }

        private void btn_Igual_Click(object sender, RoutedEventArgs e)
        {

            var num2 = int.Parse(pantalla.Content.ToString());
        
            
            if (Sumar)
            {
                float suma = num1 + num2;
                pantalla.Content = suma.ToString();
            }

            if (Restar)
            {
                float Resta = num1 - num2;
                pantalla.Content = Resta.ToString();
            }

            if (Multi)
            {
                float Multiplica = num1 * num2;
                pantalla.Content = Multiplica.ToString();
            }

            if (Dividir)
            {
                float Division = num1 / num2;
                pantalla.Content = Division.ToString();
            }

            if (Raiz)
            {               
                double Cuadrada;
                Cuadrada = (Math.Sqrt(num1));
                pantalla.Content = Cuadrada.ToString();
            }
                     
        }


        /*
        private void Suma()  // Funcion Suma 
        {
            float num1 = float.Parse(pantalla.Content.ToString()); // Cuando Pulsamos en la suma capturamos los numero 
            

        }

        private void Resta()
        {
            float num2 = float.Parse(pantalla.Content.ToString());

        }*/



    }

}
