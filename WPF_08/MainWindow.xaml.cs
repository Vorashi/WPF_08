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

namespace WPF_08
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

        public void RollMin(object sender, RoutedEventArgs e) => Window.WindowState = WindowState.Minimized;

        public void ExpandTerritory(object sender, RoutedEventArgs e) => Window.WindowState = WindowState.Maximized;

        public void Recovery(object sender, RoutedEventArgs e) => Window.WindowState= WindowState.Normal;

        public void Close(object sender, RoutedEventArgs e) => Close();
    }
}
