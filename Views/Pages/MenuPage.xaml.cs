using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void BtnVk_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"https://vk.com/gabiyn");
        }

        private void Attandance_Btn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttendancePage());
        }
    }
}
