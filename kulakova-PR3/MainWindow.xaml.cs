﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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
namespace kulakova_PR3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Page1 auth = new Page1();
            FrmMain.NavigationService.Navigate(auth);
        }

        private void FrMMain_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FrmMain_ContentRendered(object sender, EventArgs e)
        {

        }
    }
}
