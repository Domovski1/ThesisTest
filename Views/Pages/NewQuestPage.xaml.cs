using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Model;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewQuestPage.xaml
    /// </summary>
    public partial class NewQuestPage : Page
    {
        public NewQuestPage()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Q_A question = new Q_A();
                question.Question = TxbHelp.Text;
                AppData.db.Q_A.Add(question);
                AppData.db.SaveChanges();
                MessageBox.Show("Администратор ответит на ваш вопрос в ближайшее время", "Вопрос отправлен", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            } finally
            {
                NavigationService.GoBack();
            }
        }
    }
}
