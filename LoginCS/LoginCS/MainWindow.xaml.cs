﻿using System;
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

namespace LoginCS
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

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
        string usuario = TextBoxUser.Text;
        string password = TextBoxPass.Password;

            if (usuario == "shmarte@gmail.com" && password == "1234")
            {
                labelResul.Content = "Adelante";
            }
            else
            {
                labelResul.Content = "Usuario no reconocido";
            }
        }
    }
}
