using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Model;
using Tesis.Views.Pages.AdminPages;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        int Count = 0;
        public LogInPage()
        {
            InitializeComponent();
        }

        private void ShowPassword_Click(object sender, RoutedEventArgs e)
        {
            if (Pbox.Visibility == Visibility.Visible)
            {
                TxbPassword.Text = Pbox.Password;
                TxbPassword.Visibility = Visibility.Visible;
                Pbox.Visibility = Visibility.Collapsed;
            } else
            {
                TxbPassword.Visibility = Visibility.Collapsed;
                Pbox.Visibility = Visibility.Visible;
                
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.User.FirstOrDefault(u => u.Login == TxbLogin.Text && u.Password == Pbox.Password);
            if (CurrentUser != null)
            {
                if (CurrentUser.RoleID == 1)
                {
                    NavigationService.Navigate(new AdminMenuPage());
                } else
                    NavigationService.Navigate(new MenuPage());

            } else
            {
                MessageBox.Show("Такого юзера не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Count++;
            if (Count >= 5)
            {
                MessageBox.Show("Количество попыток для входа превышено. Пожалуйста, попробуйте через 5 минут либо обратитесь к администратору", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.IsEnabled = false;
            } 
        }
    }
}
