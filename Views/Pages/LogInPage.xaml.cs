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
using Tesis.Model;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
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
                NavigationService.Navigate(new MenuPage());
            } else
            {
                MessageBox.Show("Такого юзера не существует");
            }
        }
    }
}
