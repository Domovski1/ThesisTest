using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Model;

namespace Tesis.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для RequestPage.xaml
    /// </summary>
    public partial class RequestPage : Page
    {
        public RequestPage()
        {
            InitializeComponent();
            GridRequests.ItemsSource = AppData.db.User.Where(x => x.Status == false).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = (User)GridRequests.SelectedItem;
            CurrentUser.Status = true;
            AppData.db.SaveChanges();
            GridRequests.ItemsSource = AppData.db.User.Where(x => x.Status == false).ToList();
            MessageBox.Show("Данные высланы на почту пользователю", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
