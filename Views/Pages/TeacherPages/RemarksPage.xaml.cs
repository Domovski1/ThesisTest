using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Model;

namespace Tesis.Views.Pages.TeacherPages
{
    /// <summary>
    /// Логика взаимодействия для RemarksPage.xaml
    /// </summary>
    public partial class RemarksPage : Page
    {
        public RemarksPage(Student student)
        {
            InitializeComponent();
            GridRemark.ItemsSource = AppData.db.Remark.Where(x => x.StudentID == student.ID).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Status_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                var gridRemark = (Remark)GridRemark.SelectedItem;
                var CurrentRemark = AppData.db.Remark.FirstOrDefault(x => x.ID == gridRemark.ID);
                CurrentRemark.Status = true;
                AppData.db.SaveChanges();
                MessageBox.Show("Сохранение выполнено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
