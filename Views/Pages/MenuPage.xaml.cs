using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Views.Pages.SettingPages;
using Tesis.Views.Pages.TeacherPages;

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

        private void Attandance_Btn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttendancePage());
        }

        private void Setting_Btn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingPage());
        }

        private void Account_Btn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PrintPage());
        }

        private void BtnMyGroup_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminastrateGroup());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnDocs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DocumentsPage());
        }
    }
}
