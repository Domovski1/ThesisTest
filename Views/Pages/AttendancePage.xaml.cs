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
    /// Логика взаимодействия для AttendancePage.xaml
    /// </summary>
    public partial class AttendancePage : Page
    {
        public AttendancePage()
        {
            InitializeComponent();
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
            //AppData.db.SaveChanges();
        }
    }
}
