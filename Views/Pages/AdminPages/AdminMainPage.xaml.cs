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

namespace Tesis.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdminMainPage.xaml
    /// </summary>
    public partial class AdminMainPage : Page
    {
        public AdminMainPage()
        {
            InitializeComponent();
            ListTeachers.ItemsSource = AppData.db.Teacher.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var CurrentTeacher = (Teacher)ListTeachers.SelectedItem;
                if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Данные невозможно будет восстановить", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    AppData.db.Teacher.Remove(CurrentTeacher);
                    AppData.db.SaveChanges();
                    MessageBox.Show($"Преподаватель {CurrentTeacher.LastName} удалён из базы", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    ListTeachers.ItemsSource = AppData.db.Teacher.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationService.Navigate(new TeacherOperatePage((Teacher)ListTeachers.SelectedItem));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
