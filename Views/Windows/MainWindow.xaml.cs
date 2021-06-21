using System.Windows;
using Tesis.Views.Pages;

namespace Tesis
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MainFrame.Navigate(new MenuPage());
            MainFrame.Navigate(new LogInPage());
        }
    }
}
