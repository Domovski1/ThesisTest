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
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            //AppData.db.SaveChanges();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TxbDate.Text = DateTime.Today.ToShortDateString();
            //CmbGroups.ItemsSource = AppData.db.Groups.ToList();
        }

        private void AttendanceChecked(object sender, RoutedEventArgs e)
        {
            //var CurrentStudent = GridStudents.SelectedItem as Student;
            //Attendance attendance = new Attendance()
            //{
            //    Day = DateTime.Now,
            //    IsPresense = false,
            //    StudentID = CurrentStudent.ID
            //};
            //AppData.db.Attendance.Add(attendance);
        }

        private void CmbGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var CurrentGroup = CmbGroup.SelectedItem as Group;
            //GridStudents.ItemsSource = AppData.db.Student.Where(gr => gr.GroupID == CurrentGroup.Code).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
