using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;
using Tesis.Model;
using Tesis.Properties;
using Tesis.Views.Pages.AdminPages;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        int Count = 0;
        DispatcherTimer timer;
        public LogInPage()
        {
            InitializeComponent();

            timer = new DispatcherTimer();

            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Тут должно быть сравнение времён
            if (Settings.Default.TimeBlock < DateTime.Now)
            {
                this.IsEnabled = true;
                timer.Stop();
            } else
            {
                this.IsEnabled = false;
            }
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
                if (CurrentUser.Status == false)
                {
                    MessageBox.Show("Данные этого пользователя в данный момент недоступны. Свяжитесь с администратором", "Технические работы", MessageBoxButton.OK, MessageBoxImage.Warning);
                } else
                {

                    if (CurrentUser.RoleID == 1)
                    {
                        NavigationService.Navigate(new AdminMenuPage());
                    } else
                        NavigationService.Navigate(new MenuPage());
                }

            } else
            {
                MessageBox.Show("Такого пользователя не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Count++;
            if (Count >= 5)
            {
                MessageBox.Show("Количество попыток для входа превышено. Пожалуйста, попробуйте через 5 минут либо обратитесь к администратору", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.IsEnabled = false;
                Settings.Default.TimeBlock = DateTime.Now.AddSeconds(30);
                Settings.Default.Save();
            }
            else if (Count >= 3)
            {
                BtnHelp.Visibility = Visibility.Visible;
            }
        }

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewQuestPage());
        }
    }
}
