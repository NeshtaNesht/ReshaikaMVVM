using MahApps.Metro.Controls;
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

namespace ReshaikaMVVM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {            
            InitializeComponent();         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            about_img.Visibility = Visibility.Visible;
        }

        private void about_img_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            about_img.Visibility = Visibility.Collapsed;
        }
    }
}
