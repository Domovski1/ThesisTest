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

namespace Tesis.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdminMenuPage.xaml
    /// </summary>
    public partial class AdminMenuPage : Page
    {
        public AdminMenuPage()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnQuestions_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AnswerPage());
        }

        private void BtnTeachersList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminMainPage());
        }

        private void btnAddTeacher_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeacherOperatePage(new Model.Teacher()));
        }

        private void BtnRequestPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RequestPage());
        }
    }
}
