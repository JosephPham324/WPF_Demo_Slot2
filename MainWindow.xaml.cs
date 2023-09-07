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

namespace WPF_Demo_Slot2
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
        private void btnToPage01_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new PageDemo();
        }
        private void btnToPage02_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new PageDemo2();
        }
        private void btnToPage03_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new PageDemo3();
        }
        private void btnToPage04_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new PageDemo4();
        }
        private void btnToPage05_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new PageDemo5();
        }
    }
}
