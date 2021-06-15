using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
