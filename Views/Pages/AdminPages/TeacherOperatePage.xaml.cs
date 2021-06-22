using System;
using System.Collections.Generic;
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
        public User user { get; set; }

        public Teacher teacher { get; set; }

        public TeacherOperatePage(Teacher GetTeacher)
        {
            InitializeComponent();

            teacher = GetTeacher;
            user = AppData.db.User.FirstOrDefault(x => x.UserID == GetTeacher.ID);
            if (user == null)
            {
                user = new User();
            }
            genders = AppData.db.Gender.ToList();
            
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!TxbLogin.Text.Contains("@"))
                {
                    MessageBox.Show("Пожалуйста, убедитесь что правильно указали почту!", "Упс, чего-то не хватает...", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {

                    if (teacher.ID == 0)
                    {
                        AppData.db.Teacher.Add(teacher);
                    }
                    if (user.ID == 0)
                    {
                        AppData.db.User.Add(user);
                    }
                    AppData.db.SaveChanges();
                    MessageBox.Show("Сохранено", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
