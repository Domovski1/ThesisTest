using System;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Tesis.Model;

namespace Tesis.Views.Pages.TeacherPages
{
    /// <summary>
    /// Логика взаимодействия для DocumentsPage.xaml
    /// </summary>
    public partial class DocumentsPage : Page
    {
        public DocumentsPage()
        {
            InitializeComponent();
            GridDocs.ItemsSource = AppData.db.Document.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnDownload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var CurrentDoc = (Document)GridDocs.SelectedItem;
                WebClient client = new WebClient();
                if (CurrentDoc.Path.Contains(".pdf"))
                {
                    client.DownloadFile(CurrentDoc.Path, CurrentDoc.Title + ".pdf");
                }
                else if (CurrentDoc.Path.Contains(".docx"))
                {
                    client.DownloadFile(CurrentDoc.Path, CurrentDoc.Title + ".docx");
                }
                MessageBox.Show("Документ скачан", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnNewDocumetn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddDocumentPage());
        }
    }
}
