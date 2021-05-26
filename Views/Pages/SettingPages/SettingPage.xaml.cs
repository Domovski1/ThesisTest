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
            Path_Txb.Text = Settings.Default.PathToDocs;
        }

        private void Save_Btn(object sender, RoutedEventArgs e)
        {
            Settings.Default.PathToDocs = Path_Txb.Text;
            Settings.Default.Save();
            MessageBox.Show("Настройки сохранены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
