using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Model;

namespace Tesis.Views.Pages.TeacherPages
{
    /// <summary>
    /// Логика взаимодействия для AdminastrateGroup.xaml
    /// </summary>
    public partial class AdminastrateGroup : Page
    {
        public AdminastrateGroup()
        {
            InitializeComponent();
            GridStudents.ItemsSource = AppData.db.Student.ToList();
            CmbGroups.ItemsSource = AppData.db.Group.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CmbGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CurrentGroup = CmbGroups.SelectedItem as Group;
            GridStudents.ItemsSource = AppData.db.Student.Where(gr => gr.GroupID == CurrentGroup.Code).ToList();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            var CurrentStudent = (Student)GridStudents.SelectedItem;
            var IsRemarkExist = AppData.db.Remark.Where(x => x.StudentID == CurrentStudent.ID).ToList();
            if (IsRemarkExist.Count != 0)
            {
                NavigationService.Navigate(new RemarksPage(CurrentStudent));
            } else
            {
                MessageBox.Show("У данног студента нет никаких замечений", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
