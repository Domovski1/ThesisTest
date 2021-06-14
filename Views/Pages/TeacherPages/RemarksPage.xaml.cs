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
    }
}
