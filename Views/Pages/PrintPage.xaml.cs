using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Word = Microsoft.Office.Interop.Word;
using Tesis.Model;
using Tesis.Properties;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для PrintPage.xaml
    /// </summary>
    public partial class PrintPage : Page
    {
        public PrintPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CmbGroup.ItemsSource = AppData.db.Group.ToList();
            CmbGroup.DisplayMemberPath = "Title";
        }

        private void Back_btn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        // Генерация отчёта в pdf
        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {

            var CurretGroup = CmbGroup.SelectedItem as Group;

            var word = new Word.Application();
            try
            {
                var document = word.Documents.Open(Environment.CurrentDirectory + @"\" + "Template.docx");
                var table = document.Tables[1];

                var service = AppData.db.Student.Where(x => x.GroupID == CurretGroup.Code).ToList();
                int i = 2;
                foreach (var item in service)
                {
                    table.Rows.Add();
                    table.Cell(i, 1).Range.Text = item.FirstName;
                    table.Cell(i, 2).Range.Text = item.LastName;
                    table.Cell(i, 3).Range.Text = item.Group.Title;
                    table.Cell(i, 4).Range.Text = (AppData.db.Attendance.Where(x => x.StudentID == item.ID).Count() * 2).ToString();
                    i++;
                }
                
                document.SaveAs2(Settings.Default.PathToDocs, Word.WdSaveFormat.wdFormatPDF);
                document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                MessageBox.Show("Файл сохранен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
        }
    }
}
