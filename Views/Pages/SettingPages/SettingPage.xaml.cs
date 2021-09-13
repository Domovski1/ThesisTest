using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Properties;

namespace Tesis.Views.Pages.SettingPages
{
    /// <summary>
    /// Логика взаимодействия для SettingPage.xaml
    /// </summary>
    public partial class SettingPage : Page
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string path = $@"C:\Users\{Environment.UserName}\Desktop";
            //Path_Txb.Text = Settings.Default.PathToDocs;
            Path_Txb.Text = path;

            // Переписать код таким образом, что бы при первом запуске программа автоматически задавала путь до рабочего стола
            // В случае изменения настроек, чтобы это сохранялось и подгружалось
        }

        private void Save_Btn(object sender, RoutedEventArgs e)
        {
            Settings.Default.PathToDocs = Path_Txb.Text;
            Settings.Default.Save();
            MessageBox.Show("Настройки сохранены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
