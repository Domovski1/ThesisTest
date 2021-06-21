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

namespace Tesis.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AnswerPage.xaml
    /// </summary>
    public partial class AnswerPage : Page
    {
        
        public AnswerPage()
        {
            InitializeComponent();
            GridQuestions.ItemsSource = AppData.db.Q_A.Where(x => x.Answer == null).ToList();
            IsQuestionNull();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var CurrentQuestion = (Q_A)GridQuestions.SelectedItem;
                CurrentQuestion.Answer = TxbAnswer.Text;
                AppData.db.SaveChanges();
                GridQuestions.ItemsSource = AppData.db.Q_A.Where(x => x.Answer == null).ToList();
                IsQuestionNull();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        

        async void IsQuestionNull()
        {
            var data = AppData.db.Q_A.Where(x => x.Answer == null).ToList();
            if (data.Count == 0)
            {
                await Task.Delay(1000);
                MessageBox.Show("Неотвеченных вопросов нет", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        
    }
}
