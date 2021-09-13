using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Word = Microsoft.Office.Interop.Word;
using Tesis.Model;
using System.Diagnostics;

namespace Tesis.Views.Pages.TeacherPages
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


        /// <summary>
        /// Автозаполнение форм данными
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CmbGroup.ItemsSource = AppData.db.Group.ToList();
            CmbGroup.DisplayMemberPath = "Title";
        }

        private void Back_btn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Генерация отчёта в формате pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {

            var CurretGroup = CmbGroup.SelectedItem as Group;

            var word = new Word.Application();
            var document = word.Documents.Open(Environment.CurrentDirectory + @"\" + "Template.docx");
            try
            {
                var table = document.Tables[1];


                // Создание списка с людьми, которые относятся к выбранной группе
                var service = AppData.db.Student.Where(x => x.GroupID == CurretGroup.Code).ToList();
                int i = 2;


                // Заполнение документа пропусками
                foreach (var item in service)
                {
                    table.Rows.Add();
                    table.Cell(i, 1).Range.Text = item.FirstName;
                    table.Cell(i, 2).Range.Text = item.LastName;
                    table.Cell(i, 3).Range.Text = item.Group.Title;
                    table.Cell(i, 4).Range.Text = (AppData.db.Attendance.Where(x => x.StudentID == item.ID).Count() * 2).ToString();

                    i++;
                }
                

                // Сохранение документа
                document.SaveAs2($@"C:\Users\{Environment.UserName}\Desktop\{CmbGroup.Text + " C " + to_dp.Text + " до " + Until_dp.Text}.pdf", Word.WdSaveFormat.wdFormatPDF);
                document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                MessageBox.Show("Файл сохранен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);


                // Автоматическое открытие документа сразу после его создания
                Process.Start($@"C:\Users\{Environment.UserName}\Desktop\{CmbGroup.Text + " C " + to_dp.Text + " до " + Until_dp.Text}.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
        }
    }
}
