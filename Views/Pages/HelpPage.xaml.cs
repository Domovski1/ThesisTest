using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Model;

namespace Tesis.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для HelpPage.xaml
    /// </summary>
    public partial class HelpPage : Page
    {
        public HelpPage()
        {
            InitializeComponent();
            GridQuestions.ItemsSource = AppData.db.Q_A.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxbSearch.Text == "")
            {
                GridQuestions.ItemsSource = AppData.db.Q_A.ToList();
            } else
            {
                GridQuestions.ItemsSource = AppData.db.Q_A.Where(q => q.Question.Contains(TxbSearch.Text)).ToList();
            }
        }

        private void BtnNewQuestion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewQuestPage());
        }
    }
}
