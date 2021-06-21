using Microsoft.Win32;
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
    /// Логика взаимодействия для AddDocumentPage.xaml
    /// </summary>
    public partial class AddDocumentPage : Page
    {
        public AddDocumentPage()
        {
            InitializeComponent();
            CmbTeachers.ItemsSource = AppData.db.Teacher.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddTeacher_Click(object sender, RoutedEventArgs e)
        {
            ComboBox combo = new ComboBox();
            combo.Width = 200;
            combo.ItemsSource = AppData.db.Teacher.ToList();
            combo.DisplayMemberPath = "LastName";
            PanelTeachers.Children.Add(combo);
        }

        OpenFileDialog file = new OpenFileDialog();
        private void AddDocument_Click(object sender, RoutedEventArgs e)
        {
            file.Filter = "(*.pdf); (*docx); | *.pdf; *.docx";
            if (file.ShowDialog() == true)
            {
                TxbName.Text = file.SafeFileName;
            }
        }

        private void BtnSendFiles_Click(object sender, RoutedEventArgs e)
        {
            //List<TeacherDocument> docs = new List<TeacherDocument>();
            //for (int i = 0; i < PanelTeachers.Children.Count; i++)
            //{
            MessageBox.Show("Файлы отправлены пользователям", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
            //}
            //Document doc = new Document() { Title = file.SafeFileName, Path = file.FileName };
              
        }
    }
}
