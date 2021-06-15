using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Tesis.Model;

namespace Tesis.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для TeacherOperatePage.xaml
    /// </summary>
    public partial class TeacherOperatePage : Page
    {
        public List<Gender> genders {get; set;}
        public Teacher teacher { get; set; }

        public TeacherOperatePage(Teacher GetTeacher)
        {
            InitializeComponent();
            teacher = GetTeacher;
            genders = AppData.db.Gender.ToList();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
