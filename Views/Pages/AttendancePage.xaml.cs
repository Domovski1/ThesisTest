using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Model;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AttendancePage.xaml
    /// </summary>
    public partial class AttendancePage : Page
    {
        public AttendancePage()
        {
            InitializeComponent();
            GridStudents.ItemsSource = AppData.db.Student.ToList();
        }

        private void Back_Btn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CmbGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CurrentGroup = CmbGroups.SelectedItem as Group;
            GridStudents.ItemsSource = AppData.db.Student.Where(gr => gr.GroupID == CurrentGroup.Code).ToList();
        }

        private void Attendance_Checked(object sender, RoutedEventArgs e)
        {
            var CurrentStudent = (Student)GridStudents.SelectedItem;
            Attendance record = new Attendance()
            {
                Day = DateTime.Today,
                StudentID = CurrentStudent.ID,
                IsPresense = true,
            };
            AppData.db.Attendance.Add(record);
        }

        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AppData.db.SaveChanges();
                MessageBox.Show("Сохранено!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CmbGroups.ItemsSource = AppData.db.Group.ToList();
            CmbGroups.DisplayMemberPath = "Title";
        }
    }
}
