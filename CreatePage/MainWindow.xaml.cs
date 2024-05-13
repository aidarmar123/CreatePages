using CreatePage.Models;
using CreatePage.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Drawing;

namespace CreatePage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Page_Click(object sender, RoutedEventArgs e)
        {

            MainFrame.Navigate(new PageGeneration(new User(1,"Aidar", "Aidar", "Aidar",false, new BitmapImage() { UriSource =new Uri(@"C:\Users\3D\Pictures\juj.jpg") })));
        }
    }
}
